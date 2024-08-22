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
            SetupUser();
            UpdateTotalBalance();
            showHome();
        }

        private void SetupUser()
        {
            // This method should set the current user of the system
            User user1 = User.CreateUser("JD12345", "John Dee", true);

            user1.CreateAccount(new Everyday(510));
            user1.CreateAccount(new Omni(340));
            user1.CreateAccount(new Invest(320));

            User.SetCurrentUser(user1);

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
            foreach (var account in User.CurrentUser.Accounts)
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


            if (User.CurrentUser != null)
            {
                homeController.userNameLabel.Text = ($"{User.CurrentUser.UserName}");
                


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
