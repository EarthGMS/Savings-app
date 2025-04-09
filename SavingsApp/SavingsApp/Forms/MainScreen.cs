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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Panel> panels = new List<Panel>();
            panels.Add(AccountPanel);
            panels.Add(MonthlyPanel);
            CurrentTimeText.Text = DateTime.Now.ToString("MM-yyyy");
           
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
            MoneyLabel.Text = Account_Data.MoneyVolume.ToString();
        }

        private void AnalysisTab_Click(object sender, EventArgs e)
        {
            MonthlyPanel.Visible = true;
            AccountPanel.Visible = false;
            IncomeTextDisplay.Text = "รายได้ : " + Account_Data.IncomeText.ToString() + " บาท";
            ExpenseTextDisplay.Text = "รายจ่าย : " + Math.Abs(Account_Data.ExpenseText).ToString() + " บาท";
        }

        private void IncomeTextDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
