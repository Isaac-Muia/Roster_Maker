using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Roster_Test.Form1;

namespace Roster_Test
{
    public partial class shift_editor : Form
    {
        public string shift;
        ListBox roster;
        public string employee;
        public string start_time;
        public string finish_time;
        string saveFile = "";
        List<employee> employees;
        string day;

        // initialy true to prevent combboox index_changed methods from doing anything when shift editor first loads
        bool initialf = true;
        bool initials = true;
        public shift_editor(string shift, ListBox roster, List<employee> employees, string day)
        {
            InitializeComponent();
            this.shift = shift;
            this.roster = roster;
            this.employees = employees;
            this.day = day;
            

            foreach(employee emp in employees)
            {
                Employee.Items.Add(emp.name);
            }

            start_time = shift.Split(" ")[1].Split("-")[0];
            StartTime.Text = start_time;
            finish_time = shift.Split(" ")[1].Split("-")[1];
            FinishTime.Text = finish_time;
            employee = shift.Split(" ")[0];
            Employee.Text = employee;
            roster.Items[roster.SelectedIndex] = employee + " " + start_time + "-" + finish_time;
            saveFile = roster.Name.ToString().Split('_')[0] + ".txt";
            StartTime.Items.Clear();
            FinishTime.Items.Clear();
            foreach (String time in Form1.shifttimes)
            {
                StartTime.Items.Add(time);
                FinishTime.Items.Add(time);
            }

        }

        ///Delete shift
        private void button1_Click(object sender, EventArgs e)
        {
            roster.Items.Remove(roster.SelectedItem);
            //Update days roster file
            Form1.update_roster_file(saveFile,roster);
            this.Close();
        }

        private void FinishTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initialf)
            {
                int finishHour = int.Parse(FinishTime.Text.Split(":")[0]);
                int finishMinute = int.Parse(FinishTime.Text.Split(":")[1]);
                employee emp = Form1.get_employee(Employee.Text);
                bool notPosition = true;
                foreach (employee em in employees)
                {
                    if (em.name == employee)
                    {
                        notPosition = false;
                        break;
                    }
                }
                if (notPosition)
                {
                    finish_time = FinishTime.Text;
                    string newShift = employee + " " + start_time + "-" + finish_time;
                    roster.Items[roster.SelectedIndex] = newShift;
                    Form1.update_roster_file(saveFile, roster);
                    return;
                }
                if (emp.name == string.Empty)
                {
                    finish_time = FinishTime.Text;
                    string newShift = employee + " " + start_time + "-" + finish_time;
                    roster.Items[roster.SelectedIndex] = newShift;
                    Form1.update_roster_file(saveFile, roster);
                }
               else if((int.Parse(emp.finishAvailabiity[day].Split(":")[0]) > finishHour | emp.finishAvailabiity[day] == "0:00") | int.Parse(emp.finishAvailabiity[day].Split(":")[0]) == finishHour & int.Parse(emp.finishAvailabiity[day].Split(":")[1]) >= finishMinute) 
                    {
                    finish_time = FinishTime.Text;
                    string newShift = employee + " " + start_time + "-" + finish_time;
                    roster.Items[roster.SelectedIndex] = newShift;
                    Form1.update_roster_file(saveFile, roster);
                }
                else
                {
                    MessageBox.Show("Employee is not available at this time");
                    FinishTime.Text = finish_time;
                }
            }
            else
            {
                initialf= false;
            }
            
        }

        private void StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!initials)
            {
                int startHour = int.Parse(StartTime.Text.Split(":")[0]);
                int startMinute = int.Parse(StartTime.Text.Split(":")[1]);
                employee emp = Form1.get_employee(Employee.Text);
                bool notPosition = true;
                foreach (employee em in employees){
                    if(em.name == employee)
                    {
                        notPosition = false;
                        break;
                    }
                }
                if (notPosition)
                {
                    start_time = StartTime.Text;
                    string newShift = employee + " " + start_time + "-" + finish_time;
                    roster.Items[roster.SelectedIndex] = newShift;
                    Form1.update_roster_file(saveFile, roster);
                    return;
                }
                if (int.Parse(emp.startAvailabiity[day].Split(":")[0]) <= startHour & (int.Parse(emp.startAvailabiity[day].Split(":")[1]) <= startMinute | int.Parse(emp.startAvailabiity[day].Split(":")[0]) != startHour))
                {
                    start_time = StartTime.Text;
                    string newShift = employee + " " + start_time + "-" + finish_time;
                    roster.Items[roster.SelectedIndex] = newShift;
                    Form1.update_roster_file(saveFile, roster);
                }
                else
                {
                    MessageBox.Show("Employee is not available at this time");
                    StartTime.Text = start_time;
                }
            }
            else
            {
                initials = false;
            }

        }
        

        private void Employee_SelectedIndexChanged(object sender, EventArgs e)
        {   
                int startHour = int.Parse(StartTime.Text.Split(":")[0]);
                int startMinute = int.Parse(StartTime.Text.Split(":")[1]);
                int finishHour = int.Parse(FinishTime.Text.Split(":")[0]);
                int finishMinute = int.Parse(FinishTime.Text.Split(":")[1]);
                employee emp = Form1.get_employee(Employee.Text);
                if (emp.startAvailabiity[day] != "N/A")
                {
                    if ((int.Parse(emp.startAvailabiity[day].Split(":")[1]) <= startMinute | int.Parse(emp.startAvailabiity[day].Split(":")[0]) != startHour) & (int.Parse(emp.startAvailabiity[day].Split(":")[0]) <= startHour & (int.Parse(emp.finishAvailabiity[day].Split(":")[0]) > finishHour | emp.finishAvailabiity[day] == "0:00") | int.Parse(emp.finishAvailabiity[day].Split(":")[0]) == finishHour & int.Parse(emp.finishAvailabiity[day].Split(":")[1]) >= finishMinute))
                    {
                        employee = Employee.Text;
                        string newShift = employee + " " + start_time + "-" + finish_time;
                        roster.Items[roster.SelectedIndex] = newShift;
                    if (saveFile != "")
                    {
                        Form1.update_roster_file(saveFile, roster);
                    }
                    }
                    else
                    {
                        MessageBox.Show("Employee is not available at this time");
                        Employee.Text = employee;
                    }
                }
                else
                {
                    MessageBox.Show("Employee not available that day");
                    Employee.Text = employee;
                }
        }
    }
}
