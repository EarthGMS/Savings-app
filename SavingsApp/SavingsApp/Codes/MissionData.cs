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
    class MissionData
    {
        public string missionName { get; set; }
        public long missionValue { get; set; }
        public DateTime missionDate { get; set; }

        public static List<MissionData> missionList = new List<MissionData>();

        public void SaveMissionData(string name, long value, DateTime date)
        {
            var missionData = new MissionData
            {
                missionName = name,
                missionValue = value,
                missionDate = date
            };
            missionList.Add(missionData);
        }


        public void MissionDataToJson()
        {

            string json = JsonSerializer.Serialize(missionList, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("MissionData.json", json);
        }

        public void LoadMissionData()
        {
            if (File.Exists("MissionData.json"))
            {
                string json = File.ReadAllText("MissionData.json");
                var MissionsInJson = JsonSerializer.Deserialize<List<MissionData>>(json);

                if (MissionsInJson != null)
                {
                    missionList = MissionsInJson;
                }
            }
        }
    }
}
