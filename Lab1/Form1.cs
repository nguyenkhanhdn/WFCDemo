using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Loading data ....";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Data saved.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmConfirm cf = new frmConfirm();
            DialogResult yesOrNo =  cf.ShowDialog();
            if(yesOrNo == DialogResult.Yes)
            {
                MessageBox.Show("Do with Yes");
            }else
            {
                MessageBox.Show("Do with No");
            }
        }
    }
}
