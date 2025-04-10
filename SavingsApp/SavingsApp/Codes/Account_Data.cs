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
        public static long SavingsVolume;
        public static long BillVolume;
        public static long MealsVolume;
        public static long TravelVolume;
        public static long WantsVolume;


        public static long IncomeText;
        public static long ExpenseText;
        public void CalculateTransaction(int moneyTransaction)
        {
            if(moneyTransaction > 0)
            {
                IncomeText += moneyTransaction;
            }
            else
            {
                ExpenseText += moneyTransaction;
            }
        }

        public void PocketTransaction(int moneyTransaction, int PocketType)
        {
            if (PocketType == 0)
            {
                SavingsVolume += moneyTransaction;
            }
            else if (PocketType == 1)
            {
                BillVolume += moneyTransaction;
            }
            else if (PocketType == 2)
            {
                MealsVolume += moneyTransaction;
            }
            else if (PocketType == 3)
            {
                TravelVolume += moneyTransaction;
            }
            else if (PocketType == 4)
            {
                WantsVolume += moneyTransaction;

            }
        }

        public void CalculatePercentage(float percentage, float expense)
        {
            float taxRate = Math.Abs(expense) * percentage / 100;
            SavingsVolume += (long)taxRate;
        }
    }
}
