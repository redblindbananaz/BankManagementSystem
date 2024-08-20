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
            LoadAccountCards();

        }

        private void LoadAccountCards()
        {
            var currentUser = Customer.CurrentUser;
            if (currentUser == null)
                return;

            foreach (var account in currentUser.Accounts)
            {
                var accountCard = new AccountCardController
                {
                    AccountName = account.AccountName.ToString(),
                    AccountID = account.AccountID,
                    Balance = account.Balance,
                    AccountImage = GetAccountImage(account.AccountName)


                };
                accountCard.AccountCardClicked += AccountCard_Clicked;
                flowLayoutPanel1.Controls.Add(accountCard);
            }
        }

        private Image GetAccountImage(AccountName accountName)
        {
            switch (accountName)
            {
                case AccountName.Everyday:
                    return Properties.Resources.Everyday;
                case AccountName.Omni:
                    return Properties.Resources.Omni;
                case AccountName.Invest:
                    return Properties.Resources.Invest;
                default:
                    return null;
            }
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
