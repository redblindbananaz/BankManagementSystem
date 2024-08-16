using BankSystem.Components;

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
            UserNameLabel = new Label();
            customPanel.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel
            // 
            customPanel.BackColor = Color.FromArgb(169, 196, 235);
            customPanel.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel.BorderRadius = 24;
            customPanel.BorderSize = 8;
            customPanel.Controls.Add(UserNameLabel);
            customPanel.Location = new Point(0, 0);
            customPanel.Name = "customPanel";
            customPanel.Size = new Size(649, 637);
            customPanel.TabIndex = 0;
            // 
            // UserNameLabel
            // 
            UserNameLabel.AutoSize = true;
            UserNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNameLabel.Location = new Point(221, 41);
            UserNameLabel.Name = "UserNameLabel";
            UserNameLabel.Size = new Size(181, 32);
            UserNameLabel.TabIndex = 0;
            UserNameLabel.Text = "Welcome Page";
            // 
            // HomeControl
            // 
            BackColor = Color.FromArgb(0, 51, 102);
            Controls.Add(customPanel);
            DoubleBuffered = true;
            MaximumSize = new Size(648, 637);
            MinimumSize = new Size(648, 637);
            Name = "HomeControl";
            Size = new Size(648, 637);
            customPanel.ResumeLayout(false);
            customPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Components.CustomPanel customPanel;
        private Label UserNameLabel;
    }
}
