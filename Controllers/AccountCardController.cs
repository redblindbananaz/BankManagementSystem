using BankSystem.Components;


namespace BankSystem.Controllers
{
    public partial class AccountCardController : UserControl
    {
        //Event to handle when the card is clicked
        public event EventHandler<AccountCardClickedEventArgs> AccountCardClicked;

        public AccountCardController()
        {
            InitializeComponent();
            //accountButton.BringToFront();
            accountButton.Click += AccountCardController_Click;
        }

        // Properties to access the button and label outisde the class
        public Button AccountButton => accountButton;
        public Label AccountNameLabel => accountNameLabel;
        public Label BalanceLabel => balanceLabel;


        public string AccountName
        {
            get => accountNameLabel.Text;
            set => accountNameLabel.Text = value;
        }
        public int AccountId { get; set; }

        public decimal Balance
        {
            get => decimal.Parse(balanceLabel.Text.Trim('$'));
            set => balanceLabel.Text = $"${value:F2}";
        }

        public Image? AccountImage
        {
            get => accountButton.Image;
            set => accountButton.Image = value;
        }

        private void AccountCardController_Click(object sender, EventArgs e)
        {

            AccountCardClicked?.Invoke(this, new AccountCardClickedEventArgs
            (AccountName, Balance, AccountId));

        }


        public void SetSelectedStyle(bool isSelected)
        {
            if (isSelected)
            {
                //Change style when selected
                accountButton.BorderColor = CustomColors.Orange;
                accountButton.BorderSize = 8;
                accountNameLabel.ForeColor = CustomColors.Orange;
                balanceLabel.ForeColor = CustomColors.Orange;
            }
            else
            {
                //Reset to default style
                accountButton.BorderColor = CustomColors.DeepBLue;
                accountButton.BorderSize = 6;
                accountNameLabel.ForeColor = CustomColors.DeepBLue;
                balanceLabel.ForeColor = CustomColors.DeepBLue;
            }

        }

    }



}
