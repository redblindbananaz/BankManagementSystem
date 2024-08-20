using BankSystem.Components;

namespace BankSystem.Controllers
{
    partial class AccountCardController
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
            accountButton = new CustomButton();
            accountNameLabel = new Label();
            accountIDLabel = new Label();
            balanceLabel = new Label();
            SuspendLayout();
            // 
            // accountButton
            // 
            accountButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            accountButton.BackColor = Color.FromArgb(255, 242, 204);
            accountButton.BackgroundImageLayout = ImageLayout.Zoom;
            accountButton.BorderColor = Color.FromArgb(0, 51, 102);
            accountButton.BorderRadius = 24;
            accountButton.BorderSize = 6;
            accountButton.Cursor = Cursors.Hand;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.ForeColor = Color.Transparent;
            accountButton.Location = new Point(25, 58);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(140, 140);
            accountButton.TabIndex = 0;
            accountButton.TextAlign = ContentAlignment.BottomCenter;
            accountButton.TextImageRelation = TextImageRelation.ImageAboveText;
            accountButton.UseVisualStyleBackColor = false;
            // 
            // accountNameLabel
            // 
            accountNameLabel.CausesValidation = false;
            accountNameLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountNameLabel.ForeColor = Color.FromArgb(0, 51, 102);
            accountNameLabel.Location = new Point(64, 9);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(58, 18);
            accountNameLabel.TabIndex = 1;
            accountNameLabel.Text = "label1";
            accountNameLabel.UseCompatibleTextRendering = true;
            // 
            // accountIDLabel
            // 
            accountIDLabel.AutoSize = true;
            accountIDLabel.Location = new Point(84, 40);
            accountIDLabel.Name = "accountIDLabel";
            accountIDLabel.Size = new Size(19, 15);
            accountIDLabel.TabIndex = 2;
            accountIDLabel.Text = "10";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Verdana", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            balanceLabel.ForeColor = Color.FromArgb(0, 51, 102);
            balanceLabel.Location = new Point(37, 222);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(89, 26);
            balanceLabel.TabIndex = 3;
            balanceLabel.Text = "label1";
            balanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AccountCardController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 196, 235);
            Controls.Add(balanceLabel);
            Controls.Add(accountIDLabel);
            Controls.Add(accountNameLabel);
            Controls.Add(accountButton);
            Name = "AccountCardController";
            Size = new Size(192, 283);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.CustomButton accountButton;
        private Label accountNameLabel;
        private Label accountIDLabel;
        private Label balanceLabel;
    }
}
