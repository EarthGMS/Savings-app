using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace SavingsApp.Codes
{
    class SaveInfo
    {
        public long CurrentSavings { get; set; }
        public long CurrentExpenses { get; set; }
        public int CurrentMonth { get; set; }

        private void SaveData()
        {
            var data = new SaveInfo
            {
                CurrentSavings = Account_Data.IncomeText,
                CurrentExpenses = Account_Data.ExpenseText,
                CurrentMonth = int.Parse(DateTime.Now.ToString("MM-yyyy"))
            };

            string json = JsonSerializer.Serialize(data);
            File.WriteAllText("AnalysisData.json", json);
        }
    }
}

