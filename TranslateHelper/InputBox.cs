using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TextEditor.Interaction
{
    /// <summary>
    /// 提示用户输入文本数据
    /// </summary>
    public partial class InputBox : Form
    {
        public InputBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取或设定输入框标题
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设定输入框描述
        /// </summary>
        public string Description
        {
            get;
            set;
        }

        /// <summary>
        /// 获取或设定输入框值
        /// </summary>
        public string Value
        {
            get;
            set;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            if(Title != null)
            this.Text = Title;
            if (Description != null) this.label1.Text = Description;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Value = null;
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Value = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
