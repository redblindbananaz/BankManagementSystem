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
            featuresLabel = new Label();
            ImagePanel = new CustomPanel();
            CompleteInterestPanel = new Panel();
            NoBtn = new Label();
            YesBtn = new CustomButton();
            interestquestionlabel = new Label();
            calculationPanel = new CustomPanel();
            label2 = new Label();
            label3 = new Label();
            InterestrateLabel = new Label();
            customPanel1 = new CustomPanel();
            InterestLabel = new Label();
            ConfirmBtn = new CustomButton();
            label1 = new Label();
            panel3 = new Panel();
            panel1 = new Panel();
            AccountdetailNameLabel = new Label();
            homeBtn = new CustomButton();
            customPanel2.SuspendLayout();
            CompleteInterestPanel.SuspendLayout();
            calculationPanel.SuspendLayout();
            customPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.FromArgb(169, 196, 235);
            customPanel2.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel2.BorderColor = Color.FromArgb(215, 155, 0);
            customPanel2.BorderRadius = 24;
            customPanel2.BorderSize = 8;
            customPanel2.Controls.Add(featuresLabel);
            customPanel2.Controls.Add(ImagePanel);
            customPanel2.Controls.Add(CompleteInterestPanel);
            customPanel2.Controls.Add(panel1);
            customPanel2.Controls.Add(AccountdetailNameLabel);
            customPanel2.Controls.Add(homeBtn);
            customPanel2.Location = new Point(0, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(649, 637);
            customPanel2.TabIndex = 0;
            // 
            // featuresLabel
            // 
            featuresLabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            featuresLabel.ForeColor = Color.FromArgb(255, 242, 204);
            featuresLabel.Location = new Point(36, 96);
            featuresLabel.Name = "featuresLabel";
            featuresLabel.Size = new Size(283, 184);
            featuresLabel.TabIndex = 6;
            featuresLabel.Text = "label4";
            featuresLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ImagePanel
            // 
            ImagePanel.BackgroundColor = Color.FromArgb(169, 196, 235);
            ImagePanel.BorderColor = Color.FromArgb(255, 242, 204);
            ImagePanel.BorderRadius = 24;
            ImagePanel.BorderSize = 8;
            ImagePanel.Location = new Point(391, 80);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(200, 200);
            ImagePanel.TabIndex = 5;
            // 
            // CompleteInterestPanel
            // 
            CompleteInterestPanel.Controls.Add(NoBtn);
            CompleteInterestPanel.Controls.Add(YesBtn);
            CompleteInterestPanel.Controls.Add(interestquestionlabel);
            CompleteInterestPanel.Controls.Add(calculationPanel);
            CompleteInterestPanel.Controls.Add(label1);
            CompleteInterestPanel.Controls.Add(panel3);
            CompleteInterestPanel.Location = new Point(12, 284);
            CompleteInterestPanel.Name = "CompleteInterestPanel";
            CompleteInterestPanel.Size = new Size(624, 331);
            CompleteInterestPanel.TabIndex = 2;
            // 
            // NoBtn
            // 
            NoBtn.Cursor = Cursors.Hand;
            NoBtn.Font = new Font("Verdana", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            NoBtn.ForeColor = Color.FromArgb(0, 51, 102);
            NoBtn.Location = new Point(358, 268);
            NoBtn.Name = "NoBtn";
            NoBtn.Size = new Size(240, 23);
            NoBtn.TabIndex = 18;
            NoBtn.Text = "No, Thank you!";
            NoBtn.TextAlign = ContentAlignment.MiddleCenter;
            NoBtn.Click += NoBtn_Click;
            // 
            // YesBtn
            // 
            YesBtn.BackColor = Color.FromArgb(0, 51, 102);
            YesBtn.BorderColor = Color.FromArgb(215, 155, 0);
            YesBtn.BorderRadius = 24;
            YesBtn.BorderSize = 4;
            YesBtn.Cursor = Cursors.Hand;
            YesBtn.FlatStyle = FlatStyle.Flat;
            YesBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            YesBtn.ForeColor = Color.FromArgb(215, 155, 0);
            YesBtn.Location = new Point(359, 140);
            YesBtn.Name = "YesBtn";
            YesBtn.Size = new Size(243, 60);
            YesBtn.TabIndex = 17;
            YesBtn.Text = "Yes, Please!";
            YesBtn.UseVisualStyleBackColor = false;
            YesBtn.Visible = false;
            YesBtn.Click += YesBtn_Click;
            // 
            // interestquestionlabel
            // 
            interestquestionlabel.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            interestquestionlabel.ForeColor = Color.FromArgb(0, 51, 102);
            interestquestionlabel.Location = new Point(358, 62);
            interestquestionlabel.Name = "interestquestionlabel";
            interestquestionlabel.Size = new Size(243, 75);
            interestquestionlabel.TabIndex = 16;
            interestquestionlabel.Text = "Would You Like to Add This $15 Interest To Your Invest Account?";
            interestquestionlabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // calculationPanel
            // 
            calculationPanel.BackgroundColor = Color.FromArgb(169, 196, 235);
            calculationPanel.BorderColor = Color.FromArgb(0, 51, 102);
            calculationPanel.BorderRadius = 24;
            calculationPanel.BorderSize = 4;
            calculationPanel.Controls.Add(label2);
            calculationPanel.Controls.Add(label3);
            calculationPanel.Controls.Add(InterestrateLabel);
            calculationPanel.Controls.Add(customPanel1);
            calculationPanel.Controls.Add(ConfirmBtn);
            calculationPanel.Location = new Point(22, 54);
            calculationPanel.Name = "calculationPanel";
            calculationPanel.Size = new Size(285, 271);
            calculationPanel.TabIndex = 15;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 51, 102);
            label2.Location = new Point(37, 29);
            label2.Name = "label2";
            label2.Size = new Size(212, 23);
            label2.TabIndex = 7;
            label2.Text = "Your Balance: $3000";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 51, 102);
            label3.Location = new Point(114, 146);
            label3.Name = "label3";
            label3.Size = new Size(48, 50);
            label3.TabIndex = 14;
            label3.Text = "=";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InterestrateLabel
            // 
            InterestrateLabel.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InterestrateLabel.ForeColor = Color.FromArgb(0, 51, 102);
            InterestrateLabel.Location = new Point(37, 58);
            InterestrateLabel.Name = "InterestrateLabel";
            InterestrateLabel.Size = new Size(208, 18);
            InterestrateLabel.TabIndex = 13;
            InterestrateLabel.Text = "Your Rate : 0.5% ";
            InterestrateLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // customPanel1
            // 
            customPanel1.BackgroundColor = Color.FromArgb(169, 196, 235);
            customPanel1.BorderColor = Color.FromArgb(0, 51, 102);
            customPanel1.BorderRadius = 24;
            customPanel1.BorderSize = 4;
            customPanel1.Controls.Add(InterestLabel);
            customPanel1.Cursor = Cursors.No;
            customPanel1.Location = new Point(37, 199);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(208, 59);
            customPanel1.TabIndex = 11;
            // 
            // InterestLabel
            // 
            InterestLabel.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InterestLabel.ForeColor = Color.FromArgb(0, 51, 102);
            InterestLabel.Location = new Point(16, 17);
            InterestLabel.Name = "InterestLabel";
            InterestLabel.Size = new Size(176, 23);
            InterestLabel.TabIndex = 10;
            InterestLabel.Text = "$ 15";
            InterestLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.FromArgb(255, 242, 204);
            ConfirmBtn.BorderColor = Color.FromArgb(0, 51, 102);
            ConfirmBtn.BorderRadius = 24;
            ConfirmBtn.BorderSize = 4;
            ConfirmBtn.Cursor = Cursors.Hand;
            ConfirmBtn.FlatStyle = FlatStyle.Flat;
            ConfirmBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            ConfirmBtn.ForeColor = Color.FromArgb(0, 51, 102);
            ConfirmBtn.Location = new Point(37, 87);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(212, 60);
            ConfirmBtn.TabIndex = 4;
            ConfirmBtn.Text = "Calculate";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 51, 102);
            label1.Location = new Point(24, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 18);
            label1.TabIndex = 6;
            label1.Text = "Calculate Your Interest";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 51, 102);
            panel3.Location = new Point(22, 44);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 4);
            panel3.TabIndex = 5;
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
            // homeBtn
            // 
            homeBtn.BackColor = Color.FromArgb(169, 196, 235);
            homeBtn.BorderColor = Color.FromArgb(255, 242, 204);
            homeBtn.BorderRadius = 24;
            homeBtn.BorderSize = 8;
            homeBtn.Cursor = Cursors.Hand;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            homeBtn.ForeColor = Color.FromArgb(0, 51, 102);
            homeBtn.Location = new Point(373, 523);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(240, 60);
            homeBtn.TabIndex = 4;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Visible = false;
            homeBtn.Click += HomeBtn_Click;
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
            CompleteInterestPanel.ResumeLayout(false);
            CompleteInterestPanel.PerformLayout();
            calculationPanel.ResumeLayout(false);
            calculationPanel.PerformLayout();
            customPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CustomPanel customPanel2;
        private Label AccountdetailNameLabel;
        private Panel panel1;
        private Panel CompleteInterestPanel;
        private CustomButton ConfirmBtn;
        private CustomButton homeBtn;
        private Label label1;
        private Panel panel3;
        private Label label2;
        private Label InterestLabel;
        private CustomPanel customPanel1;
        private Label InterestrateLabel;
        private CustomPanel calculationPanel;
        private Label label3;
        private Label interestquestionlabel;
        private CustomButton YesBtn;
        private Label NoBtn;
        private CustomPanel ImagePanel;
        private Label featuresLabel;
    }
}
