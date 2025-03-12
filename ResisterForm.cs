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
using System.Data.SqlClient;

namespace WindowsFormsApp_P1
{
    public partial class Form3 : Form
    {
        String gender;
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Vishal_C#\\WindowsFormsApp_P1\\SResisterDB.mdf;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void resisterBtn_Click(object sender, EventArgs e)
        {
            string query = "insert into sResister values('"+nameTXT.Text+"','" + passTXT.Text+"','"+branchTXT.Text+ "','"+gender+"','"+cityList.SelectedItem.ToString()+"')";
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Resistered Successfully!!");
        }

        private void MaleTXT_CheckedChanged(object sender, EventArgs e)
        {
            gender = "MALE";
        }

        private void FemaleTXT_CheckedChanged(object sender, EventArgs e)
        {
            gender = "FEMALE";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "update sResister set name='" + nameTXT.Text + "', password='" + passTXT.Text + "', branch='" + branchTXT.Text + "', gender='" + gender + "', city='" + cityList.SelectedItem.ToString() + "' where id ='" + Convert.ToInt32(idTXT.Text)+ "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated Successfully!!");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string query = "delete from sResister where id ='" + Convert.ToInt32(idTXT.Text) + "' ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Deleted Successfully!!");
        }

        private void ShowDataBtn_Click(object sender, EventArgs e)
        {
            string query = "select * from sResister ";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            //string query = "select * from sResister ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DisplayData.DataSource = dt;
            conn.Close();
        }
    }
}
