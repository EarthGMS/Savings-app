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
            DateTime CurrentTime = DateTime.Now;
            InitializeComponent();
            MissionDataGridBox.Rows.Clear();
            for (int i = 0; i < MissionData.missionList.Count; i++)
            {
                TimeSpan duration = MissionData.missionList[i].missionDate - CurrentTime;
                MissionDataGridBox.Rows.Add(MissionData.missionList[i].missionName, MissionData.missionList[i].missionValue, (int)duration.TotalDays);
            }
            CurrentSaving.Text = "จำนวนเงินเก็บ : " + Account_Data.SavingsVolume.ToString() + " บาท";
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
            if (e.RowIndex < 0)
            {
                return;
            }
            if (int.Parse(MissionDataGridBox.CurrentRow.Cells[3].Value?.ToString()) > Account_Data.SavingsVolume)
            {
                MessageBox.Show("ยังไม่ถึงกำหนดการเก็บเงิน");
            }
            else
            {
                Account_Data account = new Account_Data();
                account.PocketTransaction(-int.Parse(MissionDataGridBox.CurrentRow.Cells[1].Value?.ToString()), 0);
                MissionDataGridBox.Rows.RemoveAt(MissionDataGridBox.CurrentRow.Index);
            }
        }
    }
}
