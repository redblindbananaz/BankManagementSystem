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
            DeclinedBtn = new CustomButton();
            SuccessBtn = new CustomButton();
            confirmationMessageActionLabel = new Label();
            CurrentBalanceLabel = new Label();
            accountNameLabel = new Label();
            ConfirmBtn = new CustomButton();
            cancelLabel = new Label();
            selectButton = new CustomButton();
            customPanel1 = new CustomPanel();
            StepLevelLabel = new Label();
            presentationPanel = new Panel();
            ValidationErrorLabel = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            EnterAmountBtn = new CustomButton();
            cash500Btn = new CustomButton();
            cash200Btn = new CustomButton();
            cash100Btn = new CustomButton();
            cash50Btn = new CustomButton();
            Linevertical = new Panel();
            customAmountLabel = new Label();
            quickCashLabel = new Label();
            presentationPanel2 = new Panel();
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
            actionPanel.Controls.Add(DeclinedBtn);
            actionPanel.Controls.Add(SuccessBtn);
            actionPanel.Controls.Add(confirmationMessageActionLabel);
            actionPanel.Controls.Add(CurrentBalanceLabel);
            actionPanel.Controls.Add(accountNameLabel);
            actionPanel.Controls.Add(ConfirmBtn);
            actionPanel.Controls.Add(cancelLabel);
            actionPanel.Controls.Add(selectButton);
            actionPanel.Controls.Add(customPanel1);
            actionPanel.Controls.Add(presentationPanel);
            actionPanel.Controls.Add(presentationPanel2);
            actionPanel.Controls.Add(actionLabel);
            actionPanel.Location = new Point(0, 0);
            actionPanel.Name = "actionPanel";
            actionPanel.Size = new Size(649, 637);
            actionPanel.TabIndex = 0;
            // 
            // DeclinedBtn
            // 
            DeclinedBtn.BackColor = Color.FromArgb(255, 242, 204);
            DeclinedBtn.BorderColor = Color.FromArgb(166, 62, 55);
            DeclinedBtn.BorderRadius = 24;
            DeclinedBtn.BorderSize = 8;
            DeclinedBtn.Cursor = Cursors.No;
            DeclinedBtn.FlatStyle = FlatStyle.Flat;
            DeclinedBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeclinedBtn.ForeColor = Color.FromArgb(166, 62, 55);
            DeclinedBtn.Location = new Point(370, 521);
            DeclinedBtn.Name = "DeclinedBtn";
            DeclinedBtn.Size = new Size(240, 60);
            DeclinedBtn.TabIndex = 10;
            DeclinedBtn.Text = "Declined :(";
            DeclinedBtn.UseVisualStyleBackColor = false;
            DeclinedBtn.Visible = false;
            // 
            // SuccessBtn
            // 
            SuccessBtn.BackColor = Color.FromArgb(255, 242, 204);
            SuccessBtn.BorderColor = Color.FromArgb(66, 107, 62);
            SuccessBtn.BorderRadius = 24;
            SuccessBtn.BorderSize = 8;
            SuccessBtn.Cursor = Cursors.No;
            SuccessBtn.FlatStyle = FlatStyle.Flat;
            SuccessBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SuccessBtn.ForeColor = Color.FromArgb(66, 107, 62);
            SuccessBtn.Location = new Point(370, 521);
            SuccessBtn.Name = "SuccessBtn";
            SuccessBtn.Size = new Size(240, 60);
            SuccessBtn.TabIndex = 9;
            SuccessBtn.Text = "Success!";
            SuccessBtn.UseVisualStyleBackColor = false;
            SuccessBtn.Visible = false;
            // 
            // confirmationMessageActionLabel
            // 
            confirmationMessageActionLabel.AutoSize = true;
            confirmationMessageActionLabel.Font = new Font("Verdana", 10F, FontStyle.Italic | FontStyle.Underline);
            confirmationMessageActionLabel.ForeColor = Color.FromArgb(215, 155, 0);
            confirmationMessageActionLabel.Location = new Point(12, 481);
            confirmationMessageActionLabel.Name = "confirmationMessageActionLabel";
            confirmationMessageActionLabel.Size = new Size(423, 17);
            confirmationMessageActionLabel.TabIndex = 8;
            confirmationMessageActionLabel.Text = "Press Confirm to continue Deposit - $300 - Everday ID 12";
            confirmationMessageActionLabel.TextAlign = ContentAlignment.MiddleCenter;
            confirmationMessageActionLabel.Visible = false;
            // 
            // CurrentBalanceLabel
            // 
            CurrentBalanceLabel.Font = new Font("Verdana", 9.75F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            CurrentBalanceLabel.ForeColor = Color.FromArgb(255, 242, 204);
            CurrentBalanceLabel.Location = new Point(185, 114);
            CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            CurrentBalanceLabel.Size = new Size(363, 15);
            CurrentBalanceLabel.TabIndex = 7;
            CurrentBalanceLabel.Text = "Current Available Balance: $ amount";
            CurrentBalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            CurrentBalanceLabel.Visible = false;
            // 
            // accountNameLabel
            // 
            accountNameLabel.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accountNameLabel.ForeColor = Color.FromArgb(215, 155, 0);
            accountNameLabel.Location = new Point(185, 78);
            accountNameLabel.Name = "accountNameLabel";
            accountNameLabel.Size = new Size(363, 28);
            accountNameLabel.TabIndex = 6;
            accountNameLabel.Text = "Name of the Account";
            accountNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            accountNameLabel.Visible = false;
            // 
            // ConfirmBtn
            // 
            ConfirmBtn.BackColor = Color.FromArgb(169, 196, 235);
            ConfirmBtn.BorderColor = Color.FromArgb(255, 242, 204);
            ConfirmBtn.BorderRadius = 24;
            ConfirmBtn.BorderSize = 8;
            ConfirmBtn.Cursor = Cursors.Hand;
            ConfirmBtn.FlatStyle = FlatStyle.Flat;
            ConfirmBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConfirmBtn.ForeColor = Color.FromArgb(0, 51, 102);
            ConfirmBtn.Location = new Point(373, 523);
            ConfirmBtn.Name = "ConfirmBtn";
            ConfirmBtn.Size = new Size(240, 60);
            ConfirmBtn.TabIndex = 4;
            ConfirmBtn.Text = "Confirm";
            ConfirmBtn.UseVisualStyleBackColor = false;
            ConfirmBtn.Visible = false;
            ConfirmBtn.Click += ConfirmBtn_Click;
            // 
            // cancelLabel
            // 
            cancelLabel.AccessibleRole = AccessibleRole.Cursor;
            cancelLabel.Cursor = Cursors.Hand;
            cancelLabel.Font = new Font("Verdana", 18F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            cancelLabel.ForeColor = Color.FromArgb(215, 155, 0);
            cancelLabel.Location = new Point(51, 538);
            cancelLabel.Name = "cancelLabel";
            cancelLabel.Size = new Size(237, 29);
            cancelLabel.TabIndex = 5;
            cancelLabel.Text = "Cancel";
            cancelLabel.TextAlign = ContentAlignment.MiddleLeft;
            cancelLabel.Click += CancelLabel_Click;
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.FromArgb(169, 196, 235);
            selectButton.BorderColor = Color.FromArgb(255, 242, 204);
            selectButton.BorderRadius = 24;
            selectButton.BorderSize = 8;
            selectButton.Cursor = Cursors.Hand;
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
            presentationPanel.Controls.Add(ValidationErrorLabel);
            presentationPanel.Controls.Add(label2);
            presentationPanel.Controls.Add(textBox1);
            presentationPanel.Controls.Add(EnterAmountBtn);
            presentationPanel.Controls.Add(cash500Btn);
            presentationPanel.Controls.Add(cash200Btn);
            presentationPanel.Controls.Add(cash100Btn);
            presentationPanel.Controls.Add(cash50Btn);
            presentationPanel.Controls.Add(Linevertical);
            presentationPanel.Controls.Add(customAmountLabel);
            presentationPanel.Controls.Add(quickCashLabel);
            presentationPanel.Location = new Point(12, 140);
            presentationPanel.Name = "presentationPanel";
            presentationPanel.Size = new Size(626, 338);
            presentationPanel.TabIndex = 2;
            // 
            // ValidationErrorLabel
            // 
            ValidationErrorLabel.Font = new Font("Verdana", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            ValidationErrorLabel.ForeColor = Color.FromArgb(192, 64, 0);
            ValidationErrorLabel.Location = new Point(358, 267);
            ValidationErrorLabel.Name = "ValidationErrorLabel";
            ValidationErrorLabel.Size = new Size(240, 71);
            ValidationErrorLabel.TabIndex = 10;
            ValidationErrorLabel.Text = "Error Message Display Here";
            ValidationErrorLabel.TextAlign = ContentAlignment.TopCenter;
            ValidationErrorLabel.Visible = false;
            // 
            // label2
            // 
            label2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 51, 102);
            label2.Location = new Point(379, 114);
            label2.Name = "label2";
            label2.Size = new Size(30, 33);
            label2.TabIndex = 9;
            label2.Text = "$";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 242, 204);
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(0, 51, 102);
            textBox1.Location = new Point(415, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 33);
            textBox1.TabIndex = 8;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Enter += textBox1_Enter;
            // 
            // EnterAmountBtn
            // 
            EnterAmountBtn.BackColor = Color.FromArgb(255, 242, 204);
            EnterAmountBtn.BorderColor = Color.FromArgb(215, 155, 0);
            EnterAmountBtn.BorderRadius = 24;
            EnterAmountBtn.BorderSize = 8;
            EnterAmountBtn.Cursor = Cursors.Hand;
            EnterAmountBtn.FlatAppearance.BorderSize = 0;
            EnterAmountBtn.FlatStyle = FlatStyle.Flat;
            EnterAmountBtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnterAmountBtn.ForeColor = Color.FromArgb(215, 155, 0);
            EnterAmountBtn.Location = new Point(358, 193);
            EnterAmountBtn.Name = "EnterAmountBtn";
            EnterAmountBtn.Size = new Size(240, 60);
            EnterAmountBtn.TabIndex = 7;
            EnterAmountBtn.Text = "Enter";
            EnterAmountBtn.UseVisualStyleBackColor = false;
            EnterAmountBtn.Click += EnterAmountBtn_Click;
            // 
            // cash500Btn
            // 
            cash500Btn.BackColor = Color.FromArgb(255, 242, 204);
            cash500Btn.BorderColor = Color.FromArgb(0, 51, 102);
            cash500Btn.BorderRadius = 30;
            cash500Btn.BorderSize = 6;
            cash500Btn.Cursor = Cursors.Hand;
            cash500Btn.FlatAppearance.BorderSize = 0;
            cash500Btn.FlatStyle = FlatStyle.Flat;
            cash500Btn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cash500Btn.ForeColor = Color.FromArgb(0, 51, 102);
            cash500Btn.Location = new Point(167, 193);
            cash500Btn.Name = "cash500Btn";
            cash500Btn.Size = new Size(120, 60);
            cash500Btn.TabIndex = 6;
            cash500Btn.Tag = 500;
            cash500Btn.Text = "500";
            cash500Btn.UseVisualStyleBackColor = false;
            cash500Btn.Click += QuickCashButton_Click;
            // 
            // cash200Btn
            // 
            cash200Btn.BackColor = Color.FromArgb(255, 242, 204);
            cash200Btn.BorderColor = Color.FromArgb(0, 51, 102);
            cash200Btn.BorderRadius = 30;
            cash200Btn.BorderSize = 6;
            cash200Btn.Cursor = Cursors.Hand;
            cash200Btn.FlatAppearance.BorderSize = 0;
            cash200Btn.FlatStyle = FlatStyle.Flat;
            cash200Btn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cash200Btn.ForeColor = Color.FromArgb(0, 51, 102);
            cash200Btn.Location = new Point(19, 193);
            cash200Btn.Name = "cash200Btn";
            cash200Btn.Size = new Size(120, 60);
            cash200Btn.TabIndex = 5;
            cash200Btn.Tag = 200;
            cash200Btn.Text = "200";
            cash200Btn.UseVisualStyleBackColor = false;
            cash200Btn.Click += QuickCashButton_Click;
            // 
            // cash100Btn
            // 
            cash100Btn.BackColor = Color.FromArgb(255, 242, 204);
            cash100Btn.BorderColor = Color.FromArgb(0, 51, 102);
            cash100Btn.BorderRadius = 30;
            cash100Btn.BorderSize = 6;
            cash100Btn.Cursor = Cursors.Hand;
            cash100Btn.FlatAppearance.BorderSize = 0;
            cash100Btn.FlatStyle = FlatStyle.Flat;
            cash100Btn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cash100Btn.ForeColor = Color.FromArgb(0, 51, 102);
            cash100Btn.Location = new Point(167, 99);
            cash100Btn.Name = "cash100Btn";
            cash100Btn.Size = new Size(120, 60);
            cash100Btn.TabIndex = 4;
            cash100Btn.Tag = 100;
            cash100Btn.Text = "100";
            cash100Btn.UseVisualStyleBackColor = false;
            cash100Btn.Click += QuickCashButton_Click;
            // 
            // cash50Btn
            // 
            cash50Btn.BackColor = Color.FromArgb(255, 242, 204);
            cash50Btn.BorderColor = Color.FromArgb(0, 51, 102);
            cash50Btn.BorderRadius = 30;
            cash50Btn.BorderSize = 6;
            cash50Btn.Cursor = Cursors.Hand;
            cash50Btn.FlatAppearance.BorderSize = 0;
            cash50Btn.FlatStyle = FlatStyle.Flat;
            cash50Btn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cash50Btn.ForeColor = Color.FromArgb(0, 51, 102);
            cash50Btn.Location = new Point(19, 99);
            cash50Btn.Name = "cash50Btn";
            cash50Btn.Size = new Size(120, 60);
            cash50Btn.TabIndex = 3;
            cash50Btn.Tag = 50;
            cash50Btn.Text = "50";
            cash50Btn.UseVisualStyleBackColor = false;
            cash50Btn.Click += QuickCashButton_Click;
            // 
            // Linevertical
            // 
            Linevertical.BackColor = Color.FromArgb(255, 242, 204);
            Linevertical.Location = new Point(310, 74);
            Linevertical.Name = "Linevertical";
            Linevertical.Size = new Size(6, 211);
            Linevertical.TabIndex = 2;
            // 
            // customAmountLabel
            // 
            customAmountLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            customAmountLabel.ForeColor = Color.FromArgb(0, 51, 102);
            customAmountLabel.Location = new Point(311, 38);
            customAmountLabel.Name = "customAmountLabel";
            customAmountLabel.Size = new Size(312, 23);
            customAmountLabel.TabIndex = 1;
            customAmountLabel.Text = "Custom Amount:";
            customAmountLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quickCashLabel
            // 
            quickCashLabel.Font = new Font("Verdana", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            quickCashLabel.ForeColor = Color.FromArgb(0, 51, 102);
            quickCashLabel.Location = new Point(3, 38);
            quickCashLabel.Name = "quickCashLabel";
            quickCashLabel.Size = new Size(312, 23);
            quickCashLabel.TabIndex = 0;
            quickCashLabel.Text = "Quick Cash:";
            quickCashLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // presentationPanel2
            // 
            presentationPanel2.BackColor = Color.FromArgb(169, 196, 235);
            presentationPanel2.Location = new Point(12, 140);
            presentationPanel2.Name = "presentationPanel2";
            presentationPanel2.Size = new Size(626, 338);
            presentationPanel2.TabIndex = 2;
            presentationPanel2.Visible = false;
            // 
            // actionLabel
            // 
            actionLabel.Font = new Font("Verdana", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            actionLabel.ForeColor = Color.FromArgb(255, 242, 204);
            actionLabel.Location = new Point(185, 49);
            actionLabel.Name = "actionLabel";
            actionLabel.Size = new Size(428, 29);
            actionLabel.TabIndex = 0;
            actionLabel.Text = "Action";
            actionLabel.TextAlign = ContentAlignment.MiddleLeft;
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
            presentationPanel.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private CustomPanel actionPanel;
        private Label actionLabel;
        private Panel presentationPanel;
        private CustomPanel customPanel1;
        private Label StepLevelLabel;
        private CustomButton selectButton;
        private Label cancelLabel;
        private Panel presentationPanel2;
        private Label quickCashLabel;
        private Label customAmountLabel;
        private Panel Linevertical;
        private CustomButton cash50Btn;
        private CustomButton cash500Btn;
        private CustomButton cash200Btn;
        private CustomButton cash100Btn;
        private CustomButton ConfirmBtn;
        private CustomButton EnterAmountBtn;
        private TextBox textBox1;
        private Label label2;
        private Label CurrentBalanceLabel;
        private Label accountNameLabel;
        private Label confirmationMessageActionLabel;
        private Label ValidationErrorLabel;
        private CustomButton SuccessBtn;
        private CustomButton DeclinedBtn;
    }
}
