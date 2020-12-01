using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateHelper
{
    public partial class TermChecker : Form
    {
        public TermChecker()
        {
            InitializeComponent();
            doHalfTrans.Checked = Configuration.HalfTran;
            traceOrigin.Checked = Configuration.UseSnd;
            checkBox1.Checked = Configuration.VerifyTrans;
        }

        string cache;

        public bool AlwaysVerify
        {
            get
            {
                return checkBox1.Checked;
            }
        }

        public void CheckTerms(string text)
        {
            text = text.Replace("CR", "");
            listView.BeginUpdate();
            listView.Items.Clear();
            if (doHalfTrans.Checked)
                text = Helpers.ToHalfShape(text);
            Dictionary<string, string> tar = !traceOrigin.Checked ? Global.oriTerm : Global.sndTerm;
            foreach (var term in tar)
            {
                if(text.ToLower().Contains(term.Key.ToLower()))
                {
                    ListViewItem li = new ListViewItem();
                    li.Text = term.Key;
                    li.SubItems.Add(term.Value);
                    li.SubItems.Add("未查");

                    listView.Items.Add(li);
                }
            }
            listView.EndUpdate();

            if(checkBox1.Checked)
            {
                VerifyCache();
            }
        }

        public void varifyTerms(string trsText)
        {
            cache = trsText;
            if (doHalfTrans.Checked)
                trsText = Helpers.ToHalfShape(trsText);
            foreach (var item in listView.Items)
            {
                if(trsText.ToLower().Contains(((ListViewItem)item).SubItems[1].Text.ToLower()))
                {
                    ((ListViewItem)item).SubItems[2].Text = "是";
                }
                else
                    ((ListViewItem)item).SubItems[2].Text = "否";
            }
        }

        private void traceOrigin_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.UseSnd = traceOrigin.Checked;
            if (cache!=null) varifyTerms(cache);
        }

        private void doHalfTrans_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.HalfTran = doHalfTrans.Checked;
            if (cache!=null) varifyTerms(cache);
        }

        internal void updateCache(string transText)
        {
            cache = transText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifyCache();
        }

        private void VerifyCache()
        {
            if (cache == null) return;
            foreach (var item in listView.Items)
            {
                if ((doHalfTrans.Checked ? Helpers.ToHalfShape(cache) : cache).ToLower().Contains(((ListViewItem)item).SubItems[1].Text.ToLower()))
                {
                    ((ListViewItem)item).SubItems[2].Text = "是";
                }
                else
                    ((ListViewItem)item).SubItems[2].Text = "否";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Configuration.VerifyTrans = checkBox1.Checked;
        }
    }
}
