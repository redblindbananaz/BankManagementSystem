using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models.Exceptions
{
    public class OmniWithdrawException: WithdrawException
    {
        public OmniWithdrawException(string message) : base(message)
        {
        }
        public OmniWithdrawException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
   
}
