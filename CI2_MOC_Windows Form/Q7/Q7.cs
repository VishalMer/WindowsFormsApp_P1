using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _23FOTCA11030_Vishal_Form.Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            String query = "insert into employee('" + nameTXT.Text + "','" + gender.Text + "','" + emailTXT.Text + "','" + stateTXT.Text + "','" + cityTXT.Text + "','" + salaryTXT.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully!!");
        }
    }
}
