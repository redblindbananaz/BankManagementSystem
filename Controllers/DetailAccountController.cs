using BankSystem.Models;

namespace BankSystem.Controllers
{
    public partial class DetailAccountController : UserControl
    {
        public event EventHandler CancelClicked;

        private decimal _balance;
        private string _currentAccount;
        private int _id;
        public DetailAccountController()
        {
            InitializeComponent();
        }

        public void InitializeDetailAccountLayout(string account, decimal balance, int id)
        {
            _balance = balance;
            _currentAccount = account;
            _id = id;

            string Efeatures = "- No Interest Rates\n- No Overdraft\n- No Transaction Fees";
            string Ifeatures = "- Variable Interest Rates\n- No Overdraft\n- Failed Transaction Fees\n- Calculate And Add Interest";
            string Ofeatures = "- Interest Rates Over $1000 Balance\n- Overdraft Available\n- Failed Transaction Fees\n- Calculate And Add Interest";


            var EverydayImage = ResizeImage(Properties.Resources.Everyday, 200, 200);
            var InvestImage = ResizeImage(Properties.Resources.Invest, 200, 200);
            var OmniImage = ResizeImage(Properties.Resources.Omni, 200, 200);

            NoBtn.Text = " No, Thank You";

            AccountdetailNameLabel.Text = $"Your {account} Account";


            if (account != "Everyday")
            {
                AddingInterestLayout();
                featuresLabel.Text = account == "Invest" ? Ifeatures : Ofeatures;
                ImagePanel.BackgroundImage = account == "Invest" ? InvestImage : OmniImage;
                label2.Text = $" Your Balance: $ {balance}";
                InterestrateLabel.Text = account == "Invest" ? $"Your Rate:{Invest.InterestRate}" : $"Your Rate:{Omni.InterestRate}";
            }
            else
            {
                featuresLabel.Text = Efeatures;
                ImagePanel.BackgroundImage = EverydayImage;
                homeBtn.Visible = true;
                CompleteInterestPanel.Visible = false;
            }

        }
        public Image ResizeImage(Image image, int width, int height)
        {
            var resizedImage = new Bitmap(width, height);
            using (var graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        public void AddingInterestLayout()
        {

            CompleteInterestPanel.Visible = true;
            NoBtn.Visible = false;
            YesBtn.Visible = false;
            interestquestionlabel.Visible = false;
            InterestLabel.Visible = false;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (_balance <= 0)
            {
                ShowError("You Have No Balance To Calculate Interest");
                return;
            }

            if (_currentAccount == "Invest")
            {
                decimal investInterest = Invest.CalculateInterest(_balance);
                InterestLabel.Visible = true;
                InterestLabel.Text = $"${investInterest:F2}";
                ShowInterestOptions($"Would you like to add this interest of {investInterest:F2} to your account {_currentAccount}?");

            }
            else if (_currentAccount == "Omni")
            {
                if (_balance < 1000)
                {
                    ShowError("You Need A Balance Of $1000 To Calculate Interest");

                }
                else
                {
                    decimal OmniInterest = Omni.CalculateInterest(_balance);
                    InterestLabel.Visible = true;
                    InterestLabel.Text = $"${OmniInterest:F2}";
                    ShowInterestOptions($"Would you like to add this interest of {OmniInterest:F2} to your account {_currentAccount}?");
                }

            }

        }

        private void ShowInterestOptions(string message)
        {
            interestquestionlabel.Visible = true;
            interestquestionlabel.Text = message;
            YesBtn.Visible = true;
            NoBtn.Visible = true;
        }

        private void ShowError(string Errormessage)
        {
            interestquestionlabel.Visible = true;
            interestquestionlabel.Text = Errormessage;
            YesBtn.Visible = false;
            NoBtn.Visible = true;
            NoBtn.Text = "Error, Click Here To Return Home";
        }


        private void YesBtn_Click(object sender, EventArgs e)
        {
            if (YesBtn.Visible == true)
            {
                if (_currentAccount == "Invest")
                {
                    decimal investInterest = Invest.CalculateInterest(_balance);
                    
                   Invest.AddInterest(investInterest);
                    ShowError("Interest Added Successfully");
                    YesBtn.Visible = false;
                    NoBtn.Text = "Return Home";
                }
                else if (_currentAccount == "Omni")
                {
                    decimal OmniInterest = Omni.CalculateInterest(_balance);
                    Omni omni = new Omni(_currentAccount, _balance);
                    omni.AddInterest(OmniInterest);
                    ShowError("Interest Added Successfully");
                    YesBtn.Visible = false;
                    NoBtn.Text = "Return Home";
                }
            }

            else
            {
                CancelClicked?.Invoke(this, EventArgs.Empty);
            }   

        }

        private void NoBtn_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
