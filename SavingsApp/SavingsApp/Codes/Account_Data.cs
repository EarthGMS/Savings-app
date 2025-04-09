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
        public static long IncomeText;
        public static long ExpenseText;
        public void CalculateTransaction(int moneyTransaction)
        {
            MoneyVolume += moneyTransaction;
            if(moneyTransaction > 0)
            {
                IncomeText += moneyTransaction;
            }
            else
            {
                ExpenseText += moneyTransaction;
            }
        }
    }
}
