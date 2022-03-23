using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5MDIApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocument doc = new frmDocument();
            Utils.docCount++;
            doc.Text = "Document #" + Utils.docCount.ToString();
            doc.MdiParent = this;
            doc.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?","MDI App", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form actForm = this.ActiveMdiChild;

            MessageBox.Show(actForm.IsMdiChild.ToString());
            if (actForm != null)
            {
                actForm.Close();
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] children = this.MdiChildren;
            foreach(Form f in children)
            {
                f.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            MessageBox.Show(f.IsMdiChild.ToString());
            f.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
