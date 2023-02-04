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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.monday_roster = new System.Windows.Forms.ListBox();
            this.tuesday_roster = new System.Windows.Forms.ListBox();
            this.wednesday_roster = new System.Windows.Forms.ListBox();
            this.thursday_roster = new System.Windows.Forms.ListBox();
            this.friday_roster = new System.Windows.Forms.ListBox();
            this.saturday_roster = new System.Windows.Forms.ListBox();
            this.sunday_roster = new System.Windows.Forms.ListBox();
            this.start_hour = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.start_minute = new System.Windows.Forms.ComboBox();
            this.finish_minute = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.finish_hour = new System.Windows.Forms.ComboBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.create_shift = new System.Windows.Forms.Button();
            this.weekday = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 23);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(341, 38);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 79);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 123);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Employee";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.listBox2.Location = new System.Drawing.Point(641, 38);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(132, 79);
            this.listBox2.TabIndex = 5;
            this.listBox2.Visible = false;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(778, 98);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Not Available";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(776, 38);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 23);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
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
            this.comboBox2.Location = new System.Drawing.Point(776, 63);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(133, 23);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(776, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Availablity";
            this.label1.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 95);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 22);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete Employee";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(200, 82);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 22);
            this.button2.TabIndex = 15;
            this.button2.Text = "Create Position";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(59, 46);
            this.listBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(127, 79);
            this.listBox3.TabIndex = 16;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Position";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Employees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Position:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 24;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Monday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 205);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tuesday";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(722, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Friday";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(553, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Thursday";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 205);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = "Wednesday";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(877, 205);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = "Saturday";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1046, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = "Sunday";
            // 
            // monday_roster
            // 
            this.monday_roster.FormattingEnabled = true;
            this.monday_roster.ItemHeight = 15;
            this.monday_roster.Location = new System.Drawing.Point(24, 230);
            this.monday_roster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monday_roster.Name = "monday_roster";
            this.monday_roster.Size = new System.Drawing.Size(152, 244);
            this.monday_roster.TabIndex = 32;
            // 
            // tuesday_roster
            // 
            this.tuesday_roster.FormattingEnabled = true;
            this.tuesday_roster.ItemHeight = 15;
            this.tuesday_roster.Location = new System.Drawing.Point(191, 230);
            this.tuesday_roster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tuesday_roster.Name = "tuesday_roster";
            this.tuesday_roster.Size = new System.Drawing.Size(152, 244);
            this.tuesday_roster.TabIndex = 33;
            // 
            // wednesday_roster
            // 
            this.wednesday_roster.FormattingEnabled = true;
            this.wednesday_roster.ItemHeight = 15;
            this.wednesday_roster.Location = new System.Drawing.Point(354, 230);
            this.wednesday_roster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wednesday_roster.Name = "wednesday_roster";
            this.wednesday_roster.Size = new System.Drawing.Size(152, 244);
            this.wednesday_roster.TabIndex = 34;
            // 
            // thursday_roster
            // 
            this.thursday_roster.FormattingEnabled = true;
            this.thursday_roster.ItemHeight = 15;
            this.thursday_roster.Location = new System.Drawing.Point(519, 230);
            this.thursday_roster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.thursday_roster.Name = "thursday_roster";
            this.thursday_roster.Size = new System.Drawing.Size(152, 244);
            this.thursday_roster.TabIndex = 35;
            // 
            // friday_roster
            // 
            this.friday_roster.FormattingEnabled = true;
            this.friday_roster.ItemHeight = 15;
            this.friday_roster.Location = new System.Drawing.Point(683, 230);
            this.friday_roster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.friday_roster.Name = "friday_roster";
            this.friday_roster.Size = new System.Drawing.Size(152, 244);
            this.friday_roster.TabIndex = 36;
            // 
            // saturday_roster
            // 
            this.saturday_roster.FormattingEnabled = true;
            this.saturday_roster.ItemHeight = 15;
            this.saturday_roster.Location = new System.Drawing.Point(845, 230);
            this.saturday_roster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saturday_roster.Name = "saturday_roster";
            this.saturday_roster.Size = new System.Drawing.Size(152, 244);
            this.saturday_roster.TabIndex = 37;
            // 
            // sunday_roster
            // 
            this.sunday_roster.FormattingEnabled = true;
            this.sunday_roster.ItemHeight = 15;
            this.sunday_roster.Location = new System.Drawing.Point(1017, 230);
            this.sunday_roster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sunday_roster.Name = "sunday_roster";
            this.sunday_roster.Size = new System.Drawing.Size(152, 244);
            this.sunday_roster.TabIndex = 38;
            // 
            // start_hour
            // 
            this.start_hour.FormattingEnabled = true;
            this.start_hour.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.start_hour.Location = new System.Drawing.Point(997, 92);
            this.start_hour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_hour.Name = "start_hour";
            this.start_hour.Size = new System.Drawing.Size(45, 23);
            this.start_hour.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(914, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 15);
            this.label16.TabIndex = 45;
            this.label16.Text = "Start Time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1046, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(10, 15);
            this.label15.TabIndex = 46;
            this.label15.Text = ":";
            // 
            // start_minute
            // 
            this.start_minute.FormattingEnabled = true;
            this.start_minute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.start_minute.Location = new System.Drawing.Point(1062, 92);
            this.start_minute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.start_minute.Name = "start_minute";
            this.start_minute.Size = new System.Drawing.Size(45, 23);
            this.start_minute.TabIndex = 47;
            // 
            // finish_minute
            // 
            this.finish_minute.FormattingEnabled = true;
            this.finish_minute.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.finish_minute.Location = new System.Drawing.Point(1062, 123);
            this.finish_minute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finish_minute.Name = "finish_minute";
            this.finish_minute.Size = new System.Drawing.Size(45, 23);
            this.finish_minute.TabIndex = 51;
            this.finish_minute.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1046, 125);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(10, 15);
            this.label17.TabIndex = 50;
            this.label17.Text = ":";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(914, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 15);
            this.label18.TabIndex = 49;
            this.label18.Text = "Finish Time";
            // 
            // finish_hour
            // 
            this.finish_hour.FormattingEnabled = true;
            this.finish_hour.Items.AddRange(new object[] {
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.finish_hour.Location = new System.Drawing.Point(997, 123);
            this.finish_hour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.finish_hour.Name = "finish_hour";
            this.finish_hour.Size = new System.Drawing.Size(45, 23);
            this.finish_hour.TabIndex = 48;
            // 
            // position
            // 
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(982, 57);
            this.position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(133, 23);
            this.position.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(914, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 15);
            this.label19.TabIndex = 53;
            this.label19.Text = "Position";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // create_shift
            // 
            this.create_shift.Location = new System.Drawing.Point(914, 159);
            this.create_shift.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.create_shift.Name = "create_shift";
            this.create_shift.Size = new System.Drawing.Size(82, 22);
            this.create_shift.TabIndex = 54;
            this.create_shift.Text = "Create Shift";
            this.create_shift.UseVisualStyleBackColor = true;
            this.create_shift.Click += new System.EventHandler(this.button4_Click);
            // 
            // weekday
            // 
            this.weekday.FormattingEnabled = true;
            this.weekday.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.weekday.Location = new System.Drawing.Point(982, 25);
            this.weekday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weekday.Name = "weekday";
            this.weekday.Size = new System.Drawing.Size(133, 23);
            this.weekday.TabIndex = 55;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(914, 25);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 15);
            this.label20.TabIndex = 56;
            this.label20.Text = "Day";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1002, 159);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 22);
            this.button4.TabIndex = 57;
            this.button4.Text = "Create Roster";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(59, 492);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(82, 22);
            this.button5.TabIndex = 58;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(217, 492);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 22);
            this.button6.TabIndex = 59;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(364, 492);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 22);
            this.button7.TabIndex = 60;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(530, 492);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 22);
            this.button8.TabIndex = 61;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(705, 492);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 22);
            this.button9.TabIndex = 62;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click_1);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(877, 492);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(82, 22);
            this.button10.TabIndex = 63;
            this.button10.Text = "Clear";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(1032, 492);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(82, 22);
            this.button11.TabIndex = 64;
            this.button11.Text = "Clear";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 15);
            this.label14.TabIndex = 65;
            this.label14.Text = "Max Hours:";
            this.label14.Visible = false;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(542, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 15);
            this.label22.TabIndex = 67;
            this.label22.Visible = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "Unlimited"});
            this.comboBox3.Location = new System.Drawing.Point(553, 43);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(82, 23);
            this.comboBox3.TabIndex = 68;
            this.comboBox3.Visible = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 523);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.weekday);
            this.Controls.Add(this.create_shift);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.position);
            this.Controls.Add(this.finish_minute);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.finish_hour);
            this.Controls.Add(this.start_minute);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.start_hour);
            this.Controls.Add(this.sunday_roster);
            this.Controls.Add(this.saturday_roster);
            this.Controls.Add(this.friday_roster);
            this.Controls.Add(this.thursday_roster);
            this.Controls.Add(this.wednesday_roster);
            this.Controls.Add(this.tuesday_roster);
            this.Controls.Add(this.monday_roster);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private ListBox listBox2;
        private CheckBox checkBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
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
    }
}