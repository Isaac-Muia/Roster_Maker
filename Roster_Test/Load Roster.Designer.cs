namespace Roster_Test
{
    partial class Load_Roster
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
            rosterList = new ListBox();
            SuspendLayout();
            // 
            // rosterList
            // 
            rosterList.FormattingEnabled = true;
            rosterList.ItemHeight = 15;
            rosterList.Location = new Point(26, 23);
            rosterList.Name = "rosterList";
            rosterList.Size = new Size(184, 304);
            rosterList.TabIndex = 0;
            rosterList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Load_Roster
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 374);
            Controls.Add(rosterList);
            Name = "Load_Roster";
            Text = "Load_Roster";
            ResumeLayout(false);
        }

        #endregion

        private ListBox rosterList;
    }
}