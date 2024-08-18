using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BankSystem.Controllers
{
    public enum ActionType
    {
        Deposit,
        Withdraw,
    }
    public partial class ActionController : UserControl
    {
        private ActionType currentAction;

        public event EventHandler CancelClicked;
        public ActionController(ActionType actionType)
        {
            InitializeComponent();
            currentAction = actionType;
            SetupUI();
        }

        private void SetupUI()
        {
            if (currentAction == ActionType.Deposit)
            {
                actionLabel.Text = "Deposit";

            }
            else if (currentAction == ActionType.Withdraw)
            {
                actionLabel.Text = "Withdraw";

            }
        }

        private void cancelLabel_Click(object sender, EventArgs e)
        {
            CancelClicked?.Invoke(this, EventArgs.Empty);

        }
    }
}
