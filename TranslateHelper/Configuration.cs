using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateHelper
{
    internal static class Configuration
    {
        public static string ConfigFilePath { get; set; }

        public static string SourceText { get; set; }

        public static string SecondarySourceText { get; set; }

        public static string TranslationStorePath { get; set; }

        public static string ComparingTranslationPath { get; set; }

        public static int LastEditingFile { get; set; }

        public static string ParserPath { get; set; }
        public static string SrcParserClass { get; set; }
        public static string TrsParserClass { get; set; }

        public static string HtmlRenderClass { get; set; }
        public static System.Drawing.Font Font { get; internal set; }
        public static bool UseSnd { get; internal set; }
        public static bool HalfTran { get; internal set; }

        public static bool VerifyTrans { get; set; }
        public static bool UsingNEM { get; set; }

        public static bool AskBeforeSave { get; set; }

        public static int LoadConfiguration(string configFilePath)
        {
            BinaryReader eye = new BinaryReader(File.OpenRead(configFilePath));

            int version = eye.ReadInt32();
            if (version < 10) return -1;

            try
            {
                SourceText = eye.ReadString();
                SecondarySourceText = eye.ReadString();
                TranslationStorePath = eye.ReadString();
                ComparingTranslationPath = eye.ReadString();
                LastEditingFile = eye.ReadInt32();

                ParserPath = eye.ReadString();
                SrcParserClass = eye.ReadString();
                TrsParserClass = eye.ReadString();
                HtmlRenderClass = eye.ReadString();
                if(version < 11)
                {
                    Font = new System.Drawing.Font("宋体", 9);
                }
                else
                {
                    string name = eye.ReadString();
                    double em = eye.ReadDouble();
                    Font = new System.Drawing.Font(name, (float)em);
                }

                if(version < 12)
                {
                    HalfTran = false;
                    UseSnd = false;
                }
                else
                {
                    HalfTran = eye.ReadBoolean();
                    UseSnd = eye.ReadBoolean();
                }

                if(version < 13)
                {
                    VerifyTrans = false;
                    UsingNEM = false;
                }
                else
                {
                    VerifyTrans = eye.ReadBoolean();
                    UsingNEM = eye.ReadBoolean();
                }

                if(version < 14)
                {
                    AskBeforeSave = true;
                }
                else
                {
                    AskBeforeSave = eye.ReadBoolean();
                }
            }
            catch (IOException)
            {
                return -5;
            }
            finally
            {
                eye.Close();
            }
            return 0;
        }

        public static int SaveConfiguration(string configFilePath)
        {
            BinaryWriter pen = new BinaryWriter(File.OpenWrite(configFilePath));

            try
            {
                pen.Write(14);

                pen.Write(SourceText);
                pen.Write(SecondarySourceText);
                pen.Write(TranslationStorePath);
                pen.Write(ComparingTranslationPath);
                pen.Write(LastEditingFile);

                pen.Write(ParserPath);
                pen.Write(SrcParserClass);
                pen.Write(TrsParserClass);
                pen.Write(HtmlRenderClass);

                pen.Write(Font.Name);
                pen.Write((double)Font.Size);

                pen.Write(HalfTran);
                pen.Write(UseSnd);

                pen.Write(VerifyTrans);
                pen.Write(UsingNEM);

                pen.Write(AskBeforeSave);
            }
            catch(IOException)
            {
                return -5;
            }
            finally
            {
                pen.Close();
            }

            return 0;
        }

        internal static void SwitchSource()
        {
            var tmp = SourceText;
            SourceText = SecondarySourceText;
            SecondarySourceText = tmp;
        }
    }
}
