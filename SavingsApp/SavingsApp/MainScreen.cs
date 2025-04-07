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
    public partial class Form1: Form
    {
        TransactionForm transaction = new TransactionForm();
        public Form1()
        {
            InitializeComponent();
        }

        private void SpendingTab_Click(object sender, EventArgs e)
        {
            transaction.Show();
        }
    }
}
