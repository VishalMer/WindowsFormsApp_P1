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

namespace WindowsFormsApp_P1
{
    public partial class Form5 : Form
    {
        string gender;
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Vishal_C#\\WindowsFormsApp_P1\\Database2.mdf;Integrated Security=True");
        public Form5()
        {
            InitializeComponent();
        }

        private void insertBTN_Click(object sender, EventArgs e)
        {
            string query = "insert into employee values('" + nameTXT.Text + "','" + gender + "','" + emailTXT.Text + "','" + stateTXT.Text + "','" + cityTXT.Text + "','" + salaryTXT.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted Successfully In The Employee Table!!");
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            string query = "update employee set emp_name='" + nameTXT.Text + "',emp_gender = '" + gender + "',emp_email = '" + emailTXT.Text + "',emp_state = '" + stateTXT.Text + "',emp_city = '" + cityTXT.Text + "',emp_salary = '" + salaryTXT.Text + "' where emp_id = '" + idTXT.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Successfully In The Employee Table!!");
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            string query = "delete from employee where emp_id = '" + idTXT.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted Successfully From The Employee Table!!");
        }

        private void ShowBTN_Click(object sender, EventArgs e)
        {
            string query = "select * from employee";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            //string query = "select * from employee ";
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            displayData.DataSource = dt;
            con.Close();
        }

        private void maleTXT_CheckedChanged(object sender, EventArgs e)
        {
            gender = "MALE";
        }

        private void femaleTXT_CheckedChanged(object sender, EventArgs e)
        {
            gender = "FEMALE";
        }
    }
}
