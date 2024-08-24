using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
   
    public abstract class Account
    {
        // Static field to generate the unique account ID
        private static int _nextID = 12;
        string localDate = DateTime.Now.ToString("MM/dd/yy");
        

        // Private Fields:
        private readonly int _accountID;
        private string _accountName;
        private decimal _balance;
        private List<string> _transactions = new List<string>();


        //Public properties:
        public int AccountID=> _accountID;

        public string AccountName 
        {  
            get=> _accountName;
            set=> _accountName = value; 
        }
        
        public decimal Balance 
        {
            get=> _balance; 
            set=> _balance = value; 
        }
        
        public List<String> Transactions=> _transactions;


        protected Account(string accountName, decimal balance)
        {
            _accountID = _nextID++;
            _accountName = accountName;
            _balance = balance;
            _transactions = new List<String>();
            
        }

        protected virtual string FormatTransaction(string type, decimal amount, bool isSuccessful)
        {
            return $"{localDate}  - {_accountName} - {_accountID} - {type} - {amount} - {(isSuccessful ? "Approved" : "Declined")} - {_balance:C}";
        }

        protected void AddTransaction(string type, decimal amount, bool isSuccessful)
        {
            
            string TDetails = FormatTransaction(type, amount, isSuccessful);

            _transactions.Add(TDetails);
        }
        

        public void Deposit(decimal amount)
        {
            // NEED UI Implementation of Validation for performing a deposit with a try, catch and message box.
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than 0");
            }

            Balance += amount;

            AddTransaction("Deposit", amount, true);

            // Update Balance Event handler? HERE?
            
        }

        public abstract void Withdraw(decimal amount);
      
    }
}
