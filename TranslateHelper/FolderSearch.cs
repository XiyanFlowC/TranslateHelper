using FileInterface;
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
    public partial class FolderSearch : Form
    {
        public string DirectoryPath { get; set; }

        public IFileParser Parser { get; set; }

        public FolderSearch()
        {
            InitializeComponent();
        }
    }
}
