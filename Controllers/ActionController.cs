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

        public AccountsController accountsController2; // Account cards object instance for Action

        private Label selectedMessageLabel;

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
                
            }
            else if (currentAction == ActionType.Withdraw)
            {
                actionLabel.Text = "Withdraw";
                
            }
        }

        private void InitializeAccountsController()
        {
            accountsController2 = new AccountsController();

            // 
            // accountsController2 Properties
            // 
            accountsController2.Location = new Point(25, 170);
            accountsController2.Name = "accountsController2";
            accountsController2.Size = new Size(600, 266);
            accountsController2.TabIndex = 0;
            

            Controls.Add(accountsController2);
           
            accountsController2.BringToFront();

            accountsController2.accountCard1.AccountCardClicked += OnAccountClicked;
            accountsController2.accountCard2.AccountCardClicked += OnAccountClicked;
            accountsController2.accountCard3.AccountCardClicked += OnAccountClicked;
        }

        public string SelectedAccountName { get;  set; }
        public int SelectedAccountId { get;  set; }
        public void SetSelectedAccount(string accountName, int accountId)
        {
            SelectedAccountName = accountName;
            SelectedAccountId = accountId;
        }

        public void OnAccountClicked(object sender, AccountCardClickedEventArgs e)
        {
            //var accountCard = (AccountCardController)sender;
            //SetSelectedAccount(e.AccountName, e.AccountId);
            MessageBox.Show($"Account {e.AccountName} selected in ACTION");
            ShowconfirmationLabel(e.AccountName, e.AccountId);
        }
        private void ShowconfirmationLabel( string Name, int ID)
        {
            selectedMessageLabel = new Label();
            // 
            // selectedMessageLabel
            // 
            selectedMessageLabel.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            selectedMessageLabel.ForeColor = Color.FromArgb(215, 155, 0);
            selectedMessageLabel.Location = new Point(39, 489);
            selectedMessageLabel.Name = "selectedMessageLabel";
            selectedMessageLabel.Size = new Size(574, 23);
            selectedMessageLabel.TabIndex = 6;
            selectedMessageLabel.Text = $"You have selected {Name} - ID {ID} for Transaction";
            selectedMessageLabel.TextAlign = ContentAlignment.MiddleLeft;

            if (Name != null)
            {
                Controls.Add(selectedMessageLabel);
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
