namespace TranslateHelper
{
    partial class SearchProgress
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.currentFile = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.totalProgressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.itemProgress = new System.Windows.Forms.Label();
            this.partProgressBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "查找文件";
            // 
            // currentFile
            // 
            this.currentFile.AutoSize = true;
            this.currentFile.Location = new System.Drawing.Point(210, 23);
            this.currentFile.Name = "currentFile";
            this.currentFile.Size = new System.Drawing.Size(82, 24);
            this.currentFile.TabIndex = 1;
            this.currentFile.Text = "文件名";
            // 
            // progress
            // 
            this.progress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progress.AutoSize = true;
            this.progress.Location = new System.Drawing.Point(823, 23);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(82, 24);
            this.progress.TabIndex = 2;
            this.progress.Text = "label2";
            // 
            // totalProgressBar
            // 
            this.totalProgressBar.Location = new System.Drawing.Point(12, 65);
            this.totalProgressBar.Name = "totalProgressBar";
            this.totalProgressBar.Size = new System.Drawing.Size(964, 44);
            this.totalProgressBar.Step = 1;
            this.totalProgressBar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "查找句";
            // 
            // itemProgress
            // 
            this.itemProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.itemProgress.AutoSize = true;
            this.itemProgress.Location = new System.Drawing.Point(823, 130);
            this.itemProgress.Name = "itemProgress";
            this.itemProgress.Size = new System.Drawing.Size(82, 24);
            this.itemProgress.TabIndex = 5;
            this.itemProgress.Text = "label3";
            // 
            // partProgressBar
            // 
            this.partProgressBar.Location = new System.Drawing.Point(12, 174);
            this.partProgressBar.Name = "partProgressBar";
            this.partProgressBar.Size = new System.Drawing.Size(964, 44);
            this.partProgressBar.Step = 1;
            this.partProgressBar.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(807, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "取消(&A)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.partProgressBar);
            this.Controls.Add(this.itemProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalProgressBar);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.currentFile);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchProgress";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SearchProgress";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentFile;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.ProgressBar totalProgressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label itemProgress;
        private System.Windows.Forms.ProgressBar partProgressBar;
        private System.Windows.Forms.Button button1;
    }
}