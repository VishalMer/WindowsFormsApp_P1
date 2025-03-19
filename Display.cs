using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp_P1
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Vishal_C#\\WindowsFormsApp_P1\\Database1.mdf;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void showBTN_Click(object sender, EventArgs e)
        {
            string query = "select * from Display";
            SqlDataAdapter da = new SqlDataAdapter(query,con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            displayData.DataSource = dt;
            con.Close();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            String query = "insert into Display('" +nameTXT.Text+"','"+rollTXT.Text+"','"+branchTXT.Text +"')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully!!");
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            String query = "delete frome Display where id = '" + idTXT + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully!!");
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            String query = "update Display set name ='" + nameTXT + "', rollno = '" + rollTXT + "', branch = '" + branchTXT + "',)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully!!");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
