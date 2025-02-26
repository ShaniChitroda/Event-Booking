using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace EventBooking
{
    public partial class adminlogin : Form
    {
        public adminlogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "Admin";
            string p = "Admin123";
            if(textBox1.Text == a && textBox2.Text == p)
            {
                MessageBox.Show("Admin Login Successful");
                AdminMain m = new AdminMain();
                m.Show();

            }
        }
    }
}
