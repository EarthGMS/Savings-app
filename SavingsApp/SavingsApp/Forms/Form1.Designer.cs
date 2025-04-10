namespace SavingsApp
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.AppNameDisplay = new System.Windows.Forms.Label();
            this.PocketMenuTab = new System.Windows.Forms.Button();
            this.SpendingTab = new System.Windows.Forms.Button();
            this.AnalysisTab = new System.Windows.Forms.Button();
            this.MonthlyPanel = new System.Windows.Forms.Panel();
            this.IncomeTextDisplay = new System.Windows.Forms.Label();
            this.ExpenseTextDisplay = new System.Windows.Forms.Label();
            this.CurrentTimeText = new System.Windows.Forms.Label();
            this.MonthlyText = new System.Windows.Forms.Label();
            this.AccountPanel = new System.Windows.Forms.Panel();
            this.WantsPocket = new System.Windows.Forms.Label();
            this.AccountText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BillPocket = new System.Windows.Forms.Label();
            this.MealsPocket = new System.Windows.Forms.Label();
            this.TravelPocket = new System.Windows.Forms.Label();
            this.SavingsPocket = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MonthlyPanel.SuspendLayout();
            this.AccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // AppNameDisplay
            // 
            this.AppNameDisplay.AutoSize = true;
            this.AppNameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AppNameDisplay.Location = new System.Drawing.Point(12, 9);
            this.AppNameDisplay.Name = "AppNameDisplay";
            this.AppNameDisplay.Size = new System.Drawing.Size(273, 39);
            this.AppNameDisplay.TabIndex = 0;
            this.AppNameDisplay.Text = "SAVERS NOTE";
            // 
            // PocketMenuTab
            // 
            this.PocketMenuTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PocketMenuTab.Location = new System.Drawing.Point(40, 82);
            this.PocketMenuTab.Name = "PocketMenuTab";
            this.PocketMenuTab.Size = new System.Drawing.Size(175, 28);
            this.PocketMenuTab.TabIndex = 1;
            this.PocketMenuTab.Text = "บัญชี";
            this.PocketMenuTab.UseVisualStyleBackColor = true;
            this.PocketMenuTab.Click += new System.EventHandler(this.PocketMenuTab_Click);
            // 
            // SpendingTab
            // 
            this.SpendingTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SpendingTab.Location = new System.Drawing.Point(40, 130);
            this.SpendingTab.Name = "SpendingTab";
            this.SpendingTab.Size = new System.Drawing.Size(175, 28);
            this.SpendingTab.TabIndex = 2;
            this.SpendingTab.Text = "รายรับ-รายจ่าย";
            this.SpendingTab.UseVisualStyleBackColor = true;
            this.SpendingTab.Click += new System.EventHandler(this.SpendingTab_Click);
            // 
            // AnalysisTab
            // 
            this.AnalysisTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AnalysisTab.Location = new System.Drawing.Point(40, 179);
            this.AnalysisTab.Name = "AnalysisTab";
            this.AnalysisTab.Size = new System.Drawing.Size(175, 28);
            this.AnalysisTab.TabIndex = 3;
            this.AnalysisTab.Text = "การเงินรายเดือน";
            this.AnalysisTab.UseVisualStyleBackColor = true;
            this.AnalysisTab.Click += new System.EventHandler(this.AnalysisTab_Click);
            // 
            // MonthlyPanel
            // 
            this.MonthlyPanel.Controls.Add(this.chart1);
            this.MonthlyPanel.Controls.Add(this.IncomeTextDisplay);
            this.MonthlyPanel.Controls.Add(this.ExpenseTextDisplay);
            this.MonthlyPanel.Controls.Add(this.CurrentTimeText);
            this.MonthlyPanel.Controls.Add(this.MonthlyText);
            this.MonthlyPanel.Location = new System.Drawing.Point(291, 12);
            this.MonthlyPanel.Name = "MonthlyPanel";
            this.MonthlyPanel.Size = new System.Drawing.Size(497, 426);
            this.MonthlyPanel.TabIndex = 11;
            // 
            // IncomeTextDisplay
            // 
            this.IncomeTextDisplay.AutoSize = true;
            this.IncomeTextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.IncomeTextDisplay.Location = new System.Drawing.Point(16, 130);
            this.IncomeTextDisplay.Name = "IncomeTextDisplay";
            this.IncomeTextDisplay.Size = new System.Drawing.Size(118, 20);
            this.IncomeTextDisplay.TabIndex = 2;
            this.IncomeTextDisplay.Text = "รายรับ : [income]";
            this.IncomeTextDisplay.Click += new System.EventHandler(this.IncomeTextDisplay_Click);
            // 
            // ExpenseTextDisplay
            // 
            this.ExpenseTextDisplay.AutoSize = true;
            this.ExpenseTextDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ExpenseTextDisplay.Location = new System.Drawing.Point(15, 161);
            this.ExpenseTextDisplay.Name = "ExpenseTextDisplay";
            this.ExpenseTextDisplay.Size = new System.Drawing.Size(142, 20);
            this.ExpenseTextDisplay.TabIndex = 3;
            this.ExpenseTextDisplay.Text = "รายจ่าย : [expenses]";
            // 
            // CurrentTimeText
            // 
            this.CurrentTimeText.AutoSize = true;
            this.CurrentTimeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.CurrentTimeText.Location = new System.Drawing.Point(13, 70);
            this.CurrentTimeText.Name = "CurrentTimeText";
            this.CurrentTimeText.Size = new System.Drawing.Size(176, 37);
            this.CurrentTimeText.TabIndex = 1;
            this.CurrentTimeText.Text = "[Time Text]";
            // 
            // MonthlyText
            // 
            this.MonthlyText.AutoSize = true;
            this.MonthlyText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MonthlyText.Location = new System.Drawing.Point(13, 13);
            this.MonthlyText.Name = "MonthlyText";
            this.MonthlyText.Size = new System.Drawing.Size(214, 37);
            this.MonthlyText.TabIndex = 0;
            this.MonthlyText.Text = "การเงินรายเดือน";
            // 
            // AccountPanel
            // 
            this.AccountPanel.Controls.Add(this.SavingsPocket);
            this.AccountPanel.Controls.Add(this.TravelPocket);
            this.AccountPanel.Controls.Add(this.MealsPocket);
            this.AccountPanel.Controls.Add(this.BillPocket);
            this.AccountPanel.Controls.Add(this.WantsPocket);
            this.AccountPanel.Controls.Add(this.AccountText);
            this.AccountPanel.Location = new System.Drawing.Point(291, 12);
            this.AccountPanel.Name = "AccountPanel";
            this.AccountPanel.Size = new System.Drawing.Size(497, 426);
            this.AccountPanel.TabIndex = 10;
            // 
            // WantsPocket
            // 
            this.WantsPocket.AutoSize = true;
            this.WantsPocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.WantsPocket.Location = new System.Drawing.Point(16, 277);
            this.WantsPocket.Name = "WantsPocket";
            this.WantsPocket.Size = new System.Drawing.Size(187, 24);
            this.WantsPocket.TabIndex = 1;
            this.WantsPocket.Text = "เงินฟุ่มเฟือย : XXX บาท";
            // 
            // AccountText
            // 
            this.AccountText.AutoSize = true;
            this.AccountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.AccountText.Location = new System.Drawing.Point(12, 33);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(144, 37);
            this.AccountText.TabIndex = 0;
            this.AccountText.Text = "ข้อมูลบัญชี";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(40, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "ภารกิจ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BillPocket
            // 
            this.BillPocket.AutoSize = true;
            this.BillPocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.BillPocket.Location = new System.Drawing.Point(16, 150);
            this.BillPocket.Name = "BillPocket";
            this.BillPocket.Size = new System.Drawing.Size(142, 24);
            this.BillPocket.TabIndex = 2;
            this.BillPocket.Text = "ค่าบิล : XXX บาท";
            // 
            // MealsPocket
            // 
            this.MealsPocket.AutoSize = true;
            this.MealsPocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MealsPocket.Location = new System.Drawing.Point(16, 193);
            this.MealsPocket.Name = "MealsPocket";
            this.MealsPocket.Size = new System.Drawing.Size(145, 24);
            this.MealsPocket.TabIndex = 3;
            this.MealsPocket.Text = "ค่ากิน : XXX บาท";
            // 
            // TravelPocket
            // 
            this.TravelPocket.AutoSize = true;
            this.TravelPocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TravelPocket.Location = new System.Drawing.Point(16, 238);
            this.TravelPocket.Name = "TravelPocket";
            this.TravelPocket.Size = new System.Drawing.Size(157, 24);
            this.TravelPocket.TabIndex = 4;
            this.TravelPocket.Text = "ค่าเที่ยว : XXX บาท";
            this.TravelPocket.Click += new System.EventHandler(this.label2_Click);
            // 
            // SavingsPocket
            // 
            this.SavingsPocket.AutoSize = true;
            this.SavingsPocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SavingsPocket.Location = new System.Drawing.Point(16, 106);
            this.SavingsPocket.Name = "SavingsPocket";
            this.SavingsPocket.Size = new System.Drawing.Size(154, 24);
            this.SavingsPocket.TabIndex = 5;
            this.SavingsPocket.Text = "เงินเก็บ : XXX บาท";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 220);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Expenses";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(457, 192);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MonthlyPanel);
            this.Controls.Add(this.AccountPanel);
            this.Controls.Add(this.AnalysisTab);
            this.Controls.Add(this.SpendingTab);
            this.Controls.Add(this.PocketMenuTab);
            this.Controls.Add(this.AppNameDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MonthlyPanel.ResumeLayout(false);
            this.MonthlyPanel.PerformLayout();
            this.AccountPanel.ResumeLayout(false);
            this.AccountPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppNameDisplay;
        private System.Windows.Forms.Button PocketMenuTab;
        private System.Windows.Forms.Button SpendingTab;
        private System.Windows.Forms.Button AnalysisTab;
        private System.Windows.Forms.Panel MonthlyPanel;
        public System.Windows.Forms.Label CurrentTimeText;
        private System.Windows.Forms.Label MonthlyText;
        private System.Windows.Forms.Panel AccountPanel;
        private System.Windows.Forms.Label AccountText;
        private System.Windows.Forms.Label WantsPocket;
        private System.Windows.Forms.Label ExpenseTextDisplay;
        private System.Windows.Forms.Label IncomeTextDisplay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BillPocket;
        private System.Windows.Forms.Label SavingsPocket;
        private System.Windows.Forms.Label TravelPocket;
        private System.Windows.Forms.Label MealsPocket;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

