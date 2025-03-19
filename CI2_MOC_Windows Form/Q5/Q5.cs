using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23FOTCA11030_Vishal_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            string item = itemTXT.Text;
            listBox1.Items.Add(item);
            itemTXT.Text = "";
            int count = listBox1.Items.Count;
           itemCNT.Text = count.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
