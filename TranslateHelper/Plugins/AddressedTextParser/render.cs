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
            //MessageBox.Show("Initing...");
            //LoadNarrators("./narrator.txt");
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

        // private string ResolveNID(int narrator)
        // {
        //     if (!Narrator.ContainsKey(narrator)) return "未索引";
        //     return Narrator[narrator];
        // }

        // private void LoadNarrators(string v)
        // {
        //     string[] lines = File.ReadAllLines(v);
        //     Narrator = new System.Collections.Generic.Dictionary<int, string>();
        //     foreach(var line in lines)
        //     {
        //         string[] f = line.Split(',');
        //         Narrator[int.Parse(f[0])] = f[1];
        //     }
        // }
    }
}