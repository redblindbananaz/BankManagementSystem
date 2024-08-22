using BankSystem.Components;

namespace BankSystem.Controllers
{
    partial class ActionController
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
            actionPanel = new CustomPanel();
            selectedMessageLabel = new Label();
            cancelLabel = new Label();
            selectButton = new CustomButton();
            customPanel1 = new CustomPanel();
            StepLevelLabel = new Label();
            presentationPanel = new Panel();
            
            label1 = new Label();
            actionLabel = new Label();
            actionPanel.SuspendLayout();
            customPanel1.SuspendLayout();
            presentationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // actionPanel
            // 
            actionPanel.BackgroundColor = Color.FromArgb(255, 242, 204);
            actionPanel.BorderColor = Color.FromArgb(215, 155, 0);
            actionPanel.BorderRadius = 24;
            actionPanel.BorderSize = 8;
            actionPanel.Controls.Add(selectedMessageLabel);
            actionPanel.Controls.Add(cancelLabel);
            actionPanel.Controls.Add(selectButton);
            actionPanel.Controls.Add(customPanel1);
            actionPanel.Controls.Add(presentationPanel);
            actionPanel.Controls.Add(label1);
            actionPanel.Controls.Add(actionLabel);
            actionPanel.Location = new Point(0, 0);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(649, 637);
            actionPanel.TabIndex = 0;
            // 
            // selectedMessageLabel
            // 
            selectedMessageLabel.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            selectedMessageLabel.ForeColor = Color.FromArgb(215, 155, 0);
            selectedMessageLabel.Location = new Point(39, 489);
            selectedMessageLabel.Name = "selectedMessageLabel";
            selectedMessageLabel.Size = new Size(574, 23);
            selectedMessageLabel.TabIndex = 6;
            selectedMessageLabel.Text = "label2";
            selectedMessageLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cancelLabel
            // 
            cancelLabel.AccessibleRole = AccessibleRole.Cursor;
            cancelLabel.AutoSize = true;
            cancelLabel.Cursor = Cursors.Hand;
            cancelLabel.Font = new Font("Verdana", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            cancelLabel.ForeColor = Color.FromArgb(215, 155, 0);
            cancelLabel.Location = new Point(51, 538);
            cancelLabel.Name = "cancelLabel";
            cancelLabel.Size = new Size(93, 29);
            cancelLabel.TabIndex = 5;
            cancelLabel.Text = "Cancel";
            cancelLabel.Click += cancelLabel_Click;
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.FromArgb(169, 196, 235);
            selectButton.BorderColor = Color.FromArgb(255, 242, 204);
            selectButton.BorderRadius = 24;
            selectButton.BorderSize = 8;
            selectButton.FlatStyle = FlatStyle.Flat;
            selectButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectButton.ForeColor = Color.FromArgb(0, 51, 102);
            selectButton.Location = new Point(373, 523);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(240, 60);
            selectButton.TabIndex = 4;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(255, 242, 204);
            customPanel1.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel1.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel1.BorderRadius = 32;
            customPanel1.BorderSize = 8;
            customPanel1.Controls.Add(StepLevelLabel);
            customPanel1.Location = new Point(25, 26);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(140, 80);
            customPanel1.TabIndex = 3;
            // 
            // StepLevelLabel
            // 
            StepLevelLabel.AutoSize = true;
            StepLevelLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            StepLevelLabel.ForeColor = Color.FromArgb(215, 155, 0);
            StepLevelLabel.Location = new Point(23, 27);
            StepLevelLabel.Name = "StepLevelLabel";
            StepLevelLabel.Size = new Size(96, 25);
            StepLevelLabel.TabIndex = 0;
            StepLevelLabel.Text = "Step 1:";
            // 
            // presentationPanel
            // 
            presentationPanel.BackColor = Color.FromArgb(169, 196, 235);
            
            presentationPanel.Location = new Point(12, 140);
            presentationPanel.Name = "presentationPanel";
            presentationPanel.Size = new Size(626, 338);
            presentationPanel.TabIndex = 2;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 242, 204);
            label1.Location = new Point(185, 49);
            label1.Name = "label1";
            label1.Size = new Size(279, 29);
            label1.TabIndex = 1;
            label1.Text = "Choose Account for ";
            // 
            // actionLabel
            // 
            actionLabel.AutoSize = true;
            actionLabel.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            actionLabel.ForeColor = Color.FromArgb(255, 242, 204);
            actionLabel.Location = new Point(461, 49);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(98, 29);
            actionLabel.TabIndex = 0;
            actionLabel.Text = "Action";
            // 
            // ActionController
            // 
            BackColor = Color.FromArgb(0, 51, 102);
            Controls.Add(actionPanel);
            DoubleBuffered = true;
            MaximumSize = new Size(648, 637);
            MinimumSize = new Size(648, 637);
            Name = "ActionController";
            Size = new Size(648, 637);
            actionPanel.ResumeLayout(false);
            actionPanel.PerformLayout();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            presentationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomPanel actionPanel;
        private Label actionLabel;
        private Label label1;
        private Panel presentationPanel;
        private CustomPanel customPanel1;
        private Label StepLevelLabel;
        private CustomButton selectButton;
        private Label cancelLabel;
        private Label selectedMessageLabel;
    }
}
