using BankSystem.Controllers;
using BankSystem.Models;
using BankSystem.Components;

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
            _userAdmin.LoadUsersIntoGrid(dataGridView1);
            
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            EditablePanel.Visible = false;
            ViewPanel.Visible = true;
            ViewPanel.BringToFront();

            //RemoveIdenticalLabels(EditablePanel);
            AddingIdenticalLabels(ViewPanel);
            
        }

        private void AddingIdenticalLabels(Panel panel)
        {
            panel.Controls.Add(labelInvest);
            panel.Controls.Add(labelOmni);
            panel.Controls.Add(labelEveryday);
            panel.Controls.Add(labelUSerContact);
            panel.Controls.Add(labelIsEmployee);
            panel.Controls.Add(labelFullName);
            panel.Controls.Add(labelUserID);
            panel.Controls.Add(rbtnNo);
            panel.Controls.Add(rbtnYes);
        }

        private void RemoveIdenticalLabels(Panel panel)
        {
            panel.Controls.Remove(labelInvest);
            panel.Controls.Remove(labelOmni);
            panel.Controls.Remove(labelEveryday);
            panel.Controls.Remove(labelUSerContact);
            panel.Controls.Remove(labelIsEmployee);
            panel.Controls.Remove(labelFullName);
            panel.Controls.Remove(labelUserID);
            panel.Controls.Remove(rbtnNo);
            panel.Controls.Remove(rbtnYes);
        }

        private void SwitchToEditPanel()
        {
            
            dataGridView1.Visible = false;
            ViewPanel.Visible = false;
            EditablePanel.Visible = true;
            RemoveIdenticalLabels(ViewPanel);
            AddingIdenticalLabels(EditablePanel);
            rbtnNo.Enabled = true;
            rbtnYes.Enabled = true;
            ChangeOpacityOfButton(EditBtn);
        }

        private void ReturnToGridView()
        {
            ViewPanel.Visible = false;
            dataGridView1.Visible = true;
            _userAdmin.LoadUsersIntoGrid(dataGridView1);
            ResetOpacityOfButton(ViewBtn);
            ResetOpacityOfButton(EditBtn);
            ResetOpacityOfButton(DeleteBtn);
            ResetOpacityOfButton(CreateBtn);
        }
        private void ChangeOpacityOfButton(CustomButton button)
        {
            button.Enabled = false;
            button.BackColor = Color.FromArgb(128, 169, 196, 235);
            button.ForeColor = Color.FromArgb(128, 0, 51, 102);
            button.BorderColor = Color.FromArgb(128, 255, 242, 204);
        }

        private void ResetOpacityOfButton(CustomButton button)
        {
            button.Enabled = true;
            button.BackColor = Color.FromArgb(169, 196, 235);
            button.ForeColor = Color.FromArgb(0, 51, 102);
            button.BorderColor = Color.FromArgb(255, 242, 204);
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {

            if (selectedRowIndex < 0 || selectedRowIndex > dataGridView1.Rows.Count)
            {
                MessageBox.Show("Please select a user to view", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
           

            var users = _userAdmin.GetAllUsers();
            var selectedRow = dataGridView1.SelectedRows[0];
            string selectedUserID = selectedRow.Cells[0].Value.ToString();
            var selectedUser = users.FirstOrDefault(user => user.UserID == selectedUserID);


            if (selectedUser == null)
            {
                MessageBox.Show("SelectedUser == null", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
        
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

              

            ChangeOpacityOfButton(ViewBtn);
            ResetOpacityOfButton(CreateBtn);
            ResetOpacityOfButton(EditBtn);
            ResetOpacityOfButton(DeleteBtn);
            SwitchToViewPanel();
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

       

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SwitchToViewPanel();
            ResetOpacityOfButton(ViewBtn);
            ResetOpacityOfButton(EditBtn);
            ChangeOpacityOfButton(DeleteBtn);
            ResetOpacityOfButton(CreateBtn);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            SwitchToEditPanel();
            label2.Text = "New User Details:";
            ResetOpacityOfButton(ViewBtn);
            ResetOpacityOfButton(EditBtn);
            ResetOpacityOfButton(DeleteBtn);
            ChangeOpacityOfButton(CreateBtn);
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            SwitchToEditPanel();
            label2.Text = "Edit User Details:";
            ResetOpacityOfButton(ViewBtn);
            ResetOpacityOfButton(DeleteBtn);
            ResetOpacityOfButton(CreateBtn);
            ChangeOpacityOfButton(EditBtn);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReturnToGridView();

        }
    }
}
