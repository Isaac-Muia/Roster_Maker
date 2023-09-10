using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Roster_Test.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Roster_Test
{
    public partial class Settings : Form
    {
        public string savefolder;
        public Settings(string earliestStart, string latestFinish, string savefolder)
        {
            InitializeComponent();
            early.Text = earliestStart;
            late.Text = latestFinish;
            this.savefolder = savefolder;
        }


        private void early_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (savefolder != null)
            {
                File.WriteAllText(savefolder + "times.txt", early.Text + "\n" + late.Text);
            }
            update_times();
        }

        private void late_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (savefolder != null)
            {
                File.WriteAllText(savefolder + "times.txt", early.Text + "\n" + late.Text);
            }
            update_times();
        }

        ///Save Roster
        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(savefolder + "data"))
            {
                string rosterName = File.ReadAllText(savefolder + "data");
                string[] files =
                Directory.GetFiles(savefolder);
                string[] filesToDelete = Directory.GetFiles(savefolder + "\\saves" + "\\" + rosterName);
                foreach (string file in filesToDelete)
                {
                    File.Delete(file);
                }
                foreach (string file in files)
                {
                    File.Copy(file, savefolder + "\\saves\\" + rosterName + "\\" + Path.GetFileName(file));
                }
            }
            else //Save as
            {
                save_roster_as saveForm = new save_roster_as(savefolder);
                saveForm.Show();
            }
        }
        ///Save Roster as
        private void button3_Click(object sender, EventArgs e)
        {
           
              save_roster_as saveForm = new save_roster_as(savefolder);
              saveForm.Show();
            
        }
        ///Load Roster
        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(savefolder + "data"))
            {
                MessageBox.Show("Roster not saved if you load a new roster the current one will be lost!");
            }
            Load_Roster loadRoster = new Load_Roster(savefolder);
            loadRoster.Show();
        }
    }
}
