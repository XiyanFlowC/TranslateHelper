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
    public partial class PathSettings : Form
    {
        public PathSettings()
        {
            InitializeComponent();
        }

        public string OriPath { get { return originalPath.Text; } }

        public string SndPath { get { return secondOriginal.Text; } }

        public string TrsPath { get { return TranslationPath.Text; } }

        public string CmpPath { get { return textBox4.Text; } }

        private void button5_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderPicker.Description = "请选择来源文本所在的文件夹。里面应当有形如“0.evd.txt”的文件。";
            folderPicker.ShowNewFolderButton = false;
            if (folderPicker.ShowDialog() == DialogResult.Cancel) return;
            originalPath.Text = folderPicker.SelectedPath;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderPicker.Description = "请选择来源文本所在的文件夹。里面应当有形如“0.evd.txt”的文件。";
            folderPicker.ShowNewFolderButton = false;
            if (folderPicker.ShowDialog() == DialogResult.Cancel) return;
            secondOriginal.Text = folderPicker.SelectedPath;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderPicker.Description = "请选择要保存翻译文本的文件夹。";
            folderPicker.ShowNewFolderButton = false;
            if (folderPicker.ShowDialog() == DialogResult.Cancel) return;
            TranslationPath.Text = folderPicker.SelectedPath;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();
        }
    }
}
