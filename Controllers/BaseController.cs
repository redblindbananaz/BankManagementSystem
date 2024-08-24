using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem.Components;
using BankSystem.Models;
using BankSystem.Controllers;

namespace BankSystem.Controllers
{
    

    public partial class BaseController : UserControl
    {
        public AccountsController AccountsController1 => accountsController1;
        public BaseController()
        {
            InitializeComponent();
            
        }

        public void InitializeHistoryLayout()
        {
            accountsController1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            seperationLine.Visible = false;
            panel1.Visible = false;
            label1.Text = "History";
            dataGridView1.Visible = true;
            
            LoadTransactionHistory(User.CurrentUser);

        }

        public void LoadTransactionHistory(User user)
        {
            dataGridView1.Rows.Clear();
            int rowIndex = 1;
            dataGridView1.Columns.Add("RowNumber", "#");
            dataGridView1.Columns.Add("Date", "localDate");
            dataGridView1.Columns.Add("AccountName", "Account");
            dataGridView1.Columns.Add("AccountID", "ID");
            dataGridView1.Columns.Add("Operatione", "Type");
            dataGridView1.Columns.Add("Amount", "Amount");
            dataGridView1.Columns.Add("Status", "status");
            dataGridView1.Columns.Add("Balance", "Balance");
            dataGridView1.Columns.Add("Fee", "FailingFee");

            dataGridView1.Columns["RowNumber"].Width = 25;
            dataGridView1.Columns["AccountID"].Width = 25;
            dataGridView1.Columns["AccountName"].Width = 50;

            foreach (var account in user.Accounts)
            {
                foreach (var transaction in account.Transactions)

                {
                    var transactionDetails =transaction.Split('-');
                    if (transactionDetails.Length >= 7) {

                        rowIndex++;
                        string date = transactionDetails[0].Trim();
                        string accountName = transactionDetails[1].Trim();
                        string accountID = transactionDetails[2].Trim();
                        string operation = transactionDetails[3].Trim();
                        string amount = transactionDetails[4].Trim();
                        string status = transactionDetails[5].Trim();
                        string balance = transactionDetails[6].Trim();

                        string failingfee = transactionDetails.Length > 7 ? transactionDetails[7].Trim() : "N/A";
                        dataGridView1.Rows.Add(rowIndex, date, accountName, accountID, operation, amount, status, balance, failingfee);

                    }

                }
            }

        }
    }
}
