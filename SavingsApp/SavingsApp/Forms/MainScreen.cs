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
        SaveInfo info;
        public Form1()
        {
            InitializeComponent();
            List<Panel> panels = new List<Panel>();
            panels.Add(AccountPanel);
            panels.Add(MonthlyPanel);
            CurrentTimeText.Text = DateTime.Now.ToString("MM-yyyy");
            info = new SaveInfo();
            BootInfo();
            PocketSetup();
            AnalysisSetup();
        }

        public void BootInfo()
        {
            info.LoadData();
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
            PocketSetup();
        }

        private void AnalysisTab_Click(object sender, EventArgs e)
        {
            MonthlyPanel.Visible = true;
            AccountPanel.Visible = false;
            AnalysisSetup();
        }

        private void IncomeTextDisplay_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        void PocketSetup()
        {
            SavingsPocket.Text = "เงินเก็บ : " + Account_Data.SavingsVolume.ToString() + " บาท";
            BillPocket.Text = "ค่าบิล : " + Account_Data.BillVolume.ToString() + " บาท";
            MealsPocket.Text = "ค่ากิน : " + Account_Data.MealsVolume.ToString() + " บาท";
            TravelPocket.Text = "ค่าเที่ยว : " + Account_Data.TravelVolume.ToString() + " บาท";
            WantsPocket.Text = "เงินฟุ่มเฟือย : " + Account_Data.WantsVolume.ToString() + " บาท";
        }

        void AnalysisSetup()
        {
            IncomeTextDisplay.Text = "รายได้ : " + Account_Data.IncomeText.ToString() + " บาท";
            ExpenseTextDisplay.Text = "รายจ่าย : " + Math.Abs(Account_Data.ExpenseText).ToString() + " บาท";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            info.SaveData();
        }
    }
}
