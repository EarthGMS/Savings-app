using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsApp.Codes
{
    class Account_Data
    {
        public long MoneyVolume = 3000;

        public void CalculateTransaction(int moneyTransaction)
        {
            MoneyVolume += moneyTransaction;
        }
    }
}
