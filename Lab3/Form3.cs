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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text Format|*.rtf|Text Files|*.txt|All Files (*.*)|*.*";
            ofd.FilterIndex = 2;
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(ofd.FileName);
                MessageBox.Show(text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("You canceled.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Rich Text Format|*.rtf|Text Files|*.txt|All Files (*.*)|*.*";
            sfd.FilterIndex = 2;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(sfd.FileName, "Just a simple text");
                MessageBox.Show("Saved");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.AllowVerticalFonts = true;
            fd.AllowSimulations = true;
            fd.AllowVectorFonts = true;
            fd.ShowApply = true;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                this.Font = fd.Font;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
           // fbd.RootFolder = Environment.SpecialFolder.MyDocuments;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(fbd.SelectedPath);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn xóa file này không?","Xóa file", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                MessageBox.Show("You selected Yes.", "Delete confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("You selected No.", "Delete confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
