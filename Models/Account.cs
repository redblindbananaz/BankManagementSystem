using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public abstract class Account
    {
        private static int nextID = 12;
        private int accountID;
        private enum AccountName;
        private decimal balance;
        public double interestRate;
        private double overdraftLimit;
        private List<Transaction> transactions;

        
        public int AccountID
        {
            get => accountID;
        }
        public decimal Balance
        {
            get => balance;
        }
        public double InterestRate
        {
            get => interestRate;
        }
        public double OverdraftLimit
        {
            get => overdraftLimit;
        }
        public List<Transaction> Transactions
        {
            get => transactions;
        }


        protected Account()
        {
            accountID = nextID++;

        }


    }
}
