using SavingsApp.Codes;
using System;
using System.Windows.Forms;

namespace SavingsApp
{
    public partial class TransactionForm: Form
    {
        int isPocketNegative;
        Account_Data account;
        float taxAmount;
        public TransactionForm()
        {
            InitializeComponent();
            PocketList.SelectedIndex = 0;
            account = new Account_Data();
        }

        private void AcceptForm_Click(object sender, EventArgs e)
        {
            float number_check;
            if (TransactionValue.Text != null && float.TryParse(TransactionValue.Text, out number_check))
            {
                if (float.Parse(TransactionValue.Text) < 0)
                {
                    taxAmount = -account.CalculatePercentage(Math.Abs(float.Parse(PercentageBox.Text)), float.Parse(TransactionValue.Text));
                }
                isPocketNegative = account.checkPocketNegative(float.Parse(TransactionValue.Text), taxAmount, PocketList.SelectedIndex);
                if (isPocketNegative == 1)
                {
                    MessageBox.Show("กรุณาเลือกกระเป๋าเงินที่มีเงินเพียงพอ");
                    taxAmount = 0;
                    return;
                }
                account.CalculateTransaction(float.Parse(TransactionValue.Text) + taxAmount);
                account.PocketTransaction(float.Parse(TransactionValue.Text) + taxAmount, PocketList.SelectedIndex);

                TransactionData transactionData = new TransactionData();
                transactionData.SaveTransactionData(TransactionName.Text, float.Parse(TransactionValue.Text), taxAmount, PocketList.SelectedIndex, DateWrittenBox.Value);
                Hide();
            }
            else
            {
                if (!float.TryParse(TransactionValue.Text, out number_check))
                {
                    MessageBox.Show("กรุณากรอกตัวเลข");
                }
            }
        }
    }
}
