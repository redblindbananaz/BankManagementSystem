using BankSystem.Controllers;
using BankSystem.Models;

namespace BankSystem
{
    public partial class Form1 : Form
    {
        private UserControl currentControl;

        BaseController homeController = new BaseController();
        ActionController depositController = new ActionController(ActionType.Deposit);
        ActionController withdrawController = new ActionController(ActionType.Withdraw);

        



        public Form1()
        {
            InitializeComponent();
            Customer.SetCurrentUser("JD12345", "John Doe");
            showHome();
        }
        
        private void Testing()
        {
            // This is a test method
            MessageBox.Show($"Testing:{ Customer.CurrentUser.Accounts[1]}");
        }

        private void LoadUserControl(UserControl control)
        {
            panel1.Controls.Clear();
            //set the new control as the current control:
            currentControl = control;
            control.Dock = DockStyle.Fill;
            control.BringToFront();

            panel1.Controls.Add(control);
        }

        private void showHome()
        {
            LoadUserControl(homeController);


            if (Customer.CurrentUser != null)
            {
                homeController.userNameLabel.Text = ($"{Customer.CurrentUser.UserName}");
                homeController.LoadAccountCards();

            }
            else
            {
                homeController.userNameLabel.Text = "Guest";
            }
        }

        // BASIC BUTTONS FUNCTIONALITY:

        private void logoBox_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(depositController);
            depositController.CancelClicked += ActionControl_CancelClicked;

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            LoadUserControl(withdrawController);
            withdrawController.CancelClicked += ActionControl_CancelClicked;

        }

        private void outButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        // EVENT HANDLERS:
        private void ActionControl_CancelClicked(object sender, EventArgs e)
        {
            showHome();
        }


    }
}
