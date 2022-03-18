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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.tbUserId.Text = "";
            this.tbPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = this.tbUserId.Text;
            string pwd = this.tbPassword.Text;
            if (userId == pwd)
            {
                this.lblStatus.Text = "Login successfully.";
            }
            else
            {
                this.lblStatus.Text = "Invalid userid or password, pls try again.";
            }
        }
    }
}
