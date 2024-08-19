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
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // accountButton
            // 
            accountButton.BackColor = Color.Transparent;
            accountButton.BorderColor = Color.FromArgb(0, 51, 102);
            accountButton.BorderRadius = 24;
            accountButton.BorderSize = 6;
            accountButton.FlatAppearance.BorderSize = 0;
            accountButton.FlatStyle = FlatStyle.Flat;
            accountButton.ForeColor = Color.Blue;
            accountButton.Location = new Point(25, 58);
            accountButton.Name = "accountButton";
            accountButton.Size = new Size(140, 140);
            accountButton.TabIndex = 0;
            accountButton.UseVisualStyleBackColor = false;
            // 
            // accountNameLabel
            // 
            accountNameLabel.AutoSize = true;
            accountNameLabel.Location = new Point(73, 16);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(38, 15);
            accountNameLabel.TabIndex = 1;
            accountNameLabel.Text = "label1";
            // 
            // accountIDLabel
            // 
            accountIDLabel.AutoSize = true;
            accountIDLabel.Location = new Point(81, 38);
            accountIDLabel.Name = "accountIDLabel";
            accountIDLabel.Size = new Size(38, 15);
            accountIDLabel.TabIndex = 2;
            accountIDLabel.Text = "label1";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new Point(97, 223);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(38, 15);
            balanceLabel.TabIndex = 3;
            balanceLabel.Text = "label1";
            // 
            // pictureBox1
            // 
            
            pictureBox1.Location = new Point(25, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // AccountCardController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 196, 235);
            Controls.Add(pictureBox1);
            Controls.Add(balanceLabel);
            Controls.Add(accountIDLabel);
            Controls.Add(accountNameLabel);
            Controls.Add(accountButton);
            Name = "AccountCardController";
            Size = new Size(192, 283);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Components.CustomButton accountButton;
        private Label accountNameLabel;
        private Label accountIDLabel;
        private Label balanceLabel;
        private PictureBox pictureBox1;
    }
}
