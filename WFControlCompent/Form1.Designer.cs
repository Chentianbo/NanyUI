
namespace WFControlCompent
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nI_ProgressBar1 = new NanyUI.NI_ProgressBar();
            this.nI_Button1 = new NanyUI.NI_Button();
            this.nI_CircleButton1 = new NanyUI.NI_CircleButton();
            this.nI_Circle1 = new NanyUI.NI_Circle();
            this.nI_Thermometer1 = new NanyUI.NI_Thermometer();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "狗狗",
            "毛毛",
            "爱爱",
            "练练",
            "猪猪"});
            this.listBox1.Location = new System.Drawing.Point(12, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 184);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            this.listBox1.MouseEnter += new System.EventHandler(this.listBox1_MouseEnter);
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            this.listBox1.MouseHover += new System.EventHandler(this.listBox1_MouseHover);
            this.listBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseMove);
            this.listBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 92);
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.增加ToolStripMenuItem.Text = "增加";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            // 
            // nI_ProgressBar1
            // 
            this.nI_ProgressBar1.Font = new System.Drawing.Font("NanyUI", 10F);
            this.nI_ProgressBar1.IsError = false;
            this.nI_ProgressBar1.Location = new System.Drawing.Point(295, 193);
            this.nI_ProgressBar1.Name = "nI_ProgressBar1";
            this.nI_ProgressBar1.ProgressBarStyle = NanyUI.NI_ProgressBar.Style.ToolTip;
            this.nI_ProgressBar1.Size = new System.Drawing.Size(264, 32);
            this.nI_ProgressBar1.TabIndex = 2;
            this.nI_ProgressBar1.Text = "nI_ProgressBar1";
            this.nI_ProgressBar1.ValueNumber = 50;
            // 
            // nI_Button1
            // 
            this.nI_Button1.ButtonType = NanyUI.ButtonType.Primary;
            this.nI_Button1.Font = new System.Drawing.Font("NanyUI", 12F);
            this.nI_Button1.Location = new System.Drawing.Point(285, 99);
            this.nI_Button1.Name = "nI_Button1";
            this.nI_Button1.Size = new System.Drawing.Size(75, 23);
            this.nI_Button1.TabIndex = 3;
            this.nI_Button1.Text = "nI_Button1";
            this.nI_Button1.TextColor = System.Drawing.Color.White;
            // 
            // nI_CircleButton1
            // 
            this.nI_CircleButton1.BgColor2 = System.Drawing.Color.Transparent;
            this.nI_CircleButton1.FlatAppearance.BorderSize = 0;
            this.nI_CircleButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.nI_CircleButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.nI_CircleButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nI_CircleButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.nI_CircleButton1.Location = new System.Drawing.Point(478, 91);
            this.nI_CircleButton1.Name = "nI_CircleButton1";
            this.nI_CircleButton1.Radius = 5;
            this.nI_CircleButton1.Size = new System.Drawing.Size(176, 43);
            this.nI_CircleButton1.TabIndex = 4;
            this.nI_CircleButton1.Text = "nI_CircleButton1";
            this.nI_CircleButton1.UseVisualStyleBackColor = true;
            // 
            // nI_Circle1
            // 
            this.nI_Circle1.Location = new System.Drawing.Point(77, 260);
            this.nI_Circle1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nI_Circle1.Name = "nI_Circle1";
            this.nI_Circle1.Size = new System.Drawing.Size(30, 30);
            this.nI_Circle1.TabIndex = 5;
            // 
            // nI_Thermometer1
            // 
            this.nI_Thermometer1.BMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nI_Thermometer1.BMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nI_Thermometer1.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.nI_Thermometer1.LeftTemperatureUnit = NanyUI.NI_Thermometer.TemperatureUnit.C;
            this.nI_Thermometer1.Location = new System.Drawing.Point(604, 208);
            this.nI_Thermometer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nI_Thermometer1.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nI_Thermometer1.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.nI_Thermometer1.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nI_Thermometer1.Name = "nI_Thermometer1";
            this.nI_Thermometer1.Size = new System.Drawing.Size(60, 200);
            this.nI_Thermometer1.SpCount = 6;
            this.nI_Thermometer1.TabIndex = 6;
            this.nI_Thermometer1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nI_Thermometer1.ValueColor = System.Drawing.Color.White;
            this.nI_Thermometer1.ValueFont = new System.Drawing.Font("宋体", 10F);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nI_Thermometer1);
            this.Controls.Add(this.nI_Circle1);
            this.Controls.Add(this.nI_CircleButton1);
            this.Controls.Add(this.nI_Button1);
            this.Controls.Add(this.nI_ProgressBar1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private NanyUI.NI_ProgressBar nI_ProgressBar1;
        private NanyUI.NI_Button nI_Button1;
        private NanyUI.NI_CircleButton nI_CircleButton1;
        private NanyUI.NI_Circle nI_Circle1;
        private NanyUI.NI_Thermometer nI_Thermometer1;
    }
}

