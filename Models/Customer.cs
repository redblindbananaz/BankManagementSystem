using BankSystem.Models;

namespace BankSystem.Models
{
    
    public class Customer : User
    {
        public static Customer? CurrentUser;
        public Customer(string userID, string userName) : base(userID, userName)
        {

            UserID = userID;
            UserName = userName;
           

        }
        public static void SetCurrentUser(string userID, string userName)
        {
            // This method should set the current user of the system
            CurrentUser = new Customer(userID, userName);
            
        }
    }

}


