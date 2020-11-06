namespace TranslateHelper
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转到ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找与替换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其它来源ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.来源比较ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.合并比较ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.来源文件夹查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.附属来源文件夹查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.翻译文件夹查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.比对文件夹查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.更改插件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改目录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.itemList = new System.Windows.Forms.ListBox();
            this.shower = new System.Windows.Forms.WebBrowser();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.删除日志ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.视图ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1382, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.toolStripSeparator2,
            this.退出ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(219, 44);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(219, 44);
            this.另存为ToolStripMenuItem.Text = "另存为";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(219, 44);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.转到ToolStripMenuItem,
            this.查找与替换ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 转到ToolStripMenuItem
            // 
            this.转到ToolStripMenuItem.Name = "转到ToolStripMenuItem";
            this.转到ToolStripMenuItem.Size = new System.Drawing.Size(267, 44);
            this.转到ToolStripMenuItem.Text = "转到";
            this.转到ToolStripMenuItem.Click += new System.EventHandler(this.转到ToolStripMenuItem_Click);
            // 
            // 查找与替换ToolStripMenuItem
            // 
            this.查找与替换ToolStripMenuItem.Name = "查找与替换ToolStripMenuItem";
            this.查找与替换ToolStripMenuItem.Size = new System.Drawing.Size(267, 44);
            this.查找与替换ToolStripMenuItem.Text = "查找与替换";
            this.查找与替换ToolStripMenuItem.Click += new System.EventHandler(this.查找与替换ToolStripMenuItem_Click);
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.其它来源ToolStripMenuItem,
            this.来源比较ToolStripMenuItem,
            this.合并比较ToolStripMenuItem});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 其它来源ToolStripMenuItem
            // 
            this.其它来源ToolStripMenuItem.Name = "其它来源ToolStripMenuItem";
            this.其它来源ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.其它来源ToolStripMenuItem.Text = "切换来源";
            this.其它来源ToolStripMenuItem.Click += new System.EventHandler(this.其它来源ToolStripMenuItem_Click);
            // 
            // 来源比较ToolStripMenuItem
            // 
            this.来源比较ToolStripMenuItem.Name = "来源比较ToolStripMenuItem";
            this.来源比较ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.来源比较ToolStripMenuItem.Text = "来源比较";
            this.来源比较ToolStripMenuItem.Click += new System.EventHandler(this.来源比较ToolStripMenuItem_Click);
            // 
            // 合并比较ToolStripMenuItem
            // 
            this.合并比较ToolStripMenuItem.Name = "合并比较ToolStripMenuItem";
            this.合并比较ToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.合并比较ToolStripMenuItem.Text = "合并比较";
            this.合并比较ToolStripMenuItem.Click += new System.EventHandler(this.合并比较ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem,
            this.toolStripSeparator1,
            this.来源文件夹查找ToolStripMenuItem,
            this.附属来源文件夹查找ToolStripMenuItem,
            this.翻译文件夹查找ToolStripMenuItem,
            this.比对文件夹查找ToolStripMenuItem,
            this.toolStripSeparator4,
            this.更改插件ToolStripMenuItem,
            this.修改目录ToolStripMenuItem,
            this.toolStripSeparator5,
            this.删除日志ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(360, 6);
            // 
            // 来源文件夹查找ToolStripMenuItem
            // 
            this.来源文件夹查找ToolStripMenuItem.Name = "来源文件夹查找ToolStripMenuItem";
            this.来源文件夹查找ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.来源文件夹查找ToolStripMenuItem.Text = "来源文件夹查找";
            // 
            // 附属来源文件夹查找ToolStripMenuItem
            // 
            this.附属来源文件夹查找ToolStripMenuItem.Name = "附属来源文件夹查找ToolStripMenuItem";
            this.附属来源文件夹查找ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.附属来源文件夹查找ToolStripMenuItem.Text = "附属来源文件夹查找";
            // 
            // 翻译文件夹查找ToolStripMenuItem
            // 
            this.翻译文件夹查找ToolStripMenuItem.Name = "翻译文件夹查找ToolStripMenuItem";
            this.翻译文件夹查找ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.翻译文件夹查找ToolStripMenuItem.Text = "翻译文件夹查找";
            // 
            // 比对文件夹查找ToolStripMenuItem
            // 
            this.比对文件夹查找ToolStripMenuItem.Name = "比对文件夹查找ToolStripMenuItem";
            this.比对文件夹查找ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.比对文件夹查找ToolStripMenuItem.Text = "比对文件夹查找";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(360, 6);
            // 
            // 更改插件ToolStripMenuItem
            // 
            this.更改插件ToolStripMenuItem.Name = "更改插件ToolStripMenuItem";
            this.更改插件ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.更改插件ToolStripMenuItem.Text = "更改插件";
            this.更改插件ToolStripMenuItem.Click += new System.EventHandler(this.更改插件ToolStripMenuItem_Click);
            // 
            // 修改目录ToolStripMenuItem
            // 
            this.修改目录ToolStripMenuItem.Name = "修改目录ToolStripMenuItem";
            this.修改目录ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.修改目录ToolStripMenuItem.Text = "修改目录";
            this.修改目录ToolStripMenuItem.Click += new System.EventHandler(this.修改目录ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.帮助ToolStripMenuItem1,
            this.toolStripSeparator3,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(82, 38);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 帮助ToolStripMenuItem1
            // 
            this.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1";
            this.帮助ToolStripMenuItem1.Size = new System.Drawing.Size(195, 44);
            this.帮助ToolStripMenuItem1.Text = "帮助";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(192, 6);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(195, 44);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 841);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1382, 41);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(134, 31);
            this.statusLabel.Text = "Undefined";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 42);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.itemList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.shower);
            this.splitContainer1.Size = new System.Drawing.Size(1382, 799);
            this.splitContainer1.SplitterDistance = 338;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 2;
            // 
            // itemList
            // 
            this.itemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemList.Font = global::TranslateHelper.Properties.Settings.Default.Font;
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 24;
            this.itemList.Location = new System.Drawing.Point(0, 0);
            this.itemList.Margin = new System.Windows.Forms.Padding(6);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(338, 799);
            this.itemList.TabIndex = 0;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.itemList_SelectedIndexChanged);
            // 
            // shower
            // 
            this.shower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shower.Location = new System.Drawing.Point(0, 0);
            this.shower.Margin = new System.Windows.Forms.Padding(6);
            this.shower.MinimumSize = new System.Drawing.Size(40, 40);
            this.shower.Name = "shower";
            this.shower.Size = new System.Drawing.Size(1036, 799);
            this.shower.TabIndex = 2;
            this.shower.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(360, 6);
            // 
            // 删除日志ToolStripMenuItem
            // 
            this.删除日志ToolStripMenuItem.Name = "删除日志ToolStripMenuItem";
            this.删除日志ToolStripMenuItem.Size = new System.Drawing.Size(363, 44);
            this.删除日志ToolStripMenuItem.Text = "删除日志";
            this.删除日志ToolStripMenuItem.Click += new System.EventHandler(this.删除日志ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 882);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "魔塔大陆剧情导出文本编辑器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 转到ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找与替换ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其它来源ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.WebBrowser shower;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem 来源比较ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 合并比较ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 来源文件夹查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 附属来源文件夹查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 翻译文件夹查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 比对文件夹查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 更改插件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改目录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 删除日志ToolStripMenuItem;
    }
}

