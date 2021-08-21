using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFControlCompent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                int index = listBox1.IndexFromPoint(e.Location);
                if (index>0)
                {
                    listBox1.SetSelected(index, true);
                    编辑ToolStripMenuItem.Enabled = true;
                    删除ToolStripMenuItem.Enabled = true;
                    保存ToolStripMenuItem.Enabled = true;
                }
                else
                {
                    listBox1.ClearSelected();
                    编辑ToolStripMenuItem.Enabled = false;
                    删除ToolStripMenuItem.Enabled = false;
                    保存ToolStripMenuItem.Enabled = false;
                }
                this.contextMenuStrip1.Show(listBox1, e.Location);
            }
        }

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
