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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode("Classes", 0, 3);
            root.Tag = "1";
            for (int i = 1; i < 10; i++)
            {
                TreeNode tn = new TreeNode("Class #" + i.ToString(), 1, 2);
                tn.Tag = "1" + i.ToString();
                root.Nodes.Add(tn);
            }
            this.treeView1.Nodes.Add(root);
            treeView1.ExpandAll();
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Tag)
            {
                case "11":
                    ListViewItem lvi = new ListViewItem(e.Node.Tag.ToString(), 1);
                    lvi.SubItems.Add("Student: " + e.Node.Tag.ToString());
                    lvi.SubItems.Add("Da nang");
                    lvi.SubItems.Add("0905 525354");

                    this.listView1.Items.Clear();
                    this.listView1.Items.Add(lvi);
                    lvi = new ListViewItem(e.Node.Tag.ToString() + "2", 1);
                    lvi.SubItems.Add("Student: " + e.Node.Tag.ToString() + "2");
                    lvi.SubItems.Add("Da nang");
                    lvi.SubItems.Add("0905 525354");
                    this.listView1.Items.Add(lvi);
                    break;
                case "12":
                    ListViewItem lvi2 = new ListViewItem(e.Node.Tag.ToString(), 1);
                    lvi2.SubItems.Add("Student: " + e.Node.Tag.ToString());
                    lvi2.SubItems.Add("Quang Nam");
                    lvi2.SubItems.Add("0905 889966");
                    this.listView1.Items.Clear();
                    this.listView1.Items.Add(lvi2);
                    break;
                case "13":
                    ListViewItem lvi3 = new ListViewItem(e.Node.Tag.ToString(), 1);
                    lvi3.SubItems.Add("Student: " + e.Node.Tag.ToString());
                    lvi3.SubItems.Add("Quang Ngai");
                    lvi3.SubItems.Add("0905 888888");
                    this.listView1.Items.Clear();
                    this.listView1.Items.Add(lvi3);
                    break;
                case "14":
                    break;
                case "15":
                    break;
                case "16":
                    break;
                case "17":
                    break;
                case "18":
                    break;
                case "19":
                    break;
                default:

                    break;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "";
            foreach (ListViewItem li in this.listView1.SelectedItems)
            {
                s = s + li.Text + "|" + li.SubItems[1].Text + "|" + li.SubItems[2].Text + "|" + li.SubItems[3].Text;
                
            }
            this.Text = s;
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.List;
        }
        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }
        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
        }
        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddStudent s = new frmAddStudent(this);
            s.ShowDialog();
        }
    }
}
