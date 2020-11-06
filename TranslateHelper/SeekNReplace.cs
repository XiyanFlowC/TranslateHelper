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
    public partial class SeekNReplace : Form
    {
        public FileInterface.DialogueItem[] items;

        public SeekNReplace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("替换所有匹配项，具有一定危险性，确认？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) return;
            foreach(var item in items)
            {
                item.Dialogue = item.Dialogue.Replace(seek.Text, replacement.Text);
            }
            MessageBox.Show("替换完成。你可能需要重载文件以确认更改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
