using SavingsApp.Codes;
using SavingsApp.Forms;
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
            setupTransactionData();
        }

        public void BootInfo()
        {
            info.LoadData();
        }

        private void SpendingTab_Click(object sender, EventArgs e)
        {
            MonthlyPanel.Visible = false;
            transactionPanel.Visible = true;
            AccountPanel.Visible = false;
            setupTransactionData();
        }

        private void PocketMenuTab_Click(object sender, EventArgs e)
        {
            AccountPanel.Visible = true;
            transactionPanel.Visible = false;
            MonthlyPanel.Visible = false;
            PocketSetup();
        }

        private void AnalysisTab_Click(object sender, EventArgs e)
        {
            MonthlyPanel.Visible = true;
            transactionPanel.Visible = false;
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
            chart1.Series["Income"].Points.AddXY(DateTime.Now.ToString("MM-yyyy"), Account_Data.IncomeText);
            chart1.Series["Expenses"].Points.AddXY(DateTime.Now.ToString("MM-yyyy"), Math.Abs(Account_Data.ExpenseText));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            info.SaveData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mission missionWindow = new Mission();
            missionWindow.Show();
        }

        private void addTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Show();
        }

        //TRANSACTION DATA FUNCTION
        void setupTransactionData()
        {
            for (int i = 0; i < TransactionData.transactionList.Count(); i++)
            {
                transactionGridView.Rows.Add(TransactionData.transactionList[i].transactionName, TransactionData.transactionList[i].transactionValue, "");
            }
        }
    }
}
