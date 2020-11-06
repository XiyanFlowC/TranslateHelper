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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tragetDirectory = new System.Windows.Forms.TextBox();
            this.searchText = new System.Windows.Forms.TextBox();
            this.replacement = new System.Windows.Forms.TextBox();
            this.replace = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.resultShower = new System.Windows.Forms.ListView();
            this.fileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rowNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "目标";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "查找";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "替换";
            // 
            // tragetDirectory
            // 
            this.tragetDirectory.Location = new System.Drawing.Point(152, 6);
            this.tragetDirectory.Name = "tragetDirectory";
            this.tragetDirectory.ReadOnly = true;
            this.tragetDirectory.Size = new System.Drawing.Size(692, 35);
            this.tragetDirectory.TabIndex = 3;
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(152, 47);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(692, 35);
            this.searchText.TabIndex = 4;
            // 
            // replacement
            // 
            this.replacement.Location = new System.Drawing.Point(152, 88);
            this.replacement.Name = "replacement";
            this.replacement.Size = new System.Drawing.Size(692, 35);
            this.replacement.TabIndex = 5;
            // 
            // replace
            // 
            this.replace.Location = new System.Drawing.Point(508, 129);
            this.replace.Name = "replace";
            this.replace.Size = new System.Drawing.Size(165, 62);
            this.replace.TabIndex = 6;
            this.replace.Text = "替换";
            this.replace.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(679, 129);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(165, 62);
            this.search.TabIndex = 7;
            this.search.Text = "查找";
            this.search.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(16, 129);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(165, 62);
            this.close.TabIndex = 8;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            // 
            // resultShower
            // 
            this.resultShower.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fileName,
            this.rowNumber,
            this.content});
            this.resultShower.HideSelection = false;
            this.resultShower.Location = new System.Drawing.Point(16, 197);
            this.resultShower.Name = "resultShower";
            this.resultShower.Size = new System.Drawing.Size(828, 393);
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
            // FolderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 602);
            this.Controls.Add(this.resultShower);
            this.Controls.Add(this.close);
            this.Controls.Add(this.search);
            this.Controls.Add(this.replace);
            this.Controls.Add(this.replacement);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.tragetDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FolderSearch";
            this.Text = "文件夹搜索";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tragetDirectory;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.TextBox replacement;
        private System.Windows.Forms.Button replace;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ListView resultShower;
        private System.Windows.Forms.ColumnHeader fileName;
        private System.Windows.Forms.ColumnHeader rowNumber;
        private System.Windows.Forms.ColumnHeader content;
    }
}