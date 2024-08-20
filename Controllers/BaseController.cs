using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankSystem.Components;
using BankSystem.Models;

namespace BankSystem.Controllers
{

    public partial class BaseController : UserControl
    {


        public BaseController()
        {

            InitializeComponent();
        }

        public AccountCardController accountCard1 => accountCardController1;
        public AccountCardController accountCard2 => accountCardController2;
        public AccountCardController accountCard3 => accountCardController3;



        public void LoadAccountCards()
        {
            var currentUser = Customer.CurrentUser;
            
            if (currentUser == null)
                return;

            SetupAccountCard(accountCard1, currentUser.Accounts[0]);
            SetupAccountCard(accountCard2, currentUser.Accounts[1]);
            SetupAccountCard(accountCard3, currentUser.Accounts[2]);


        }

        private void SetupAccountCard(AccountCardController accountcard, Account account)
        {
            accountcard.AccountName = account.AccountName;
            accountcard.Balance = account.Balance;
            accountcard.AccountImage = GetAccountImage(account.AccountName);
            accountcard.AccountCardClicked += AccountCard_Clicked;
        }

        private Image GetAccountImage(string accountName)
        {
            switch (accountName)
            {
                case "Everyday":
                    var image1= ResizeImage(Properties.Resources.Everyday, 110, 110);
                    return image1;
                case "Omni":
                    var image2 = ResizeImage(Properties.Resources.Omni, 110, 110);
                    return image2;
                case "Invest":
                    var image3 = ResizeImage(Properties.Resources.Invest, 110, 110);
                    return image3;
                default:
                    return null;
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

        private void AccountCard_Clicked(object sender, EventArgs e)
        {
            var card = sender as AccountCardController;
            if (card != null)
            {
                MessageBox.Show($"Account {card.AccountName} clicked");
            }
        }
    }
}
