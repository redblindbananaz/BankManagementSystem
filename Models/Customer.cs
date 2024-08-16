using BankSystem.Models;

namespace BankSystem.Models
{
    public class Customer : User
    {
        public Customer(string userID, string userName, string contactDetails) : base(userID, userName, contactDetails)
        {

            UserID = userID;
            UserName = userName;
            ContactDetails = contactDetails;
        }
    }

}


