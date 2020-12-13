using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text;
using FileInterface;


namespace TXTSrcParser
{
    public class TXTSrcHtmlRender : IHtmlItemRender
    {
        //Dictionary<int, string> Narrator;

        public TXTSrcHtmlRender()
        {
        }

        public string GenerateItemHtml(string template, int id, DialogueItem b_data, DialogueItem b_trsd)
        {
            var data = b_data as ATI;
            var trsd = b_trsd as ATI;
            
                return template
                   .Replace("@[itemID]", id.ToString())
                   .Replace("@[OriginalText]", data.Dialogue)
                   .Replace("@[TranslateText]", trsd.Dialogue);
                   //.Replace("@[ID]", data.Length.ToString());
        }
    }
}