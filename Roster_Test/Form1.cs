using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Roster_Test
{
    public partial class Form1 : Form
    {
        public static string saved_files_path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\RosterMaker\\"; //Path where the files the program creates are saved
        public struct employee
        {
            public string name;
            public Dictionary<string, string> startAvailabiity;
            public Dictionary<string, string> finishAvailabiity;
            public string position;
            public Dictionary<string, bool> shifts; //True if employee is scheduled to work on that day on current rosters
            public Dictionary<string, double> hours; //Hours employee is working each day
            public int maxHours;
        }


        static List<employee> employees = new List<employee>();
        List<String> positions = new List<String>();
        public static string? earliestStart;
        public static string? latestFinish;

        public static List<String> times = new List<String>() {"0,00","0:30","1:00","1:30","2:00","2:30","3:00","3:30","4:00","4:30","5:00","5:30","6:00","6:30","7:00","7:30","8:00","8:30","9:00","9:30","10:00","10:30","11:00","11:30","12:00",
                                        "12:30","13:00","13:30","14:00","14:30","15:00","15:30","16:00","16:30","17:00","17:30","18:00","18:30","19:00","19:30","20:00","20:30","21:00","21:30","22:00","22:30","23:00","23:30","24:00"};

        public static List<String> shifttimes = new List<String>();
        public Form1()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm() {
            ///Event handler for deleting positions of position ListBox
            listBox3.MouseDoubleClick += new MouseEventHandler(listBox3_DoubleClick);

            monday_roster.AllowDrop = true;
            tuesday_roster.AllowDrop = true;
            wednesday_roster.AllowDrop = true;
            thursday_roster.AllowDrop = true;
            friday_roster.AllowDrop = true;
            saturday_roster.AllowDrop = true;
            sunday_roster.AllowDrop = true;

            ///Event handlers for rearanging daily rosters by draging shifts
            monday_roster.MouseDown += new MouseEventHandler(roster_MouseDown);
            monday_roster.DragDrop += new DragEventHandler(roster_DragDrop);
            monday_roster.DragOver += new DragEventHandler(roster_DragOver);
            tuesday_roster.MouseDown += new MouseEventHandler(roster_MouseDown);
            tuesday_roster.DragDrop += new DragEventHandler(roster_DragDrop);
            tuesday_roster.DragOver += new DragEventHandler(roster_DragOver);
            wednesday_roster.MouseDown += new MouseEventHandler(roster_MouseDown);
            wednesday_roster.DragDrop += new DragEventHandler(roster_DragDrop);
            wednesday_roster.DragOver += new DragEventHandler(roster_DragOver);
            thursday_roster.MouseDown += new MouseEventHandler(roster_MouseDown);
            thursday_roster.DragDrop += new DragEventHandler(roster_DragDrop);
            thursday_roster.DragOver += new DragEventHandler(roster_DragOver);
            friday_roster.MouseDown += new MouseEventHandler(roster_MouseDown);
            friday_roster.DragDrop += new DragEventHandler(roster_DragDrop);
            friday_roster.DragOver += new DragEventHandler(roster_DragOver);
            saturday_roster.MouseDown += new MouseEventHandler(roster_MouseDown);
            saturday_roster.DragDrop += new DragEventHandler(roster_DragDrop);
            saturday_roster.DragOver += new DragEventHandler(roster_DragOver);
            sunday_roster.MouseDown += new MouseEventHandler(roster_MouseDown);
            sunday_roster.DragDrop += new DragEventHandler(roster_DragDrop);
            sunday_roster.DragOver += new DragEventHandler(roster_DragOver);

            //Event handlers for editing shifts by double clicking
            monday_roster.MouseDoubleClick += new MouseEventHandler(edit_shift);
            tuesday_roster.MouseDoubleClick += new MouseEventHandler(edit_shift);
            wednesday_roster.MouseDoubleClick += new MouseEventHandler(edit_shift);
            thursday_roster.MouseDoubleClick += new MouseEventHandler(edit_shift);
            friday_roster.MouseDoubleClick += new MouseEventHandler(edit_shift);
            saturday_roster.MouseDoubleClick += new MouseEventHandler(edit_shift);
            sunday_roster.MouseDoubleClick += new MouseEventHandler(edit_shift);

            //Open settings on double click
            Settings.MouseDoubleClick += new MouseEventHandler(open_settings);

            comboBox1.Hide();
            comboBox2.Hide();
            label1.Hide();
            button3.Hide();
            label5.Hide();
            label6.Hide();
            comboBox3.Hide();
            label14.Hide();
            listBox2.Hide();
            label4.Hide();


            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\RosterMaker"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\RosterMaker");
            }
            if (!Directory.Exists(saved_files_path + "\\saves")){
                Directory.CreateDirectory(saved_files_path + "\\saves");
            }
            // Get start and end times of buisness
            if (File.Exists(saved_files_path + "times.txt"))
            {
                update_times();
            }
            else
            {
                earliestStart = "8:00";
                latestFinish = "6:00";
                write_data(saved_files_path + "times.txt", earliestStart + "\n" + latestFinish);
                update_times();
            }
            // Get saved positons
            if (File.Exists(saved_files_path + "positions.txt"))
            {
                listBox1.Items.Clear();
                listBox3.Items.Clear(); 
                monday_roster.Items.Clear();
                tuesday_roster.Items.Clear();
                wednesday_roster.Items.Clear();
                thursday_roster.Items.Clear();
                friday_roster.Items.Clear();
                saturday_roster.Items.Clear();
                sunday_roster.Items.Clear();
                string[] saved_positions = File.ReadAllLines(saved_files_path + "positions.txt");
                foreach (string pos in saved_positions)
                {
                    listBox3.Items.Add(pos);
                    positions.Add(pos);
                    position.Items.Add(pos);
                }
            }
            // Add saved shifts to roster
            get_saved_shifts("monday.txt");
            get_saved_shifts("tuesday.txt");
            get_saved_shifts("wednesday.txt");
            get_saved_shifts("thursday.txt");
            get_saved_shifts("friday.txt");
            get_saved_shifts("saturday.txt");
            get_saved_shifts("sunday.txt");

            // Load employees
            if (File.Exists(saved_files_path + "employees.csv"))
            {
                foreach (string saved_employees in File.ReadAllLines(saved_files_path + "employees.csv"))
                {
                    employee emp;
                    emp.name = saved_employees.Split(',')[0];
                    emp.startAvailabiity = new Dictionary<string, string>() { { "Monday", saved_employees.Split(',')[1] }, { "Tuesday", saved_employees.Split(',')[2] }, { "Wednesday", saved_employees.Split(',')[3] }, { "Thursday", saved_employees.Split(',')[4] }, { "Friday", saved_employees.Split(',')[5] }, { "Saturday", saved_employees.Split(',')[6] }, { "Sunday", saved_employees.Split(',')[7] } };
                    emp.finishAvailabiity = new Dictionary<string, string>() { { "Monday", saved_employees.Split(',')[8] }, { "Tuesday", saved_employees.Split(',')[9] }, { "Wednesday", saved_employees.Split(',')[10] }, { "Thursday", saved_employees.Split(',')[11] }, { "Friday", saved_employees.Split(',')[12] }, { "Saturday", saved_employees.Split(',')[13] }, { "Sunday", saved_employees.Split(',')[14] } };
                    emp.shifts = new Dictionary<string, bool>() { { "Monday", saved_employees.Split(',')[15] == "TRUE" }, { "Tuesday", saved_employees.Split(',')[16] == "TRUE" }, { "Wednesday", saved_employees.Split(',')[17] == "TRUE" }, { "Thursday", saved_employees.Split(',')[18] == "TRUE" }, { "Friday", saved_employees.Split(',')[19] == "TRUE" }, { "Saturday", saved_employees.Split(',')[20] == "TRUE" }, { "Sunday", saved_employees.Split(',')[21] == "TRUE" } };
                    emp.hours = new Dictionary<string, double>() { { "Monday", double.Parse(saved_employees.Split(',')[22]) }, { "Tuesday", double.Parse(saved_employees.Split(',')[23]) }, { "Wednesday", double.Parse(saved_employees.Split(',')[24]) }, { "Thursday", double.Parse(saved_employees.Split(',')[25]) }, { "Friday", double.Parse(saved_employees.Split(',')[26]) }, { "Saturday", double.Parse(saved_employees.Split(',')[27]) }, { "Sunday", double.Parse(saved_employees.Split(',')[28]) } }; //Hours employee is wokring each day

                    emp.maxHours = int.Parse(saved_employees.Split(',')[29]);
                    emp.position = saved_employees.Split(',')[30];
                    employees.Add(emp);
                    listBox1.Items.Add(emp.name);
                }
            }
        }
        ///Choose employee
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                button3.Show();
                label5.Show();
                label6.Show();
                comboBox3.Show();
                label14.Show();
                listBox2.Show();
                employee emp = get_employee((string)listBox1.SelectedItem);
                label6.Text = emp.position;
                //If not available check not available checkbox otherwise uncheck
                if (checkBox1.Visible)
                {
                    checkBox1.Checked = emp.startAvailabiity[listBox2.Text] == "N/A";
                }

                //Show availability for that day
                //If not available check not available checkbox otherwise uncheck
                if (listBox2.SelectedItem != null)
                {
                    checkBox1.Checked = emp.startAvailabiity[listBox2.Text] == "N/A";
                    comboBox1.Text = emp.startAvailabiity[listBox2.Text];
                    comboBox2.Text = emp.finishAvailabiity[listBox2.Text];
                }
                label22.Show();
                label22.Text = listBox1.Text;
                if (emp.maxHours == 100)
                {
                    comboBox3.Text = "Unlimited";
                }
                else
                {
                    comboBox3.Text = emp.maxHours.ToString();
                }
            }
        }

        ///Add employee
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" & listBox3.SelectedItem != null)
            {
                listBox1.Items.Add(textBox1.Text);
                employee newEmployee;
                newEmployee.name = textBox1.Text;
                newEmployee.startAvailabiity = new Dictionary<string, string>() { { "Monday", earliestStart }, { "Tuesday", earliestStart }, { "Wednesday", earliestStart }, { "Thursday", earliestStart }, { "Friday", earliestStart }, { "Saturday", earliestStart }, { "Sunday", earliestStart } };
                newEmployee.finishAvailabiity = new Dictionary<string, string>() { { "Monday", latestFinish }, { "Tuesday", latestFinish }, { "Wednesday", latestFinish }, { "Thursday", latestFinish }, { "Friday", latestFinish }, { "Saturday", latestFinish }, { "Sunday", latestFinish } };
                newEmployee.shifts = new Dictionary<string, bool>() { { "Monday", false }, { "Tuesday", false }, { "Wednesday", false }, { "Thursday", false }, { "Friday", false }, { "Saturday", false }, { "Sunday", false } };
                newEmployee.position = listBox3.Text;
                newEmployee.hours = new Dictionary<string, double>() { { "Monday", 0 }, { "Tuesday", 0 }, { "Wednesday", 0 }, { "Thursday", 0 }, { "Friday", 0 }, { "Saturday", 0 }, { "Sunday", 0 } };
                newEmployee.maxHours = 100;
                employees.Add(newEmployee);
                textBox1.Text = null;
                save_employee(newEmployee);
            }
        }

        ///Delete employee
        private void button3_Click(object sender, EventArgs e)
        {
            //Delete employee off employees list
            employee emp = get_employee((string)listBox1.SelectedItem);
            employees.Remove(emp);
            update_employees_data();

            listBox1.Items.Remove(listBox1.SelectedItem);

            checkBox1.Hide();
            comboBox1.Hide();
            comboBox2.Hide();
            label1.Hide();
            button3.Hide();
            listBox2.Hide();
            label5.Hide();
            label6.Hide();
            label22.Hide();
            comboBox3.Hide();
            label14.Hide();
        }

        ///Weekday selector
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Show();
            comboBox2.Show();
            label1.Show();

            //Show availability for that day
            employee emp = get_employee((string)listBox1.SelectedItem);
            //If not available check not available checkbox otherwise uncheck
            checkBox1.Checked = emp.startAvailabiity[listBox2.Text] == "N/A";
            comboBox1.Text = emp.startAvailabiity[listBox2.Text];
            comboBox2.Text = emp.finishAvailabiity[listBox2.Text];

        }


        ///Starting availability
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get chosen employee
            employee emp = get_employee((string)listBox1.SelectedItem);

            //Update availability
            emp.startAvailabiity[listBox2.Text] = comboBox1.Text;

            update_employees_data();
        }
        ///Ending availability
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get chosen employee
            employee emp = get_employee((string)listBox1.SelectedItem);

            //Update availability
            emp.finishAvailabiity[listBox2.Text] = comboBox2.Text;

            update_employees_data();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        ///Not available checkbox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            employee emp = get_employee((string)listBox1.SelectedItem);

            //Update availability
            if (checkBox1.Checked)
            {
                emp.startAvailabiity[listBox2.Text] = "N/A";
                emp.finishAvailabiity[listBox2.Text] = "N/A";
            }
            else
            {
                emp.startAvailabiity[listBox2.Text] = earliestStart;
                emp.finishAvailabiity[listBox2.Text] = latestFinish;
            }
            comboBox1.Text = emp.startAvailabiity[listBox2.Text];
            comboBox2.Text = emp.finishAvailabiity[listBox2.Text];
            update_employees_data();
        }

        ///Add position
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                string pos = textBox2.Text.Replace(" ", "-");
                listBox3.Items.Add(pos);
                positions.Add(pos);
                position.Items.Add(pos);
                write_data(saved_files_path + "positions.txt", pos);
                textBox2.Text = "";
            }

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        ///Create shift
        private void button4_Click(object sender, EventArgs e)
        {
            if (start_hour.Text != "" & finish_hour.Text != "" & start_minute.Text != "" & finish_minute.Text != "" & weekday.Text != "" & position.Text != "")
            {
                string shift = position.Text + ' ' + start_hour.Text + ':' + start_minute.Text + '-' + finish_hour.Text + ":" + finish_minute.Text;
                //Get weekday
                switch (weekday.Text)
                {

                    case "Monday":
                        monday_roster.Items.Add(shift);
                        write_data(saved_files_path + "monday.txt", shift);
                        break;
                    case "Tuesday":
                        tuesday_roster.Items.Add(shift);
                        write_data(saved_files_path + "tuesday.txt", shift);
                        break;
                    case "Wednesday":
                        wednesday_roster.Items.Add(shift);
                        write_data(saved_files_path + "wednesday.txt", shift);
                        break;
                    case "Thursday":
                        thursday_roster.Items.Add(shift);
                        write_data(saved_files_path + "thursday.txt", shift);
                        break;
                    case "Friday":
                        friday_roster.Items.Add(shift);
                        write_data(saved_files_path + "friday.txt", shift);
                        break;
                    case "Saturday":
                        saturday_roster.Items.Add(shift);
                        write_data(saved_files_path + "saturday.txt", shift);
                        break;
                    case "Sunday":
                        sunday_roster.Items.Add(shift);
                        write_data(saved_files_path + "sunday.txt", shift);
                        break;
                }
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        ///Create roster
        private void button4_Click_1(object sender, EventArgs e)
        {

            assign("Monday");
            assign("Tuesday");
            assign("Wednesday");
            assign("Thursday");
            assign("Friday");
            assign("Saturday");
            assign("Sunday");
            File.Delete(saved_files_path + "monday.txt");
            foreach (string shift in monday_roster.Items)
            {
                write_data(saved_files_path + "monday.txt", shift);
            }
            File.Delete(saved_files_path + "tuesday.txt");
            foreach (string shift in tuesday_roster.Items)
            {
                write_data(saved_files_path + "tuesday.txt", shift);
            }
            File.Delete(saved_files_path + "wednesday.txt");
            foreach (string shift in wednesday_roster.Items)
            {
                write_data(saved_files_path + "wednesday.txt", shift);
            }
            File.Delete(saved_files_path + "thursday.txt");
            foreach (string shift in thursday_roster.Items)
            {
                write_data(saved_files_path + "thursday.txt", shift);
            }
            File.Delete(saved_files_path + "friday.txt");
            foreach (string shift in friday_roster.Items)
            {
                write_data(saved_files_path + "friday.txt", shift);
            }
            File.Delete(saved_files_path + "saturday.txt");
            foreach (string shift in saturday_roster.Items)
            {
                write_data(saved_files_path + "saturday.txt", shift);
            }
            File.Delete(saved_files_path + "sunday.txt");
            foreach (string shift in sunday_roster.Items)
            {
                write_data(saved_files_path + "sunday.txt", shift);
            }
        }


        private void label19_Click(object sender, EventArgs e)
        {

        }

        ///Clear Sunday Shifts
        private void button11_Click(object sender, EventArgs e)
        {
            sunday_roster.Items.Clear();
            foreach (employee emp in employees)
            {
                emp.hours["Sunday"] = 0;
                emp.shifts["Sunday"] = false;
                update_employees_data();

            }
            File.WriteAllText(saved_files_path + "sunday.txt", "");

        }
        ///Clear Saturday Shifts
        private void button10_Click_1(object sender, EventArgs e)
        {
            saturday_roster.Items.Clear();
            foreach (employee emp in employees)
            {
                emp.hours["Saturday"] = 0;
                emp.shifts["Saturday"] = false;
                update_employees_data();
            }
            File.WriteAllText(saved_files_path + "saturday.txt", "");
        }
        ///Clear Friday Shifts
        private void button9_Click_1(object sender, EventArgs e)
        {
            friday_roster.Items.Clear();
            foreach (employee emp in employees)
            {
                emp.hours["Friday"] = 0;
                emp.shifts["Friday"] = false;
                update_employees_data();
            }
            File.WriteAllText(saved_files_path + "friday.txt", "");
        }
        ///Clear thursday Shifts
        private void button8_Click(object sender, EventArgs e)
        {
            thursday_roster.Items.Clear();
            foreach (employee emp in employees)
            {
                emp.hours["Thursday"] = 0;
                emp.shifts["Thursday"] = false;
                update_employees_data();
            }
            File.WriteAllText(saved_files_path + "thursday.txt", "");
        }
        ///Clear wednesday shifts
        private void button7_Click(object sender, EventArgs e)
        {
            wednesday_roster.Items.Clear();
            foreach (employee emp in employees)
            {
                emp.hours["Wednesday"] = 0;
                emp.shifts["Wednesday"] = false;
                update_employees_data();
            }
            File.WriteAllText(saved_files_path + "wednesday.txt", "");
        }
        ///Clear tuesday shifts
        private void button6_Click(object sender, EventArgs e)
        {
            tuesday_roster.Items.Clear();
            foreach (employee emp in employees)
            {
                emp.hours["Tuesday"] = 0;
                emp.shifts["Tuesday"] = false;
                update_employees_data();
            }
            File.WriteAllText(saved_files_path + "tuesday.txt", "");
        }
        ///Clear monday shifts
        private void button5_Click(object sender, EventArgs e)
        {
            monday_roster.Items.Clear();
            foreach (employee emp in employees)
            {
                emp.hours["Monday"] = 0;
                emp.shifts["Monday"] = false;
                update_employees_data();
            }
            File.WriteAllText(saved_files_path + "monday.txt", "");
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee Originalemp = get_employee((string)listBox1.SelectedItem);
            employee emp = get_employee((string)listBox1.SelectedItem);
            string maxHours = comboBox3.Text;
            if (maxHours == "Unlimited")
            {
                emp.maxHours = 100;
            }
            else
            {
                emp.maxHours = int.Parse(maxHours);
            }
            employees[employees.IndexOf(Originalemp)] = emp;
            update_employees_data();


        }

        ///Remove position
        private void listBox3_DoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox3.IndexFromPoint(e.Location);
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("Do you want to remove " + listBox3.SelectedItem.ToString() + " from positions?", "Alert", buttons);

            if (index != System.Windows.Forms.ListBox.NoMatches & result == System.Windows.Forms.DialogResult.Yes)
            {
                position.Items.Remove(listBox3.SelectedItem);
                positions.Remove((string)listBox3.SelectedItem);

                //Remove position from positions file
                string[] saved_positions = File.ReadAllLines(saved_files_path + "positions.txt");
                File.WriteAllText(saved_files_path + "positions.txt", "");
                foreach (string saved_position in saved_positions)
                {
                    if (saved_position != (string)listBox3.SelectedItem)
                    {
                        write_data(saved_files_path + "positions.txt", saved_position);
                    }
                }
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
        }

        public void assign(string day)
        {
            ListBox roster;
            switch (day)
            {
                case "Monday":
                    roster = monday_roster;
                    break;
                case "Tuesday":
                    roster = tuesday_roster;
                    break;
                case "Wednesday":
                    roster = wednesday_roster;
                    break;
                case "Thursday":
                    roster = thursday_roster;
                    break;
                case "Friday":
                    roster = friday_roster;
                    break;
                case "Saturday":
                    roster = saturday_roster;
                    break;
                default:
                    roster = sunday_roster;
                    break;
            }

            List<string> shifts = new List<string>() { };
            List<int> shifts_to_assign = new List<int> { };
            int k = 0;
            //Go through each shift and assign a valid employee
            foreach (string shift in roster.Items)
            {
                string shift_position = shift.Split(" ")[0];
                string time = shift.Split(" ")[1];


                string shift_startTime = time.Split("-")[0];
                int startHour = int.Parse(shift_startTime.Split(":")[0]);
                int startMinute = int.Parse(shift_startTime.Split(":")[1]);

                string shift_finishTime = time.Split("-")[1];
                int finishHour = int.Parse(shift_finishTime.Split(":")[0]);
                int finishMinute = int.Parse(shift_finishTime.Split(":")[1]);
                double d_finishHour = finishHour;
                double d_finishMinute = finishMinute;
                double d_startHour = startHour;
                double d_startMinute = startMinute;
                double shiftDuration = d_finishHour - d_startHour + ((d_finishMinute - d_startMinute) / 60.0);
                //Randomise employees
                Random rand = new Random();
                List<employee> shuffled_employees = employees.OrderBy(_ => rand.Next()).ToList();

                foreach (employee emp in shuffled_employees)
                {
                    //Check employee for avaiability correct position max hours and if employee is not already working that day
                    if (emp.startAvailabiity[day] != "N/A" & (total_hours(emp) + shiftDuration) <= emp.maxHours)
                    {
                        if (emp.position == shift_position & !emp.shifts[day])
                        {
                            if (int.Parse(emp.startAvailabiity[day].Split(":")[0]) <= startHour)
                            {
                                if (int.Parse(emp.startAvailabiity[day].Split(":")[1]) <= startMinute | int.Parse(emp.startAvailabiity[day].Split(":")[0]) != startHour)
                                {
                                    if (int.Parse(emp.finishAvailabiity[day].Split(":")[0]) > finishHour | emp.finishAvailabiity[day] == latestFinish)
                                    {
                                        shifts.Add(shift.Replace(shift_position, emp.name));
                                        shifts_to_assign.Add(k);
                                        emp.shifts[day] = true;
                                        emp.hours[day] = shiftDuration;
                                        update_employees_data();
                                        break;
                                    }

                                    else if (int.Parse(emp.finishAvailabiity[day].Split(":")[0]) == finishHour & int.Parse(emp.finishAvailabiity[day].Split(":")[1]) >= finishMinute)
                                    {
                                        shifts.Add(shift.Replace(shift_position, emp.name));
                                        shifts_to_assign.Add(k);
                                        emp.shifts[day] = true;
                                        emp.hours[day] = shiftDuration;
                                        update_employees_data();
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                k++;
            }
            //replace placeholder shifts with employees
            int i = 0;
            foreach (string s in shifts)
            {
                roster.Items[shifts_to_assign[i]] = s;
                i++;
            }
            switch (day)
            {
                case "Monday":
                    monday_roster = roster;
                    break;
                case "Tuesday":
                    tuesday_roster = roster;
                    break;
                case "Wednesday":
                    wednesday_roster = roster;
                    break;
                case "Thursday":
                    thursday_roster = roster;
                    break;
                case "Friday":
                    friday_roster = roster;
                    break;
                case "Saturday":
                    saturday_roster = roster;
                    break;
                default:
                    sunday_roster = roster;
                    break;
            }
        }

        ///Returns the employee that the user has selected on the employee listbox
        public static employee get_employee(string employee_name)
        {

            employee output;
            output.name = string.Empty;
            output.startAvailabiity = new Dictionary<string, string>() { };
            output.finishAvailabiity = new Dictionary<string, string>() { };
            output.shifts = new Dictionary<string, bool>() { };
            output.hours = new Dictionary<string, double>() { };
            output.maxHours = 0;
            output.position = string.Empty;

            foreach (employee emp in employees)
            {
                if (emp.name == employee_name)
                {
                    return (emp);
                }
            }
            return (output);
        }

        ///Adds data to the file at path
        public static void write_data(string path, string data)
        {
            if (File.Exists(path))
            {
                string[] saved_data = File.ReadAllLines(path);
                string all_data = "";

                foreach (string p in saved_data)
                {
                    all_data = all_data + p + "\n";
                }
                all_data.Reverse();
                File.WriteAllText(path, all_data + data);
            }
            else
            {
                File.WriteAllText(path, data + "\n");
            }
        }

        public void get_saved_shifts(string file)
        {
            ListBox roster;

            switch (file)
            {
                case "monday.txt":
                    roster = monday_roster;
                    break;
                case "tuesday.txt":
                    roster = tuesday_roster;
                    break;
                case "wednesday.txt":
                    roster = wednesday_roster;
                    break;
                case "thursday.txt":
                    roster = thursday_roster;
                    break;
                case "friday.txt":
                    roster = friday_roster;
                    break;
                case "saturday.txt":
                    roster = saturday_roster;
                    break;
                default:
                    roster = sunday_roster;
                    break;
            }
            string path = saved_files_path + file;
            if (File.Exists(path))
            {
                string[] shifts = File.ReadAllLines(path);

                foreach (string shift in shifts)
                {
                    roster.Items.Add(shift);
                }
            }
        }
        ///Saves employee to emplyees.csv
        public void save_employee(employee newEmployee)
        {
            string startTimes = "";
            string finishTimes = "";
            string workingShifts = "";
            string dailyHours = "";
            foreach (KeyValuePair<string, string> time in newEmployee.startAvailabiity)
            {
                startTimes = startTimes + ',' + time.Value;
            }
            foreach (KeyValuePair<string, string> time in newEmployee.finishAvailabiity)
            {
                finishTimes = finishTimes + ',' + time.Value;
            }
            foreach (KeyValuePair<string, bool> shift in newEmployee.shifts)
            {
                workingShifts = workingShifts + ',' + shift.Value.ToString();
            }
            foreach (KeyValuePair<string, double> day in newEmployee.hours)
            {
                dailyHours = dailyHours + ',' + day.Value.ToString();
            }
            string path = saved_files_path + "employees.csv";
            if (!File.Exists(path))
            {
                File.WriteAllText(path, newEmployee.name + startTimes + finishTimes + workingShifts + dailyHours + ',' + newEmployee.maxHours.ToString() + ',' + newEmployee.position);
            }
            else
            {
                string saved_employees = "";
                foreach (string employee in File.ReadAllLines(path))
                {
                    saved_employees = saved_employees + employee + '\n';
                }
                File.WriteAllText(path, saved_employees + newEmployee.name + startTimes + finishTimes + workingShifts + dailyHours + ',' + newEmployee.maxHours.ToString() + ',' + newEmployee.position);
            }
        }
        ///Remove content of employee file and re-add all employees with updated data
        public void update_employees_data()
        {
            File.WriteAllText(saved_files_path + "employees.csv", "");
            foreach (employee em in employees)
            {
                save_employee(em);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        ///Returns an interger of the total hours the given emplyee is working in the current roster
        private int total_hours(employee emp)
        {
            double hours = 0;
            foreach (KeyValuePair<string, double> day in emp.hours)
            {
                hours = hours + day.Value;
            }
            int output = (int)hours;
            return (output);
        }

        private void roster_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox roster = (ListBox)sender;
            if (roster.SelectedItem == null) return;
            if (e.Button == MouseButtons.Left && e.Clicks == 1)
            {
                roster.DoDragDrop(roster.SelectedItem, DragDropEffects.Move);

            }
        }

        private void roster_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void roster_DragDrop(object sender, DragEventArgs e)
        {
            ListBox roster = (ListBox)sender;
            Point point = roster.PointToClient(new Point(e.X, e.Y));
            int index = roster.IndexFromPoint(point);
            if (index < 0) index = roster.Items.Count - 1;
            object data = e.Data.GetData(typeof(string));
            roster.Items.Remove(data);
            roster.Items.Insert(index, data);

            string saveFile = roster.Name.ToString().Split('_')[0] + ".txt";

            //Update days roster file
            File.WriteAllText(saved_files_path + saveFile, "");
            foreach (string shift in roster.Items)
            {
                write_data(saved_files_path + saveFile, shift);
            }
        }
        ///Opens shift editor form on current shift
        private void edit_shift(object sender, MouseEventArgs e)
        {
            ListBox roster = (ListBox)sender;
            if (roster.SelectedItem != null)
            {
                string shift = (string)roster.SelectedItem;
                string day = "";
                switch (roster.Name)
                {
                    case "monday_roster":
                        day = "Monday";
                        break;
                    case "tuesday_roster":
                        day = "Tuesday";
                        break;
                    case "wednesday_roster":
                        day = "Wednesday";
                        break;
                    case "thursday_roster":
                        day = "Thursday";
                        break;
                    case "friday_roster":
                        day = "Friday";
                        break;
                    case "saturday_roster":
                        day = "Saturday";
                        break;
                    case "sunday_roster":
                        day = "Sunday";
                        break;
                }
                shift_editor newform = new shift_editor(shift, roster, employees, day);

                newform.Show();
            }
        }

        ///Updates roster file at savefile with current roster
        public static void update_roster_file(string saveFile, ListBox roster)
        {
            File.WriteAllText(saved_files_path + saveFile, "");
            foreach (string shift in roster.Items)
            {
                write_data(saved_files_path + saveFile, shift);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        //Settings
        private void open_settings(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            bool settingsOpen = false;
            Form settings = null;
            foreach (Form frm in fc)
            {
                if (frm.Name == "Settings Form")
                {
                    settings = frm;
                    settingsOpen = true;
                }
            }
            if (!settingsOpen)
            {
                Settings settingsform = new Settings(earliestStart, latestFinish, saved_files_path);
                settingsform.Name = "Settings Form";    
                settingsform.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        public static void update_times()
        {
            string[] saved_positions = File.ReadAllLines(saved_files_path + "times.txt");
            earliestStart = saved_positions[0];
            latestFinish = saved_positions[1];
            shifttimes.Clear();
            if (times.IndexOf(earliestStart) <= times.IndexOf(latestFinish))
            {
                for (int i = times.IndexOf(earliestStart); i <= times.IndexOf(latestFinish); i++)
                {
                    shifttimes.Add(times[i]);

                }
            }
            else
            {
                foreach(string time in times)
                {
                    shifttimes.Add(time);
                }
               
                for (int i = times.IndexOf(latestFinish) + 1; i <= times.IndexOf(earliestStart); i++)
                {
                    shifttimes.Remove(times[i]);
                }
            }
        
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (String time in shifttimes)
            {
                comboBox1.Items.Add(time);
                comboBox2.Items.Add(time);
            }
        }

    }
}
