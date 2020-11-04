namespace TranslateHelper
{
    partial class ParserChoose
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
            this.srcParser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trsParser = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.htmRander = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // srcParser
            // 
            this.srcParser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.srcParser.FormattingEnabled = true;
            this.srcParser.Location = new System.Drawing.Point(193, 12);
            this.srcParser.Name = "srcParser";
            this.srcParser.Size = new System.Drawing.Size(692, 32);
            this.srcParser.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "源解析器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "翻译解析器";
            // 
            // trsParser
            // 
            this.trsParser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trsParser.FormattingEnabled = true;
            this.trsParser.Location = new System.Drawing.Point(193, 70);
            this.trsParser.Name = "trsParser";
            this.trsParser.Size = new System.Drawing.Size(692, 32);
            this.trsParser.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // htmRander
            // 
            this.htmRander.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.htmRander.FormattingEnabled = true;
            this.htmRander.Location = new System.Drawing.Point(193, 128);
            this.htmRander.Name = "htmRander";
            this.htmRander.Size = new System.Drawing.Size(692, 32);
            this.htmRander.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "显示渲染器";
            // 
            // ParserChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 299);
            this.ControlBox = false;
            this.Controls.Add(this.htmRander);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trsParser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.srcParser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ParserChoose";
            this.Text = "选择解析器";
            this.Load += new System.EventHandler(this.ParserChoose_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox srcParser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox trsParser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox htmRander;
        private System.Windows.Forms.Label label3;
    }
}