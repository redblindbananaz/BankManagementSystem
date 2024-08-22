using BankSystem.Components;
using System.Windows.Forms;

namespace BankSystem.Controllers
{
    partial class AccountsController
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            accountCardController1 = new AccountCardController();
            accountCardController2 = new AccountCardController();
            accountCardController3 = new AccountCardController();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(169, 196, 235);
            flowLayoutPanel1.Controls.Add(accountCardController1);
            flowLayoutPanel1.Controls.Add(accountCardController2);
            flowLayoutPanel1.Controls.Add(accountCardController3);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(600, 266);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // accountCardController1
            // 
            accountCardController1.AccountImage = null;
            accountCardController1.AccountName = "label1";
            accountCardController1.BackColor = Color.FromArgb(169, 196, 235);
            accountCardController1.Location = new Point(3, 3);
            accountCardController1.Name = "accountCardController1";
            accountCardController1.Size = new Size(192, 263);
            accountCardController1.TabIndex = 0;
            // 
            // accountCardController2
            // 
            accountCardController2.AccountImage = null;
            accountCardController2.AccountName = "label1";
            accountCardController2.BackColor = Color.FromArgb(169, 196, 235);
            accountCardController2.Location = new Point(201, 3);
            accountCardController2.Name = "accountCardController2";
            accountCardController2.Size = new Size(193, 263);
            accountCardController2.TabIndex = 1;
            // 
            // accountCardController3
            // 
            accountCardController3.AccountImage = null;
            accountCardController3.AccountName = "label1";
            accountCardController3.BackColor = Color.FromArgb(169, 196, 235);
            accountCardController3.Location = new Point(400, 3);
            accountCardController3.Name = "accountCardController3";
            accountCardController3.Size = new Size(191, 263);
            accountCardController3.TabIndex = 2;
            // 
            // AccountsController
            // 
            Controls.Add(flowLayoutPanel1);
            Name = "AccountsController";
            Size = new Size(600, 266);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private AccountCardController accountCardController1;
        private AccountCardController accountCardController2;
        private AccountCardController accountCardController3;
        
    }
}
