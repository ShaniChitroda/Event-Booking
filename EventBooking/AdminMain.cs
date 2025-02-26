using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventBooking
{
    public partial class AdminMain : Form
    {
        private object t;

        public AdminMain()
        {
            InitializeComponent();
        }

        public void Hello()
        {
            Label l = new Label
            {
                Text="Add Event",
                Location=new Point(200, 100)
            };
            panel1.Controls.Add(l);
            TextBox t = new TextBox
            {
                Location=new Point(200, 120)
            };
            panel1.Controls.Add(t);


            Button b1 = new Button
            {
                Text = "Add",
                Location = new Point(220, 130),
                Name = "btn_add"
            };
        }
        private void addEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Hello();
        }
        private void viewEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("View Events Clicked"); // Temporary test message
        }

    }
}
