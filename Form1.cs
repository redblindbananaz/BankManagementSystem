using BankSystem.Controllers;
using BankSystem.Models;

namespace BankSystem
{
    public partial class Form1 : Form
    {

        BaseController homeController = new BaseController();

        public Form1()
        {
            InitializeComponent();
            ShowControl();

        }

        public void ShowControl()
        {
            
            homeController.Dock = DockStyle.Fill;
            homeController.BringToFront();
            panel1.Controls.Clear();
            panel1.Controls.Add(homeController);

        }
        //Default user for the application:
        User customer1 = new Customer("JD1234", "John", "JohnD@xtra.co.nz");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
