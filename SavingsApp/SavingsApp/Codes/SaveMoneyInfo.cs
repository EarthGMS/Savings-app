using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace SavingsApp.Codes
{
    class SaveMoneyInfo
    {
        public long ReserveInfo { get; set; }
        public long BillInfo { get; set; }
        public long ConsumptionInfo { get; set; }
        public long TravelInfo { get; set; }
        public long WantsInfo { get; set; }

        public void SaveMoneyData(long reserve, long bill, long consumption, long travel, long wants)
        {
            var data = new SaveMoneyInfo
            {
                ReserveInfo = reserve,
                BillInfo = bill,
                ConsumptionInfo = consumption,
                TravelInfo = travel,
                WantsInfo = wants
            };

            string json = JsonSerializer.Serialize(data);
            File.WriteAllText("MoneyData.json", json);
        }
        public void LoadMoneyData()
        {
            if (File.Exists("MoneyData.json"))
            {
                string json = File.ReadAllText("MoneyData.json");
                SaveMoneyInfo info = JsonSerializer.Deserialize<SaveMoneyInfo>(json);
                Account_Data.SavingsVolume = info.ReserveInfo;
                Account_Data.BillVolume = info.BillInfo;
                Account_Data.MealsVolume = info.ConsumptionInfo;
                Account_Data.TravelVolume = info.TravelInfo;
                Account_Data.WantsVolume = info.WantsInfo;
            }
        }
    }
}
