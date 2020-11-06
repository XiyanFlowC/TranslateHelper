using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FileInterface;
using System.Windows.Forms;

namespace TXTSrcParser
{
    class ATDialogueItem : DialogueItem
    {
        public int Id { get; set; }
        public int Narrator { get; set; }
        public bool IsSelection { get; set; }
    }

    class TXTSrcParser : IFileParser
    {
        public void SaveFile(DialogueItem[] item, string filename)
        {
            StreamWriter sw = new StreamWriter(File.Open(filename, FileMode.Create));
            foreach(var i in item)
            {
                var it = i as ATDialogueItem;
                if(it.IsSelection)
                {
                    sw.WriteLine(it.Dialogue);
                }
                else
                {
                    sw.WriteLine(string.Format("{0},{1},{2}", it.Id, it.Narrator, it.Dialogue));
                }
                sw.WriteLine();
            }
            sw.Close();
        }

        public DialogueItem[] LoadFile(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            List<DialogueItem> ret = new List<DialogueItem>();

            foreach(var line in lines)
            {
                if(string.IsNullOrEmpty(line)) continue;
                StringBuilder sb = new StringBuilder();

                int field = 0;
                ATDialogueItem di = new ATDialogueItem();

                foreach(var cha in line)
                {
                    if(field == 0)
                    {
                        if(cha == ',')
                        {
                            field++;
                            di.Id = int.Parse(sb.ToString());
                            sb.Clear();
                        }
                        else
                            sb.Append(cha);
                    }
                    else if(field == 1)
                    {
                        if(cha == ',')
                        {
                            field++;
                            
                            di.Narrator = int.Parse(sb.ToString());
                            sb.Clear();
                        }
                        else
                            sb.Append(cha);
                    }
                    else if(field == 2)
                    {
                        sb.Append(cha);
                    }
                }
                di.IsSelection = (field == 0) ? true : false;
                
                di.Dialogue = sb.ToString();

                ret.Add(di as DialogueItem);
            }
            return ret.ToArray();
        }

        public string SupportFormat { get{return "txt"; } }

        public string Description { get{return "可以解析evd抽出型TXT剧情文件"; } }
    }
}