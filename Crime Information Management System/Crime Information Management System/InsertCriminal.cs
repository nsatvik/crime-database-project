using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class InsertCriminal : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public InsertCriminal()
        {
            InitializeComponent();
            InitIDs(comboBoxInType.Text);
        }
        public InsertCriminal(string name, bool criminal)
        {
            InitializeComponent();
            InitIDs(comboBoxInType.Text);
            textBoxName.Text = name;
            if (!criminal)
            {
                comboBoxInType.Text = "Victim";
            }
        }
        private void InitIDs(string type)
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            connector.open();
            string command;
            if (type == "Criminal")
            {
                command = "select criminalid from criminal ;";
            }
            else
            {
                command = "select victimid from victim; ";

            }
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add(""+connector.GetReaderItem(0));
            connector.Close();
            textBoxID.AutoCompleteCustomSource = data;
            textBoxID.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxInType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitIDs(comboBoxInType.Text);
            if (comboBoxInType.Text == "Criminal")
            {
                labelStatus.Visible = comboBoxStatus.Visible = labelType.Visible = comboBoxType.Visible = true;
               
            }
            else
            {
                labelStatus.Visible = comboBoxStatus.Visible = labelType.Visible = comboBoxType.Visible = false;
            }

        }
        private int  run(string command)
        {
            connector.open();
            int res = connector.runCommand(command);
            connector.Close();
            return res;
        }
        private string SelectedSex()
        {
            if (radioButtonFemale.Checked)
                return "'F'";
            else
                return "'M'";
        }
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            int success = -1;
            if (comboBoxInType.Text == "Criminal")
            {
                string command = "insert into criminal values ('" + textBoxID.Text + "','" + textBoxName.Text + "','"
                    + domainUpDownAge.Text + "',"+SelectedSex()+",'"+ textBoxHeight.Text + "','" + textBoxWeight.Text + "','" + 
                    textBoxDescription.Text +
                    "','" + comboBoxStatus.Text + "','" + comboBoxType.Text + "');";
                success = run(command);
                
            }
            else
            {
                string command = "insert into victim values ('" + textBoxID.Text + "','" + textBoxName.Text + "','"
                    + domainUpDownAge.Text + "'," + SelectedSex() + ",'" + textBoxHeight.Text + "','" + textBoxWeight.Text + 
                    "','" + textBoxDescription.Text+"');";
                success = run(command);
            }
            if (success == 1)
                MessageBox.Show("Successfully Inserted " + textBoxName.Text);
            else
                MessageBox.Show("An Error Occured! Try again and agin");
            //this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
