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

namespace Roster_Test
{
    public partial class Settings : Form
    {
        public string savefile;
        public Settings(string earliestStart, string latestFinish, string savefile)
        {
            InitializeComponent();
            early.Text = earliestStart;
            late.Text = latestFinish;
            this.savefile = savefile;
        }


        private void early_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (savefile != null)
            {
                File.WriteAllText(savefile, early.Text + "\n" + late.Text);
            }
            update_times();
        }

        private void late_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (savefile != null)
            {
                File.WriteAllText(savefile, early.Text + "\n" + late.Text);
            }
            update_times();
        }
    }
}
