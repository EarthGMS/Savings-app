using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsApp.Codes
{
    class Account_Data
    {
        public static long MoneyVolume;

        public void CalculateTransaction(int moneyTransaction)
        {
            MoneyVolume += moneyTransaction;
            MessageBox.Show(MoneyVolume.ToString());
        }
    }
}
