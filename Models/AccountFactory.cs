using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public class AccountFactory
    {
        public static Account CreateAccount(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Everyday:
                    return new Everyday();
                case AccountType.Omni:
                    return new Omni();
                case AccountType.Invest:
                    return new Invest();
                default:
                    throw new ArgumentException("Invalid account type", "accountType");
            }
        }
    }
    public enum AccountType
    {
        Everyday,
        Omni,
        Invest
    }
}
