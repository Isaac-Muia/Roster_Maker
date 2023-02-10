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
        string saveFile;
        List<Form1.employee> employees;

        // initialy true to prevent combox index_changed methods from doing anythiny wien shift editor first loads
        bool initialf = true;
        bool initials = true;
        bool initialp = true;
        public shift_editor(string shift, ListBox roster, List<employee> employees)
        {
            InitializeComponent();
            this.shift = shift;
            this.roster = roster;
            this.employees = employees;

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
   
                string newShift = employee + " " + start_time + "-" + FinishTime.Text;
                roster.Items[roster.SelectedIndex] = newShift;
            if (!initialf)
            {
                Form1.update_roster_file(saveFile, roster);
            }
            else
            {
                initialf= false;
            }
            
        }

        private void StartTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string newShift = employee + " " + StartTime.Text + "-" + finish_time;
            roster.Items[roster.SelectedIndex] = newShift;
            if (!initials)
            {
                Form1.update_roster_file(saveFile, roster);
            }
            else
            {
                initials = false;
            }

        }
        

        private void Employee_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string newShift = Employee.Text + " " + start_time + "-" + finish_time;
            roster.Items[roster.SelectedIndex] = newShift;
            if (!initialp)
            {
                Form1.update_roster_file(saveFile, roster);
            }
            else
            {
                initialp = false;
            }

        }
    }
}
