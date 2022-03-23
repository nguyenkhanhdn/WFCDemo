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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "Path of Image";
            this.pictureBox1.Load(path);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

          

            //this.listView1.Items.Clear();
            this.treeView1.Nodes.Clear();
            TreeNode root = new TreeNode("Classes", 1, 2);
            root.Tag = "1";
            for(int i = 1; i < 10; i++)
            {
                /*
                //Add listview items
                ListViewItem lvi = new ListViewItem("#" + i.ToString(),2);
                lvi.SubItems.Add("Student #" + i.ToString());
                lvi.SubItems.Add("090598765" + i.ToString());
                this.listView1.Items.Add(lvi);
                */
                //add treeview nodes
                TreeNode node = new TreeNode("Class #" + i.ToString(), 1, 2);
                node.Tag = "10" + i.ToString();
                root.Nodes.Add(node);
            }
            this.tabControl1.SelectedIndex = 1;

            this.treeView1.Nodes.Add(root);
            this.treeView1.ExpandAll();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.List;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Details;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.Tile;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.SmallIcon;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.listView1.View = View.LargeIcon;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = "";
            foreach(ListViewItem it in this.listView1.SelectedItems)
            {
                text = text + it.Text + ", " + it.SubItems[1].Text + ", " + it.SubItems[2].Text;
            }

            this.Text = text;
        }

        private void treeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            
            
           
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //treeView1_BeforeSelect(sender, (TreeNodeMouseClickEventArgs)e);

            //if (e.Node.Tag.ToString().Length > 1)
            //{
            //    //Load data for listview
            //    this.listView1.Items.Clear();
            //    string node = e.Node.Tag.ToString().Substring(2, 1);

            //    for (int i = 1; i < 11; i++)
            //    {
            //        ListViewItem lvi = new ListViewItem(node + "0" + i.ToString(), 3);
            //        lvi.SubItems.Add("Student #" + node + "0" + i.ToString());
            //        lvi.SubItems.Add("090598765" + i.ToString());
            //        this.listView1.Items.Add(lvi);
            //    }

            //    //MessageBox.Show("Dùng để load dữ liệu trước khi mở node");
            //}
        }

        private void treeView1_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag.ToString().Length > 1)
            {
                //Load data for listview
                this.listView1.Items.Clear();
                string node = e.Node.Tag.ToString().Substring(2, 1);

                for (int i = 1; i < 11; i++)
                {
                    ListViewItem lvi = new ListViewItem(node + "0" + i.ToString(), 3);
                    lvi.SubItems.Add("Student #" + node + "0" + i.ToString());
                    lvi.SubItems.Add("090598765" + i.ToString());
                    this.listView1.Items.Add(lvi);
                }

                //MessageBox.Show("Dùng để load dữ liệu trước khi mở node");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string hh = DateTime.Now.Hour.ToString();
            string mm = DateTime.Now.Minute.ToString();
            string ss = DateTime.Now.Second.ToString();

            string time = hh + ":" + mm + ":" + ss;
            this.Text = time;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 10)
            {
                this.progressBar1.Value = progressBar1.Value + 1;
            }
            else
            {
                progressBar1.Value = 0;
                timer2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
