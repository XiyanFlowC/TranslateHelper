using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileInterface;

namespace TranslateHelper
{

    public class TextContent
    {
        public string filename;
        public string trsname;
        //string translatefilename;
        private readonly IFileParser _parser;
        private readonly IFileParser _transParser;
        //DialogueItem contents;
        
        public TextContent(IFileParser parser, IFileParser transParser, string filename, string trsname)
        {
            _parser = parser;
            _transParser = transParser;
            Load(filename, trsname);
        }

        public void Load(string p_filename, string p_trsname)
        {
            OpenFile(p_filename);
            //int rst;
            //rst = 
            LoadTranslation(p_trsname);
            //if (rst != 0) return;
            //rst = LoadTranslation(p_filename + ".tld");
            //if (rst != 0) return;
            //LoadTranslation(p_filename + ".evd");
        }

        public DialogueItem[] Content { get; private set; }

        public DialogueItem[] Translation { get; set; }

        public void OpenFile(string p_fileName)
        {
            filename = p_fileName;
            Content = _parser.LoadFile(p_fileName);
        }

        public void SaveFile(string p_fileName)
        {
            _parser.SaveFile(Content, p_fileName);
        }

        public void SaveFile()
        {
            SaveFile(filename);
        }

        public void SaveTranslation()
        {
            SaveTranslation(trsname);
        }

        public void SaveTranslation(string p_filename)
        {
            _transParser.SaveFile(Translation, p_filename);
        }

        public int LoadTranslation(string p_filename)
        {
            trsname = p_filename;
            //if (!System.IO.File.Exists(p_filename)) _transParser.SaveFile(Content, p_filename);
            Translation = _transParser.LoadFile(p_filename);
            return Translation.Length;
        }
    }
}
