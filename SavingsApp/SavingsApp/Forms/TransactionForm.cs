using SavingsApp.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsApp
{
    public partial class TransactionForm: Form
    {
        Account_Data account;
        public TransactionForm()
        {
            InitializeComponent();
            PocketList.SelectedIndex = 0;
            account = new Account_Data();
        }

        private void AcceptForm_Click(object sender, EventArgs e)
        {
            if(TransactionValue.Text != null)
            {
                account.CalculateTransaction(int.Parse(TransactionValue.Text));
                account.PocketTransaction(int.Parse(TransactionValue.Text), PocketList.SelectedIndex);
                if(int.Parse(TransactionValue.Text) < 0)
                {
                    account.CalculatePercentage(int.Parse(PercentageBox.Text), int.Parse(TransactionValue.Text));
                }
            }
            Hide();
        }
    }
}
