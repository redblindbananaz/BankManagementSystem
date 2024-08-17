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
            Customer.SetCurrentUser("JD12345","John Doe");
            ShowControl();

        }

        public void ShowControl()
        {

            homeController.Dock = DockStyle.Fill;
            homeController.BringToFront();
            panel1.Controls.Clear();
            panel1.Controls.Add(homeController);
            if (Customer.CurrentUser != null)
            {
                homeController.userNameLabel.Text = ($"{Customer.CurrentUser.UserName}");
            }
            else
            {
                homeController.userNameLabel.Text = "Guest";
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
