﻿using System;
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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string u = "shani";
            string p = "shani123";
            if(textBox1.Text == u && textBox2.Text== p)
            {
                MessageBox.Show("User login Successful");
                bookingsection b = new bookingsection();
                b.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter valid Username or Password");
            }
        }
    }
}
