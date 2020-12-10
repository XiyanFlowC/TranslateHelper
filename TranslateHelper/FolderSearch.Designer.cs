namespace TranslateHelper
{
    partial class FolderSearch
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
            this.resultShower = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rowNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searcher = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.close = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.replace = new System.Windows.Forms.Button();
            this.replacement = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.targetDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultShower
            // 
            this.resultShower.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.rowNumber,
            this.content});
            this.resultShower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultShower.HideSelection = false;
            this.resultShower.Location = new System.Drawing.Point(0, 0);
            this.resultShower.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultShower.Name = "resultShower";
            this.resultShower.Size = new System.Drawing.Size(778, 530);
            this.resultShower.TabIndex = 9;
            this.resultShower.UseCompatibleStateImageBehavior = false;
            this.resultShower.View = System.Windows.Forms.View.Details;
            // 
            // fileName
            // 
            this.fileName.Text = "文件名";
            this.fileName.Width = 231;
            // 
            // rowNumber
            // 
            this.rowNumber.Text = "行数";
            this.rowNumber.Width = 67;
            // 
            // content
            // 
            this.content.Text = "内容";
            this.content.Width = 514;
            // 
            // searcher
            // 
            this.searcher.WorkerSupportsCancellation = true;
            this.searcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.searcher_DoWork);
            this.searcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.searcher_RunWorkerCompleted);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.close);
            this.splitContainer1.Panel1.Controls.Add(this.search);
            this.splitContainer1.Panel1.Controls.Add(this.replace);
            this.splitContainer1.Panel1.Controls.Add(this.replacement);
            this.splitContainer1.Panel1.Controls.Add(this.searchText);
            this.splitContainer1.Panel1.Controls.Add(this.targetDirectory);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.resultShower);
            this.splitContainer1.Size = new System.Drawing.Size(778, 810);
            this.splitContainer1.SplitterDistance = 272;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 10;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(22, 172);
            this.close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(164, 62);
            this.close.TabIndex = 14;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(592, 172);
            this.search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(164, 62);
            this.search.TabIndex = 13;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(420, 172);
            this.replace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(164, 62);
            this.replace.TabIndex = 12;
            this.replace.Text = "替换";
            this.replace.UseVisualStyleBackColor = true;
            this.replace.Click += new System.EventHandler(this.replace_Click);
            // 
            // replacement
            // 
            this.replacement.Location = new System.Drawing.Point(172, 122);
            this.replacement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.replacement.Name = "replacement";
            this.replacement.Size = new System.Drawing.Size(580, 35);
            this.replacement.TabIndex = 11;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(172, 72);
            this.searchText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(580, 35);
            this.searchText.TabIndex = 10;
            // 
            // targetDirectory
            // 
            this.targetDirectory.Location = new System.Drawing.Point(172, 22);
            this.targetDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.targetDirectory.Name = "targetDirectory";
            this.targetDirectory.ReadOnly = true;
            this.targetDirectory.Size = new System.Drawing.Size(580, 35);
            this.targetDirectory.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "替换";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "查找";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "目标";
            // 
            // FolderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(778, 810);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FolderSearch";
            this.Text = "文件夹搜索";
            this.Load += new System.EventHandler(this.FolderSearch_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView resultShower;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader rowNumber;
        private System.Windows.Forms.ColumnHeader content;
        private System.ComponentModel.BackgroundWorker searcher;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox replacement;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.TextBox targetDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button replace;
    }
}