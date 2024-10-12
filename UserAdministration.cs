using BankSystem.Controllers;
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

        private UserAdmin _userAdmin;
        private string? _selectedUserID;
        public UserAdministration()
        {
            InitializeComponent();
            _userAdmin = new UserAdmin();
            LoadUsersIntoGrid();
        }

        private void LoadUsersIntoGrid()
        {
            var users = _userAdmin.GetUsers();

            foreach (User user in users)
            {
                string everydayBalance = GetAccountBalance(user, typeof(Everyday));
                string omniBalance = GetAccountBalance(user, typeof(Omni));
                string investBalance = GetAccountBalance(user, typeof(Invest));

                string isEmployee = user.IsEmployee ? "Yes" : "No";

                string ContactDetails = string.IsNullOrEmpty(user.ContactDetails) ? "N/A" : user.ContactDetails;

                dataGridView1.Rows.Add(user.UserID, user.UserName, isEmployee, ContactDetails, everydayBalance, omniBalance, investBalance);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                _selectedUserID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            }
 
        }

        private string GetAccountBalance(User user, Type accountType)
        {
            var account = user.Accounts.FirstOrDefault(account => account.GetType() == accountType);
            return account != null ? $"${account.Balance}" : "N/A";
        }

        private void SwitchToViewPanel()
        {
            label2.Text = "User Details:";
            dataGridView1.Visible = false;
            ViewPanel.Visible = true;
        }

        

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            SwitchToViewPanel();
            if (_selectedUserID !=null)
            {
                var user = _userAdmin.GetUserByID(_selectedUserID);
                if (user != null)
                {
                    
                    UserIdData.Text = user.UserID;
                   

                }
            }
            else
            {
                UserIdData.Text = "N/A";
            }
        }
    }
}
