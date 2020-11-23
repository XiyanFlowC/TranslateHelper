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
    public partial class FolderSearch : Form
    {
        class SearchResult
        {
            public string FileName { get; set; }
            public int Line { get; set; }
            public string Sample { get; set; }

            public SearchResult(string fileName, int line, string sample)
            {
                FileName = fileName;
                Line = line;
                Sample = sample;
            }
        }

        public string DirectoryPath { get; set; }

        public bool EnableReplace { get; set; }

        public IFileParser Parser { get; set; }

        SearchProgress searchProgress;

        public FolderSearch()
        {
            InitializeComponent();
            EnableReplace = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            if (DialogResult.Cancel == MessageBox.Show("警告！替换不可恢复！仍然确定？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)) return;
            string[] files = Directory.GetFiles(DirectoryPath);
            searchProgress = new SearchProgress(files.Length);
            searchProgress.CancelAction += () => { searcher.CancelAsync(); };
            searchProgress.Show(this);
            this.Enabled = false;
            searcher.RunWorkerAsync(new object[] { files, searchProgress, searchText.Text, replacement.Text });
        }

        private void FolderSearch_Load(object sender, EventArgs e)
        {
            replacement.ReadOnly = !EnableReplace;
            replace.Enabled = EnableReplace;
            targetDirectory.Text = DirectoryPath;
        }

        private void search_Click(object sender, EventArgs e)
        {
            resultShower.Items.Clear();
            string[] files = Directory.GetFiles(DirectoryPath);
            searchProgress = new SearchProgress(files.Length);
            searchProgress.CancelAction += () => { searcher.CancelAsync(); };
            searchProgress.Show(this);
            this.Enabled = false;
            searcher.RunWorkerAsync(new object[] { files, searchProgress, searchText.Text });
        }

        private void searcher_DoWork(object sender, DoWorkEventArgs e)
        {
            object[] args = e.Argument as object[];
            string searchString = args[2] as string;
            if (!(args[0] is string[] files) || !(args[1] is SearchProgress sp)) throw new ArgumentException("Parameter type mismatch.");
            bool doReplace = false;
            string replaceString = null;
            if(args.Length == 4)
            {
                doReplace = true;
                replaceString = args[3] as string;
            }
            int i = 0;
            List<SearchResult> result = new List<SearchResult>();
            foreach(string file in files)
            {
                var items = Parser.LoadFile(file);
                sp.ChangePhase(file, ++i, items.Length);

                int j = 0;
                foreach(var itm in items)
                {
                    sp.ChangeProgress(++j);
                    //System.Threading.Thread.Sleep(100);
                    if (itm.Dialogue.Contains(searchString))
                    {
                        if (doReplace) itm.Dialogue = itm.Dialogue.Replace(searchString, replaceString);
                        result.Add(new SearchResult(file, j, itm.Dialogue));
                    }
                    if(searcher.CancellationPending)
                    {
                        e.Result = result;
                        return;
                    }
                }
                if (doReplace) Parser.SaveFile(items, file);
            }
            e.Result = result;
        }

        private void searcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<SearchResult> rst =  e.Result as List<SearchResult>;

            this.Enabled = true;

            resultShower.BeginUpdate();
            foreach (var itm in rst)
            {
                ListViewItem li = new ListViewItem();
                li.Text = itm.FileName;
                li.SubItems.Add(itm.Line.ToString());
                li.SubItems.Add(itm.Sample);

                resultShower.Items.Add(li);
            }
            resultShower.EndUpdate();
            searchProgress.Close();
        }
    }
}
