using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models.Exceptions
{
    public class EverydayWithdrawException : WithdrawException
    {
        public EverydayWithdrawException(string message) : base(message)
        {
        }
        public EverydayWithdrawException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
