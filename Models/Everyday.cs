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
        public override void Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > Balance)
            {
                throw new ArgumentException("Withdraw amount must be greater than 0 and smaller than the current Balance");
            }
            Balance -= amount;
            AddTransaction("Withdraw", amount, true);
        }
    }
}
