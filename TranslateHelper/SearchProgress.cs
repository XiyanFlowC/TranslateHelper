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
    public partial class SearchProgress : Form
    {
        int totalCount, partCount;
        string filename;
        public delegate void CancelAction_t();
        public CancelAction_t CancelAction { get; set; }

        public SearchProgress(int totalProgress)
        {
            InitializeComponent();
            totalCount = totalProgress;
            totalProgressBar.Maximum = totalProgress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancelAction();
            button1.Enabled = false;
            button1.Text = "正在取消";
        }

        public void ChangeProgress(int partProgress)
        {
            this.Invoke(new Action(() => {
                //partProgressBar.Value = partProgress;
                partProgressBar.PerformStep();
                itemProgress.Text = partProgress.ToString() + '/' + partCount.ToString();
            }));
        }

        public void ChangePhase(string p_filename, int progre, int total)
        {
            filename = p_filename;
            partCount = total;
            this.Invoke(new Action(() =>
            {
                Update();
                //totalProgressBar.Value = progre;
                totalProgressBar.PerformStep();
                partProgressBar.Maximum = partCount;
                partProgressBar.Value = 0;
                currentFile.Text = p_filename;
                progress.Text = progre.ToString() + '/' + totalCount;
            }));
        }
    }
}
