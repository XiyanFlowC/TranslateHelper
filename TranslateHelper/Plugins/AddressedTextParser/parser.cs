using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using FileInterface;
using System.Windows.Forms;

namespace TXTSrcParser
{
    public class ATI : DialogueItem
    {
        int addr;
        int length;

        /// <summary>
        /// 使用指定数据初始化项
        /// </summary>
        /// <param name="p_Data"></param>
        public ATI(string p_Data)
        {
            Data = p_Data;
        }

        /// <summary>
        /// 获取或设定格式文本
        /// </summary>
        public string Data
        {
            get
            {
                return addr.ToString("X8") + ',' + length.ToString() + ',' + Dialogue;
            }
            set
            {
                int i = 0;
                string t = "";
                while (value[i] != ',')
                {
                    t += value[i];
                    ++i;
                }
                addr = int.Parse(t, System.Globalization.NumberStyles.AllowHexSpecifier);

                ++i;
                t = "";
                while (value[i] != ',')
                {
                    t += value[i];
                    ++i;
                }
                length = int.Parse(t, System.Globalization.NumberStyles.Integer);

                Dialogue = value.Substring(i + 1);
            }
        }

        public int Address
        {
            set
            {
                addr = value;
            }
            get
            {
                return addr;
            }
        }
    }

    class TXTSrcParser : IFileParser
    {
        public void SaveFile(DialogueItem[] item, string filename)
        {
            StreamWriter pen = new StreamWriter(filename, false, Encoding.Unicode);

            foreach (var a in item)
            {
                pen.WriteLine(((ATI)a).Data);
                pen.WriteLine();
            }
            pen.Close();
        }

        public DialogueItem[] LoadFile(string filename)
        {
            List<ATI> n = new List<ATI>();

            string[] cntx = File.ReadAllLines(filename);
            foreach (string line in cntx)
            {
                if (string.IsNullOrEmpty(line)) continue;

                n.Add(new ATI(line));
            }

            //items = n.ToArray();
            return n.ToArray();
        }

        public string SupportFormat { get{return "txt"; } }

        public string Description { get{return "可以解析地址-长度-文本型文本"; } }
    }
}