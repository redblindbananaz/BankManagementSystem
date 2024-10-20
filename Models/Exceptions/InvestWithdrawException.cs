using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models.Exceptions
{
    public class InvestWithdrawException : WithdrawException
    {
        public InvestWithdrawException(string message) : base(message)
        {
        }
        public InvestWithdrawException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
