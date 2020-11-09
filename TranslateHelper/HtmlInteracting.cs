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
        TextContent content;
        WebBrowser webBrowser;
        SEditor editor;
        readonly bool enableSave;
        bool changed = false;

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

        public void Edit(string id)
        {
            changed = true;
            if (editor == null || editor.IsDisposed) editor = new SEditor();//如果上个编辑窗口被关闭
            int iid = int.Parse(id);
            editor.OriginalText = content.Content[iid].Dialogue;//TODO:有时间的话改成回调吧。一个编辑窗口跨窗体改数据好丑啊……
            editor.TargetElement = webBrowser.Document.GetElementById("trs_" + id);
            editor.TransText = webBrowser.Document.GetElementById("trs_" + id).InnerHtml;//使编辑器可以修改数据
            editor.Edit();
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
