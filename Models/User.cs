using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace BankSystem.Models
{
    public class User
    {
        private string _userID;
        private string _userName;
        private string _contactDetails;
        private bool _isEmployee;
        private List<Account> _accounts;

        public string UserID
        {
            get => _userID;
            set => _userID = value;
        }

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }

        public string ContactDetails
        {
            get => _contactDetails;
            set => _contactDetails = value;
        }

        public bool IsEmployee
        {
            get => _isEmployee;
            set => _isEmployee = value;
        }

        public List<Account> Accounts
        {   get => _accounts;
            private set => _accounts = value;

        }

        public static User? CurrentUser { get; private set; }

       
      
        protected User(string userID, string userName, bool isEmployee)
        {
            _userID = userID;
            _userName = userName;
            _isEmployee = isEmployee;
            _contactDetails = string.Empty;
            _accounts = new List<Account>();
        }
      
        protected User(string userID, string userName,bool isEmployee, string contactDetails)
        {
            _userID = userID;
            _userName = userName;
            _isEmployee = isEmployee;
            _contactDetails = contactDetails;
            _accounts = new List<Account>();
        }

        //Methods:

        public void CreateAccount(Account account)
        {
            _accounts.Add(account);
        }

        public void RemoveAccount(Account account)
        {
            _accounts.Remove(account);
        }

        public static User CreateUser(string userID, string userName, bool isEmployee, string contactdetails)
        {
            return new User(userID, userName, isEmployee, contactdetails);
        }

        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
        }

        

    }
}
