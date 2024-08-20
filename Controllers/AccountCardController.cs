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
    public partial class AccountCardController : UserControl
    {
        
        
        public AccountCardController()
        {
            InitializeComponent();
            //accountButton.BringToFront();
            
            
        }

        public  string AccountName
        {
            get => accountNameLabel.Text;
            set => accountNameLabel.Text = value.ToString();
            
        }

        public int AccountID
        {
            get => int.Parse(accountIDLabel.Text);
            set => accountIDLabel.Text = value.ToString();
        }

        public decimal Balance
        {
            get => decimal.Parse(balanceLabel.Text.Trim('$'));
            set => balanceLabel.Text = $"${value:F2}";
        }
        public Image AccountImage
        {
            get => accountButton.Image;
            set => accountButton.Image = value;
        }
        
        //Event to handle when the card is clicked
        public event EventHandler AccountCardClicked;

        private void AccountCardController_Click(object sender, EventArgs e)
        {
            AccountCardClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
