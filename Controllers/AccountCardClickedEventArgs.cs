using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Controllers
{
    public class AccountCardClickedEventArgs :EventArgs
    {
        public string? AccountName { get; set; }
        public decimal Balance { get; set; }
        public int AccountId { get; set; }

        public AccountCardClickedEventArgs(string accountName, decimal balance, int accountId)
        {
            AccountName = accountName;
            Balance = balance;
            AccountId = accountId;
        }
    }
}
