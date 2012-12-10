using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Login : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public Login()
        {
            InitializeComponent();
            InitUsernames();
        }
        private void InitUsernames()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            
            connector.open();
            string command = "select username from registered_users ;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add((string)connector.GetReaderItem(0));
            connector.Close();
            textBoxUName.AutoCompleteCustomSource = data;
            textBoxUName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
        }

         private void butSignIn_Click(object sender, EventArgs e)
        {
            MySqlConnector myconnector = new MySqlConnector();
            myconnector.open();
            if (UserTypeBox.Text == "Normal User" || UserTypeBox.Text == "Police Dept")
                myconnector.runCommand("select password from registered_users where username = '" +
                     textBoxUName.Text + "' and type = '" + UserTypeBox.Text + "';");
            else
            {
                MessageBox.Show("User type not defined!");
                return;
            }
          
            string usertype = this.UserTypeBox.Text;
            if (myconnector.ReaderRead() && textBoxPasswd.Text == (string)myconnector.GetReaderItem(0))
            {
                this.Hide();
                
                if (usertype == "Normal User")
                {
                    Normal_User nuser_form = new Normal_User(textBoxUName.Text);
                    nuser_form.ShowDialog();

                }
                else if (usertype == "Police Dept")
                {
                    Police_Users puser_form = new Police_Users(textBoxUName.Text);
                    puser_form.ShowDialog();

                }
                
                this.Show();
                this.Visible = true;
                this.textBoxPasswd.Text = this.textBoxUName.Text = this.UserTypeBox.Text = "";
                myconnector.Close();

            }
            else
            {
                MessageBox.Show("No such User   " + textBoxUName.Text + "  Found!");
            }
        }

         private void butCancel_Click(object sender, EventArgs e)
         {
             this.textBoxPasswd.Text = this.textBoxUName.Text = this.UserTypeBox.Text = "";
         }

         private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
         {
             RegistrationForm regform = new RegistrationForm();
             this.Hide();
             regform.ShowDialog();
             this.Show();
         }
    }
}
