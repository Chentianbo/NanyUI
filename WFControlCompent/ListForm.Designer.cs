
namespace WFControlCompent
{
    partial class ListForm
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
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详情模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.列表模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大图标模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小图标模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 450);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.刷新ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.重命名ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(113, 114);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.打开ToolStripMenuItem.Text = "选择";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.详情模式ToolStripMenuItem,
            this.列表模式ToolStripMenuItem,
            this.大图标模式ToolStripMenuItem,
            this.小图标模式ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 详情模式ToolStripMenuItem
            // 
            this.详情模式ToolStripMenuItem.Name = "详情模式ToolStripMenuItem";
            this.详情模式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.详情模式ToolStripMenuItem.Text = "详情模式";
            this.详情模式ToolStripMenuItem.Click += new System.EventHandler(this.详情模式ToolStripMenuItem_Click);
            // 
            // 列表模式ToolStripMenuItem
            // 
            this.列表模式ToolStripMenuItem.Name = "列表模式ToolStripMenuItem";
            this.列表模式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.列表模式ToolStripMenuItem.Text = "列表模式";
            this.列表模式ToolStripMenuItem.Click += new System.EventHandler(this.列表模式ToolStripMenuItem_Click);
            // 
            // 大图标模式ToolStripMenuItem
            // 
            this.大图标模式ToolStripMenuItem.Name = "大图标模式ToolStripMenuItem";
            this.大图标模式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.大图标模式ToolStripMenuItem.Text = "大图标模式";
            this.大图标模式ToolStripMenuItem.Click += new System.EventHandler(this.大图标模式ToolStripMenuItem_Click);
            // 
            // 小图标模式ToolStripMenuItem
            // 
            this.小图标模式ToolStripMenuItem.Name = "小图标模式ToolStripMenuItem";
            this.小图标模式ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.小图标模式ToolStripMenuItem.Text = "小图标模式";
            this.小图标模式ToolStripMenuItem.Click += new System.EventHandler(this.小图标模式ToolStripMenuItem_Click);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.刷新ToolStripMenuItem.Text = "刷新";
            this.刷新ToolStripMenuItem.Click += new System.EventHandler(this.刷新ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Name = "ListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件管理系统";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详情模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列表模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大图标模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小图标模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
    }
}