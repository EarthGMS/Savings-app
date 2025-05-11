using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsApp.Codes
{
    class Account_Data
    {
        public static float SavingsVolume;
        public static float BillVolume;
        public static float MealsVolume;
        public static float TravelVolume;
        public static float WantsVolume;


        public static float IncomeText;
        public static float ExpenseText;
        public void CalculateTransaction(float moneyTransaction)
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

        public void PocketTransaction(float moneyTransaction, int PocketType)
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

        public float CalculatePercentage(float percentage, float expense)
        {
            float taxRate = Math.Abs(expense) * percentage / 100;
            SavingsVolume += (long)taxRate;
            return taxRate;
        }

        public int checkPocketNegative(float originalValue, float taxValue, int PocketType)
        {
            float result = 0;
            if (PocketType == 0)
            {
                result = SavingsVolume + (originalValue + taxValue);
            }
            else if (PocketType == 1)
            {
                result = BillVolume + (originalValue + taxValue);
            }
            else if (PocketType == 2)
            {
                result = MealsVolume + (originalValue + taxValue);
            }
            else if (PocketType == 3)
            {
                result = TravelVolume + (originalValue + taxValue);
            }
            else if (PocketType == 4)
            {
                result = WantsVolume + (originalValue + taxValue);

            }
            if(result < 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
