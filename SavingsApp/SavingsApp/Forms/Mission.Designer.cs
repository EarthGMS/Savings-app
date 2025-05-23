﻿namespace SavingsApp.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mission));
            this.label1 = new System.Windows.Forms.Label();
            this.MissionDataGridBox = new System.Windows.Forms.DataGridView();
            this.addMissionButton = new System.Windows.Forms.Button();
            this.CurrentSaving = new System.Windows.Forms.Label();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.MissionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissionValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinishMission = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MissionDataGridBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "เป้าหมาย";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MissionDataGridBox
            // 
            this.MissionDataGridBox.AllowUserToAddRows = false;
            this.MissionDataGridBox.AllowUserToResizeColumns = false;
            this.MissionDataGridBox.AllowUserToResizeRows = false;
            this.MissionDataGridBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MissionDataGridBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MissionName,
            this.MissionValue,
            this.Day,
            this.FinishMission});
            this.MissionDataGridBox.Location = new System.Drawing.Point(70, 105);
            this.MissionDataGridBox.Name = "MissionDataGridBox";
            this.MissionDataGridBox.RowHeadersVisible = false;
            this.MissionDataGridBox.Size = new System.Drawing.Size(533, 292);
            this.MissionDataGridBox.TabIndex = 1;
            this.MissionDataGridBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MissionData_CellContentClick);
            // 
            // addMissionButton
            // 
            this.addMissionButton.Location = new System.Drawing.Point(70, 74);
            this.addMissionButton.Name = "addMissionButton";
            this.addMissionButton.Size = new System.Drawing.Size(93, 25);
            this.addMissionButton.TabIndex = 2;
            this.addMissionButton.Text = "เพิ่มเป้าหมาย";
            this.addMissionButton.UseVisualStyleBackColor = true;
            this.addMissionButton.Click += new System.EventHandler(this.addMissionButton_Click);
            // 
            // CurrentSaving
            // 
            this.CurrentSaving.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentSaving.AutoSize = true;
            this.CurrentSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CurrentSaving.Location = new System.Drawing.Point(188, 71);
            this.CurrentSaving.Name = "CurrentSaving";
            this.CurrentSaving.Size = new System.Drawing.Size(209, 25);
            this.CurrentSaving.TabIndex = 3;
            this.CurrentSaving.Text = "จำนวนเงินในขณะนี้ : [?]";
            this.CurrentSaving.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MissionName
            // 
            this.MissionName.HeaderText = "ชื่อ";
            this.MissionName.Name = "MissionName";
            this.MissionName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MissionName.Width = 230;
            // 
            // MissionValue
            // 
            this.MissionValue.HeaderText = "จำนวนเงิน";
            this.MissionValue.Name = "MissionValue";
            this.MissionValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MissionValue.Width = 150;
            // 
            // Day
            // 
            this.Day.HeaderText = "วัน";
            this.Day.Name = "Day";
            this.Day.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Day.Width = 50;
            // 
            // FinishMission
            // 
            this.FinishMission.HeaderText = "เสร็จสิ้น";
            this.FinishMission.Name = "FinishMission";
            this.FinishMission.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FinishMission.Text = "เสร็จสิ้น";
            this.FinishMission.UseColumnTextForButtonValue = true;
            // 
            // Mission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 426);
            this.Controls.Add(this.CurrentSaving);
            this.Controls.Add(this.addMissionButton);
            this.Controls.Add(this.MissionDataGridBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mission";
            this.Text = "Saver\'s Note : เป้าหมาย";
            ((System.ComponentModel.ISupportInitialize)(this.MissionDataGridBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView MissionDataGridBox;
        private System.Windows.Forms.Button addMissionButton;
        private System.Windows.Forms.Label CurrentSaving;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MissionValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewButtonColumn FinishMission;
    }
}