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

    internal class Everyday : Account
    {
        //( string accountName, decimal balance, decimal interestRate, decimal overdraftLimit, decimal transactionFee)
        public Everyday(decimal balance): base("Everyday", balance, 0, 0, 0)
        {
            this.AccountName = "Everyday";
            
        }
    }
}
