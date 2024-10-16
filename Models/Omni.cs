using BankSystem.Models.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
    [Serializable]
    internal class Omni : Account
    {

        public const decimal InterestRate = 0.04m; // 4% Interest Rate
        private const decimal Overdraft = 100m; // Overdraft of $100
        private const decimal FailingFee = 5m; // Fee for Failed Transactions

        public Omni (decimal balance) : base("Omni", balance)
        {
        }
        [JsonConstructor]
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

        public override bool Withdraw(decimal amount)
        {
            bool success;
            if (amount <= 0)
            {
                throw new OmniWithdrawException("Omni - Withdraw amount must be greater than 0");
            }
            bool isSuccessful = Balance - amount >= -Overdraft;
            if (isSuccessful)
            {
                Balance -= amount;
                success = true;

            }
            else
            {
                Balance -= FailingFee;
                throw new OmniWithdrawException($"Omni - Overdraft Limit Exceeded - {FailingFee}$ Fee Applied");
 
            }
            string transactionDetails = FormatTransaction("Withdraw", amount, isSuccessful);
            Transactions.Add(transactionDetails);
            return success;
           
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

        public bool AddInterest(decimal interest)
        {
            bool success = true;
            
            if (interest > 0)
            {
                
                Balance += interest;
                AddTransaction("Interest Added", interest, true);
                Transactions.Add($"- {interest}");
                return success;
            }
            else
            {
                MessageBox.Show("Balance Must Be Over $1000 In Order To Earn Interest");
                return false;
            }
            // Failed interest as error OR balance is below 1000... Check if needed custom add transaction.
        }
    }
}
