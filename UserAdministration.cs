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
        private bool _isFormLoading = false;
        private UserAdmin _userAdmin;
        private string? _selectedUserID;
        private int selectedRowIndex = -1;
        public UserAdministration()
        {
            InitializeComponent();
            _userAdmin = new UserAdmin();
            ReturnToGridView();

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // No row selected - Ignore header clicks

            string selectedUserID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            if (!string.IsNullOrEmpty(selectedUserID))
            {
                var userData = _userAdmin.GetSelectedUserData(selectedUserID);
                if (userData != null)
                {

                    DisplayUserDetails(userData);
                }
                else
                {
                    MessageBox.Show("Please select a valid User", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a user to view", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Suggestion from web to use Dynamic or try DTO Class fior user details
        private void DisplayUserDetails(UserDetailsDTO userData)
        {

            if (userData == null) return;


            UserIdData.Text = userData.SelectedID;
            NameData.Text = userData.SelectedUserName;
            rbtnYes.Checked = userData.SelectedBoolEmployee;
            rbtnNo.Checked = !userData.SelectedBoolEmployee;
            UpdateRadioBUttonColors(rbtnYes.Checked);


            ContactData.Text = userData.SelectedContact;

            EverydayData.Text = userData.SelectedEveryday;
            OmniData.Text = userData.SelectedOmni;
            InvestData.Text = userData.SelectedInvest;


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

        }

        private void ReturnToGridView()
        {
            ViewPanel.Visible = false;
            EditablePanel.Visible = false;
            dataGridView1.Visible = true;
            ViewBtn.Visible = true;
            _userAdmin.LoadUsersIntoGrid(dataGridView1);


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

        private void ClearForm()
        {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxContact.Text = string.Empty;
            textBoxEveryday.Text = string.Empty;
            textBoxOmni.Text = string.Empty;
            textBoxInvest.Text = string.Empty;
        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedRow = dataGridView1.CurrentRow;
                var selectedUserID = selectedRow.Cells[0].Value.ToString();

                var userData = _userAdmin.GetSelectedUserData(selectedUserID);
                if (userData != null)
                {
                    DisplayUserDetails(userData);
                    SwitchToViewPanel();
                }
                else
                {
                    MessageBox.Show("No User data found for the selected user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            var userDetailsDTO = new UserDetailsDTO
            {
                SelectedID = textBoxID.Text,
                SelectedUserName = textBoxName.Text,
                SelectedBoolEmployee = rbtnYes.Checked,
                SelectedContact = textBoxContact.Text,
                SelectedEveryday = textBoxEveryday.Text,
                SelectedOmni = textBoxOmni.Text,
                SelectedInvest = textBoxInvest.Text,

            };
            bool isCreated = _userAdmin.AddUserToAdmin(userDetailsDTO);

            if (isCreated)
            {
                MessageBox.Show("New User Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReturnToGridView();
            }
            else
            {
                MessageBox.Show("Failed to create user. Please Check Input Values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateRadioBUttonColors(bool isEmployee)
        {
            rbtnNo.Enabled = false;
            rbtnYes.Enabled = false;

            if (rbtnYes.Checked)
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
            label2.Text = "User Deletion:";
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            SwitchToEditPanel();
            label2.Text = "New User Details:";
            ClearForm();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            SwitchToEditPanel();
            label2.Text = "Edit User Details:";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ReturnToGridView();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to Logout?", "Logging out of the  Admin Panel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit(); // Exit first then will create another Form for Login
            }

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            ReturnToGridView();
        }
    }
}
