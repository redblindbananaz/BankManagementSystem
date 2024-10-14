using BankSystem.Components;

namespace BankSystem
{
    partial class UserAdministration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            label1 = new Label();
            LogoutBtn = new CustomButton();
            customPanel1 = new CustomPanel();
            ViewPanel = new Panel();
            returnBtn = new CustomButton();
            rbtnNo = new RadioButton();
            rbtnYes = new RadioButton();
            InvestData = new Label();
            OmniData = new Label();
            EverydayData = new Label();
            labelInvest = new Label();
            labelOmni = new Label();
            labelEveryday = new Label();
            labelUSerContact = new Label();
            labelIsEmployee = new Label();
            labelFullName = new Label();
            labelUserID = new Label();
            ContactData = new Label();
            NameData = new Label();
            UserIdData = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Everyday = new DataGridViewTextBoxColumn();
            Omni = new DataGridViewTextBoxColumn();
            Invest = new DataGridViewTextBoxColumn();
            BottomPanel = new Panel();
            ViewBtn = new CustomButton();
            CreateBtn = new CustomButton();
            DeleteBtn = new CustomButton();
            EditBtn = new CustomButton();
            TopPanel.SuspendLayout();
            customPanel1.SuspendLayout();
            ViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(label1);
            TopPanel.Controls.Add(LogoutBtn);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(934, 82);
            TopPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 242, 204);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(324, 59);
            label1.TabIndex = 5;
            label1.Text = "Admin Panel";
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(255, 242, 204);
            LogoutBtn.BorderColor = Color.FromArgb(215, 155, 0);
            LogoutBtn.BorderRadius = 24;
            LogoutBtn.BorderSize = 6;
            LogoutBtn.Cursor = Cursors.Hand;
            LogoutBtn.FlatStyle = FlatStyle.Flat;
            LogoutBtn.Font = new Font("Verdana", 16F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.FromArgb(215, 155, 0);
            LogoutBtn.Location = new Point(722, 12);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(200, 57);
            LogoutBtn.TabIndex = 4;
            LogoutBtn.Text = "Log out";
            LogoutBtn.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            customPanel1.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel1.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel1.BorderRadius = 24;
            customPanel1.BorderSize = 8;
            customPanel1.Controls.Add(ViewPanel);
            customPanel1.Controls.Add(label2);
            customPanel1.Controls.Add(dataGridView1);
            customPanel1.Location = new Point(12, 88);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(910, 498);
            customPanel1.TabIndex = 1;
            // 
            // ViewPanel
            // 
            ViewPanel.Controls.Add(returnBtn);
            ViewPanel.Controls.Add(rbtnNo);
            ViewPanel.Controls.Add(rbtnYes);
            ViewPanel.Controls.Add(InvestData);
            ViewPanel.Controls.Add(OmniData);
            ViewPanel.Controls.Add(EverydayData);
            ViewPanel.Controls.Add(labelInvest);
            ViewPanel.Controls.Add(labelOmni);
            ViewPanel.Controls.Add(labelEveryday);
            ViewPanel.Controls.Add(labelUSerContact);
            ViewPanel.Controls.Add(labelIsEmployee);
            ViewPanel.Controls.Add(labelFullName);
            ViewPanel.Controls.Add(labelUserID);
            ViewPanel.Controls.Add(ContactData);
            ViewPanel.Controls.Add(NameData);
            ViewPanel.Controls.Add(UserIdData);
            ViewPanel.Location = new Point(16, 66);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(879, 410);
            ViewPanel.TabIndex = 6;
            ViewPanel.Visible = false;
            // 
            // returnBtn
            // 
            returnBtn.BackColor = Color.FromArgb(0, 51, 102);
            returnBtn.BorderColor = Color.FromArgb(255, 242, 204);
            returnBtn.BorderRadius = 24;
            returnBtn.BorderSize = 3;
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            returnBtn.ForeColor = Color.FromArgb(255, 242, 204);
            returnBtn.Location = new Point(457, 322);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(372, 60);
            returnBtn.TabIndex = 17;
            returnBtn.Text = "<- Return Home";
            returnBtn.UseVisualStyleBackColor = false;
            returnBtn.Click += returnBtn_Click;
            // 
            // rbtnNo
            // 
            rbtnNo.AutoSize = true;
            rbtnNo.Enabled = false;
            rbtnNo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnNo.ForeColor = Color.White;
            rbtnNo.Location = new Point(177, 255);
            rbtnNo.Name = "rbtnNo";
            rbtnNo.Size = new Size(48, 22);
            rbtnNo.TabIndex = 16;
            rbtnNo.TabStop = true;
            rbtnNo.Text = "No";
            rbtnNo.UseVisualStyleBackColor = true;
          
            // 
            // rbtnYes
            // 
            rbtnYes.AutoSize = true;
            rbtnYes.Enabled = false;
            rbtnYes.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnYes.ForeColor = Color.White;
            rbtnYes.Location = new Point(49, 255);
            rbtnYes.Name = "rbtnYes";
            rbtnYes.Size = new Size(55, 22);
            rbtnYes.TabIndex = 15;
            rbtnYes.TabStop = true;
            rbtnYes.Text = "Yes";
            rbtnYes.UseVisualStyleBackColor = true;
            // 
            // InvestData
            // 
            InvestData.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvestData.ForeColor = Color.White;
            InvestData.Location = new Point(457, 252);
            InvestData.Name = "InvestData";
            InvestData.Size = new Size(372, 25);
            InvestData.TabIndex = 14;
            InvestData.Text = "Invest here";
            InvestData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // OmniData
            // 
            OmniData.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OmniData.ForeColor = Color.White;
            OmniData.Location = new Point(457, 150);
            OmniData.Name = "OmniData";
            OmniData.Size = new Size(372, 25);
            OmniData.TabIndex = 13;
            OmniData.Text = "Omni here";
            OmniData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // EverydayData
            // 
            EverydayData.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EverydayData.ForeColor = Color.White;
            EverydayData.Location = new Point(457, 48);
            EverydayData.Name = "EverydayData";
            EverydayData.Size = new Size(372, 25);
            EverydayData.TabIndex = 12;
            EverydayData.Text = "Everyday here";
            EverydayData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelInvest
            // 
            labelInvest.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelInvest.ForeColor = Color.FromArgb(215, 155, 0);
            labelInvest.Location = new Point(457, 221);
            labelInvest.Name = "labelInvest";
            labelInvest.Size = new Size(372, 25);
            labelInvest.TabIndex = 11;
            labelInvest.Text = "Invest Account:";
            // 
            // labelOmni
            // 
            labelOmni.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelOmni.ForeColor = Color.FromArgb(215, 155, 0);
            labelOmni.Location = new Point(457, 119);
            labelOmni.Name = "labelOmni";
            labelOmni.Size = new Size(372, 25);
            labelOmni.TabIndex = 10;
            labelOmni.Text = "Omni Account:";
            // 
            // labelEveryday
            // 
            labelEveryday.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelEveryday.ForeColor = Color.FromArgb(215, 155, 0);
            labelEveryday.Location = new Point(457, 17);
            labelEveryday.Name = "labelEveryday";
            labelEveryday.Size = new Size(372, 25);
            labelEveryday.TabIndex = 9;
            labelEveryday.Text = "Everyday Account:";
            // 
            // labelUSerContact
            // 
            labelUSerContact.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelUSerContact.ForeColor = Color.FromArgb(215, 155, 0);
            labelUSerContact.Location = new Point(49, 322);
            labelUSerContact.Name = "labelUSerContact";
            labelUSerContact.Size = new Size(372, 25);
            labelUSerContact.TabIndex = 8;
            labelUSerContact.Text = "User  Contact Details:";
            // 
            // labelIsEmployee
            // 
            labelIsEmployee.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelIsEmployee.ForeColor = Color.FromArgb(215, 155, 0);
            labelIsEmployee.Location = new Point(49, 221);
            labelIsEmployee.Name = "labelIsEmployee";
            labelIsEmployee.Size = new Size(372, 25);
            labelIsEmployee.TabIndex = 7;
            labelIsEmployee.Text = "User Is An Employee:";
            // 
            // labelFullName
            // 
            labelFullName.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelFullName.ForeColor = Color.FromArgb(215, 155, 0);
            labelFullName.Location = new Point(49, 119);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(372, 25);
            labelFullName.TabIndex = 6;
            labelFullName.Text = "User Full Name:";
            // 
            // labelUserID
            // 
            labelUserID.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelUserID.ForeColor = Color.FromArgb(215, 155, 0);
            labelUserID.Location = new Point(49, 17);
            labelUserID.Name = "labelUserID";
            labelUserID.Size = new Size(372, 25);
            labelUserID.TabIndex = 5;
            labelUserID.Text = "User ID:";
            // 
            // ContactData
            // 
            ContactData.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ContactData.ForeColor = Color.White;
            ContactData.Location = new Point(49, 353);
            ContactData.Name = "ContactData";
            ContactData.Size = new Size(372, 25);
            ContactData.TabIndex = 2;
            ContactData.Text = "Contact Number here";
            ContactData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // NameData
            // 
            NameData.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NameData.ForeColor = Color.White;
            NameData.Location = new Point(49, 150);
            NameData.Name = "NameData";
            NameData.Size = new Size(372, 25);
            NameData.TabIndex = 1;
            NameData.Text = "Full Name here";
            NameData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserIdData
            // 
            UserIdData.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserIdData.ForeColor = Color.White;
            UserIdData.Location = new Point(49, 48);
            UserIdData.Name = "UserIdData";
            UserIdData.Size = new Size(372, 25);
            UserIdData.TabIndex = 0;
            UserIdData.Text = "User ID here";
            UserIdData.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 15F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 242, 204);
            label2.Location = new Point(65, 31);
            label2.Name = "label2";
            label2.Size = new Size(203, 25);
            label2.TabIndex = 1;
            label2.Text = "List of Customers :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 51, 102);
            dataGridViewCellStyle1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserId, LastName, Employee, Contact, Everyday, Omni, Invest });
            dataGridView1.Location = new Point(16, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(879, 410);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // UserId
            // 
            UserId.HeaderText = "User ID";
            UserId.Name = "UserId";
            UserId.Width = 86;
            // 
            // LastName
            // 
            LastName.HeaderText = "Full Name";
            LastName.Name = "LastName";
            LastName.Width = 220;
            // 
            // Employee
            // 
            Employee.FillWeight = 200F;
            Employee.HeaderText = "IsEmployee";
            Employee.Name = "Employee";
            Employee.Width = 120;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.Width = 110;
            // 
            // Everyday
            // 
            Everyday.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Everyday.HeaderText = "Everyday";
            Everyday.Name = "Everyday";
            // 
            // Omni
            // 
            Omni.HeaderText = "Omni";
            Omni.Name = "Omni";
            // 
            // Invest
            // 
            Invest.HeaderText = "Invest";
            Invest.Name = "Invest";
            // 
            // BottomPanel
            // 
            BottomPanel.Anchor = AnchorStyles.Bottom;
            BottomPanel.Controls.Add(ViewBtn);
            BottomPanel.Controls.Add(CreateBtn);
            BottomPanel.Controls.Add(DeleteBtn);
            BottomPanel.Controls.Add(EditBtn);
            BottomPanel.Location = new Point(0, 583);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(934, 75);
            BottomPanel.TabIndex = 2;
            // 
            // ViewBtn
            // 
            ViewBtn.BackColor = Color.FromArgb(169, 196, 235);
            ViewBtn.BorderColor = Color.FromArgb(255, 242, 204);
            ViewBtn.BorderRadius = 24;
            ViewBtn.BorderSize = 8;
            ViewBtn.FlatAppearance.BorderSize = 0;
            ViewBtn.FlatStyle = FlatStyle.Flat;
            ViewBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            ViewBtn.ForeColor = Color.FromArgb(0, 51, 102);
            ViewBtn.Location = new Point(12, 9);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(200, 60);
            ViewBtn.TabIndex = 3;
            ViewBtn.Text = "View";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.BackColor = Color.FromArgb(0, 51, 102);
            CreateBtn.BorderColor = Color.FromArgb(215, 155, 0);
            CreateBtn.BorderRadius = 24;
            CreateBtn.BorderSize = 8;
            CreateBtn.FlatAppearance.BorderSize = 0;
            CreateBtn.FlatStyle = FlatStyle.Flat;
            CreateBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            CreateBtn.ForeColor = Color.FromArgb(215, 155, 0);
            CreateBtn.Location = new Point(722, 9);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(200, 60);
            CreateBtn.TabIndex = 2;
            CreateBtn.Text = "NEW";
            CreateBtn.UseVisualStyleBackColor = false;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BackColor = Color.FromArgb(169, 196, 235);
            DeleteBtn.BorderColor = Color.FromArgb(255, 242, 204);
            DeleteBtn.BorderRadius = 24;
            DeleteBtn.BorderSize = 8;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            DeleteBtn.ForeColor = Color.FromArgb(0, 51, 102);
            DeleteBtn.Location = new Point(485, 9);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(200, 60);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = Color.FromArgb(169, 196, 235);
            EditBtn.BorderColor = Color.FromArgb(255, 242, 204);
            EditBtn.BorderRadius = 24;
            EditBtn.BorderSize = 8;
            EditBtn.FlatAppearance.BorderSize = 0;
            EditBtn.FlatStyle = FlatStyle.Flat;
            EditBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold);
            EditBtn.ForeColor = Color.FromArgb(0, 51, 102);
            EditBtn.Location = new Point(249, 9);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(200, 60);
            EditBtn.TabIndex = 0;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            // 
            // UserAdministration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 51, 102);
            ClientSize = new Size(934, 661);
            Controls.Add(BottomPanel);
            Controls.Add(customPanel1);
            Controls.Add(TopPanel);
            Name = "UserAdministration";
            Text = "UserAdministration";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ViewPanel.ResumeLayout(false);
            ViewPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            BottomPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel TopPanel;
        private CustomButton LogoutBtn;
        private Label label1;
        private CustomPanel customPanel1;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel BottomPanel;
        private CustomButton EditBtn;
        private CustomButton CreateBtn;
        private CustomButton DeleteBtn;
        private CustomButton ViewBtn;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Everyday;
        private DataGridViewTextBoxColumn Omni;
        private DataGridViewTextBoxColumn Invest;
        private Panel ViewPanel;
        private Label UserIdData;
        private Label NameData;
        private Label ContactData;
        private Label labelUserID;
        private Label labelUSerContact;
        private Label labelIsEmployee;
        private Label labelFullName;
        private Label labelInvest;
        private Label labelOmni;
        private Label labelEveryday;
        private Label InvestData;
        private Label OmniData;
        private Label EverydayData;
        private RadioButton rbtnNo;
        private RadioButton rbtnYes;
        private CustomButton returnBtn;
    }
}