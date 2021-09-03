using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NanyUI
{
    public partial class NI_Circle : UserControl
    {
        public NI_Circle()
        {
            InitializeComponent();
            this.Width = this.Height =30;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = e.ClipRectangle;

            Rectangle rect1 = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 2, rect.Height - 2);
            g.DrawEllipse(new Pen(this.ForeColor), rect1);
            g.FillEllipse(new SolidBrush(this.ForeColor), rect1);
        }
    }
}
