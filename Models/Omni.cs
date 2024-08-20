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
        //( string accountName, decimal balance, decimal interestRate, decimal overdraftLimit, decimal transactionFee)
        public Omni(decimal balance, decimal overdraft ) : base ("Omni",  balance, 0, overdraft, 0)
        {
            this.AccountName = "Omni";
        }
    }
}
