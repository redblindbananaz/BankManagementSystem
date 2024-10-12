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
            UserIdData = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            FirstName = new DataGridViewTextBoxColumn();
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
            ViewPanel.Controls.Add(UserIdData);
            ViewPanel.Location = new Point(16, 66);
            ViewPanel.Name = "ViewPanel";
            ViewPanel.Size = new Size(879, 410);
            ViewPanel.TabIndex = 6;
            ViewPanel.Visible = false;
            // 
            // UserIdData
            // 
            UserIdData.AutoSize = true;
            UserIdData.Location = new Point(115, 103);
            UserIdData.Name = "UserIdData";
            UserIdData.Size = new Size(38, 15);
            UserIdData.TabIndex = 0;
            UserIdData.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 242, 204);
            label2.Location = new Point(65, 31);
            label2.Name = "label2";
            label2.Size = new Size(166, 18);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FirstName, LastName, Employee, Contact, Everyday, Omni, Invest });
            dataGridView1.Location = new Point(16, 66);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(879, 410);
            dataGridView1.TabIndex = 0;
            // 
            // FirstName
            // 
            FirstName.HeaderText = "User ID";
            FirstName.Name = "FirstName";
            FirstName.Width = 86;
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
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn Employee;
        private DataGridViewTextBoxColumn Contact;
        private DataGridViewTextBoxColumn Everyday;
        private DataGridViewTextBoxColumn Omni;
        private DataGridViewTextBoxColumn Invest;
        private Panel ViewPanel;
        private Label UserIdData;
    }
}