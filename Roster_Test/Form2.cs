using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roster_Test
{
    public partial class save_roster_as : Form
    {
        public string saveFolder;
        public save_roster_as(string saveFolder)
        {
            this.saveFolder = saveFolder;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                File.WriteAllText(saveFolder + "data", textBox1.Text);
                string[] files =
                Directory.GetFiles(saveFolder);
                Directory.CreateDirectory(saveFolder + "\\saves" + "\\" + textBox1.Text);
                foreach (string file in files )
                {
                    File.Copy(file, saveFolder +"\\saves\\" + textBox1.Text + "\\" + Path.GetFileName(file));
                }
                ActiveForm.Close();  
            }
        }
    }
}
