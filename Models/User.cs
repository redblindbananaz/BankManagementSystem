using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Models
{
    public abstract class User
    {
        private string userID;
        private string userName;
        private string contactDetails;
        private List<Account> accounts;

        public string UserID
        {
            get => userID; 
            set => userID = value; 
        }

        public string UserName
        {
            get => userName; 
            set => userName = value; 
        }

        public string ContactDetails
        {
            get => contactDetails; 
            set => contactDetails = value; 
        }

        public List<Account> Accounts
            { get => accounts;  }

        protected User(string userID, string userName, string contactDetails )
        {
            UserID = userID;
            UserName = userName;
            ContactDetails = contactDetails;
            accounts = new List<Account>();
        }
    }
    
    public class Employee : User
    {
        private int employeeID;
        private static double discountRate;

        public int EmployeeID
        {
            get => employeeID;
            set => employeeID = value;
        }

        public static double DiscountRate
        {
            get => discountRate;
            set => discountRate = 0.5;
        }
        public Employee(string userID, string userName, string contactDetails, int employeeID) : base(userID, userName, contactDetails)
        {

            UserID = userID;
            UserName = userName;
            ContactDetails = contactDetails;
      
            EmployeeID = employeeID;
        }

        public void CalculateDiscountedFee()
        {
            DiscountRate = 0.5; // Should add the fees that occurs fron the accounts and make calculation
        }
    }
}
