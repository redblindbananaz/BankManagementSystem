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
using BankSystem.Controllers;

namespace BankSystem.Controllers
{
    

    public partial class BaseController : UserControl
    {
        public AccountsController AccountsController1 => accountsController1;
        public BaseController()
        {
            InitializeComponent();
            
        }
    }
}
