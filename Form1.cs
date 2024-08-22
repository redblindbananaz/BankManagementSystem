using BankSystem.Controllers;
using BankSystem.Models;

namespace BankSystem
{
    public partial class Form1 : Form
    {
        private UserControl currentControl;
        public AccountsController AccountsController1;// Account cards object instance for Home


        BaseController homeController = new BaseController();
        

        public ActionController depositController { get; private set; }
        public ActionController withdrawController { get; private set; }
        

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
            homeController.AccountsController1.LoadAccountCards();

            if (User.CurrentUser != null)
            {
                homeController.userNameLabel.Text = ($"{User.CurrentUser.UserName}");
            }
            else
            {
                throw new ArgumentException("There is no Current User");
            }
        }

        // BASIC BUTTONS FUNCTIONALITY:

        private void logoBox_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            depositController = new ActionController(ActionType.Deposit);
            LoadUserControl(depositController);
           
            depositController.accountsController2.LoadAccountCards();
            depositController.CancelClicked += ActionControl_CancelClicked;

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            withdrawController = new ActionController(ActionType.Withdraw);
            LoadUserControl(withdrawController);
            withdrawController.accountsController2.LoadAccountCards();
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
