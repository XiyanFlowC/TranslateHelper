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
        Dictionary<int, string> Narrator;

        public TXTSrcHtmlRender()
        {
            //MessageBox.Show("Initing...");
            LoadNarrators("./narrator.txt");
        }

        public string GenerateItemHtml(string template, int id, DialogueItem b_data, DialogueItem b_trsd)
        {
            var data = b_data as ATDialogueItem;
            var trsd = b_trsd as ATDialogueItem;
            //MessageBox.Show(data.ToString());
            if (data.IsSelection)
            {
                return template
                   .Replace("@[itemID]", id.ToString())
                   .Replace("@[OriginalText]", data.Dialogue)
                   .Replace("@[TranslateText]", trsd.Dialogue)
                   .Replace("@[ID]", "选项")
                   .Replace("@[Narrator]", "选项");
            }
            else
            {
                return template
                   .Replace("@[itemID]", id.ToString())
                   .Replace("@[OriginalText]", data.Dialogue)
                   .Replace("@[TranslateText]", trsd.Dialogue)
                   .Replace("@[ID]", data.Id.ToString())
                   .Replace("@[Narrator]", ResolveNID(data.Narrator));
            }
        }

        private string ResolveNID(int narrator)
        {
            if (!Narrator.ContainsKey(narrator)) return narrator.ToString();
            return Narrator[narrator];
        }

        private void LoadNarrators(string v)
        {
            if(!File.Exists(v))
            {
                MessageBox.Show("找不到narrator.txt文件。渲染器初始化失败。");
                Narrator = new System.Collections.Generic.Dictionary<int, string>();
            }
            string[] lines = File.ReadAllLines(v);
            Narrator = new System.Collections.Generic.Dictionary<int, string>();
            foreach(var line in lines)
            {
                string[] f = line.Split(',');
                Narrator[int.Parse(f[0])] = f[1];
            }
        }
    }
}