using BankSystem.Components;
using System.Windows.Forms.VisualStyles;

namespace BankSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            depositButton = new CustomButton();
            withdrawButton = new CustomButton();
            historyButton = new CustomButton();
            outButton = new CustomButton();
            LogoBox = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)LogoBox).BeginInit();
            SuspendLayout();
            // 
            // depositButton
            // 
            depositButton.BackColor = Color.FromArgb(169, 196, 235);
            depositButton.BorderColor = Color.FromArgb(255, 242, 204);
            depositButton.BorderRadius = 24;
            depositButton.BorderSize = 8;
            depositButton.Cursor = Cursors.Hand;
            depositButton.FlatStyle = FlatStyle.Flat;
            depositButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.ForeColor = Color.FromArgb(0, 51, 102);
            depositButton.Location = new Point(12, 313);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(240, 60);
            depositButton.TabIndex = 1;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = false;
            depositButton.Click += depositButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.BackColor = Color.FromArgb(169, 196, 235);
            withdrawButton.BorderColor = Color.FromArgb(255, 242, 204);
            withdrawButton.BorderRadius = 24;
            withdrawButton.BorderSize = 8;
            withdrawButton.Cursor = Cursors.Hand;
            withdrawButton.FlatStyle = FlatStyle.Flat;
            withdrawButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.ForeColor = Color.FromArgb(0, 51, 102);
            withdrawButton.Location = new Point(12, 393);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(240, 60);
            withdrawButton.TabIndex = 2;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = false;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // historyButton
            // 
            historyButton.BackColor = Color.FromArgb(169, 196, 235);
            historyButton.BorderColor = Color.FromArgb(255, 242, 204);
            historyButton.BorderRadius = 24;
            historyButton.BorderSize = 8;
            historyButton.Cursor = Cursors.Hand;
            historyButton.FlatStyle = FlatStyle.Flat;
            historyButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyButton.ForeColor = Color.FromArgb(0, 51, 102);
            historyButton.Location = new Point(12, 473);
            historyButton.Name = "historyButton";
            historyButton.Size = new Size(240, 60);
            historyButton.TabIndex = 3;
            historyButton.Text = "History";
            historyButton.UseVisualStyleBackColor = false;
            // 
            // outButton
            // 
            outButton.BackColor = Color.FromArgb(255, 242, 204);
            outButton.BorderColor = Color.FromArgb(215, 155, 0);
            outButton.BorderRadius = 24;
            outButton.BorderSize = 8;
            outButton.Cursor = Cursors.Hand;
            outButton.FlatStyle = FlatStyle.Flat;
            outButton.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            outButton.ForeColor = Color.FromArgb(215, 155, 0);
            outButton.Location = new Point(12, 573);
            outButton.Name = "outButton";
            outButton.Size = new Size(240, 76);
            outButton.TabIndex = 4;
            outButton.Text = "EXIT";
            outButton.UseVisualStyleBackColor = false;
            outButton.Click += outButton_Click;
            // 
            // LogoBox
            // 
            LogoBox.BackgroundImageLayout = ImageLayout.Center;
            LogoBox.Cursor = Cursors.Hand;
            LogoBox.Image = Properties.Resources.bankLogo1;
            LogoBox.Location = new Point(12, 0);
            LogoBox.Name = "LogoBox";
            LogoBox.Size = new Size(240, 186);
            LogoBox.TabIndex = 5;
            LogoBox.TabStop = false;
            LogoBox.Click += logoBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 15.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 189);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 6;
            label1.Text = "Total Balance:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Tahoma", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(215, 155, 0);
            label2.Location = new Point(33, 220);
            label2.Name = "label2";
            label2.Size = new Size(195, 39);
            label2.TabIndex = 7;
            label2.Text = "$ 5, 037.36";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(273, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(649, 637);
            panel1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 51, 102);
            ClientSize = new Size(934, 661);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogoBox);
            Controls.Add(depositButton);
            Controls.Add(withdrawButton);
            Controls.Add(historyButton);
            Controls.Add(outButton);
            Controls.Add(panel1);
            MaximumSize = new Size(950, 700);
            MinimumSize = new Size(950, 700);
            Name = "Form1";
            Text = "B-Bank";
            ((System.ComponentModel.ISupportInitialize)LogoBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomButton depositButton;

        private CustomButton withdrawButton;

        private CustomButton historyButton;

        private CustomButton outButton;

        private PictureBox LogoBox;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}
