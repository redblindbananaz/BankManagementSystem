using BankSystem.Components;
using BankSystem.Models;
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

        private decimal selectedAmount = 0;
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

        private void CancelLabel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }

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
                    //MessageBox.Show($"Deposit action for {selectedAccountName}");
                }
                else if (currentAction == ActionType.Withdraw)
                {
                   // MessageBox.Show($"Withdraw action for {selectedAccountName}");
                }
                else
                {
                    throw new NotImplementedException("Error in the system");

                }
            }
        }


        // ++++++++++++ SECOND ACTION FROM ACTION CONTROLLER ++++++++++++++++++++++++++++++++

        private void QuickCashButton_Click(object sender, EventArgs e)
        {
            CustomButton? clickedButton = sender as CustomButton;

            if (clickedButton != null) 
            {
                textBox1.Text = string.Empty;
                ValidationErrorLabel.Visible = false;
                ResetQuickCashButton();

                clickedButton.BorderColor = CustomColors.Orange;

                selectedAmount = Convert.ToDecimal(clickedButton.Tag);
                confirmationMessageActionLabel.Visible = true;
                confirmationMessageActionLabel.Text = $"Press Confirm to continue {currentAction} - Quick -{selectedAmount} - {selectedAccountName} ID {selectedAccountId}";
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


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ResetQuickCashButton();
            textBox1.ForeColor = CustomColors.DeepBLue;
            ValidationErrorLabel.Visible = false;

        }

        private void EnterAmountBtn_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal amount) && amount > 0)
            {
                ResetQuickCashButton();
                ValidationErrorLabel.Visible = false;
                
                if (amount <= 0)
                {
                    ValidationErrorLabel.Visible = true;
                    ValidationErrorLabel.Text = "Please Enter Amount Greater than 0";
                    textBox1.ForeColor = Color.Red;
                    return;
                }
                if (amount < 5) 
                { 
                    ValidationErrorLabel.Visible = true;
                    ValidationErrorLabel.Text = "The Minimum Amount is $5";
                    textBox1.ForeColor = Color.Red;
                    return;
                }
                if (amount % 5 != 0) 
                { 
                    ValidationErrorLabel.Visible = true;
                    ValidationErrorLabel.Text = "The  Amount Must Be a Multiple of 5 ";
                    textBox1.ForeColor = Color.Red;
                    return;
                }
                if (amount > 1000)
                {
                    ValidationErrorLabel.Visible = true;
                    ValidationErrorLabel.Text = $"Sorry, Maximum Amount for {currentAction} is $1000";
                    textBox1.ForeColor = Color.Red;
                    return;
                }


                selectedAmount = amount;
                confirmationMessageActionLabel.Visible = true;
                confirmationMessageActionLabel.Text = $"Press Confirm to continue {currentAction} - Custom -{selectedAmount} - {selectedAccountName} ID {selectedAccountId}";
                
            }
            else
            {
                confirmationMessageActionLabel.Visible = true;
                confirmationMessageActionLabel.Text = "Please Enter a Valid Amount";
            }
        }

        

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            ResetQuickCashButton();
            textBox1.Text = string.Empty;

            // Need to implement deposit as all same for all accounts.
            //MessageBox.Show($"Transaction Completed: {currentAction} - {selectedAmount} - {selectedAccountName} ID {selectedAccountId}");

            var account = User.CurrentUser.Accounts.FirstOrDefault(a=> a.AccountID == selectedAccountId);
            if (account == null)
            {
                MessageBox.Show("Account not found");
                return;
            }
            if (currentAction == ActionType.Deposit)
            {
                account.Deposit(selectedAmount);
                // This below is to return Home, Not Cancel
                CancelClicked?.Invoke(this, EventArgs.Empty);

            }
            else if (currentAction == ActionType.Withdraw)
            {
                account.Withdraw(selectedAmount);
                // This below is to return Home, Not Cancel
                CancelClicked?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Sorry Error System...");
                return;
            }
        }
    }
}
