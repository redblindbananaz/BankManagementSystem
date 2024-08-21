using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
   
    public abstract class Account
    {
        private static int _nextID = 12;
        private int _accountID;
        private string _accountName;
        private decimal _balance;
        
        private List<Transaction> transactions;

        
        public int AccountID { get; set; }

        public string AccountName { get; set; }
        
        public decimal Balance { get; set; }
        
       
        public List<Transaction> Transactions { get; set; }


        protected Account(string _accountName, decimal _balance)
        {
            AccountID = _nextID++;
            AccountName = _accountName;
            Balance = _balance;
        }

        public abstract void Deposit(decimal amount);


        public abstract void Withdraw(decimal amount);
      
    }
}
