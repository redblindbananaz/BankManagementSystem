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

namespace BankSystem.Controllers
{
    [Serializable]
    public class UserAdmin
    {
        private List<User> _users = null!;

        public UserAdmin()
        {
            _users = new List<User>();
            InitializeUsers();
            //LoadUsersFromJsonFile("users.json");

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

            SaveUsersToJsonFile();
        }

        public User? GetUserByID(string userID)
        {
            return _users.FirstOrDefault(user => user.UserID == userID);
        }

        public List<User> GetUsers()
        {
            return _users;
        }

        // Serialise the users list to a JSON file
        public void SaveUsersToJsonFile()
        {
            string directory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string resourcesPath = Path.Combine(directory, "Resources");
            Directory.CreateDirectory(resourcesPath);

            string filePath = Path.Combine(resourcesPath, "users.json");

            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                //Converters = { new AccountConverter() }
            };

            try 
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (StreamWriter writer = new StreamWriter(fs))
                {
                    string jsonString = JsonSerializer.Serialize(_users, options);
                    writer.Write(jsonString);
                    Console.WriteLine(jsonString);


                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //File.WriteAllText(filePath, jsonString);
          

        }

        // Deserialise the users list from a JSON file
        public void LoadUsersFromJsonFile(string fileName)
        {
            string filePath = GetFilePath(fileName);
            if (!File.Exists(filePath)) return;
            var options = new JsonSerializerOptions
            {
                //Converters = { new AccountConverter() }
            };
            _users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(filePath), options) ?? new List<User>();
        }
        
        public void AddUser(User user)
        {
            _users.Add(user);
            SaveUsersToJsonFile();
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
