﻿using System;
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
    public partial class SEditor : Form
    {
        TermChecker tck;

        public SEditor()
        {
            InitializeComponent();
        }

        bool isNatural;
        public HtmlElement TargetElement { get; set; }
        public string OriginalText { get; set; }
        public string TransText
        {
            get
            {
                if(isNatural)
                {
                    return trans.Text.Replace(Environment.NewLine, "CR");
                }
                else return trans.Text;
            }
            set
            {
                if(isNatural)//TODO:支持脚本的人性化控制符系统（包括get和set）
                {
                    trans.Text = value.Replace("CR", Environment.NewLine);
                }
                else
                {
                    trans.Text = value;
                }
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            isNatural = false;
            trans.Text = TargetElement.InnerHtml;
            trans.Font = Configuration.Font;

            if(Configuration.UsingNEM)
            {
                UseNEM();
            }
            else
            {
                UseREM();
            }
        }

        private void 特异控制符模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UseREM();
        }

        private void UseREM()//raw text editing mode
        {
            Configuration.UsingNEM = false;
            if (特异控制符模式ToolStripMenuItem.Checked) return;
            特异控制符模式ToolStripMenuItem.Checked = true;
            自然模式ToolStripMenuItem.Checked = false;
            isNatural = false;
            TransText = TransText;
        }

        private void 自然模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuration.UsingNEM = true;
            UseNEM();
        }

        private void UseNEM()//natral text editing mode
        {
            if (自然模式ToolStripMenuItem.Checked) return;
            自然模式ToolStripMenuItem.Checked = true;
            特异控制符模式ToolStripMenuItem.Checked = false;
            isNatural = true;
            TransText = TransText;
        }

        //private void 插入IMToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    trans.Text += "IMXX";
        //}

        internal void Edit(Form parentForm)
        {
            if (tck != null) tck.CheckTerms(OriginalText);
            if(!Visible) Show(parentForm);
            Focus();
        }

        //private void 插入SPToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    trans.Text += "SPXX";
        //}

        //private void 插入CRToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    trans.Text += "CR";
        //}

        private void trans_TextChanged(object sender, EventArgs e)
        {
            TargetElement.InnerHtml = TransText;
            if(tck != null)
            {
                if (tck.AlwaysVerify)
                    tck.varifyTerms(TransText);
                else tck.updateCache(TransText);
            }
            //if(tck != null)tck.CheckTerms(OriginalText);
        }

        private void 以原始文本覆盖ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransText = OriginalText;
        }

        private void 专有名词检查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tck == null || tck.IsDisposed)
            {
                tck = new TermChecker();
                tck.CheckTerms(OriginalText);
                if (tck.AlwaysVerify) tck.varifyTerms(TransText);
            }

            if (!tck.Visible) tck.Show(this);
            else tck.Focus();
        }
    }
}
