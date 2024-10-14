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
            dataGridView1.Rows.Clear(); // Otherwise i have duplicates!!!
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
            ChangeOpacityOfViewButton();
        }

        private void ReturnToGridView()
        {
            ViewPanel.Visible = false;
            dataGridView1.Visible = true;
            LoadUsersIntoGrid();
            ResetOpacityOfViewButton();
        }
        private void ChangeOpacityOfViewButton()
        {
            ViewBtn.Enabled = false;
            ViewBtn.BackColor = Color.FromArgb(128,169,196,235);
            ViewBtn.ForeColor = Color.FromArgb(128, 0, 51, 102);
            ViewBtn.BorderColor = Color.FromArgb(128, 255, 242, 204);
        }

        private void ResetOpacityOfViewButton()
        {
            ViewBtn.Enabled = true;
            ViewBtn.BackColor = Color.FromArgb(169, 196, 235);
            ViewBtn.ForeColor = Color.FromArgb(0, 51, 102);
            ViewBtn.BorderColor = Color.FromArgb(255, 242, 204);
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
                    UpdateRadioBUttonColors(selectedUser.IsEmployee);


                    ContactData.Text = string.IsNullOrEmpty(selectedUser.ContactDetails) ? "N/A" : selectedUser.ContactDetails;

                    EverydayData.Text = GetAccountBalance(selectedUser, typeof(Everyday));
                    OmniData.Text = GetAccountBalance(selectedUser, typeof(Omni));
                    InvestData.Text = GetAccountBalance(selectedUser, typeof(Invest));

                }

            }
        }

        private void UpdateRadioBUttonColors(bool isEmployee)
        {
            rbtnNo.Enabled = false;
            rbtnYes.Enabled = false;

            if (isEmployee)
            {  
                rbtnYes.Enabled = true;
            }
            else
            {
               rbtnNo.Enabled = true;
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnToGridView();
        }

    }
}
