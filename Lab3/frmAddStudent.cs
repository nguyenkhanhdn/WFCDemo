using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class frmAddStudent : Form
    {
        private frmClass classForm;
        public frmAddStudent()
        {
            InitializeComponent();
        }
        public frmAddStudent(frmClass f)
        {
            InitializeComponent();
            classForm = f;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ListViewItem li = new ListViewItem(textBox1.Text,1);
            li.SubItems.Add(textBox2.Text);
            li.SubItems.Add(textBox3.Text);
            li.SubItems.Add(textBox4.Text);
            classForm.listView1.Items.Add(li);
            this.Close();
        }
    }
}
