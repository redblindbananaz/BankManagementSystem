using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Diagnostics;
using Microsoft.VisualBasic.ApplicationServices;
using User = BankSystem.Models.User;
using System.Windows.Forms;

namespace BankSystem.Controllers
{

    public class UserAdmin
    {
        private List<User> _users = null!;

        public List<User> Users { get; private set; } = new();
        

        public UserAdmin()
        {
            _users = new List<User>();
            InitializeUsers();
            //LoadUsersFromJsonFile();

        }

        private void InitializeUsers()
        {
            User user1 = User.CreateUser("JD12345", "John Dee", true, "027 778 999");

            user1.CreateAccount(new Everyday(510));
            user1.CreateAccount(new Omni(340));
            user1.CreateAccount(new Invest(320));

            _users.Add(user1);

            User user2 = User.CreateUser("AB12345", "Andrea Bolneli", false, "");

            user2.CreateAccount(new Everyday(30));
            user2.CreateAccount(new Omni(1000));


            _users.Add(user2);

            User user3 = User.CreateUser("SA23479", "Steph Anie", false, "");

            user3.CreateAccount(new Everyday(200));
            user3.CreateAccount(new Invest(900));

            _users.Add(user3);

            //SaveUsersToJsonFile();
        }

        public User? GetUserByID(string userID)
        {
            return _users.FirstOrDefault(user => user.UserID == userID);
        }

        public object? GetSelectedUserData(string userID)
        {
            var selectedUser = GetUserByID(userID);
            if (selectedUser != null)
            {
                return new
                {
                    SelectedID = selectedUser.UserID,
                    SelectedUserName = selectedUser.UserName,
                    SelectedBoolEmployee = selectedUser.IsEmployee ? "Yes" : "No",
                    SelectedContact = string.IsNullOrEmpty(selectedUser.ContactDetails) ? "N/A" : selectedUser.ContactDetails,
                    SelectedEveryday = GetAccountBalance(selectedUser, typeof(Everyday)),
                    SelectedOmni = GetAccountBalance(selectedUser, typeof(Omni)),
                    SelectedInvest = GetAccountBalance(selectedUser, typeof(Invest))

                };
            }
            MessageBox.Show("User not found");
            return null;
        }

        private string GetAccountBalance(User user, Type accountType)
        {
            var account = user.Accounts.FirstOrDefault(account => account.GetType() == accountType);
            return account != null ? $"${account.Balance}" : "N/A";
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }

        public void LoadUsersIntoGrid(DataGridView grid)
        {
            grid.Rows.Clear(); // Otherwise i have duplicates!!!
            GetAllUsers();


            foreach (User user in GetAllUsers())
            {
                string everydayBalance = GetAccountBalance(user, typeof(Everyday));
                string omniBalance = GetAccountBalance(user, typeof(Omni));
                string investBalance = GetAccountBalance(user, typeof(Invest));

                string isEmployee = user.IsEmployee ? "Yes" : "No";

                string ContactDetails = string.IsNullOrEmpty(user.ContactDetails) ? "N/A" : user.ContactDetails;

                grid.Rows.Add(user.UserID, user.UserName, isEmployee, ContactDetails, everydayBalance, omniBalance, investBalance);
            }

        }
        public void AddUser(User user)
        {
            _users.Add(user);
            //SaveUsersToJsonFile();
        }





        // Serialise the users list to a JSON file -- NOT WORKING AT THE MOMENT
        public void SaveUsersToJsonFile()
        {
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string _filePath = Path.Combine(solutionDirectory, "Serialization", "users.json");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new AccountConverter() }


            };
            string jsonString = JsonSerializer.Serialize(_users, options);
            Console.WriteLine($"Serialised Users: {jsonString}");
            File.WriteAllText(_filePath, jsonString);
        }

        // Deserialise the users list from a JSON file
        public void LoadUsersFromJsonFile()
        {
           
            string solutionDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string _filePath = Path.Combine(solutionDirectory, "Serialization", "users.json");

            if (!File.Exists(_filePath))
            {
                Console.WriteLine("JSON File not Found, Initializing with an empty user list");
                return;
            }
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Converters = { new AccountConverter() }
            };

            try 
            {
                string jsonString = File.ReadAllText(_filePath);
                _users = JsonSerializer.Deserialize<List<User>>(jsonString, options)?? new List<User>();
                Console.WriteLine($"Deserialised Users: {_users}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error during desterialisation: {e.Message}");
            }
           

            
           
        }
        
       
        private string GetFilePath(string fileName)
        {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BankSystem");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            return Path.Combine(folderPath, fileName);
        }
    }
}
