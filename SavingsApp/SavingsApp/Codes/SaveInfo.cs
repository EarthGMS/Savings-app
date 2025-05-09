using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace SavingsApp.Codes
{
    class SaveInfo
    {
        public float CurrentSavings { get; set; }
        public float CurrentExpenses { get; set; }
        public int CurrentMonth { get; set; }

        public void SaveData()
        {
            var data = new SaveInfo
            {
                CurrentSavings = Account_Data.IncomeText,
                CurrentExpenses = Account_Data.ExpenseText,
                CurrentMonth = int.Parse(DateTime.Now.ToString("MM"))
            };

            string json = JsonSerializer.Serialize(data);
            File.WriteAllText("AnalysisData.json", json);
        }

        public void SaveTransactionData()
        {

        }

        public void SaveMissionData()
        {

        }

        public void LoadData()
        {
            if (File.Exists("AnalysisData.json"))
            {
                string json = File.ReadAllText("AnalysisData.json");
                SaveInfo info = JsonSerializer.Deserialize<SaveInfo>(json);
                Account_Data.IncomeText = info.CurrentSavings;
                Account_Data.ExpenseText = info.CurrentExpenses;
            }
        }
    }
}

