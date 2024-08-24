using BankSystem.Components;
using System.Windows.Forms;

namespace BankSystem.Controllers
{
    partial class DetailAccountController
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
            customPanel2 = new CustomPanel();
            panel1 = new Panel();
            AccountdetailNameLabel = new Label();
            customPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(169, 196, 235);
            customPanel2.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel2.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel2.BorderRadius = 24;
            customPanel2.BorderSize = 8;
            customPanel2.Controls.Add(panel1);
            customPanel2.Controls.Add(AccountdetailNameLabel);
            customPanel2.Location = new Point(0, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(649, 637);
            customPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 51, 102);
            panel1.Location = new Point(34, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 4);
            panel1.TabIndex = 1;
            // 
            // AccountdetailNameLabel
            // 
            AccountdetailNameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AccountdetailNameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            AccountdetailNameLabel.Location = new Point(36, 34);
            AccountdetailNameLabel.Name = "AccountdetailNameLabel";
            AccountdetailNameLabel.Size = new Size(580, 23);
            AccountdetailNameLabel.TabIndex = 0;
            AccountdetailNameLabel.Text = "Your Everyday Account";
            AccountdetailNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DetailAccountController
            // 
            BackColor = Color.FromArgb(0, 51, 102);
            Controls.Add(customPanel2);
            DoubleBuffered = true;
            MaximumSize = new Size(648, 637);
            MinimumSize = new Size(648, 637);
            Name = "DetailAccountController";
            Size = new Size(648, 637);
            customPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomPanel customPanel2;
        private Label AccountdetailNameLabel;
        private Panel panel1;
    }
}
