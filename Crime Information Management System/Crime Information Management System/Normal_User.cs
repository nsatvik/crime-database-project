using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Normal_User : Form
    {
        string username;
        public Normal_User(string Name)
        {
            InitializeComponent();
            username = Name;
            welcomeTextBox.Text = "Welcome " + Name + "!";
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            //Program.main.Show();
        }

        private void pictureBoxFIR_Click(object sender, EventArgs e)
        {
            FIR_Form firform = new FIR_Form(username,"Normal User");
            this.Hide();
            firform.ShowDialog();
            this.Show();
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Search_Form searchForm = new Search_Form(username,"Normal User");
            this.Hide();
            searchForm.ShowDialog();
            this.Show();
        }

        private void pictureBoxMWL_Click(object sender, EventArgs e)
        {
            MostWantedCriminals mwcform = new MostWantedCriminals(username, "Normal User");
            this.Hide();
            mwcform.ShowDialog();
            this.Show();


        }

        private void pictureBoxPForum_Click(object sender, EventArgs e)
        {
            Public_Forum pbforum = new Public_Forum(username,"Normal User");
            this.Hide();
            pbforum.ShowDialog();
            this.Show();

        }

        private void pictureBoxReport_Click(object sender, EventArgs e)
        {
            CrimeStats crimestatsform = new CrimeStats();
            this.Hide();
            crimestatsform.ShowDialog();
            this.Show();
        }

        private void pictureBoxSafeTips_Click(object sender, EventArgs e)
        {
            SafetyTips safetyform = new SafetyTips();
            this.Hide();
            safetyform.ShowDialog();
            this.Show();
        }

        private void linkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new SettingsWindow(username, "Normal User")).ShowDialog();
            this.Show();
        }
        
    }
}
