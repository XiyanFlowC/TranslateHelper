using FileInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslateHelper
{
    static class Global
    {
        static public IFileParser srcParser = null;
        static public IFileParser trsParser = null;
        //public static Dictionary<int, string> Narrator;
        public static IHtmlItemRender htmlRender = null;
        public static Dictionary<string, string> oriTerm;
        public static Dictionary<string, string> sndTerm;
    }
}
