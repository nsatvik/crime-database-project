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
    public partial class MostWantedCriminals : Form
    {
        string usertype, username;
        MySqlConnector connector = new MySqlConnector();
        public MostWantedCriminals(string user, string type)
        {
            InitializeComponent();
            usertype = type;
            username = user;
            InitNames();
            UpdateMWList();
            if (type == "Police Dept")
            {
                pictureBoxUpdate.Visible = true;
                labelUpdate.Visible = true;
            }
        }
        private void InitNames()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            connector.open();
            string command;
            
                command = "select name from criminal where type not in ('Most Wanted','Terrorist','Underworld Don') "+
                    " and status not in ('Dead','Jailed');";
           
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add((string)connector.GetReaderItem(0));
            connector.Close();
            textBoxSearch.AutoCompleteCustomSource = data;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void UpdateMWList()
        {
            
            string command = "SELECT name, description, type FROM criminal WHERE (status='Missing'"+
                " OR status='Absconded') AND (type = 'Most Wanted' OR "+
            "type = 'Terrorist' OR type='Underworld Don' );";
            
            connector.open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();

                MyDA.SelectCommand = new MySqlCommand(command, connector.GetConnection());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridViewResults.DataSource = bSource;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connector.Close();
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void welcomeTextBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxUpdate_Click(object sender, EventArgs e)
        {
            labelCName.Visible = true;
            buttonAdd.Visible = textBoxSearch.Visible = true;

        }
        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Alter the criminal as most wanted and Update
            connector.open();
            connector.runCommand("update criminal set type = 'Most Wanted' where name = '" + textBoxSearch.Text + "';");
            connector.Close();
            UpdateMWList();
            textBoxSearch.Text = "";
        }

        
    }
}
