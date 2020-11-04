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
    public partial class ChoosePlugin : Form
    {
        public ChoosePlugin()
        {
            InitializeComponent();
        }

        string[] plugin;

        public string SelectedPlugin
        {
            get
            {
                return plugin[plugins.SelectedIndex];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(plugins.SelectedIndex == -1)
            {
                MessageBox.Show("请选择插件");
                return;
            }
            Hide();
        }

        private void ChoosePlugin_Load(object sender, EventArgs e)
        {
            plugin = Directory.GetDirectories("./Plugins/");
            plugins.Items.Clear();

            foreach (var plugini in plugin)
            {
                plugins.Items.Add(plugini.Substring(plugini.LastIndexOf('\\') + 1));
            }
        }
    }
}
