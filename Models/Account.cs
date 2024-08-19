using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public enum AccountName
    {
        Everyday,
        Omni,
        Invest
    };
    public abstract class Account
    {
        private static int nextID = 12;
        private int accountID;
        private AccountName accountName;
        private decimal balance;
        public decimal interestRate;
        private decimal overdraftLimit;
        private decimal transactionFee = 10;
        private List<Transaction> transactions;

        
        public int AccountID
        {
            get => accountID;
        }
        public AccountName AccountName 
        {
            get => accountName;
        }
        public decimal Balance
        {
            get => balance;
        }
        public decimal InterestRate
        {
            get => interestRate;
        }
        public decimal OverdraftLimit
        {
            get => overdraftLimit;
        }

        public decimal TransactionFee
        {
            get => transactionFee;
        }
        public List<Transaction> Transactions
        {
            get => transactions;
        }


        protected Account( string accountName, decimal balance, decimal interestRate, decimal overdraftLimit, decimal transactionFee)
        {
            this.accountID = nextID++;
            this.accountName = AccountName;
            this.balance = balance;
            this.interestRate = interestRate;
            this.overdraftLimit = overdraftLimit;
            this.transactionFee = transactionFee;

        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (balance - amount >= -overdraftLimit)
            {
                balance -= amount;
            }
            else
            {
                //Overdraft limit reached
            }
        }
        public void CalculateInterest()
        {
            balance += balance * (decimal)interestRate;
        }


    }
}
