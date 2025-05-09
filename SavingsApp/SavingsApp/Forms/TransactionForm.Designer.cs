namespace SavingsApp
{
    partial class TransactionForm
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
            System.Windows.Forms.Button AcceptForm;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionForm));
            this.TransactionValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TransactionName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PocketList = new System.Windows.Forms.ComboBox();
            this.WhereToGo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PercentageBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DateWrittenBox = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            AcceptForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AcceptForm
            // 
            AcceptForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            AcceptForm.ForeColor = System.Drawing.Color.Black;
            AcceptForm.Location = new System.Drawing.Point(98, 386);
            AcceptForm.Name = "AcceptForm";
            AcceptForm.Size = new System.Drawing.Size(156, 33);
            AcceptForm.TabIndex = 6;
            AcceptForm.Text = "ตกลง";
            AcceptForm.UseVisualStyleBackColor = true;
            AcceptForm.Click += new System.EventHandler(this.AcceptForm_Click);
            // 
            // TransactionValue
            // 
            this.TransactionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TransactionValue.Location = new System.Drawing.Point(143, 147);
            this.TransactionValue.Name = "TransactionValue";
            this.TransactionValue.Size = new System.Drawing.Size(171, 26);
            this.TransactionValue.TabIndex = 0;
            this.TransactionValue.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "กรอกรายรับ-รายจ่าย";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ปริมาณเงิน";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(321, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "บาท";
            // 
            // TransactionName
            // 
            this.TransactionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TransactionName.Location = new System.Drawing.Point(144, 110);
            this.TransactionName.Name = "TransactionName";
            this.TransactionName.Size = new System.Drawing.Size(171, 26);
            this.TransactionName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(21, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ชื่อ";
            // 
            // PocketList
            // 
            this.PocketList.DisplayMember = "0";
            this.PocketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PocketList.FormattingEnabled = true;
            this.PocketList.Items.AddRange(new object[] {
            "เงินเก็บ",
            "ค่าบิล",
            "ค่ากิน",
            "ค่าเที่ยว",
            "เงินฟุ่มเฟือย"});
            this.PocketList.Location = new System.Drawing.Point(143, 188);
            this.PocketList.Name = "PocketList";
            this.PocketList.Size = new System.Drawing.Size(171, 28);
            this.PocketList.TabIndex = 7;
            this.PocketList.ValueMember = "0";
            // 
            // WhereToGo
            // 
            this.WhereToGo.AutoSize = true;
            this.WhereToGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.WhereToGo.Location = new System.Drawing.Point(21, 191);
            this.WhereToGo.Name = "WhereToGo";
            this.WhereToGo.Size = new System.Drawing.Size(116, 20);
            this.WhereToGo.TabIndex = 8;
            this.WhereToGo.Text = "เก็บที่/จ่ายเงินจาก";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 37);
            this.label5.TabIndex = 9;
            this.label5.Text = "หักเงินเพิ่มเพื่อออม";
            // 
            // PercentageBox
            // 
            this.PercentageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.PercentageBox.Location = new System.Drawing.Point(144, 330);
            this.PercentageBox.Name = "PercentageBox";
            this.PercentageBox.Size = new System.Drawing.Size(171, 26);
            this.PercentageBox.TabIndex = 10;
            this.PercentageBox.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(21, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "เปอร์เซ็นต์";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(321, 330);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "%";
            // 
            // DateWrittenBox
            // 
            this.DateWrittenBox.Location = new System.Drawing.Point(144, 237);
            this.DateWrittenBox.Name = "DateWrittenBox";
            this.DateWrittenBox.Size = new System.Drawing.Size(200, 20);
            this.DateWrittenBox.TabIndex = 13;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.DateLabel.Location = new System.Drawing.Point(22, 237);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(116, 20);
            this.DateLabel.TabIndex = 14;
            this.DateLabel.Text = "เก็บที่/จ่ายเงินจาก";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 455);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateWrittenBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PercentageBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WhereToGo);
            this.Controls.Add(this.PocketList);
            this.Controls.Add(AcceptForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TransactionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TransactionValue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransactionForm";
            this.Text = "Saver\'s Note : กรอกรายรับ-รายจ่าย";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TransactionValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TransactionName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox PocketList;
        private System.Windows.Forms.Label WhereToGo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PercentageBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DateWrittenBox;
        private System.Windows.Forms.Label DateLabel;
    }
}