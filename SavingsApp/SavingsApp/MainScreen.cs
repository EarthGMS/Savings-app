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
        public Form1()
        {
            InitializeComponent();
            List<Panel> panels = new List<Panel>();
            panels.Add(AccountPanel);
            panels.Add(MonthlyPanel);
        }

        private void SpendingTab_Click(object sender, EventArgs e)
        {
            TransactionForm transaction = new TransactionForm();
            transaction.Show();
        }

        private void PocketMenuTab_Click(object sender, EventArgs e)
        {
            AccountPanel.Visible = true;
            MonthlyPanel.Visible = false;
        }

        private void AnalysisTab_Click(object sender, EventArgs e)
        {
            MonthlyPanel.Visible = true;
            AccountPanel.Visible = false;
        }
    }
}
