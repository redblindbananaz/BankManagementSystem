using BankSystem.Components;
using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Controllers
{
    public partial class AccountsController : UserControl
    {
       
        public ActionController  DepositController { get; set; }
        public ActionController WithdrawController { get; set; }

        public AccountsController()
        {

            InitializeComponent();
        
        }

        public AccountCardController accountCard1 => accountCardController1;
        public AccountCardController accountCard2 => accountCardController2;
        public AccountCardController accountCard3 => accountCardController3;

        




        public void LoadAccountCards()
        {
            var currentUser = User.CurrentUser;

            if (currentUser == null)
                return;

            SetupAccountCard(accountCard1, currentUser.Accounts[0]);
            SetupAccountCard(accountCard2, currentUser.Accounts[1]);
            SetupAccountCard(accountCard3, currentUser.Accounts[2]);


        }

        private void SetupAccountCard(AccountCardController accountcard, Account account)
        {
            //Unsubscribe to the AccountCardClicked event to solve multiple time click on ok messagebox tests:
            accountcard.AccountCardClicked -= AccountCard_Clicked;

            accountcard.AccountName = account.AccountName;
            accountcard.Balance = account.Balance;
            accountcard.AccountId = account.AccountID;
            accountcard.AccountImage = GetAccountImage(account.AccountName);

            //Subscribe to the AccountCardClicked event
            accountcard.AccountCardClicked += AccountCard_Clicked;
        }

        private Image GetAccountImage(string accountName)
        {
            switch (accountName)
            {
                case "Everyday":
                    var image1 = ResizeImage(Properties.Resources.Everyday, 110, 110);
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

        private string? _selectedAccountName;
        private int? _selectedAccountID;
        private decimal _selectedAccountBalance;

       
        private void AccountCard_Clicked(object sender, AccountCardClickedEventArgs  e)
        {
            
            var card = sender as AccountCardController;
            if (card != null )
            {
                _selectedAccountName = card.AccountName;
                _selectedAccountID = card.AccountId;
                _selectedAccountBalance = card.Balance;


                HighlightSelection(card);
               
                //OnAccountClickedInController(sender, e);

            }
        }

        protected virtual void OnAccountClickedInController(object sender, AccountCardClickedEventArgs e)
        {
            // This could be used to pass an event to another controller:
            // someController.HandlingthisCLicked(e);
            
        }

        // public void HandlingthisCLicked(AccountCardClickedEventArgs e){
        //     MessageBox.Show($"Handled in another controller: Account {e.AccountName} ");}

        private void HighlightSelection(AccountCardController selectedCard)
        {
            ResetAllHighlight();

            selectedCard.SetSelectedStyle(true);
        }

        private void ResetAllHighlight()
        {
            accountCard1.SetSelectedStyle(false);
            accountCard2.SetSelectedStyle(false);
            accountCard3.SetSelectedStyle(false);
        }
    } 
}


