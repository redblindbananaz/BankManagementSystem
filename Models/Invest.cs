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
    internal class Invest: Account
    {
        //( string accountName, decimal balance, decimal interestRate, decimal overdraftLimit, decimal transactionFee)
        public Invest(decimal balance, decimal interestRate, decimal transactionFee) : base ( "Invest", balance, interestRate, 0, transactionFee)
        { 
        }
    }
}
