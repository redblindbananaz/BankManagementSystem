using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankSystem
{
    public partial class UserAdministration : Form
    {

        private UserAdmin _userAdmin = new UserAdmin();
        public UserAdministration()
        {
            InitializeComponent();
            _userAdmin = new UserAdmin();
            LoadUsersIntoGrid();
        }

        private void LoadUsersIntoGrid()
        {
            var users = _userAdmin.GetUsers();
            foreach(User user in users)
            {
                dataGridView1.Rows.Add(user.UserID, user.UserName, user.IsEmployee, user.ContactDetails);
            }

        }
    }
}
