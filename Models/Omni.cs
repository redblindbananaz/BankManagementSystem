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

        private const decimal InterestRate = 0.04m; // 4% Interest Rate
        private const decimal Overdraft = 100m; // Overdraft of $100
        private const decimal FailingFee = 5m; // Fee for Failed Transactions

        public Omni (decimal balance) : base("Omni", balance)
        {
        }
        
        public Omni(string accountName, decimal balance ) : base ("Omni",  balance)
        {
        }

        // Deposit method is Done in Base class.

        public override void Withdraw(decimal amount)
        {
            if (Balance - amount >= -Overdraft)
            {
                Balance -= amount;
                AddTransaction("Withdraw", amount, true);
            }
            else
            {
                Balance -= FailingFee;
                AddTransaction("Withdraw", amount, false);
                Transactions.Add($"- Fee: {FailingFee}");
            }
        }

        public void AddInterest()
        {
            if (Balance > 1000)
            {
                decimal interest = Balance * InterestRate;
                Balance += interest;
                AddTransaction("Interest Added", interest, true);
                Transactions.Add($"- Interest: {interest}");
            }
            // Failed interest as error OR balance is below 1000... Check if needed custom add transaction.
        }
    }
}
