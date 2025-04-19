using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingsApp.Codes
{
    class MissionData
    {
        public string missionName { get; set; }
        public long missionValue { get; set; }
        public long missionDay { get; set; }

        public static List<MissionData> missionList = new List<MissionData>();

        public void SaveMissionData(string name, long value, long day)
        {
            var missionData = new MissionData
            {
                missionName = name,
                missionValue = value,
                missionDay = day
            };
            missionList.Add(missionData);
        }
    }
}
