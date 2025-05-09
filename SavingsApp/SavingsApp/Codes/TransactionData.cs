using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections;

namespace SavingsApp.Codes
{
    class TransactionData
    {
        public string transactionName { get; set; }
        public float transactionValue { get; set; }
        public float transactionType { get; set; }
        public DateTime transactionDate { get; set; }

        public static List<TransactionData> transactionList = new List<TransactionData>();

        public void SaveTransactionData(string name, float value, float taxRate, int type, DateTime date)
        {
            var transactionData = new TransactionData
            {
                transactionName = name,
                transactionValue = value + taxRate,
                transactionType = type,
                transactionDate = date
            };

            transactionList.Add(transactionData);
        }

        public void TransactionDataToJson()
        {

            string json = JsonSerializer.Serialize(transactionList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("TransactionData.json", json);
        }

        public void LoadTransactionData()
        {
            if (File.Exists("TransactionData.json"))
            {
                string json = File.ReadAllText("TransactionData.json");
                var DerserializedTransaction = JsonSerializer.Deserialize<List<TransactionData>>(json);

                if (DerserializedTransaction != null)
                {
                    transactionList = DerserializedTransaction;
                }
            }
        }
    }
}
