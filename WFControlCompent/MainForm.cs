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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            loadData(20);
        }

        private void loadData(int count)
        {
            for (int i = 0; i < count; i++)
            {
                AddRow(i);
            }
        }

        private void loadStudentData(int count)
        {
            List<Student> list = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                var objec = new Student { SName = "小明" + i,  Sex = i % 2 == 0 ? "男" : "女", Age = new Random().Next(0, 100),Phone = "1234567895" + i };
                list.Add(objec);
            }
            dataGridView1.DataSource = list;
        }

        private void AddRow(int index)
        {
            var objec = new Student { SName="小明"+index,Age=new Random().Next(0,100),Sex= index%2==0?"男":"女",Phone="1234567895"+index};
            dataGridView1.Rows.Add("小明" + index,index % 2 == 0 ? "男" : "女", new Random().Next(0, 100),"1234567895" + index);
        }



    }

    public class Student
    {
        public string SName { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
    }
}
