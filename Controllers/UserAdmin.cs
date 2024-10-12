using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.Controllers
{
    public class UserAdmin
    {
        private List<User> _users = null!;

        public List<User> Users
        {
            get => _users;
            private set => _users = value;
        }

        public UserAdmin()
        {
            _users = new List<User>();
            InitializeUsers();
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
        }

        public List<User> GetUsers()
        {
            return _users;
        }

    }
}
