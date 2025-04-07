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
            account = new Account_Data();
        }

        private void AcceptForm_Click(object sender, EventArgs e)
        {
            Hide();
            account.CalculateTransaction(int.Parse(TransactionValue.Text));
        }
    }
}
