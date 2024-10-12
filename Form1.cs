using BankSystem.Components;
using BankSystem.Controllers;
using BankSystem.Models;

namespace BankSystem
{
    public partial class Form1 : Form
    {
        private UserControl _currentControl;
        public AccountsController AccountsController1;// Account cards object instance for Home
        private BaseController _homeController = new BaseController();
        private BaseController _historyController = new BaseController();
        private DetailAccountController _detailController = new DetailAccountController();
        public ActionController DepositController { get; private set; }
        public ActionController WithdrawController { get; private set; }


        public Form1()
        {
            InitializeComponent();
            InitializeUser();

            UpdateTotalBalance();
            showHome();
        }
        public void Form1_Resize(object sender, EventArgs e)
        {
            panel2.Left = (this.ClientSize.Width - panel2.Width) / 2;
            panel2.Top = (this.ClientSize.Height - panel2.Height) / 2;
        }

        private void InitializeUser()
        {
            // This method should set the current user of the system
            User user1 = User.CreateUser("JD12345", "John Dee", true, "");

            user1.CreateAccount(new Everyday(510));
            user1.CreateAccount(new Omni(340));
            user1.CreateAccount(new Invest(320));

            User.SetCurrentUser(user1);

        }

        private void LoadUserControl(UserControl control)
        {
            panel1.Controls.Clear();
            //set the new control as the current control:
            _currentControl = control;
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            panel1.Controls.Add(control);
        }

        public decimal CalculateTotalBalance()
        {
            return User.CurrentUser.Accounts.Sum(account => account.Balance);
        }

        private void UpdateTotalBalance()
        {
            totalBalanceLabel.Text = $"{CalculateTotalBalance():C}";
        }

        private void ResetButtonColors()
        {
            depositButton.BorderColor = Color.FromArgb(255, 242, 204);
            withdrawButton.BorderColor = Color.FromArgb(255, 242, 204);
            historyButton.BorderColor = Color.FromArgb(255, 242, 204);

        }

        private void showHome()
        {
            UpdateTotalBalance();
            LoadUserControl(_homeController);
            _homeController.AccountsController1.LoadAccountCards();
            _homeController.AccountsController1.accountCard1.AccountCardClicked += OnHomeAccountCard_Clicked;
            _homeController.AccountsController1.accountCard2.AccountCardClicked += OnHomeAccountCard_Clicked;
            _homeController.AccountsController1.accountCard3.AccountCardClicked += OnHomeAccountCard_Clicked;

            ResetButtonColors();
            _homeController.userNameLabel.Text = User.CurrentUser?.UserName ?? "Guest";

        }

        private void OnHomeAccountCard_Clicked(object sender, AccountCardClickedEventArgs e)
        {
            UpdateTotalBalance();
            LoadUserControl(_detailController);

            _detailController.InitializeDetailAccountLayout(e.AccountName, e.Balance, e.AccountId);
            _detailController.CancelClicked += ActionControl_CancelClicked;

        }

        // BASIC BUTTONS FUNCTIONALITY:

        private void logoBox_Click(object sender, EventArgs e)
        {
            showHome();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            UpdateTotalBalance();
            DepositController = new ActionController(ActionType.Deposit);
            LoadUserControl(DepositController);
            DepositController.accountsController2.LoadAccountCards();
            DepositController.CancelClicked += ActionControl_CancelClicked;
            ResetButtonColors();
            depositButton.BorderColor = CustomColors.Orange;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            UpdateTotalBalance();
            WithdrawController = new ActionController(ActionType.Withdraw);
            LoadUserControl(WithdrawController);
            WithdrawController.accountsController2.LoadAccountCards();
            WithdrawController.CancelClicked += ActionControl_CancelClicked;
            ResetButtonColors();
            withdrawButton.BorderColor = CustomColors.Orange;

        }

        private void outButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void ActionControl_CancelClicked(object sender, EventArgs e)
        {
            showHome();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            UpdateTotalBalance();
            LoadUserControl(_historyController);
            _historyController.InitializeHistoryLayout();
            depositButton.BorderColor = Color.FromArgb(255, 242, 204);
            withdrawButton.BorderColor = Color.FromArgb(255, 242, 204);
            historyButton.BorderColor = CustomColors.Orange;
        }
    }
}
