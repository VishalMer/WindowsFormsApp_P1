using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_P1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        private void button5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "7";
            }
            else
            {
                display.Text = display.Text + "7";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "0";
            }
            else
            {
                display.Text = display.Text + "0";
            }
        }

        private void btn_point_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = ".";
            }
            else
            {
                display.Text = display.Text + ".";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "3";
            }
            else
            {
                display.Text = display.Text + "3";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "2";
            }
            else
            {
                display.Text = display.Text + "2";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "1";
            }
            else
            {
                display.Text = display.Text + "1";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text !=null)
            {
                display.Text = "6";
            }
            else
            {
                display.Text = display.Text+"6";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "5";
            }
            else
            {
                display.Text = display.Text + "5";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "4";
            }
            else
            {
                display.Text = display.Text + "4";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "9";
            }
            else
            {
                display.Text = display.Text + "9";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "8";
            }
            else
            {
                display.Text = display.Text + "8";
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "/";
            }
            else
            {
                display.Text = display.Text + "/";
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "+";
            }
            else
            {
                display.Text = display.Text + "+";
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "-";
            }
            else
            {
                display.Text = display.Text + "-";
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "x";
            }
            else
            {
                display.Text = display.Text + "x";
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void btn_module_Click(object sender, EventArgs e)
        {
            if (display.Text == "0" && display.Text != null)
            {
                display.Text = "%";
            }
            else
            {
                display.Text = display.Text + "%";
            }
        }
    }
}
