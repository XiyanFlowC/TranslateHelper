namespace TranslateHelper
{
    partial class SEditor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.特异控制符模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自然模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.专有名词检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以原始文本覆盖ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制符ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入IMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入SPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.插入CRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trans = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.模式ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.控制符ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 模式ToolStripMenuItem
            // 
            this.模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.特异控制符模式ToolStripMenuItem,
            this.自然模式ToolStripMenuItem});
            this.模式ToolStripMenuItem.Name = "模式ToolStripMenuItem";
            this.模式ToolStripMenuItem.Size = new System.Drawing.Size(121, 35);
            this.模式ToolStripMenuItem.Text = "模式(&M)";
            // 
            // 特异控制符模式ToolStripMenuItem
            // 
            this.特异控制符模式ToolStripMenuItem.Checked = true;
            this.特异控制符模式ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.特异控制符模式ToolStripMenuItem.Name = "特异控制符模式ToolStripMenuItem";
            this.特异控制符模式ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.特异控制符模式ToolStripMenuItem.Size = new System.Drawing.Size(444, 44);
            this.特异控制符模式ToolStripMenuItem.Text = "特异控制符模式(&S)";
            this.特异控制符模式ToolStripMenuItem.Click += new System.EventHandler(this.特异控制符模式ToolStripMenuItem_Click);
            // 
            // 自然模式ToolStripMenuItem
            // 
            this.自然模式ToolStripMenuItem.Name = "自然模式ToolStripMenuItem";
            this.自然模式ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.自然模式ToolStripMenuItem.Size = new System.Drawing.Size(444, 44);
            this.自然模式ToolStripMenuItem.Text = "自然模式(&N)";
            this.自然模式ToolStripMenuItem.Click += new System.EventHandler(this.自然模式ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.专有名词检查ToolStripMenuItem,
            this.以原始文本覆盖ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(112, 35);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            // 
            // 专有名词检查ToolStripMenuItem
            // 
            this.专有名词检查ToolStripMenuItem.Name = "专有名词检查ToolStripMenuItem";
            this.专有名词检查ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.专有名词检查ToolStripMenuItem.Size = new System.Drawing.Size(435, 44);
            this.专有名词检查ToolStripMenuItem.Text = "专有名词检查(T)";
            this.专有名词检查ToolStripMenuItem.Click += new System.EventHandler(this.专有名词检查ToolStripMenuItem_Click);
            // 
            // 以原始文本覆盖ToolStripMenuItem
            // 
            this.以原始文本覆盖ToolStripMenuItem.Name = "以原始文本覆盖ToolStripMenuItem";
            this.以原始文本覆盖ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.以原始文本覆盖ToolStripMenuItem.Size = new System.Drawing.Size(435, 44);
            this.以原始文本覆盖ToolStripMenuItem.Text = "以原始文本覆盖(&R)";
            this.以原始文本覆盖ToolStripMenuItem.Click += new System.EventHandler(this.以原始文本覆盖ToolStripMenuItem_Click);
            // 
            // 控制符ToolStripMenuItem
            // 
            this.控制符ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.插入IMToolStripMenuItem,
            this.插入SPToolStripMenuItem,
            this.插入CRToolStripMenuItem});
            this.控制符ToolStripMenuItem.Name = "控制符ToolStripMenuItem";
            this.控制符ToolStripMenuItem.Size = new System.Drawing.Size(129, 35);
            this.控制符ToolStripMenuItem.Text = "控制符(&I)";
            // 
            // 插入IMToolStripMenuItem
            // 
            this.插入IMToolStripMenuItem.Name = "插入IMToolStripMenuItem";
            this.插入IMToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.插入IMToolStripMenuItem.Text = "插入IM";
            this.插入IMToolStripMenuItem.Click += new System.EventHandler(this.插入IMToolStripMenuItem_Click);
            // 
            // 插入SPToolStripMenuItem
            // 
            this.插入SPToolStripMenuItem.Name = "插入SPToolStripMenuItem";
            this.插入SPToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.插入SPToolStripMenuItem.Text = "插入SP";
            this.插入SPToolStripMenuItem.Click += new System.EventHandler(this.插入SPToolStripMenuItem_Click);
            // 
            // 插入CRToolStripMenuItem
            // 
            this.插入CRToolStripMenuItem.Name = "插入CRToolStripMenuItem";
            this.插入CRToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.插入CRToolStripMenuItem.Text = "插入CR";
            this.插入CRToolStripMenuItem.Click += new System.EventHandler(this.插入CRToolStripMenuItem_Click);
            // 
            // trans
            // 
            this.trans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trans.Location = new System.Drawing.Point(0, 39);
            this.trans.Multiline = true;
            this.trans.Name = "trans";
            this.trans.Size = new System.Drawing.Size(949, 271);
            this.trans.TabIndex = 1;
            this.trans.TextChanged += new System.EventHandler(this.trans_TextChanged);
            // 
            // SEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 310);
            this.Controls.Add(this.trans);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SEditor";
            this.Text = "编辑";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 特异控制符模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自然模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 专有名词检查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制符ToolStripMenuItem;
        private System.Windows.Forms.TextBox trans;
        private System.Windows.Forms.ToolStripMenuItem 插入IMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入SPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 插入CRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 以原始文本覆盖ToolStripMenuItem;
    }
}