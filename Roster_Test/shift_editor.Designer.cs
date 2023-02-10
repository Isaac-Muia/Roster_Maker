namespace Roster_Test
{
    partial class shift_editor
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
            this.FinishTime = new System.Windows.Forms.ComboBox();
            this.StartTime = new System.Windows.Forms.ComboBox();
            this.Employee = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FinishTime
            // 
            this.FinishTime.FormattingEnabled = true;
            this.FinishTime.Items.AddRange(new object[] {
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30",
            "0:00"});
            this.FinishTime.Location = new System.Drawing.Point(213, 55);
            this.FinishTime.Name = "FinishTime";
            this.FinishTime.Size = new System.Drawing.Size(151, 28);
            this.FinishTime.TabIndex = 0;
            this.FinishTime.SelectedIndexChanged += new System.EventHandler(this.FinishTime_SelectedIndexChanged);
            // 
            // StartTime
            // 
            this.StartTime.FormattingEnabled = true;
            this.StartTime.Items.AddRange(new object[] {
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30",
            "0:00"});
            this.StartTime.Location = new System.Drawing.Point(36, 55);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(151, 28);
            this.StartTime.TabIndex = 1;
            this.StartTime.SelectedIndexChanged += new System.EventHandler(this.StartTime_SelectedIndexChanged);
            // 
            // Employee
            // 
            this.Employee.FormattingEnabled = true;
            this.Employee.Location = new System.Drawing.Point(36, 138);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(151, 28);
            this.Employee.TabIndex = 2;
            this.Employee.SelectedIndexChanged += new System.EventHandler(this.Employee_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Delete Shift";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Finish Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start Time";
            // 
            // shift_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 216);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.StartTime);
            this.Controls.Add(this.FinishTime);
            this.Name = "shift_editor";
            this.Text = "shift_editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox FinishTime;
        private ComboBox StartTime;
        private ComboBox Employee;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}