using FileInterface;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace TranslateHelper
{
    internal static class Helpers
    {
        internal static void DataInitialize()
        {
            if (DialogResult.No == MessageBox.Show("即将清除各类数据文件。请确认数据已备份。", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)) return;
            CleanUp();
            PathSettings paths = new PathSettings();
            while (DialogResult.OK != paths.ShowDialog())
            {
                MessageBox.Show("要进行初始化，必须设定路径");
            }

            if (!Directory.Exists(paths.CmpPath)) Directory.CreateDirectory(paths.CmpPath);
            if (!Directory.Exists(paths.SndPath)) Directory.CreateDirectory(paths.SndPath);
            if (!Directory.Exists(paths.OriPath)) Directory.CreateDirectory(paths.OriPath);
            if (!Directory.Exists(paths.TrsPath)) Directory.CreateDirectory(paths.TrsPath);

            Configuration.ComparingTranslationPath = paths.CmpPath;
            Configuration.TranslationStorePath = paths.TrsPath;
            Configuration.SourceText = paths.OriPath;
            Configuration.SecondarySourceText = paths.SndPath;
            Configuration.LastEditingFile = 0;
            ReloadPlugin();

            Configuration.Font = new System.Drawing.Font("宋体", 9);

            Configuration.SaveConfiguration("./cfg.bin");
        }

        public static void ReloadPlugin()
        {
            ChoosePlugin cp = new ChoosePlugin();
            cp.ShowDialog();
            Configuration.ParserPath = cp.SelectedPlugin;

            while (!InitParsers())//循环直至配置完成
            {
                MessageBox.Show("所选插件或解析器无效。");
                cp.ShowDialog();
                Configuration.ParserPath = cp.SelectedPlugin;
            }
            cp.Close();
        }

        public static bool LoadParsers()
        {
            return LoadParser();
        }
        

        private static bool LoadParser()
        {
            Assembly src;
            src = LoadPlugin(Configuration.ParserPath);
            if (src == null) return false;

            try
            {
                Global.srcParser = (IFileParser)src.CreateInstance(Configuration.SrcParserClass);//按上次用户之配置进行
                Global.trsParser = (IFileParser)src.CreateInstance(Configuration.TrsParserClass);
                Global.htmlRender = (IHtmlItemRender)src.CreateInstance(Configuration.HtmlRenderClass);
            }
            catch(Exception)
            {
                return false;
            }

            return true;
        }

        private static bool InitParsers()//读取解析器和渲染器
        {
            Assembly src;
            src = LoadPlugin(Configuration.ParserPath);
            if (src == null) return false;

            List<IFileParser> parsers = new List<IFileParser>();
            List<IHtmlItemRender> renders = new List<IHtmlItemRender>();

            int fnd = 0;

            foreach (var type in src.GetTypes())
            {
                if (type.GetInterface("IFileParser") != null)
                {
                    parsers.Add((IFileParser)src.CreateInstance(type.FullName));
                    fnd |= 0x1;
                }
                if (type.GetInterface("IHtmlItemRender") != null)
                {
                    renders.Add((IHtmlItemRender)src.CreateInstance(type.FullName));
                    fnd |= 0x2;
                }
                //if (type.GetInterface("IFileParser") != null)
                //{
                //    parsers.Add((IFileParser)src.CreateInstance(type.FullName));
                //}
            }
            if ((fnd & 0x3) != 0x3) return false;

            ParserChoose pc = new ParserChoose();
            pc.Renders = renders.ToArray();
            pc.Parsers = parsers.ToArray();
            pc.ShowDialog();

            Global.srcParser = pc.sourceParser;
            Global.trsParser = pc.translationParser;
            Global.htmlRender = pc.htmlItemRender;

            Configuration.SrcParserClass = pc.sourceParser.GetType().FullName;
            Configuration.TrsParserClass = pc.translationParser.GetType().FullName;
            Configuration.HtmlRenderClass = pc.htmlItemRender.GetType().FullName;
            return true;
        }

        internal static void LoadTermTable(string v)
        {
            if (!File.Exists(v)) File.Create(v);
            string[] lines = File.ReadAllLines(v);

            Global.oriTerm = new Dictionary<string, string>();
            Global.sndTerm = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                string[] fields = line.Split(',');
                if (fields.Length != 3 && fields.Length != 2)
                {
                    Logger.Fatal("Term Info Load Failed.");
                    Application.Exit();
                }

                Global.oriTerm[fields[0]] = fields[1];
                if(fields.Length == 3)
                    Global.sndTerm[fields[2]] = fields[1];
            }
        }

        internal static string ToHalfShape(string fullShapeString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in fullShapeString)
            {
                 if ((c >= 'Ａ' && c <= 'Ｚ')
                     || (c >= 'ａ' && c <= 'ｚ')
                     || (c >= '０' && c <= '９')
                     || (c >= '！' && c <= '？')) sb.Append((char)(c - 65248));
                 if (c == '　') sb.Append(' ');
            }
            return sb.ToString();
        }

        public static Assembly LoadPlugin(string path)//载入或编译插件
        {
            Assembly src;
            if (File.Exists(path + "/plugin.dll"))
                src = Assembly.LoadFrom(path + "/plugin.dll");
            else
            {
                CSharpCodeProvider cscp = new CSharpCodeProvider();
                CompilerParameters cp = new CompilerParameters();
                cp.ReferencedAssemblies.Add("System.dll");
                cp.ReferencedAssemblies.Add("System.Core.dll");
                cp.ReferencedAssemblies.Add("FileInterface.dll");
                cp.ReferencedAssemblies.Add("System.Windows.Forms.dll");
                cp.GenerateExecutable = false;
                cp.GenerateInMemory = true;
                CompilerResults cr = cscp.CompileAssemblyFromFile(cp, Directory.GetFiles(path));
                if(cr.Errors.Count != 0)
                {
                    foreach(var err in cr.Errors)
                    {
                        if (DialogResult.Cancel ==
                            MessageBox.Show(err.ToString(), "编译错误", MessageBoxButtons.OKCancel)) return null;
                        return null;
                    }
                }
                src = cr.CompiledAssembly;
            }
            return src;
        }

        internal static class Logger
        {
            static StreamWriter pen = null;

            public static int LogLevel { get; set; }

            public static void Init(string logFilePath)
            {
                pen = new StreamWriter(File.Open(logFilePath, FileMode.Append));
                LogLevel = 0;
            }

            public static void Close()
            {
                pen.Close();
            }

            public static void Information(string msg)
            {
                pen.WriteLine("[Info] " + msg);
            }

            public static void Debug(string msg)
            {
                pen.WriteLine("[Debug] " + msg);
            }

            public static void Warning(string msg)
            {
                pen.WriteLine("[Warn] " + msg);
            }

            public static void Danger(string msg)
            {
                pen.WriteLine("[Danger] " + msg);
            }

            public static void Error(string msg)
            {
                pen.WriteLine("[Error] " + msg);
            }

            public static void Fatal(string msg)
            {
                pen.WriteLine("[Fatal] " + msg);
            }
        }

        private static void CleanUp()
        {
            return;
        }
    }
}