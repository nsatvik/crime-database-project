using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class SettingsWindow : Form
    {
        string username, usertype;
        MySqlConnector connector = new MySqlConnector();
        public SettingsWindow(string uname, string utype)
        {
            InitializeComponent();
            username = uname;
            utype = usertype;
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {

        }
        private void run(string command)
        {
            connector.open();
            connector.runCommand(command);
            connector.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureChPasswd_Click(object sender, EventArgs e)
        {
            textBoxPassNew.Visible = textBoxUName.Visible = textBoxPasswd.Visible =
                butConfirm.Visible = butCancel.Visible = true;
            labelUname.Visible = labelPassNew.Visible = labelPasswd.Visible = true;

        }

        private void butConfirm_Click(object sender, EventArgs e)
        {
            //Code to update the database;
            connector.open();
            connector.runCommand("select password from registered_users where username = '" + textBoxUName.Text + "';");
            string existingpasswd = "";
            if (connector.ReaderRead())
            {
                existingpasswd = "" + connector.GetReaderItem(0);
                connector.Close();
            }
            else
            {
                MessageBox.Show("user not found.");
                if (usertype == "Normal User")
                {
                    new Normal_User(username).Show();
                }
                else
                {
                    new Police_Users(username).Show();

                }
                return;
            }
            if (existingpasswd == textBoxPasswd.Text)
            {
                if (textBoxPassNew.Text.Length > 0)
                {
                    connector.open();
                    connector.runCommand("update registered_users set password = '" + textBoxPassNew.Text +
                        "' where username = '" + textBoxUName.Text + "';");
                    if (!connector.ReaderRead())
                    {
                        MessageBox.Show("The password has been changed.");
                        textBoxPassNew.Visible = textBoxUName.Visible = textBoxPasswd.Visible =
                butConfirm.Visible = butCancel.Visible = false;
                        textBoxPassNew.Text = textBoxUName.Text = textBoxPasswd.Text = "";
                        labelUname.Visible = labelPassNew.Visible = labelPasswd.Visible = false;
                        this.Hide();
                        Program.main.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("An error occured ... Password not changed."); if (usertype == "Normal User")
                        {
                            new Normal_User(username).Show();
                        }
                        else
                        {
                            new Police_Users(username).Show();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("The password cannot be null/empty.");
                }
            }
            else
            {
                MessageBox.Show("Authentication failure.");
                if (usertype == "Normal User")
                {
                    new Normal_User(username).Show();
                }
                else
                {
                    new Police_Users(username).Show();

                }
            }
            
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            textBoxPassNew.Visible = textBoxUName.Visible = textBoxPasswd.Visible =
                butConfirm.Visible = butCancel.Visible = false;
            textBoxPassNew.Text = textBoxUName.Text = textBoxPasswd.Text = "";
            labelUname.Visible = labelPassNew.Visible = labelPasswd.Visible = false;
        }

        private void pictureDelAcc_Click(object sender, EventArgs e)
        {
            textBoxPassDel.Visible = labelPassDel.Visible = buttonCanDel.Visible = buttonDel.Visible = true;
            textBoxPassNew.Visible = textBoxUName.Visible = textBoxPasswd.Visible =
                butConfirm.Visible = butCancel.Visible = false;
            labelUname.Visible = labelPassNew.Visible = labelPasswd.Visible = false;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            connector.open();
            connector.runCommand("select password from registered_users where username = '" + username + "';");
            string existingpasswd = "";
            if (connector.ReaderRead())
            {
                existingpasswd = "" + connector.GetReaderItem(0);
                connector.Close();
            }
            else
            {
                MessageBox.Show("user not found.");
                return;
            }
            if (existingpasswd == textBoxPassDel.Text)
            {
                run("delete from username_pid where username = '" + username + "';");
                run("delete from fir_by where submittedby = '" + username + "';");
                
                run("delete from registered_users where username = '" + username + "';");
                textBoxPassDel.Visible = labelPassDel.Visible = buttonCanDel.Visible = buttonDel.Visible = false;
                MessageBox.Show("Successfully Deleted!");
                this.Hide();
                (new Login()).Show();
                
            }

            else
            {
                MessageBox.Show("Authentication failure.");
            }
            
            
        }

        private void textBoxUName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPasswd_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUname_Click(object sender, EventArgs e)
        {

        }

        private void labelPassNew_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCanDel_Click(object sender, EventArgs e)
        {
            textBoxPassDel.Visible = labelPassDel.Visible = false;
            buttonCanDel.Visible = buttonDel.Visible = false;
        }
    }
}
