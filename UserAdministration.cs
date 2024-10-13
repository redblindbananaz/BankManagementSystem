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
        private int selectedRowIndex = -1;
        public UserAdministration()
        {
            InitializeComponent();
            _userAdmin = new UserAdmin();
            LoadUsersIntoGrid();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
                selectedRowIndex = dataGridView1.SelectedRows[0].Index;
             
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

            if (selectedRowIndex >= 0 && selectedRowIndex < dataGridView1.Rows.Count)
            {
                var users = _userAdmin.GetUsers();
                var selectedRow = dataGridView1.SelectedRows[0];
                string selectedUserID = selectedRow.Cells[0].Value.ToString();
                var selectedUser = users.FirstOrDefault(user => user.UserID == selectedUserID);

                if (selectedUser != null)
                {
                    _selectedUserID = selectedUserID;
                    UserIdData.Text = selectedUser.UserID;
                    NameData.Text = selectedUser.UserName;
                    rbtnYes.Checked = selectedUser.IsEmployee;
                    rbtnNo.Checked = !selectedUser.IsEmployee;
                    ContactData.Text = string.IsNullOrEmpty(selectedUser.ContactDetails) ? "N/A": selectedUser.ContactDetails;

                    EverydayData.Text = GetAccountBalance(selectedUser, typeof(Everyday));
                    OmniData.Text = GetAccountBalance(selectedUser, typeof(Omni));
                    InvestData.Text = GetAccountBalance(selectedUser, typeof(Invest));

                }

            }
        }
    }
}
