using BankSystem.Controllers;
using BankSystem.Models;

namespace BankSystem
{
    public partial class Form1 : Form
    {

        BaseController homeControl = new BaseController();

        public Form1()
        {
            InitializeComponent();
            ShowControl();

        }

        private void ShowControl()
        {
            
            homeControl.Dock = DockStyle.Fill;
            homeControl.BringToFront();
            panel1.Controls.Clear();
            panel1.Controls.Add(homeControl);

        }
        //Default user for the application:
        User customer1 = new Customer("JD1234", "John", "JohnD@xtra.co.nz");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
