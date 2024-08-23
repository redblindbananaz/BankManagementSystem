using BankSystem.Components;
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

        private decimal selectedAmount;
        public string selectedAccountName;
        public int selectedAccountId;
        public decimal selectedBalance;


        public ActionController(ActionType actionType)
        {
            InitializeComponent();
            InitializeAccountsController();
            InitializeConfirmationLabel();
            currentAction = actionType;
            actionLabel.Text = actionType == ActionType.Deposit ? "Choose Account for Deposit" : "Choose Account for Withdraw";

        }

        private void InitializeAccountsController()
        {
            accountsController2 = new AccountsController();

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

        private void InitializeConfirmationLabel()
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
            selectedMessageLabel.Text = "Please Select an Account for Transaction";
            selectedMessageLabel.TextAlign = ContentAlignment.MiddleLeft;

            Controls.Add(selectedMessageLabel);
            selectedMessageLabel.BringToFront();
        }
       

        public void SetSelectedAccount(string accountName, int accountId, decimal balance)
        {
            selectedAccountName = accountName;
            selectedAccountId = accountId;
            selectedBalance = balance;
        }

        public void OnAccountClicked(object sender, AccountCardClickedEventArgs e)
        {
            SetSelectedAccount(e.AccountName, e.AccountId, e.Balance);

            selectedMessageLabel.Text = $"Selected Account: {e.AccountName} - {e.AccountId} --> Press 'Select' to Continue";
        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void InitialiZeNewAction()
        { }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedAccountName))
            {
                MessageBox.Show("Please select an account to continue");

            }
            else
            {
                accountsController2.Visible = false;
                selectedMessageLabel.Visible = false;
                selectButton.Visible = false;
                ConfirmBtn.Visible = true;
                StepLevelLabel.Text = "Step 2";
                actionLabel.Text = currentAction == ActionType.Deposit ? "Enter Amount for Deposit" : "Enter Amount for Withdraw";
                presentationPanel2.Visible = true;
                accountNameLabel.Visible = true;
                CurrentBalanceLabel.Visible = true;
                accountNameLabel.Text = $"{selectedAccountName} Account";
                CurrentBalanceLabel.Text = $"Current Available Balance: $ {selectedBalance}";


                if (currentAction == ActionType.Deposit)
                {
                    MessageBox.Show($"Deposit action for {selectedAccountName}");
                }
                else if (currentAction == ActionType.Withdraw)
                {
                    MessageBox.Show($"Withdraw action for {selectedAccountName}");
                }
                else
                {
                    throw new NotImplementedException("Error in the system");

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void QuickCashButton_Click(object sender, EventArgs e)
        {
            CustomButton? clickedButton = sender as CustomButton;

            if (clickedButton != null) 
            {
                ResetQuickCashButton();

                clickedButton.BorderColor = CustomColors.Orange;

                selectedAmount = Convert.ToDecimal(clickedButton.Tag);
                confirmationMessageActionLabel.Visible = true;
                confirmationMessageActionLabel.Text = $"Press Confirm to continue {currentAction} - {selectedAmount} - {selectedAccountName} ID {selectedAccountId}";
            }
        }

        private void ResetQuickCashButton()
        {
            cash50Btn.BorderColor = CustomColors.DeepBLue;
            cash100Btn.BorderColor = CustomColors.DeepBLue;
            cash200Btn.BorderColor = CustomColors.DeepBLue;
            cash500Btn.BorderColor = CustomColors.DeepBLue;

            confirmationMessageActionLabel.Visible = false;
        }
        private void cash50Btn_Click(object sender, EventArgs e)
        {
            SelectAmount(50);

        }

        private void cash100Btn_Click(object sender, EventArgs e)
        {
            SelectAmount(100);

        }

        private void cash200Btn_Click(object sender, EventArgs e)
        {
            SelectAmount(200);

        }

        private void cash500Btn_Click(object sender, EventArgs e)
        {
            SelectAmount(500);
        }

        private void SelectAmount(decimal amount)
        {
            selectedAmount = amount;
            MessageBox.Show($"{currentAction} - Selected Amount: {selectedAmount} - account: {selectedAccountName}");
        }


        private void EnterAmountBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
