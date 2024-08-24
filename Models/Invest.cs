using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BankSystem.Models
{
    /* Invest account:
     * 
     * Variable Interest Rates Applied to All Funds
     * No Overdraft
     * Incurs a Fee for Failed Transactions
     * Ability to calculate and add interest to the balance
     */


    public class Invest: Account
    {
        private const decimal InterestRate = 0.05m;
        private const decimal FailingFee = 10m;

        public Invest(decimal balance) : base("Invest", balance)
        {
        }
        public Invest(string accountName, decimal balance) : base("Invest", balance)
        { 
           
        }

        private decimal CalculateFailingFee()
        {
            return FailingFee;
        }

        protected override string FormatTransaction(string type, decimal amount, bool isSuccessful)
        {
            string baseDetails = base.FormatTransaction(type, amount, isSuccessful);
            if (!isSuccessful)
            {
                baseDetails += $" - {FailingFee}";
            }
            return baseDetails;
        }


        public void AddInvestTransaction(string type, decimal amount, bool isSuccessful)
        {
            string transactionDetails = FormatTransaction("Withdraw", amount, isSuccessful);
            Transactions.Add(transactionDetails);
            if (!isSuccessful) 
            {
                Balance -= FailingFee;
                
            }
        }


        // Deposit method is Done in Base class.

        public override void Withdraw(decimal amount)
        {
            if (amount <= 0) // Just not penalities for withdrawing 0 :)
            {
                throw new ArgumentException("Withdraw amount must be greater than 0");
            }
            if (Balance - amount < 0)
            {
                AddInvestTransaction("Withdraw", amount, false);
                return;
            }
            Balance -= amount;
            AddInvestTransaction("Withdraw", amount, true);
        }

        public void AddInterest()
        {
            decimal interest = Balance * InterestRate;
            Balance += interest;
            AddInvestTransaction("Interest Added", interest, true);
            Transactions.Add($"- {interest}");
        }
    }
}
