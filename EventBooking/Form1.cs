namespace EventBooking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserLogin u = new UserLogin();
            u.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminlogin a = new adminlogin();
            a.ShowDialog();

        }
    }
}
