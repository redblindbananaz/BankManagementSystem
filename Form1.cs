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
            Customer.SetCurrentUser("JD12345", "John Doe");// All accounts with inital balance are instanciated here.
            UpdateTotalBalance();
            showHome();
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

        public decimal CalculateTotalBalance()
        {
            decimal total = 0;
            foreach (var account in Customer.CurrentUser.Accounts)
            {
                total += account.Balance;
            }
            return total;
        }

        private void UpdateTotalBalance()
        {
            totalBalanceLabel.Text = $"{CalculateTotalBalance():C}";
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
