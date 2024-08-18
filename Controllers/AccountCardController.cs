using BankSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankSystem.Controllers
{
    public partial class AccountCardController : UserControl
    {
        private Account account;
        public AccountCardController(Account account)
        {
            InitializeComponent();
            this.account = account;
            SetupCard();
        }

        private void SetupCard()
        {
            accountNameLabel.Text = account.GetType().Name;
            accountIDLabel.Text = account.AccountID.ToString();
            accountButton.BackgroundImage = GetAccountImage(account.GetType());
            balanceLabel.Text = account.Balance.ToString("C");
        }

        private Image GetAccountImage(Type accountType)
        {
            if (accountType == typeof(Everyday))
            {
                return Properties.Resources.everyday;
            }
            if (accountType == typeof(Omni))
            {
                return Properties.Resources.omni;
            }
            else if (accountType == typeof(Invest))
            {
                return Properties.Resources.invest;
            }
            return null;
        }
        }
}
