using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BankSystem.Controllers
{
    public enum ActionType
    {
        Deposit,
        Withdraw,
    }

    

    public partial class ActionController : UserControl
    {
        private readonly ActionType currentAction;
       
        public AccountsController AccountsController2 { get; private set; } // Account cards object instance for Action

        public event EventHandler CancelClicked;
        public ActionController(ActionType actionType)
        {
            InitializeComponent();
            InitializeAccountsController();
            currentAction = actionType;
            SetupUI();
        }

        private void SetupUI()
        {
            if (currentAction == ActionType.Deposit)
            {
                actionLabel.Text = "Deposit";
                ShowconfirmationLabel();
            }
            else if (currentAction == ActionType.Withdraw)
            {
                actionLabel.Text = "Withdraw";
                ShowconfirmationLabel();
            }
        }

        private void InitializeAccountsController()
        {
            AccountsController2 = new AccountsController();

            // 
            // accountsController2 Properties
            // 
            AccountsController2.Location = new Point(25, 170);
            AccountsController2.Name = "accountsController2";
            AccountsController2.Size = new Size(600, 266);
            AccountsController2.TabIndex = 0;
            

            Controls.Add(AccountsController2);
            AccountsController2.BringToFront();
        }

        public string SelectedAccountName { get; private set; }
        public int SelectedAccountId { get; private set; }
        public void SetSelectedAcount(string accountName, int accountId)
        {
            SelectedAccountName = accountName;
            SelectedAccountId = accountId;

        }
        private void ShowconfirmationLabel()
        {
            if (!string.IsNullOrEmpty(SelectedAccountName))
            {
                selectedMessageLabel.Text = $"You have selected {SelectedAccountName}";

            }
            else
            {
                selectedMessageLabel.Text = "Please select an account";
            }
        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);

        }

        private void selectButton_Click(object sender, EventArgs e)
        {

        }
    }
}
