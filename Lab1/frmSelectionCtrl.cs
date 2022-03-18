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
    public partial class frmSelectionCtrl : Form
    {
        public frmSelectionCtrl()
        {
            InitializeComponent();
        }

        private void frmSelectionCtrl_Load(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.checkedListBox1.Items.Clear();
            for (int i = 2; i < 9; i++)
            {
                if (i == 8) 
                {
                    this.listBox1.Items.Add("Chủ nhật");
                    checkedListBox1.Items.Add("Chủ nhật", true);
                }
                else
                {
                    this.listBox1.Items.Add("Thứ " + i.ToString());
                    this.checkedListBox1.Items.Add("Thứ " + i.ToString());
                }
            }                        
            this.comboBox1.SelectedIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            for(int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBox2.Items.Clear();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i))
                {
                    listBox2.Items.Add(listBox1.Items[i]);
                    listBox1.SetSelected(i,false);
                }                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.Items[comboBox1.SelectedIndex].ToString());
        }
        private string gender = "";
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(this.radioButton1.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(int idx in this.checkedListBox1.CheckedIndices)
            {
                textBox1.AppendText(this.checkedListBox1.Items[idx].ToString());
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string msg = "";

            foreach (object obj in checkedListBox1.CheckedItems)
            {
                msg = msg + obj.ToString() + Environment.NewLine;
            }
            MessageBox.Show(msg);
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            MessageBox.Show(e.CurrentValue.ToString() + " - " + e.NewValue.ToString());
            MessageBox.Show(e.Index.ToString());
        }
    }
}
