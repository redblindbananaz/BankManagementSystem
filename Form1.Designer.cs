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
            customButton = new CustomButton();
            customButton2 = new CustomButton();
            customButton3 = new CustomButton();
            customButton4 = new CustomButton();
            customPanel1 = new CustomPanel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // customButton
            // 
            customButton.BackColor = Color.FromArgb(169, 196, 235);
            customButton.BorderColor = Color.FromArgb(255, 242, 204);
            customButton.BorderRadius = 24;
            customButton.BorderSize = 8;
            customButton.FlatStyle = FlatStyle.Flat;
            customButton.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton.ForeColor = Color.FromArgb(0, 51, 102);
            customButton.Location = new Point(12, 313);
            customButton.Name = "customButton";
            customButton.Size = new Size(240, 60);
            customButton.TabIndex = 1;
            customButton.Text = "Deposit";
            customButton.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(169, 196, 235);
            customButton2.BorderColor = Color.FromArgb(255, 242, 204);
            customButton2.BorderRadius = 24;
            customButton2.BorderSize = 8;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton2.ForeColor = Color.FromArgb(0, 51, 102);
            customButton2.Location = new Point(12, 393);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(240, 60);
            customButton2.TabIndex = 2;
            customButton2.Text = "Withdraw";
            customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            customButton3.BackColor = Color.FromArgb(169, 196, 235);
            customButton3.BorderColor = Color.FromArgb(255, 242, 204);
            customButton3.BorderRadius = 24;
            customButton3.BorderSize = 8;
            customButton3.FlatStyle = FlatStyle.Flat;
            customButton3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton3.ForeColor = Color.FromArgb(0, 51, 102);
            customButton3.Location = new Point(12, 473);
            customButton3.Name = "customButton3";
            customButton3.Size = new Size(240, 60);
            customButton3.TabIndex = 3;
            customButton3.Text = "History";
            customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.BackColor = Color.FromArgb(255, 242, 204);
            customButton4.BorderColor = Color.FromArgb(215, 155, 0);
            customButton4.BorderRadius = 24;
            customButton4.BorderSize = 8;
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButton4.ForeColor = Color.FromArgb(215, 155, 0);
            customButton4.Location = new Point(12, 573);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(240, 76);
            customButton4.TabIndex = 4;
            customButton4.Text = "EXIT";
            customButton4.UseVisualStyleBackColor = false;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.FromArgb(169, 196, 235);
            customPanel1.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel1.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel1.BorderRadius = 24;
            customPanel1.BorderSize = 8;
            customPanel1.Location = new Point(273, 12);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(649, 637);
            customPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = BankSystem.Properties.Resources.bankLogo1;
            pictureBox1.Location = new Point(12, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 186);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 51, 102);
            ClientSize = new Size(934, 661);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(customButton);
            Controls.Add(customButton2);
            Controls.Add(customButton3);
            Controls.Add(customButton4);
            Controls.Add(customPanel1);
            MaximumSize = new Size(950, 700);
            MinimumSize = new Size(950, 700);
            Name = "Form1";
            Text = "B-Bank";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomButton customButton;

        private CustomButton customButton2;

        private CustomButton customButton3;

        private CustomButton customButton4;

        private CustomPanel customPanel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}
