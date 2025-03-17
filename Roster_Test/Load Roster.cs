using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Roster_Test
{
    public partial class Load_Roster : Form
    {
        public string saveFolder;
        public Load_Roster(string saveFolder)
        {
            InitializeComponent();
            this.saveFolder = saveFolder;
            string[] rosters = Directory.GetDirectories(saveFolder + "\\saves");
            foreach (string roster in rosters)
            {
                rosterList.Items.Add(Path.GetFileName(roster));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(saveFolder + "\\saves\\" + rosterList.SelectedItem);
            string[] filesToDelete = Directory.GetFiles(saveFolder);
            foreach (string file in filesToDelete)
            {

                File.Delete(file);
            }
            foreach (string file in files)
            {
                File.Copy(file, saveFolder + "\\" + Path.GetFileName(file));
            }
            //Create new form with new loaded data
            Form1 newForm = new Form1();
            //Close all forms but the new one
            List<Form> openForms = new List<Form>();
            foreach (Form form in Application.OpenForms)
            {
                openForms.Add(form);
            }
            foreach (Form form in openForms)
            {
                if (form != openForms[0])
                {
                    form.Close();
                }
            }
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            form1.LoadForm();



        }
    }
}
