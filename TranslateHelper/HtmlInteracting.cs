using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateHelper
{
    [ComVisible(true)]
    public class HtmlInteracting
    {
        public Form ParentForm { get; set; }
        TextContent content;
        WebBrowser webBrowser;
        SEditor editor;
        readonly bool enableSave;
        bool changed = false;
        int editingID;

        public TextContent Content 
        { 
            get
            {
                return content;
            }
        }

        public HtmlInteracting(TextContent cnt, WebBrowser target, bool EnableSave = true)
        {
            content = cnt;
            webBrowser = target;
            enableSave = EnableSave;//是否允许保存：部分情形这里应该保持只读
        }

        public void Save()
        {
            if (!changed || !enableSave) return;//避免重复磁盘写入
            for(int i = 0; i < content.Translation.Length; ++i)
            {
                var ele = webBrowser.Document.GetElementById("trs_" + i);//从WebBrowser中载入数据
                if(ele == null)//数据不匹配或已卸载
                {
                    content.SaveTranslation("./emergencydump");
                    MessageBox.Show("Save failed. Buffer data collapsed.\nData dumped to ./emergencydump");
                    return;
                }
                content.Translation[i].Dialogue = ele.InnerHtml;
            }
            content.SaveTranslation();
            changed = false;
        }

        public void SaveAs(string path)
        {
            for (int i = 0; i < content.Translation.Length; ++i)//靠，耦了
            {
                var ele = webBrowser.Document.GetElementById("trs_" + i);
                content.Translation[i].Dialogue = ele.InnerHtml;
            }
            content.SaveTranslation(path);
        }

        protected HtmlElement targetElement;

        public void TranslationUpdate(string text)
        {
            targetElement.InnerHtml = text;
        }

        public string StringEncode(string input)
        {
            return webBrowser.Document.InvokeScript("stringEncoder", new object[] { input }) as string;
        }

        public string StringDecode(string input)
        {
            return webBrowser.Document.InvokeScript("stringDecoder", new object[] { input }) as string;
        }

        void NextEdit()
        {
            webBrowser.Document.InvokeScript("startEdit", new object[] { editingID + 1 });
        }

        public void Edit(string id)
        {
            changed = true;
            if (editor == null || editor.IsDisposed)
            {
                editor = new SEditor();//如果上个编辑窗口被关闭
                editor.OnNextItem = new ActionExecuter(NextEdit);
                editor.OnTranslationChanged = new TranslatingHandler(TranslationUpdate);//使编辑器可以修改数据
                editor.Decoder = new StringCodec(StringDecode);
                editor.Encoder = new StringCodec(StringEncode);
            }
            int iid = int.Parse(id);

            if(iid >= content.Content.Length)
            {
                if (DialogResult.No == MessageBox.Show("已达文件尾端，现在保存吗？", "保存", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) return;
                Save();
                return;
            }
            editingID = iid;

            editor.OriginalText = content.Content[iid].Dialogue;//TO DO:有时间的话改成回调吧。一个编辑窗口跨窗体改数据好丑啊……
            targetElement = webBrowser.Document.GetElementById("trs_" + id);
            editor.TransText = webBrowser.Document.GetElementById("trs_" + id).InnerHtml;
            editor.Edit(ParentForm);
        }

        internal void Dispose()
        {
            if(changed && DialogResult.Yes == MessageBox.Show("是否保存在" + content.filename + "中的更改？", "工作区切换提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1))
            {
                Save();
            }
            if (editor != null && !editor.IsDisposed) editor.Close();
        }
    }
}
