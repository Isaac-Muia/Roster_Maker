namespace Roster_Test
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            listBox2 = new ListBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            button3 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            listBox3 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            monday_roster = new ListBox();
            tuesday_roster = new ListBox();
            wednesday_roster = new ListBox();
            thursday_roster = new ListBox();
            friday_roster = new ListBox();
            saturday_roster = new ListBox();
            sunday_roster = new ListBox();
            start_hour = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            start_minute = new ComboBox();
            finish_minute = new ComboBox();
            label17 = new Label();
            label18 = new Label();
            finish_hour = new ComboBox();
            position = new ComboBox();
            label19 = new Label();
            create_shift = new Button();
            weekday = new ComboBox();
            label20 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            label14 = new Label();
            label22 = new Label();
            comboBox3 = new ComboBox();
            Settings = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Settings).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 15);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(341, 38);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(132, 79);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(59, 123);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(109, 22);
            button1.TabIndex = 2;
            button1.Text = "Add Employee";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            listBox2.Location = new Point(641, 38);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(132, 79);
            listBox2.TabIndex = 5;
            listBox2.Visible = false;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(778, 98);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(97, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Not Available";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30", "0:00" });
            comboBox1.Location = new Point(776, 38);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 9;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30", "0:00" });
            comboBox2.Location = new Point(776, 63);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 10;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(776, 20);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 11;
            label1.Text = "Availablity";
            label1.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(486, 95);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(117, 22);
            button3.TabIndex = 12;
            button3.Text = "Delete Employee";
            button3.UseVisualStyleBackColor = true;
            button3.Visible = false;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 58);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(119, 23);
            textBox2.TabIndex = 14;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(200, 82);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(118, 22);
            button2.TabIndex = 15;
            button2.Text = "Create Position";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(59, 46);
            listBox3.Margin = new Padding(3, 2, 3, 2);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(127, 79);
            listBox3.TabIndex = 16;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 17);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 46);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 21;
            label3.Text = "Position";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 15);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 22;
            label4.Text = "Employees";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 69);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 23;
            label5.Text = "Position:";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(542, 69);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 24;
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 205);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 25;
            label7.Text = "Monday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(228, 205);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 26;
            label8.Text = "Tuesday";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(722, 205);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 27;
            label9.Text = "Friday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(553, 205);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 28;
            label10.Text = "Thursday";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(383, 205);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 29;
            label11.Text = "Wednesday";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(877, 205);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 30;
            label12.Text = "Saturday";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(1046, 205);
            label13.Name = "label13";
            label13.Size = new Size(46, 15);
            label13.TabIndex = 31;
            label13.Text = "Sunday";
            // 
            // monday_roster
            // 
            monday_roster.FormattingEnabled = true;
            monday_roster.ItemHeight = 15;
            monday_roster.Location = new Point(24, 230);
            monday_roster.Margin = new Padding(3, 2, 3, 2);
            monday_roster.Name = "monday_roster";
            monday_roster.Size = new Size(152, 244);
            monday_roster.TabIndex = 32;
            // 
            // tuesday_roster
            // 
            tuesday_roster.FormattingEnabled = true;
            tuesday_roster.ItemHeight = 15;
            tuesday_roster.Location = new Point(191, 230);
            tuesday_roster.Margin = new Padding(3, 2, 3, 2);
            tuesday_roster.Name = "tuesday_roster";
            tuesday_roster.Size = new Size(152, 244);
            tuesday_roster.TabIndex = 33;
            // 
            // wednesday_roster
            // 
            wednesday_roster.FormattingEnabled = true;
            wednesday_roster.ItemHeight = 15;
            wednesday_roster.Location = new Point(354, 230);
            wednesday_roster.Margin = new Padding(3, 2, 3, 2);
            wednesday_roster.Name = "wednesday_roster";
            wednesday_roster.Size = new Size(152, 244);
            wednesday_roster.TabIndex = 34;
            // 
            // thursday_roster
            // 
            thursday_roster.FormattingEnabled = true;
            thursday_roster.ItemHeight = 15;
            thursday_roster.Location = new Point(519, 230);
            thursday_roster.Margin = new Padding(3, 2, 3, 2);
            thursday_roster.Name = "thursday_roster";
            thursday_roster.Size = new Size(152, 244);
            thursday_roster.TabIndex = 35;
            // 
            // friday_roster
            // 
            friday_roster.FormattingEnabled = true;
            friday_roster.ItemHeight = 15;
            friday_roster.Location = new Point(683, 230);
            friday_roster.Margin = new Padding(3, 2, 3, 2);
            friday_roster.Name = "friday_roster";
            friday_roster.Size = new Size(152, 244);
            friday_roster.TabIndex = 36;
            // 
            // saturday_roster
            // 
            saturday_roster.FormattingEnabled = true;
            saturday_roster.ItemHeight = 15;
            saturday_roster.Location = new Point(845, 230);
            saturday_roster.Margin = new Padding(3, 2, 3, 2);
            saturday_roster.Name = "saturday_roster";
            saturday_roster.Size = new Size(152, 244);
            saturday_roster.TabIndex = 37;
            // 
            // sunday_roster
            // 
            sunday_roster.FormattingEnabled = true;
            sunday_roster.ItemHeight = 15;
            sunday_roster.Location = new Point(1017, 230);
            sunday_roster.Margin = new Padding(3, 2, 3, 2);
            sunday_roster.Name = "sunday_roster";
            sunday_roster.Size = new Size(152, 244);
            sunday_roster.TabIndex = 38;
            // 
            // start_hour
            // 
            start_hour.FormattingEnabled = true;
            start_hour.Items.AddRange(new object[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "00" });
            start_hour.Location = new Point(997, 92);
            start_hour.Margin = new Padding(3, 2, 3, 2);
            start_hour.Name = "start_hour";
            start_hour.Size = new Size(45, 23);
            start_hour.TabIndex = 41;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(914, 94);
            label16.Name = "label16";
            label16.Size = new Size(60, 15);
            label16.TabIndex = 45;
            label16.Text = "Start Time";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1046, 94);
            label15.Name = "label15";
            label15.Size = new Size(10, 15);
            label15.TabIndex = 46;
            label15.Text = ":";
            // 
            // start_minute
            // 
            start_minute.FormattingEnabled = true;
            start_minute.Items.AddRange(new object[] { "00", "15", "30", "45" });
            start_minute.Location = new Point(1062, 92);
            start_minute.Margin = new Padding(3, 2, 3, 2);
            start_minute.Name = "start_minute";
            start_minute.Size = new Size(45, 23);
            start_minute.TabIndex = 47;
            // 
            // finish_minute
            // 
            finish_minute.FormattingEnabled = true;
            finish_minute.Items.AddRange(new object[] { "00", "15", "30", "45" });
            finish_minute.Location = new Point(1062, 123);
            finish_minute.Margin = new Padding(3, 2, 3, 2);
            finish_minute.Name = "finish_minute";
            finish_minute.Size = new Size(45, 23);
            finish_minute.TabIndex = 51;
            finish_minute.SelectedIndexChanged += comboBox5_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1046, 125);
            label17.Name = "label17";
            label17.Size = new Size(10, 15);
            label17.TabIndex = 50;
            label17.Text = ":";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(914, 125);
            label18.Name = "label18";
            label18.Size = new Size(67, 15);
            label18.TabIndex = 49;
            label18.Text = "Finish Time";
            // 
            // finish_hour
            // 
            finish_hour.FormattingEnabled = true;
            finish_hour.Items.AddRange(new object[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "00" });
            finish_hour.Location = new Point(997, 123);
            finish_hour.Margin = new Padding(3, 2, 3, 2);
            finish_hour.Name = "finish_hour";
            finish_hour.Size = new Size(45, 23);
            finish_hour.TabIndex = 48;
            // 
            // position
            // 
            position.FormattingEnabled = true;
            position.Location = new Point(982, 57);
            position.Margin = new Padding(3, 2, 3, 2);
            position.Name = "position";
            position.Size = new Size(133, 23);
            position.TabIndex = 52;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(914, 60);
            label19.Name = "label19";
            label19.Size = new Size(50, 15);
            label19.TabIndex = 53;
            label19.Text = "Position";
            label19.Click += label19_Click;
            // 
            // create_shift
            // 
            create_shift.Location = new Point(914, 159);
            create_shift.Margin = new Padding(3, 2, 3, 2);
            create_shift.Name = "create_shift";
            create_shift.Size = new Size(82, 22);
            create_shift.TabIndex = 54;
            create_shift.Text = "Create Shift";
            create_shift.UseVisualStyleBackColor = true;
            create_shift.Click += button4_Click;
            // 
            // weekday
            // 
            weekday.FormattingEnabled = true;
            weekday.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            weekday.Location = new Point(982, 25);
            weekday.Margin = new Padding(3, 2, 3, 2);
            weekday.Name = "weekday";
            weekday.Size = new Size(133, 23);
            weekday.TabIndex = 55;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(914, 25);
            label20.Name = "label20";
            label20.Size = new Size(27, 15);
            label20.TabIndex = 56;
            label20.Text = "Day";
            // 
            // button4
            // 
            button4.Location = new Point(1002, 159);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(112, 22);
            button4.TabIndex = 57;
            button4.Text = "Create Roster";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(59, 492);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(82, 22);
            button5.TabIndex = 58;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(217, 492);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(82, 22);
            button6.TabIndex = 59;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(364, 492);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(82, 22);
            button7.TabIndex = 60;
            button7.Text = "Clear";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(530, 492);
            button8.Margin = new Padding(3, 2, 3, 2);
            button8.Name = "button8";
            button8.Size = new Size(82, 22);
            button8.TabIndex = 61;
            button8.Text = "Clear";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(705, 492);
            button9.Margin = new Padding(3, 2, 3, 2);
            button9.Name = "button9";
            button9.Size = new Size(82, 22);
            button9.TabIndex = 62;
            button9.Text = "Clear";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click_1;
            // 
            // button10
            // 
            button10.Location = new Point(877, 492);
            button10.Margin = new Padding(3, 2, 3, 2);
            button10.Name = "button10";
            button10.Size = new Size(82, 22);
            button10.TabIndex = 63;
            button10.Text = "Clear";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click_1;
            // 
            // button11
            // 
            button11.Location = new Point(1032, 492);
            button11.Margin = new Padding(3, 2, 3, 2);
            button11.Name = "button11";
            button11.Size = new Size(82, 22);
            button11.TabIndex = 64;
            button11.Text = "Clear";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(486, 46);
            label14.Name = "label14";
            label14.Size = new Size(68, 15);
            label14.TabIndex = 65;
            label14.Text = "Max Hours:";
            label14.Visible = false;
            label14.Click += label14_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(542, 17);
            label22.Name = "label22";
            label22.Size = new Size(0, 15);
            label22.TabIndex = 67;
            label22.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "Unlimited" });
            comboBox3.Location = new Point(553, 43);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(82, 23);
            comboBox3.TabIndex = 68;
            comboBox3.Visible = false;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // Settings
            // 
            Settings.Image = Properties.Resources.icons8_settings_32;
            Settings.Location = new Point(1136, 6);
            Settings.Name = "Settings";
            Settings.Size = new Size(31, 32);
            Settings.TabIndex = 69;
            Settings.TabStop = false;
            Settings.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 523);
            Controls.Add(Settings);
            Controls.Add(comboBox3);
            Controls.Add(label22);
            Controls.Add(label14);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label20);
            Controls.Add(weekday);
            Controls.Add(create_shift);
            Controls.Add(label19);
            Controls.Add(position);
            Controls.Add(finish_minute);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(finish_hour);
            Controls.Add(start_minute);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(start_hour);
            Controls.Add(sunday_roster);
            Controls.Add(saturday_roster);
            Controls.Add(friday_roster);
            Controls.Add(thursday_roster);
            Controls.Add(wednesday_roster);
            Controls.Add(tuesday_roster);
            Controls.Add(monday_roster);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(checkBox1);
            Controls.Add(listBox2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Roster Maker";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Settings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private CheckBox checkBox1;
        private Label label1;
        private Button button3;
        private TextBox textBox2;
        private Button button2;
        private ListBox listBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private ListBox monday_roster;
        private ListBox tuesday_roster;
        private ListBox wednesday_roster;
        private ListBox thursday_roster;
        private ListBox friday_roster;
        private ListBox saturday_roster;
        private ListBox sunday_roster;
        private ComboBox start_hour;
        private Label label16;
        private Label label15;
        private ComboBox start_minute;
        private ComboBox finish_minute;
        private Label label17;
        private Label label18;
        private ComboBox finish_hour;
        private ComboBox position;
        private Label label19;
        private Button create_shift;
        private ComboBox weekday;
        private Label label20;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label label14;
        private Label label22;
        private ComboBox comboBox3;
        private PictureBox Settings;
        private static ComboBox comboBox1;
        private static ComboBox comboBox2;
    }
}