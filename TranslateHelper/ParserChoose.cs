using FileInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranslateHelper
{
    public partial class ParserChoose : Form
    {
        //string[] plugins;

        public ParserChoose()
        {
            InitializeComponent();
        }

        public IFileParser sourceParser
        {
            get
            {
                return Parsers[srcParser.SelectedIndex];
            }
        }

        public IHtmlItemRender htmlItemRender
        {
            get
            {
                return Renders[htmRander.SelectedIndex];
            }
        }

        public IFileParser[] Parsers { get; set; }
        public IHtmlItemRender[] Renders { get; set; }

        public IFileParser translationParser
        {
            get
            {
                return Parsers[trsParser.SelectedIndex];
            }
        }

        private void ParserChoose_Load(object sender, EventArgs e)
        {
            //plugins = Directory.GetDirectories("./Plugins/");
            srcParser.Items.Clear();
            trsParser.Items.Clear();
            htmRander.Items.Clear();

            foreach(var parser in Parsers)
            {
                srcParser.Items.Add(parser.GetType().Name + ':' + parser.Description);
                trsParser.Items.Add(parser.GetType().Name + ':' + parser.Description);
                //htmRander.Items.Add(plugin.Substring(plugin.LastIndexOf('\\') + 1));
            }

            foreach(var render in Renders)
            {
                htmRander.Items.Add(render.GetType().Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (srcParser.SelectedIndex == -1 || trsParser.SelectedIndex == -1 || htmRander.SelectedIndex == -1)
            {
                MessageBox.Show("未选择插件。");
                return;
            }
            Hide();
        }
    }
}
