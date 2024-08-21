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
       
        
        public Everyday(int accountID,  string accountName, decimal balance ): base (accountID, accountName, balance)
        {
            AccountID = 0;
            AccountName = "Everyday";
            Balance = balance;

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
