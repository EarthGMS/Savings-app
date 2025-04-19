using SavingsApp.Codes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingsApp.Forms
{
    public partial class Mission: Form
    {
        public Mission()
        {
            InitializeComponent();
            for (int i = 0; i < MissionData.missionList.Count; i++)
            {
                MissionDataGridBox.Rows.Add(MissionData.missionList[i].missionName, MissionData.missionList[i].missionValue, MissionData.missionList[i].missionDay);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addMissionButton_Click(object sender, EventArgs e)
        {
            addMission addMission = new addMission();
            addMission.Show();
        }

        private void MissionData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
