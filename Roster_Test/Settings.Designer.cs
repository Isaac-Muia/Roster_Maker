namespace Roster_Test
{
    partial class Settings
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
            early = new ComboBox();
            late = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // early
            // 
            early.FormattingEnabled = true;
            early.Items.AddRange(new object[] { "0:00", "0:30", "1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30", "24:00" });
            early.Location = new Point(114, 15);
            early.Name = "early";
            early.Size = new Size(121, 23);
            early.TabIndex = 0;
            early.SelectedIndexChanged += early_SelectedIndexChanged;
            // 
            // late
            // 
            late.FormattingEnabled = true;
            late.Items.AddRange(new object[] { "0:00", "0:30", "1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30", "24:00" });
            late.Location = new Point(114, 52);
            late.Name = "late";
            late.Size = new Size(121, 23);
            late.TabIndex = 1;
            late.SelectedIndexChanged += late_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 3;
            label2.Text = "Earliest shift start";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 55);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 4;
            label3.Text = "Latest shift finish";
            // 
            // button1
            // 
            button1.Location = new Point(68, 102);
            button1.Name = "button1";
            button1.Size = new Size(101, 23);
            button1.TabIndex = 5;
            button1.Text = "Load Roster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(68, 147);
            button2.Name = "button2";
            button2.Size = new Size(101, 23);
            button2.TabIndex = 6;
            button2.Text = "Save Roster";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(68, 188);
            button3.Name = "button3";
            button3.Size = new Size(101, 23);
            button3.TabIndex = 7;
            button3.Text = "Save Roster As";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(239, 223);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(late);
            Controls.Add(early);
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox early;
        private ComboBox late;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}