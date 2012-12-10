using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UpdateCriminals : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public UpdateCriminals()
        {
            InitializeComponent();
            InitNames(comboBoxSearchType.Text);
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitNames(comboBoxSearchType.Text);
            if (comboBoxSearchType.Text == "Criminal")
            {
                labelStatus.Visible = labelType.Visible = true;
                textBoxStatus.Visible = textBoxType.Visible = true;


            }
            else
            {
                labelStatus.Visible = labelType.Visible = false;
                textBoxStatus.Visible = textBoxType.Visible = false;
            }
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxGeneral_Click(object sender, EventArgs e)
        {
            connector.open();
            string command;
            if (comboBoxSearchType.Text == "Criminal")
                command = "select * from criminal where name = '" + textBoxSearch.Text + "';";
            else
                command = "select * from victim where name = '" + textBoxSearch.Text + "';";
            connector.runCommand(command);
            while (connector.ReaderRead())
            {
                textBoxID.Text = "" + connector.GetReaderItem(0);
                textBoxName.Text = "" + connector.GetReaderItem(1);
                textBoxAge.Text = "" + connector.GetReaderItem(2);
                labelSex.Text = "Sex: " + connector.GetReaderItem(3);
                textBoxHeight.Text = "" + connector.GetReaderItem(4);
                textBoxWeight.Text = "" + connector.GetReaderItem(5);
                textBoxDescription.Text = "" + connector.GetReaderItem(6);
                if (comboBoxSearchType.Text == "Criminal")
                {
                    labelType.Visible = labelStatus.Visible = true;
                    textBoxStatus.Text = "" + connector.GetReaderItem(7);
                    textBoxType.Text = "" + connector.GetReaderItem(8);

                }
                else { labelType.Visible = labelStatus.Visible = false; }
            }

            connector.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxID.Text = textBoxName.Text = textBoxSearch.Text = textBoxStatus.Text =
                textBoxType.Text = textBoxWeight.Text = textBoxDescription.Text = "";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
             string command = "";
            connector.open();
            if (comboBoxSearchType.Text == "Criminal")
            {
                command = "update criminal c set c.age = '" + textBoxAge.Text + "'" +
                ", c.type='" + textBoxType.Text + "', c.status = '" + textBoxStatus.Text + "'" +
                ", c.height='" + textBoxHeight.Text + "', c.weight = '" + textBoxWeight.Text + "'" +
                ", c.description='" + textBoxDescription.Text + "' where c.criminalid = '" + textBoxID.Text + "';";
            }
            else
            {
                command = "update victim c set c.age = '" + textBoxAge.Text + "'" +
                ", c.height='" + textBoxHeight.Text + "', c.weight = '" + textBoxWeight.Text + "'" +
                ", c.description='" + textBoxDescription.Text + "' where c.victimid = '" + textBoxID.Text + "';";

            }
            if (connector.runCommand(command) == 1)
            {
                MessageBox.Show("Update Successful");
                
                
            }
            else
            {
                MessageBox.Show("An Error Occured. Enter valid data and try again");
            }

            connector.Close();
            InitNames(comboBoxSearchType.Text);
            ClearAll();
        }

        private void ClearAll()
        {
            textBoxID.Text = textBoxName.Text = textBoxSearch.Text = textBoxStatus.Text =
                 textBoxType.Text = textBoxWeight.Text = textBoxDescription.Text = "";
            textBoxAge.Text = textBoxHeight.Text = "";
            labelSex.Text = "Sex : ";
        }
    }
}
