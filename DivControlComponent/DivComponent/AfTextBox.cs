using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivControlComponent.DivComponent
{
    public partial class AfTextBox : UserControl
    {
        public AfTextBox()
        {
            InitializeComponent();
        }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            if (this.Controls.Count == 0) return;
            Control c = this.Controls[0];

            Padding p = this.Padding;
            int x = 0, y = 0;
            int w = this.Width, h = this.Height;
            w -= (p.Left + p.Right);
            x += p.Left;
            int h2 = c.PreferredSize.Height;
            if (h2 > h) h2 = h;
            y = (h - h2) / 2;
            c.Location = new Point(x, y);
            c.Size = new Size(w,h2);
        }

        //private void InitializeComponent()
        //{
        //    this.Edit = new System.Windows.Forms.TextBox();
        //    this.SuspendLayout();

        //    this.Edit.BorderStyle = System.Windows.Forms.BorderStyle.None;
        //    this.Edit.Font = new System.Drawing.Font("宋体", 10.5f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        //    this.Edit.Location = new System.Drawing.Point(43,25);
        //    this.Edit.Name = "Edit";
        //    this.Edit.Size = new System.Drawing.Size(143,16);
        //    this.Edit.TabIndex = 0;

        //    this.BackColor = System.Drawing.Color.White;
        //    this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        //    this.Controls.Add(this.Edit);

        //    this.Name = "AfTextBox";
        //    this.Size = new System.Drawing.Size(238,76);
        //    this.ResumeLayout(false);
        //    this.PerformLayout();
        //}
        [Browsable(true)]//是否显示属性 默认true
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("文本框")]
        public override string Text
        {
            get { return this.Edit.Text; }
            set { this.Edit.Text = value; }
        }

        //[Browsable(true)]//是否显示属性 默认true
        //[Category("Appearance")]
        //[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        //[Description("文本框")]
        //public string AfText
        //{
        //    get { return this.Edit.Text; }
        //    set { this.Edit.Text = value; }
        //}
    }
}
