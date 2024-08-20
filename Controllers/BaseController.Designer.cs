using BankSystem.Components;
using BankSystem.Models;

namespace BankSystem.Controllers
{
    partial class BaseController
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
            customPanel = new CustomPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            accountCardController1 = new AccountCardController();
            accountCardController2 = new AccountCardController();
            accountCardController3 = new AccountCardController();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            seperationLine = new Panel();
            userNameLabel = new Label();
            label1 = new Label();
            customPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel
            // 
            customPanel.BackColor = Color.FromArgb(169, 196, 235);
            customPanel.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel.BorderRadius = 24;
            customPanel.BorderSize = 8;
            customPanel.Controls.Add(flowLayoutPanel1);
            customPanel.Controls.Add(label3);
            customPanel.Controls.Add(panel1);
            customPanel.Controls.Add(label2);
            customPanel.Controls.Add(seperationLine);
            customPanel.Controls.Add(userNameLabel);
            customPanel.Controls.Add(label1);
            customPanel.Location = new Point(0, 0);
            customPanel.Name = "customPanel";
            customPanel.Size = new Size(649, 637);
            customPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(accountCardController1);
            flowLayoutPanel1.Controls.Add(accountCardController2);
            flowLayoutPanel1.Controls.Add(accountCardController3);
            flowLayoutPanel1.Location = new Point(25, 170);
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(169, 196, 235);
            label3.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(255, 242, 204);
            label3.Location = new Point(34, 439);
            label3.Name = "label3";
            label3.Size = new Size(155, 18);
            label3.TabIndex = 5;
            label3.Text = "Last Transactions";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 242, 204);
            panel1.Location = new Point(34, 460);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 4);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 242, 204);
            label2.Location = new Point(34, 139);
            label2.Name = "label2";
            label2.Size = new Size(83, 18);
            label2.TabIndex = 3;
            label2.Text = "Accounts";
            // 
            // seperationLine
            // 
            seperationLine.BackColor = Color.FromArgb(255, 242, 204);
            seperationLine.Location = new Point(34, 160);
            seperationLine.Name = "seperationLine";
            seperationLine.Size = new Size(580, 4);
            seperationLine.TabIndex = 2;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Verdana", 24F, FontStyle.Italic, GraphicsUnit.Point, 0);
            userNameLabel.ForeColor = Color.FromArgb(255, 242, 204);
            userNameLabel.Location = new Point(30, 70);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(0, 38);
            userNameLabel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 51, 102);
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(181, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome";
            // 
            // BaseController
            // 
            BackColor = Color.FromArgb(0, 51, 102);
            Controls.Add(customPanel);
            DoubleBuffered = true;
            MaximumSize = new Size(648, 637);
            MinimumSize = new Size(648, 637);
            Name = "BaseController";
            Size = new Size(648, 637);
            customPanel.ResumeLayout(false);
            customPanel.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CustomPanel customPanel;
        private Label label1;
        public Label userNameLabel;
        private Panel seperationLine;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private AccountCardController accountCardController1;
        private AccountCardController accountCardController2;
        private AccountCardController accountCardController3;
    }
}
