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
            MissionData missionData = new MissionData();
            missionData.SaveMissionData(nameTextBox.Text, long.Parse(priceTextBox.Text), TargetDate.Value);
            Hide();
        }
    }
}
