using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    /* Omni Account:
     * 
     * Interest Rates Applied Only on Balances Over $1000
     * Specified Overdraft Permitted
     * Fee Incurred for Failed Transactions
     * Simple deposit method
     * Ability to calculate and add interest to the balance
     */
    internal class Omni : Account
    {

        public const decimal InterestRate = 0.04m; // 4% Interest Rate
        private const decimal Overdraft = 100m; // Overdraft of $100
        private const decimal FailingFee = 5m; // Fee for Failed Transactions

        public Omni (decimal balance) : base("Omni", balance)
        {
        }
        
        public Omni(string accountName, decimal balance ) : base ("Omni",  balance)
        {
        }

        // Deposit method is Done in Base class.
        protected override string FormatTransaction(string type, decimal amount, bool isSuccessful)
        {
            string baseDetails = base.FormatTransaction(type, amount, isSuccessful);
            if (!isSuccessful)
            {
                baseDetails += $" - {FailingFee}";
            }
            return baseDetails;
        }

        public override void Withdraw(decimal amount)
        {
            bool isSuccessful = Balance - amount >= -Overdraft;
            if (isSuccessful)
            {
                Balance -= amount;
                
            }
            else
            {
                Balance -= FailingFee;
                
            }
            string transactionDetails = FormatTransaction("Withdraw", amount, isSuccessful);
            Transactions.Add(transactionDetails);
        }

        public static decimal CalculateInterest(decimal balance)
        {
            if (balance > 1000)
            {
                return balance * InterestRate;
            }
            else
            {
                return 0;
            }
        }

        public void AddInterest(decimal interest)
        {
            
            if (interest > 0)
            {
                
                Balance += interest;
                AddTransaction("Interest Added", interest, true);
                Transactions.Add($"- {interest}");
            }
            else
            {
                MessageBox.Show("Balance Must Be Over $1000 In Order To Earn Interest");
            }
            // Failed interest as error OR balance is below 1000... Check if needed custom add transaction.
        }
    }
}
