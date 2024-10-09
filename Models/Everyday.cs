using BankSystem.Models.Exceptions;
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
        
        // Deposit method is Done in Base class.

        // Same UI Implementation as Account Base Class (Check Comments)
        public override bool Withdraw(decimal amount)
        {
            bool success = true;
           
            // New Exception Handling
          
            if (amount <= 0)
            {
                throw new EverydayWithdrawException("Everyday - Withdraw amount must be greater than 0");
            }
            if (amount > Balance)
            {
                throw new EverydayWithdrawException("Everyday - Withdraw amount must be smaller than the current Balance");
            }

            Balance -= amount;
            AddTransaction("Withdraw", amount, true);
            return success;
        }
    }
}
