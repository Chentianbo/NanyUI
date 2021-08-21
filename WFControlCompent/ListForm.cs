using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFControlCompent
{
    public partial class ListForm : Form
    {
        private string directoryPath = "C:\\";
        public ListForm()
        {
            InitializeComponent();
            InitListView();

            LoadDir(new DirectoryInfo(directoryPath));
        }

        private void InitListView()
        {
            //设计 详情模式
            listView1.View = View.Details;
            listView1.Columns.Add("文件名",-2,HorizontalAlignment.Left);//-2 表示自动宽度
            listView1.Columns.Add("修改日期", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("类型", 80, HorizontalAlignment.Left);
            listView1.Columns.Add("大小", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("位置", 300, HorizontalAlignment.Left);

            ///创建小图标
            ImageList imglist = new ImageList();
            imglist.ImageSize = new Size(16, 16);
            imglist.Images.Add(Properties.Resources.smallfile);
            imglist.Images.Add(Properties.Resources.smallfileinfo);

            //设置图标
            listView1.SmallImageList = imglist;

            ///创建大图标
            ImageList imglistBig = new ImageList();
            imglistBig.ImageSize = new Size(64, 64);
            imglistBig.Images.Add(Properties.Resources.bigfile);
            imglistBig.Images.Add(Properties.Resources.bigfileinfo);

            listView1.LargeImageList = imglistBig;




        }

        private void LoadDir(DirectoryInfo dir)
        {
            listView1.Items.Clear();
            //防止界面更新频繁
            listView1.BeginUpdate();
            DirectoryInfo[] subdir = dir.GetDirectories();
            foreach (var item in subdir)
            {
                if ((item.Attributes & FileAttributes.Hidden) > 0)
                    AddListItem(item.Name, item.LastAccessTime,"文件夹",-1,  item.FullName);

            }


            FileInfo[] subfiles = dir.GetFiles();
            foreach (var item in subfiles)
            { 
                string ext = item.Extension.ToLower();
                AddListItem(item.Name, item.LastAccessTime, ext, item.Length, item.FullName);
            }
            //更新完成之后在update 界面
            listView1.EndUpdate();
        }

        private void AddListItem(string fileName, DateTime time,string type,long size, string fullPath)
        {
           
            //判断是文件夹还是文件使用不同图标

            //图标采用索引方式插入
            int imageIndex = 0;
            if (!type.Equals("文件夹")) imageIndex = 1;
            ListViewItem item = new ListViewItem(fileName, imageIndex);
            item.SubItems.Add(time.ToString("yyyy-MM-dd HH:mm:ss"));
            item.SubItems.Add(type);
            string sizeStr = "";
            if (size < 0)
                sizeStr = "";
            else if (size < 1024)
                sizeStr = "" + size;
            else if (size < (1024*1024))
                sizeStr = size/ 1024 + "KB";
            else if (size < (1024*1024*1024))
                sizeStr = size / (1024*1024) + "M";
            else
                sizeStr = size / (1024 * 1024*1024) + "GB";
            item.SubItems.Add(sizeStr);
            //放到控件上
            listView1.Items.Add(item);
            item.SubItems.Add(fullPath);

        }

        private void 详情模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void 列表模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void 大图标模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void 小图标模式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                ListViewItem item = listView1.GetItemAt(e.X, e.Y);
                //根据当前选择显示模式，设置菜单项状态
                View view = listView1.View;
                详情模式ToolStripMenuItem.Checked = (view == View.Details);
                列表模式ToolStripMenuItem.Checked = (view == View.List);
                大图标模式ToolStripMenuItem.Checked = (view == View.LargeIcon);
                小图标模式ToolStripMenuItem.Checked = (view == View.SmallIcon);
                contextMenuStrip1.Show(listView1,e.Location);
            }
        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directoryPath = dialog.SelectedPath;
                LoadDir(new DirectoryInfo(directoryPath));
                this.Text = "文件管理系统" + "--位置："+ directoryPath;
            }
           
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadDir(new DirectoryInfo(directoryPath));
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var item =  listView1.SelectedItems;
            if (item.Count<=0)
            {
                MessageBox.Show("请选择文件", "系统提示");
                return;
            }
            var filePath = item[0].SubItems[4].Text.Trim();
            FileInfo file = new FileInfo(filePath);
            if (!file.Exists) { MessageBox.Show("文件不存在", "系统提示"); return; }
            file.Delete();
            file.Refresh();
            LoadDir(new DirectoryInfo(directoryPath));
        }
    }
}
