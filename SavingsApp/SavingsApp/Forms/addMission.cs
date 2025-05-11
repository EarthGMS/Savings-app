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
    public partial class addMission: Form
    {
        public addMission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add a new mission
            float number_check;
            MissionData missionData = new MissionData();
            if (!float.TryParse(priceTextBox.Text, out number_check))
            {
                MessageBox.Show("กรุณากรอกตัวเลข");
            }
            else
            {
                missionData.SaveMissionData(nameTextBox.Text, float.Parse(priceTextBox.Text), TargetDate.Value);
            }
            Hide();
        }
    }
}
