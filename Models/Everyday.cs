using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankSystem.Models
{
    /* Everyday account:
     * 
     * No Interest
     * No Overdraft
     * No Transaction Fees
     */

    public class Everyday : Account
    {

        public Everyday(decimal balance) : base("Everyday", balance)
        {

        }
       
        public Everyday(string accountName, decimal balance ): base ("Everyday", balance)
        {
 
        }


        // STATUS FOR TRANSACTION => APPROVED OR DECLINED
        public override void Deposit(decimal amount)
        {
            
            // NEED UI Implementation of Validation for performing a deposit with a try, catch and message box.
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be greater than 0");
            }
            Balance += amount;
            AddTransaction("Deposit", amount, "Approved");

            // Update Balance Event handler? HERE?
        }

        // Same UI Implementation as above
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
            {
                throw new ArgumentException("Withdraw amount must be greater than 0 and smaller than the current Balance");
            }
            Balance -= amount;
            AddTransaction("Withdraw", amount, "Approved");
        }
    }
}
