using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsApp.Codes
{
    class TransactionData
    {
        public string transactionName { get; set; }
        public long transactionValue { get; set; }

        public static List<TransactionData> transactionList = new List<TransactionData>();

        public void SaveTransactionData(string name, long value)
        {
            var transactionData = new TransactionData
            {
                transactionName = name,
                transactionValue = value
            };

            transactionList.Add(transactionData);
        }

    }
}
