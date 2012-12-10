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
    public partial class Police_Users : Form
    {
        string username;
        public Police_Users(string Name)
        {
            InitializeComponent();
            username = Name;
            welcomeTextBox.Text = "Welcome " + Name + "!";
        }

       

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            (new SettingsWindow(username, "Police Dept")).ShowDialog();
            this.Show();

            
        }

        private void softInfo_Click(object sender, EventArgs e)
        {

        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }
        
        private void pictureBoxCases_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Cases(username,"Police Dept")).ShowDialog();
            this.Show();

        }

        private void pictureBoxFIR_Click(object sender, EventArgs e)
        {
            Police_FIR_List firform = new Police_FIR_List(username, "Police Dept");
            this.Hide();
            firform.ShowDialog();
            this.Show();
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            Search_Form searchForm = new Search_Form(username, "Police Dept");
            this.Hide();
            searchForm.ShowDialog();
            this.Show();
        }

        private void pictureBoxMWL_Click(object sender, EventArgs e)
        {
            MostWantedCriminals mwcform = new MostWantedCriminals(username, "Police Dept");
            this.Hide();
            mwcform.ShowDialog();
            this.Show();


        }

        private void pictureBoxPForum_Click(object sender, EventArgs e)
        {
            Public_Forum pbforum = new Public_Forum(username, "Police Dept");
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

        private void pictureBoxSearch_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            (new Search_Form(username, "Police Dept")).ShowDialog();
            this.Show();
        }

        private void pictureBoxMWL_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            (new MostWantedCriminals(username, "Police Dept")).ShowDialog();
            this.Show();
        }
    }
}
