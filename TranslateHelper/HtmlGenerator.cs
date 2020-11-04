using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateHelper
{
    static class HtmlGenerator
    {
        internal static string HtmlViewerGen(string frameTemplatePath, string itemTemplatePath, TextContent txtcnt)
        {
            string rst = File.ReadAllText(frameTemplatePath);
            rst = rst.Replace("@[FileName]", txtcnt.filename)
                .Replace("@[HtmlPath]", "file://" + Application.StartupPath + "/Html/");
            string tableText = HtmlItemGen(itemTemplatePath, txtcnt.Content, txtcnt.Translation);
            rst = rst.Replace("@[ContentAsTable]", tableText);
            return rst;
        }

        private static string HtmlItemGen(string itemTemplatePath, FileInterface.DialogueItem[] orig, FileInterface.DialogueItem[] tran)
        {
            string template = File.ReadAllText(itemTemplatePath);
            StringBuilder sb = new StringBuilder();
            //int id = 0;
            for (int id = 0; id < orig.Length; ++id)
            {
                sb.Append( Global.htmlRender.GenerateItemHtml(template, id, orig[id], tran[id]) );
            }
            return sb.ToString();
        }
    }
}
