using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class RegistrationForm : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void UserTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTypeBox.Text == "Police Dept")
            {
                textBoxPID.Visible = comboBoxDesingation.Visible = comboBoxOffLoc.Visible = true;
                labelAddnDetails.Visible = labelPID.Visible = labelDesig.Visible = labelOffLoc.Visible = true;
                labelPUserDetails.Visible = true;
                //labelPUserDetails.ForeColor = Colou

            }
            else
            {
                textBoxPID.Visible = comboBoxDesingation.Visible = comboBoxOffLoc.Visible = false;
                labelAddnDetails.Visible = labelPID.Visible = labelDesig.Visible = labelOffLoc.Visible = false;
                labelPUserDetails.Visible = false;
                

            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            //radioButtonFemale.
        }
        private void run(string command)
        {
            connector.open();
            connector.runCommand(command);
            connector.Close();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (ValidDataPresent())
            {


                if (UserTypeBox.Text == "Normal User" || UserTypeBox.Text == "Police Dept")
                {
                    run("insert into registered_users values('" + textBoxName.Text + "'," +
                        SelectedSex() + ",'" + domainUpDownAge.Text + "','" +
                        textBoxUName.Text + "','" + textBoxPasswd.Text + "', '" +
                textBoxAddress.Text + "','" + UserTypeBox.Text + "');");

                    if (UserTypeBox.Text == "Police Dept")
                    {
                        run("insert into police_details values('" + textBoxPID.Text + "','" + comboBoxOffLoc.Text + "','"
                            + comboBoxDesingation.Text + "');");
                        run("insert into username_pid values('" + textBoxPID.Text + "','" + textBoxUName.Text + "');");
                        
                    }
                }
                MessageBox.Show("User " + textBoxName.Text + " added!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter the valid data and try again");
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string SelectedSex()
        {
            if (radioButtonFemale.Checked)
                return "'F'";
            else
                return "'M'";
        }

        private bool ValidDataPresent()
        {
            int age = ConvertIntoInt(domainUpDownAge.Text);
            if (age < 18 || age > 100)
            {
                MessageBox.Show("Invalid Age");
                return false;
            }
            if (radioButtonFemale.Checked == false && radioButtonMale.Checked == false)
            {
                MessageBox.Show("Select sex");
                return false;
            }
            if (textBoxPassConfirm.Text != textBoxPasswd.Text)
            {
                MessageBox.Show("Passwords donot match");
                return false;
            }
            if (checkBoxAccept.Checked == false)
            {
                MessageBox.Show("Accept the license");
                return false;
            }

            if (UserNotPresent(UserTypeBox.Text))
                return true;
            



            return true;
        }
        private int ConvertIntoInt(string number)
        {
            int res = 0;
            for (int i = 0; i < number.Length; i++)
                res = res * 10 + number[i] - '0';
            return res;
        }
        private bool UserNotPresent(string type)
        {
            bool result = false;
            MySqlConnector connector = new MySqlConnector();
            connector.open();
           
            connector.Close();
            return result;
        }


    }
}
