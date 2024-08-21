using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public decimal InterestRate { get; set; }
        public decimal FailingFee { get; set; }

        public Invest(int accountID, string accountName, decimal balance, decimal interestRate, decimal failingFee) : base(accountID, accountName, balance)
        { 
            AccountName = "Invest";
            Balance = balance;
            InterestRate = interestRate;
            FailingFee = failingFee;
        }


        public override void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public override void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
    }
}
