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
            pictureBox1.Image = GetAccountImage(account.GetType());
            //accountButton.BackgroundImage = GetAccountImage(account.GetType());
            accountButton.BringToFront();
            balanceLabel.Text = account.Balance.ToString("C");
        }

        private Image GetAccountImage(Type accountType)
        {
            if (accountType == typeof(Everyday))
            {
                return Properties.Resources.Everyday;
            }
            if (accountType == typeof(Omni))
            {
                return Properties.Resources.Omni;
            }
            else if (accountType == typeof(Invest))
            {
                return Properties.Resources.Invest;
            }
            return null;
        }
        }
}
