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
        DateTime localDate = DateTime.Now;

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
            
        }

        protected void AddTransaction(string type, decimal amount, string status)
        {
            _transactions.Add($"{localDate} - AccountID: {_accountID} - Account: {_accountName} - {type} - ${amount} - Status: {status}");
        }
        

        public abstract void Deposit(decimal amount);


        public abstract void Withdraw(decimal amount);
      
    }
}
