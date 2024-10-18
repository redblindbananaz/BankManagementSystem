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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            TopPanel = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LogoutBtn = new CustomButton();
            customPanel1 = new CustomPanel();
            GridPAnel = new Panel();
            ViewBtn = new CustomButton();
            dataGridView1 = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            Employee = new DataGridViewTextBoxColumn();
            Contact = new DataGridViewTextBoxColumn();
            Everyday = new DataGridViewTextBoxColumn();
            Omni = new DataGridViewTextBoxColumn();
            Invest = new DataGridViewTextBoxColumn();
            ViewPanel = new Panel();
            InvestData = new Label();
            OmniData = new Label();
            EditBtn = new CustomButton();
            DeleteBtn = new CustomButton();
            EverydayData = new Label();
            ContactData = new Label();
            NameData = new Label();
            UserIdData = new Label();
            EditablePanel = new Panel();
            saveBtn = new CustomButton();
            cancelBtn = new CustomButton();
            AddBtn = new CustomButton();
            textBoxInvest = new TextBox();
            textBoxOmni = new TextBox();
            textBoxEveryday = new TextBox();
            textBoxContact = new TextBox();
            textBoxName = new TextBox();
            textBoxID = new TextBox();
            label2 = new Label();
            rbtnNo = new RadioButton();
            rbtnYes = new RadioButton();
            labelInvest = new Label();
            labelOmni = new Label();
            labelEveryday = new Label();
            labelUSerContact = new Label();
            labelIsEmployee = new Label();
            labelFullName = new Label();
            labelUserID = new Label();
            BottomPanel = new Panel();
            CreateBtn = new CustomButton();
            label3 = new Label();
            TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel1.SuspendLayout();
            GridPAnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ViewPanel.SuspendLayout();
            EditablePanel.SuspendLayout();
            BottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TopPanel
            // 
            TopPanel.Anchor = AnchorStyles.Top;
            TopPanel.Controls.Add(pictureBox1);
            TopPanel.Controls.Add(label1);
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(934, 82);
            TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.icons8_home_50;
            pictureBox1.Location = new Point(29, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 36F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 242, 204);
            label1.Location = new Point(288, 12);
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
            LogoutBtn.Location = new Point(28, 12);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(200, 57);
            LogoutBtn.TabIndex = 4;
            LogoutBtn.Text = "Log out";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top;
            customPanel1.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel1.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel1.BorderRadius = 24;
            customPanel1.BorderSize = 8;
            customPanel1.Controls.Add(label3);
            customPanel1.Controls.Add(GridPAnel);
            customPanel1.Controls.Add(ViewPanel);
            customPanel1.Controls.Add(EditablePanel);
            customPanel1.Controls.Add(label2);
            customPanel1.Location = new Point(0, 82);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(934, 496);
            customPanel1.TabIndex = 1;
            // 
            // GridPAnel
            // 
            GridPAnel.Controls.Add(ViewBtn);
            GridPAnel.Controls.Add(dataGridView1);
            GridPAnel.Location = new Point(28, 64);
            GridPAnel.Name = "GridPAnel";
            GridPAnel.Size = new Size(880, 411);
            GridPAnel.TabIndex = 15;
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
            ViewBtn.Location = new Point(675, 331);
            ViewBtn.Name = "ViewBtn";
            ViewBtn.Size = new Size(200, 60);
            ViewBtn.TabIndex = 3;
            ViewBtn.Text = "View";
            ViewBtn.UseVisualStyleBackColor = false;
            ViewBtn.Click += ViewBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 51, 102);
            dataGridViewCellStyle2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserId, LastName, Employee, Contact, Everyday, Omni, Invest });
            dataGridView1.Location = new Point(1, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(879, 327);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // UserId
            // 
            UserId.HeaderText = "User ID";
            UserId.Name = "UserId";
            UserId.ReadOnly = true;
            UserId.Width = 86;
            // 
            // LastName
            // 
            LastName.HeaderText = "Full Name";
            LastName.Name = "LastName";
            LastName.ReadOnly = true;
            LastName.Width = 220;
            // 
            // Employee
            // 
            Employee.FillWeight = 200F;
            Employee.HeaderText = "IsEmployee";
            Employee.Name = "Employee";
            Employee.ReadOnly = true;
            Employee.Width = 120;
            // 
            // Contact
            // 
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            Contact.ReadOnly = true;
            Contact.Width = 110;
            // 
            // Everyday
            // 
            Everyday.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Everyday.HeaderText = "Everyday";
            Everyday.Name = "Everyday";
            Everyday.ReadOnly = true;
            // 
            // Omni
            // 
            Omni.HeaderText = "Omni";
            Omni.Name = "Omni";
            Omni.ReadOnly = true;
            // 
            // Invest
            // 
            Invest.HeaderText = "Invest";
            Invest.Name = "Invest";
            Invest.ReadOnly = true;
            // 
            // ViewPanel
            // 
            ViewPanel.Controls.Add(InvestData);
            ViewPanel.Controls.Add(OmniData);
            ViewPanel.Controls.Add(EditBtn);
            ViewPanel.Controls.Add(DeleteBtn);
            ViewPanel.Controls.Add(EverydayData);
            ViewPanel.Controls.Add(ContactData);
            ViewPanel.Controls.Add(NameData);
            ViewPanel.Controls.Add(UserIdData);
            ViewPanel.Location = new Point(29, 67);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(879, 410);
            ViewPanel.TabIndex = 6;
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
            EditBtn.Location = new Point(457, 332);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(200, 60);
            EditBtn.TabIndex = 0;
            EditBtn.Text = "Edit";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
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
            DeleteBtn.Location = new Point(675, 331);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(200, 60);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.Click += DeleteBtn_Click;
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
            // EditablePanel
            // 
            EditablePanel.Controls.Add(saveBtn);
            EditablePanel.Controls.Add(cancelBtn);
            EditablePanel.Controls.Add(AddBtn);
            EditablePanel.Controls.Add(textBoxInvest);
            EditablePanel.Controls.Add(textBoxOmni);
            EditablePanel.Controls.Add(textBoxEveryday);
            EditablePanel.Controls.Add(textBoxContact);
            EditablePanel.Controls.Add(textBoxName);
            EditablePanel.Controls.Add(textBoxID);
            EditablePanel.Location = new Point(28, 64);
            EditablePanel.Name = "EditablePanel";
            EditablePanel.Size = new Size(879, 410);
            EditablePanel.TabIndex = 17;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = Color.FromArgb(255, 242, 204);
            saveBtn.BorderColor = Color.FromArgb(66, 107, 62);
            saveBtn.BorderRadius = 24;
            saveBtn.BorderSize = 8;
            saveBtn.FlatAppearance.BorderColor = Color.FromArgb(215, 155, 0);
            saveBtn.FlatAppearance.BorderSize = 8;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.FromArgb(66, 107, 62);
            saveBtn.Location = new Point(675, 331);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(200, 60);
            saveBtn.TabIndex = 20;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += HandleUserSaveOrUpdate;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(0, 51, 102);
            cancelBtn.BorderColor = Color.FromArgb(0, 51, 102);
            cancelBtn.BorderRadius = 24;
            cancelBtn.BorderSize = 8;
            cancelBtn.FlatAppearance.BorderSize = 0;
            cancelBtn.FlatStyle = FlatStyle.Flat;
            cancelBtn.Font = new Font("Verdana", 15F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.FromArgb(215, 155, 0);
            cancelBtn.Location = new Point(457, 331);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(200, 60);
            cancelBtn.TabIndex = 19;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = Color.FromArgb(255, 242, 204);
            AddBtn.BorderColor = Color.FromArgb(215, 155, 0);
            AddBtn.BorderRadius = 24;
            AddBtn.BorderSize = 8;
            AddBtn.FlatAppearance.BorderColor = Color.FromArgb(215, 155, 0);
            AddBtn.FlatAppearance.BorderSize = 8;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Verdana", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = Color.FromArgb(215, 155, 0);
            AddBtn.Location = new Point(676, 339);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(200, 60);
            AddBtn.TabIndex = 18;
            AddBtn.Text = "Create New";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += HandleUserSaveOrUpdate;
            // 
            // textBoxInvest
            // 
            textBoxInvest.Location = new Point(457, 259);
            textBoxInvest.Name = "textBoxInvest";
            textBoxInvest.PlaceholderText = "Enter Amount";
            textBoxInvest.Size = new Size(332, 23);
            textBoxInvest.TabIndex = 17;
            // 
            // textBoxOmni
            // 
            textBoxOmni.Location = new Point(457, 155);
            textBoxOmni.Name = "textBoxOmni";
            textBoxOmni.PlaceholderText = "Enter Amount";
            textBoxOmni.Size = new Size(332, 23);
            textBoxOmni.TabIndex = 16;
            // 
            // textBoxEveryday
            // 
            textBoxEveryday.Location = new Point(457, 53);
            textBoxEveryday.Name = "textBoxEveryday";
            textBoxEveryday.PlaceholderText = "Enter Amount";
            textBoxEveryday.Size = new Size(332, 23);
            textBoxEveryday.TabIndex = 15;
            // 
            // textBoxContact
            // 
            textBoxContact.Location = new Point(49, 358);
            textBoxContact.Name = "textBoxContact";
            textBoxContact.PlaceholderText = "Enter Contact Details";
            textBoxContact.Size = new Size(332, 23);
            textBoxContact.TabIndex = 14;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(49, 155);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Enter Full Name";
            textBoxName.Size = new Size(332, 23);
            textBoxName.TabIndex = 13;
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(49, 53);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "Enter Unique ID";
            textBoxID.Size = new Size(332, 23);
            textBoxID.TabIndex = 12;
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
            // BottomPanel
            // 
            BottomPanel.Anchor = AnchorStyles.Bottom;
            BottomPanel.Controls.Add(CreateBtn);
            BottomPanel.Controls.Add(LogoutBtn);
            BottomPanel.Location = new Point(0, 583);
            BottomPanel.Name = "BottomPanel";
            BottomPanel.Size = new Size(934, 75);
            BottomPanel.TabIndex = 2;
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
            CreateBtn.Location = new Point(704, 9);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(200, 60);
            CreateBtn.TabIndex = 2;
            CreateBtn.Text = "NEW";
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label3
            // 
            label3.Location = new Point(288, 30);
            label3.Name = "label3";
            label3.Size = new Size(616, 23);
            label3.TabIndex = 18;
            label3.Text = "label3";
            label3.TextAlign = ContentAlignment.MiddleLeft;
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            GridPAnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ViewPanel.ResumeLayout(false);
            EditablePanel.ResumeLayout(false);
            EditablePanel.PerformLayout();
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
        private PictureBox pictureBox1;
        private Panel EditablePanel;
        private TextBox textBoxInvest;
        private TextBox textBoxOmni;
        private TextBox textBoxEveryday;
        private TextBox textBoxContact;
        private TextBox textBoxName;
        private TextBox textBoxID;
        private Panel GridPAnel;
        private CustomButton AddBtn;
        private CustomButton cancelBtn;
        private CustomButton saveBtn;
        private Label label3;
    }
}