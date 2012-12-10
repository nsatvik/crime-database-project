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
    public partial class FIR_Form : Form
    {
        private MySqlConnector connector = new MySqlConnector();
        string username, usertype;
        public FIR_Form(string Name, string UserType)
        {
            InitializeComponent();
            username = Name;
            usertype = UserType;
            InitIDs();
            UpdateDataGrid("select fby.firno from fir_by fby where fby.submittedby = '" + username + "';"); 
        }
        private void InitIDs()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            connector.open();
            string command;
            command = "select firno from fir_details;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add(""+connector.GetReaderItem(0));
            connector.Close();
            textBoxFIRID.AutoCompleteCustomSource = data;
            textBoxFIRID.AutoCompleteSource = AutoCompleteSource.CustomSource;

            
        }
        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InitFIRids()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            connector.open();
            string command = "select username from registered_users ;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add((string)connector.GetReaderItem(0));
            connector.Close();
            textBoxFIRID.AutoCompleteCustomSource = data;
            textBoxFIRID.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void UpdateDataGrid(string command)
        {
            
            connector.open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();

                MyDA.SelectCommand = new MySqlCommand(command, connector.GetConnection());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridFIRs.DataSource = bSource;
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
       

        

        private void buttonCancelFIR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string DateGenerator()
        {
            return "2012-03-04";
        }
        private int IDGenerator()
        {
            Random r = new Random();

            return r.Next();
        }
        private void buttonSubmit_Click(object sender, EventArgs e)
        {

              labelFIRID.Text = "" + IDGenerator(); 
                string command = "insert into fir_details values('" + labelFIRID.Text + "','" + textBoxSubject.Text + "','"
                    + textBoxDescription.Text + "','"+DateGenerator()+"','Pending');";
                run(command);
                MessageBox.Show("FIR Submitted");
                run("insert into fir_by values('" + labelFIRID.Text + "','" + username + "');");
               
                
                InitIDs();
                SetNull();
                UpdateDataGrid("select f.firno from fir_by f where f.submittedby = ' " + username + "';");
            
        }
        private void SetNull()
        {
            textBoxDescription.Text =
                textBoxFIRID.Text = textBoxSubject.Text = "";

        }
        private void run(string command)
        {
            connector.open();
            connector.runCommand(command);
            connector.Close();
        }

        private void pictureBoxFIR_Click(object sender, EventArgs e)
        {
            SetNull();
            buttonCancelFIR.Visible = buttonSubmit.Visible = true;
            textBoxDescription.Visible = textBoxSubject.Visible =
            labelStatus.Visible = true;

            labelDescription.Visible = labelFIRID.Visible = labelSubject.Visible = true;
            
            textBoxFIRID.Visible = false;
            pictureBoxSearch.Visible = false;

            labelStatus.Text = "FIR Status : Pending";
            labelFIRID.Text =  "FIR ID:To be Assigned";
        }

        private void pictureBoxViewFIR_Click(object sender, EventArgs e)
        {
            buttonCancelFIR.Visible = buttonSubmit.Visible = false;
           textBoxDescription.Visible =textBoxSubject.Visible
                = true;
            //SetNull();
           labelDescription.Visible = labelFIRID.Visible = labelSubject.Visible = true;
             pictureBoxSearch.Visible = textBoxFIRID.Visible = true;
            labelFIRID.Text = "FIR ID:";
            
            labelFIRbyYou.Text = "\n FIRs Filed by Me \n";
            connector.open();
            string command = "select firno from fir_by where submittedby = '"+username+"';";
            connector.runCommand(command);
            while(connector.ReaderRead())
                labelFIRbyYou.Text += "\n"+connector.GetReaderItem(0) +'\n';
            connector.Close();


        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            
            string command = "SELECT DISTINCT f.subject, f.description, vic.name, crim.name, f.status FROM "+
            " fir_details f, fir_victim v,"+
            "fir_criminal c, victim vic, criminal crim WHERE "+
            " f.firno = '" + textBoxFIRID.Text + "' and f.firno=v.firno AND vic.victimid = v.victimid "+
            "AND crim.criminalid=c.criminalid and f.firno = c.firno;";
            connector.open();
            connector.runCommand(command);
            if (connector.ReaderRead())
            {
                textBoxSubject.Text = (string)connector.GetReaderItem(0);
                textBoxDescription.Text = (string)connector.GetReaderItem(1);
               // textBoxVicName.Text = (string)connector.GetReaderItem(2);
               // textBoxCrimaName.Text = (string)connector.GetReaderItem(3);
                labelStatus.Text = "FIR Status : " + connector.GetReaderItem(4);
            }
            connector.Close();
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
