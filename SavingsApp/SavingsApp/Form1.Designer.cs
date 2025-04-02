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
            this.AppNameDisplay = new System.Windows.Forms.Label();
            this.PocketMenuTab = new System.Windows.Forms.Button();
            this.SpendingTab = new System.Windows.Forms.Button();
            this.AnalysisTab = new System.Windows.Forms.Button();
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
            this.PocketMenuTab.Size = new System.Drawing.Size(122, 28);
            this.PocketMenuTab.TabIndex = 1;
            this.PocketMenuTab.Text = "บัญชี";
            this.PocketMenuTab.UseVisualStyleBackColor = true;
            // 
            // SpendingTab
            // 
            this.SpendingTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SpendingTab.Location = new System.Drawing.Point(40, 130);
            this.SpendingTab.Name = "SpendingTab";
            this.SpendingTab.Size = new System.Drawing.Size(122, 28);
            this.SpendingTab.TabIndex = 2;
            this.SpendingTab.Text = "รายรับ-รายจ่าย";
            this.SpendingTab.UseVisualStyleBackColor = true;
            // 
            // AnalysisTab
            // 
            this.AnalysisTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AnalysisTab.Location = new System.Drawing.Point(40, 179);
            this.AnalysisTab.Name = "AnalysisTab";
            this.AnalysisTab.Size = new System.Drawing.Size(122, 28);
            this.AnalysisTab.TabIndex = 3;
            this.AnalysisTab.Text = "การเงินรายเดือน";
            this.AnalysisTab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AnalysisTab);
            this.Controls.Add(this.SpendingTab);
            this.Controls.Add(this.PocketMenuTab);
            this.Controls.Add(this.AppNameDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AppNameDisplay;
        private System.Windows.Forms.Button PocketMenuTab;
        private System.Windows.Forms.Button SpendingTab;
        private System.Windows.Forms.Button AnalysisTab;
    }
}

