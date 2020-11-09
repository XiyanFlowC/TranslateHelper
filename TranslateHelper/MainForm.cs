using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateHelper
{
    public partial class MainForm : Form
    {
        HtmlInteracting hi = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            statusLabel.Text = "正在初始化……";
            Helpers.Logger.Information("Application start up. Initializing...");
            shower.Navigate(Application.StartupPath + "/Html/NotFoundTemplate.html");
            try
            {
                Helpers.Logger.Information("Load and apply configuration...");
                InitLoad();
            }
            catch(IOException ex)
            {
                Helpers.Logger.Error("Load configuration failed.");
                statusLabel.Text += "失败";
                if(DialogResult.No == MessageBox.Show("程序初始化失败。尝试清空临时文件、重新生成过程数据？", "错误", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1))
                {
                    Helpers.Logger.Information("User decided to exit.");
                    Helpers.Logger.Debug(ex.ToString());
                    MessageBox.Show("程序无法正常启动。", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Helpers.Logger.Information("Configuration re-setup...");
                    statusLabel.Text = "设定舍弃，环境初始化";
                    Helpers.DataInitialize();
                    statusLabel.Text = "正在初始化……";
                    Helpers.Logger.Information("Try to load config again...");
                    InitLoad();
                }
            }
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString(), "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            statusLabel.Text = "就绪";
            Helpers.Logger.Information("Ready");
        }

        private void InitLoad()
        {
            Helpers.Logger.Information("InitLoad: Loading config...");
            if(-1 == Configuration.LoadConfiguration("./cfg.bin")) Helpers.DataInitialize();
            //ParserChoose pc = new ParserChoose();
            if (!Helpers.LoadParsers())
            {
                Helpers.Logger.Warning("Plugin invalid.");
                MessageBox.Show("所选插件无效。");
                Helpers.ReloadPlugin();
                //pc.ShowDialog();
            }
            Helpers.Logger.Information("InitLoad: Plugin loaded.");
            //pc.Close();

            string[] srcFiles = Directory.GetFiles(Configuration.SourceText, "*." + Global.srcParser.SupportFormat);
            foreach(var file in srcFiles)
            {
                string tmp = file.Substring(file.LastIndexOfAny(new char[] { '/', '\\' }));
                itemList.Items.Add( tmp.Substring(0, tmp.LastIndexOf('.')) );
            }
            Helpers.Logger.Information("InitLoad: File list initialized.");

            Helpers.LoadTermTable("./term.txt");
            //Helpers.LoadNarrators("./narrator.txt");
        }

        private void itemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusLabel.Text = "载入数据……";
            if (itemList.SelectedIndex == -1)
            {
                shower.DocumentText = File.ReadAllText("./Html/NotFoundTemplate.html");
                return;
            }
            string fileid = (string)itemList.SelectedItem;
            Helpers.Logger.Information("File I/O: Load file: " + fileid);
            LoadFile(fileid);
            statusLabel.Text = "就绪";
        }

        private void LoadFile(string fileid)
        {
            if (hi != null) hi.Dispose();

            TextContent tc;
            try
            {
                if (!System.IO.File.Exists(Configuration.TranslationStorePath + fileid + '.' + Global.trsParser.SupportFormat))//如果翻译文件不存在就创建吧
                    Global.trsParser.SaveFile
                        (Global.srcParser.LoadFile(Configuration.SourceText + fileid + '.' + Global.srcParser.SupportFormat), 
                        Configuration.TranslationStorePath + fileid + '.' + Global.trsParser.SupportFormat);

                tc = new TextContent(
                                Global.srcParser,
                                Global.trsParser,
                                Configuration.SourceText + fileid + '.' + Global.srcParser.SupportFormat,
                                Configuration.TranslationStorePath + fileid + '.' + Global.trsParser.SupportFormat);
            }
            catch(IOException ex)
            {
                Helpers.Logger.Error("File I/O: Can't load file: " + fileid);
                Helpers.Logger.Debug("File I/O: " + ex.ToString());
                MessageBox.Show("文件状态异常。");
                return;
            }
            //shower.Navigate();
            //shower.Url = new Uri(Application.StartupPath + "/Html/ViewerTemplate.html");

            Helpers.Logger.Information("Viewer: Rendering...");
            shower.DocumentText = (HtmlGenerator.HtmlViewerGen("./Html/ViewerTemplate.html",
                "./Html/SingleItemTemplate.txt",
                tc));

            Helpers.Logger.Information("Viewer: Creating code-viewer interactive interface.");
            hi = new HtmlInteracting(tc, shower);//创建交互介面
            shower.ObjectForScripting = hi;
        }

        private void 其它来源ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration.SwitchSource();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("通用文本编辑器 Ver.1.1\n最初为AT而编写。\n作者：巇岩流云", "关于");
        }

        private void 转到ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextEditor.Interaction.InputBox input = new TextEditor.Interaction.InputBox();
            if (DialogResult.Cancel == input.ShowDialog()) return;
            LoadFile(input.Value);
            itemList.SelectedIndex = -1;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("确实要退出吗？未保存的更改将丢失。", "退出确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                e.Cancel = true;
                return;
            }
            Helpers.Logger.Information("Application shutting down...");
            Helpers.Logger.Close();
            Configuration.SaveConfiguration("cfg.bin");
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hi == null)
            {
                MessageBox.Show("文件未加载", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            hi.Save();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == fontDialog1.ShowDialog()) return;
            Configuration.Font = fontDialog1.Font;
        }

        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hi == null)
            {
                MessageBox.Show("文件未加载", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (DialogResult.Cancel == saveFileDialog1.ShowDialog()) return;
            hi.SaveAs(saveFileDialog1.FileName);
        }

        private void 更改插件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.ReloadPlugin();
        }

        private void 修改目录ToolStripMenuItem_Click(object sender, EventArgs e)//TODO:耦合……什么时候把方法提取出来
        {
            PathSettings paths = new PathSettings();
            if (DialogResult.Cancel == paths.ShowDialog())
            {
                return;
            }

            if (!Directory.Exists(paths.CmpPath)) Directory.CreateDirectory(paths.CmpPath);
            if (!Directory.Exists(paths.SndPath)) Directory.CreateDirectory(paths.SndPath);
            if (!Directory.Exists(paths.OriPath)) Directory.CreateDirectory(paths.OriPath);
            if (!Directory.Exists(paths.TrsPath)) Directory.CreateDirectory(paths.TrsPath);

            Configuration.ComparingTranslationPath = paths.CmpPath;
            Configuration.TranslationStorePath = paths.TrsPath;
            Configuration.SourceText = paths.OriPath;
            Configuration.SecondarySourceText = paths.SndPath;

            paths.Close();

            Helpers.Logger.Information("User updated the path information.");
        }

        private void CmpSrc(string fileid)
        {
            if (hi != null) hi.Dispose();

            TextContent tc;
            try
            {
                tc = new TextContent(
                                Global.srcParser,
                                Global.srcParser,
                                Configuration.SourceText + fileid + '.' + Global.srcParser.SupportFormat,
                                Configuration.SecondarySourceText + fileid + '.' + Global.srcParser.SupportFormat);
            }
            catch (IOException ex)
            {
                MessageBox.Show("文件状态异常。");
                Helpers.Logger.Error("File I/O: Can't load file.");
                Helpers.Logger.Debug(ex.ToString());
                return;
            }
            //shower.Navigate();
            //shower.Url = new Uri(Application.StartupPath + "/Html/ViewerTemplate.html");

            shower.DocumentText = (HtmlGenerator.HtmlViewerGen("./Html/CompareTemplate.html",
                "./Html/CompareItemTemplate.txt",
                tc));

            hi = new HtmlInteracting(tc, shower, false);
            shower.ObjectForScripting = hi;
        }

        private void 来源比较ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "载入数据……";
            if (itemList.SelectedIndex == -1)
            {
                shower.DocumentText = File.ReadAllText("./Html/NotFoundTemplate.html");
                statusLabel.Text = "未选择文件";
                return;
            }
            string fileid = (string)itemList.SelectedItem;
            Helpers.Logger.Information("File I/O: Load file" + fileid);
            CmpSrc(fileid);
            statusLabel.Text = "就绪";
        }

        private void CmpTrs(string fileid)
        {
            if (hi != null) hi.Dispose();

            TextContent tc;
            try
            {
                tc = new TextContent(
                                Global.srcParser,
                                Global.srcParser,
                                Configuration.ComparingTranslationPath + fileid + '.' + Global.srcParser.SupportFormat,
                                Configuration.TranslationStorePath + fileid + '.' + Global.srcParser.SupportFormat);
            }
            catch (IOException)
            {
                MessageBox.Show("文件状态异常。");
                return;
            }
            //shower.Navigate();
            //shower.Url = new Uri(Application.StartupPath + "/Html/ViewerTemplate.html");

            shower.DocumentText = (HtmlGenerator.HtmlViewerGen("./Html/CombinTemplate.html",
                "./Html/CombinItemTemplate.txt",
                tc));

            hi = new HtmlInteracting(tc, shower, false);
            shower.ObjectForScripting = hi;
        }

        private void 合并比较ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "载入数据……";
            if (itemList.SelectedIndex == -1)
            {
                shower.DocumentText = File.ReadAllText("./Html/NotFoundTemplate.html");
                return;
            }
            string fileid = (string)itemList.SelectedItem;
            Helpers.Logger.Information("File I/O: Load file" + fileid);
            CmpTrs(fileid);
            statusLabel.Text = "就绪";
        }

        private void 查找与替换ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hi == null)
            {
                MessageBox.Show("文件未载入", "非法操作");return;
            }
            if (DialogResult.Cancel == MessageBox.Show("替换前必须保存更改，确认？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) return;
            hi.Save();
            SeekNReplace snr = new SeekNReplace();
            snr.items = hi.Content.Translation;
            snr.ShowDialog();
        }

        private void 删除日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helpers.Logger.Close();
            File.Delete("./log.txt");
            Helpers.Logger.Init("./log.txt");
            Helpers.Logger.Information("User clear previous log in application at " + DateTime.Now.ToString());
        }

        private void statusLabel_TextChanged(object sender, EventArgs e)
        {
            Update();
        }

        private void 来源文件夹查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderSearch fs = new FolderSearch();
            fs.DirectoryPath = Configuration.SourceText;
            fs.EnableReplace = false;
            fs.Parser = Global.srcParser;

            fs.ShowDialog();
        }

        private void 附属来源文件夹查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderSearch fs = new FolderSearch();
            fs.DirectoryPath = Configuration.SecondarySourceText;
            fs.EnableReplace = false;
            fs.Parser = Global.srcParser;

            fs.ShowDialog();
        }

        private void 翻译文件夹查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderSearch fs = new FolderSearch();
            fs.DirectoryPath = Configuration.TranslationStorePath;
            fs.EnableReplace = true;
            fs.Parser = Global.trsParser;

            fs.ShowDialog();
        }

        private void 比对文件夹查找ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderSearch fs = new FolderSearch();
            fs.DirectoryPath = Configuration.ComparingTranslationPath;
            fs.EnableReplace = true;
            fs.Parser = Global.trsParser;

            fs.ShowDialog();
        }
    }
}
