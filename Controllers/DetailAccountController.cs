using BankSystem.Components;
using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            AccountdetailNameLabel.Text = $"Your {account} Account";


            if (account != "Everyday")
            {
                AddingInterestLayout();
                featuresLabel.Text = account == "Invest" ? Ifeatures : Ofeatures;
                ImagePanel.BackgroundImage = account == "Invest" ? InvestImage : OmniImage;
                label2.Text =$" Your Balance: $ {balance}";
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

            // Calculate the interest rates.
            NoBtn.Visible = true;
            YesBtn.Visible = true;
            InterestLabel.Visible = true;
            if (_currentAccount == "Invest")
            {
                decimal investInterest = Invest.CalculateInterest(_balance);
                InterestLabel.Text = $"${investInterest}";

            }
            else
            {
                decimal OmniInterest = Omni.CalculateInterest(_balance);
                InterestLabel.Text = $"${OmniInterest}";
            }

        }


        private void YesBtn_Click(object sender, EventArgs e)
        {
            // ADd the interest to The Account:

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
