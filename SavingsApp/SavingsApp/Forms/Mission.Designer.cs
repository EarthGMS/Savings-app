namespace SavingsApp.Forms
{
    partial class Mission
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.MissionData = new System.Windows.Forms.DataGridView();
            this.addMissionButton = new System.Windows.Forms.Button();
            this.MissionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishMission = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MissionData)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ภารกิจ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MissionData
            // 
            this.MissionData.AllowUserToAddRows = false;
            this.MissionData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MissionData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MissionName,
            this.MissionValue,
            this.Day,
            this.FinishMission});
            this.MissionData.Location = new System.Drawing.Point(70, 105);
            this.MissionData.Name = "MissionData";
            this.MissionData.RowHeadersVisible = false;
            this.MissionData.Size = new System.Drawing.Size(533, 292);
            this.MissionData.TabIndex = 1;
            // 
            // addMissionButton
            // 
            this.addMissionButton.Location = new System.Drawing.Point(70, 74);
            this.addMissionButton.Name = "addMissionButton";
            this.addMissionButton.Size = new System.Drawing.Size(93, 25);
            this.addMissionButton.TabIndex = 2;
            this.addMissionButton.Text = "เพิ่มภารกิจ";
            this.addMissionButton.UseVisualStyleBackColor = true;
            this.addMissionButton.Click += new System.EventHandler(this.addMissionButton_Click);
            // 
            // MissionName
            // 
            this.MissionName.HeaderText = "ชื่อภารกิจ";
            this.MissionName.Name = "MissionName";
            this.MissionName.Width = 230;
            // 
            // MissionValue
            // 
            this.MissionValue.HeaderText = "จำนวนเงิน";
            this.MissionValue.Name = "MissionValue";
            this.MissionValue.Width = 150;
            // 
            // Day
            // 
            this.Day.HeaderText = "วัน";
            this.Day.Name = "Day";
            this.Day.Width = 50;
            // 
            // FinishMission
            // 
            this.FinishMission.HeaderText = "เสร็จสิ้นภารกิจ";
            this.FinishMission.Name = "FinishMission";
            this.FinishMission.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FinishMission.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FinishMission.Text = "เสร็จสิ้น";
            this.FinishMission.UseColumnTextForButtonValue = true;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 426);
            this.Controls.Add(this.addMissionButton);
            this.Controls.Add(this.MissionData);
            this.Controls.Add(this.label1);
            this.Name = "Mission";
            this.Text = "Mission";
            ((System.ComponentModel.ISupportInitialize)(this.MissionData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MissionData;
        private System.Windows.Forms.Button addMissionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewButtonColumn FinishMission;
    }
}