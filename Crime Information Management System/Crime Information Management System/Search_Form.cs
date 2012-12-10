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
    public partial class Search_Form : Form
    {
        MySqlConnector connector = new MySqlConnector();
        string usertype, username;
        public Search_Form(string uname,string Usertype)
        {
            InitializeComponent();
            usertype = Usertype;
            username = uname;
            picboxGeneral.Image = pictureBoxSearch2.Image;
            InitNames(comboBoxSearchType.Text);


        }
        private void InitNames(string type)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            connector.open();
            string command;
            if (type == "Criminal")
                command = "select name from criminal ;";
            else
                command = "select name from victim;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add((string)connector.GetReaderItem(0));
            connector.Close();
            textBoxSearch.AutoCompleteCustomSource = data;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }


        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Do Nothing :D
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            labelAge.Visible = labelCID.Visible = labelName.Visible = labelDescription.Visible = labelHeight.Visible =
                labelWeight.Visible = labelStatus.Visible = labelType.Visible = true;
            labelDelete.Visible = pictureBoxDelete.Visible = false;
            if (usertype == "Police Dept")
            {
                labelInsert.Visible = labelSearch.Visible = labelDelete.Visible = true;
                picboxGeneral.Visible = false;
                pictureBoxDelete.Visible = pictureBoxInsert.Visible = pictureBoxSearch2.Visible = true;
                textBoxSearch.Visible = false;
                comboBoxSearchType.Visible = false;
                if (picboxGeneral.Image == pictureBoxDelete.Image)
                {
                    connector.open();
                    string command = "select * from criminal where name = '" + textBoxSearch.Text + "';";
                    connector.runCommand(command);
                    while (connector.ReaderRead())
                    {
                        labelCID.Text = "CID: " + connector.GetReaderItem(0);
                        labelName.Text = "Name: " + connector.GetReaderItem(1);
                        labelAge.Text = "Age: " + connector.GetReaderItem(2);
                        labelSex.Text = "Sex: " + connector.GetReaderItem(3);
                        labelHeight.Text = "Height: " + connector.GetReaderItem(4);
                        labelWeight.Text = "Weight: " + connector.GetReaderItem(5);
                        labelDescription.Text = "Description: " + connector.GetReaderItem(6);
                        labelStatus.Text = "Status: " + connector.GetReaderItem(7);
                        labelType.Text = "Type: " + connector.GetReaderItem(8);
                    }

                    connector.Close();
                    if (comboBoxSearchType.Text == "Criminal")
                    {
                        command = "delete from criminal where name = '" + textBoxSearch.Text + "';";

                        run(command);
                    }
                    else
                    {
                        command = "delete from victim where name = '" + textBoxSearch.Text + "';";

                        run(command);
                    }
                    labelResults.Text += " : " +textBoxSearch.Text +" found and deleted! ";
                    InitNames(comboBoxSearchType.Text);

                }
                else if (pictureBoxInsert.Image == picboxGeneral.Image)
                {
                    //start new form for insertion 
                }
                else
                {
                    //search 
                    connector.open();
                     string command;
                    if(comboBoxSearchType.Text == "Criminal")
                        command = "select * from criminal where name = '" + textBoxSearch.Text + "';";
                    else
                        command = "select * from victim where name = '"+textBoxSearch.Text +"';";
                    connector.runCommand(command);
                    while (connector.ReaderRead())
                    {
                        labelCID.Text = "ID: " + connector.GetReaderItem(0);
                        labelName.Text = "Name: " + connector.GetReaderItem(1);
                        labelAge.Text = "Age: " + connector.GetReaderItem(2);
                        labelSex.Text = "Sex: " + connector.GetReaderItem(3);
                        labelHeight.Text = "Height: " + connector.GetReaderItem(4);
                        labelWeight.Text = "Weight: " + connector.GetReaderItem(5);
                        labelDescription.Text = "Description: " + connector.GetReaderItem(6);
                        if (comboBoxSearchType.Text == "Criminal")
                        {
                            labelType.Visible = labelStatus.Visible = true;
                            labelStatus.Text = "Status: " + connector.GetReaderItem(7);
                            labelType.Text = "Type: " + connector.GetReaderItem(8);

                        }
                        else { labelType.Visible = labelStatus.Visible = false; }
                    }

                    connector.Close();

                }
            }
            else
            {
                //NOrmal User search 
                labelType.Visible = labelStatus.Visible = false; 
                connector.open();
                string command;
                if (comboBoxSearchType.Text == "Criminal")
                    command = "select * from criminal where name = '" + textBoxSearch.Text + "';";
                else
                    command = "select * from victim where name = '" + textBoxSearch.Text + "';";
                connector.runCommand(command);
                while (connector.ReaderRead())
                {
                    
                    labelCID.Text = "CID: " + connector.GetReaderItem(0);
                    labelName.Text = "Name: " + connector.GetReaderItem(1);
                    labelAge.Text = "Age: " + connector.GetReaderItem(2);
                    labelSex.Text = "Sex: " + connector.GetReaderItem(3);
                    labelHeight.Text = "Height: " + connector.GetReaderItem(4);
                    labelWeight.Text = "Weight: " + connector.GetReaderItem(5);
                    labelDescription.Text = "Description: " + connector.GetReaderItem(6);
                    
                }

                connector.Close();
            }

        }
        private void run(string command)
        {
            connector.open();
            connector.runCommand(command);
            connector.Close();
        }

        private void pictureBoxSearch2_Click(object sender, EventArgs e)
        {
            comboBoxSearchType.Visible = true;
            
            pictureBoxDelete.Visible = pictureBoxInsert.Visible = pictureBoxSearch2.Visible = false;
            textBoxSearch.Visible = true;
            picboxGeneral.Image = pictureBoxSearch2.Image;
            picboxGeneral.Visible = true;
            labelInsert.Visible = labelSearch.Visible = labelDelete.Visible = false;


        }

        private void pictureBoxInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new InsertCriminal()).ShowDialog();
            this.Show();
            InitNames(comboBoxSearchType.Text);
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            pictureBoxDelete.Visible = pictureBoxInsert.Visible = pictureBoxSearch2.Visible = false;
            comboBoxSearchType.Visible = true;
            textBoxSearch.Visible = true;
            picboxGeneral.Image = pictureBoxDelete.Image;
            picboxGeneral.Visible = true;
            labelInsert.Visible = labelSearch.Visible = labelDelete.Visible = false;
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitNames(comboBoxSearchType.Text);
            if (comboBoxSearchType.Text == "Criminal")
            {
                labelStatus.Visible = labelType.Visible = true;
            }
            else
                labelStatus.Visible = labelType.Visible = false;
                     
        }

        private void textBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
        
    }
}
