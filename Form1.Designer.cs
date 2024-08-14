using BankSystem;

namespace roundBtn
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
            customButton.Location = new Point(12, 258);
            customButton.Name = "customButton";
            customButton.Size = new Size(240, 60);
            customButton.TabIndex = 0;
            customButton.Text = "Deposit";
            customButton.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 51, 102);
            ClientSize = new Size(934, 661);
            Controls.Add(customButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private CustomButton customButton;
        
    }
}
