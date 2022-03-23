using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {

        private BLL.BLLStudent sm = new BLL.BLLStudent();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DAL.Student ds = new DAL.Student();
            //BLL.Student bs = new BLL.Student();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.StudentId = int.Parse(textBox1.Text);
            s.Name = textBox2.Text;
            s.Address = textBox3.Text;
            s.Phone = textBox4.Text;
            sm.AddStudent(s);

            //add to listview
            AddListView();

            clearTextBox();
        }

        private void AddListView()
        {
            this.listView1.Items.Clear();
            foreach(Student s in sm.GetStudents())
            {
                ListViewItem lvi = new ListViewItem(s.StudentId.ToString());
                lvi.SubItems.Add(s.Name);
                lvi.SubItems.Add(s.Address);
                lvi.SubItems.Add(s.Phone);
                this.listView1.Items.Add(lvi);
            }
        }

        private void clearTextBox()
        {
            foreach (Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sm.RemoveStudentAt(1);
            AddListView();
        }
    }
}
