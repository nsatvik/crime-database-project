using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Cases : Form
    {
        MySqlConnector connector = new MySqlConnector();
        string username, usertype;
        public Cases(string username, string usertype)
        {
            InitializeComponent();
            this.username = username;
            this.usertype = usertype;
            InitFIRids();
            UpdateDataGrid("select * from cases c, fir_details f where f.firno = c.firno ");
            //UpdateDataGrid("select * from registered_users where type = 'Normal User' ;");
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            run("update cases c, fir_details f set c.status = f.status WHERE c.firno = f.firno;");
            this.Close();
        }
        private int run(string command)
        {
            connector.open();
            int res = connector.runCommand(command);
            connector.Close();
            return res;
        }
        private int IDGenerator()
        {
            Random r = new Random();

            return r.Next();
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            labelByMe.Visible = false;
            pictureBoxSearch2.Visible = true;
            labelSearchBy.Visible = true;
            textBoxSearch.Visible = true;
            ComboBoxFilter.Visible = true;
       }
        private void UpdateDataGrid(string command)
        {
            // MessageBox.Show(command);
            
            connector.open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();

                MyDA.SelectCommand = new MySqlCommand(command, connector.GetConnection());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridResults.DataSource = bSource;
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
        private void SetNull()
        {
            textBoxCaseID.Text = comboBoxFIRStatus.Text = "";
        }
        private void pictureBoxFIR_Click(object sender, EventArgs e)
        {
             pictureBoxSearch2.Visible = false;
             labelByMe.Visible = true;
             pictureBoxSearch2.Visible =
             labelSearchBy.Visible =
             textBoxSearch.Visible =
             ComboBoxFilter.Visible = false;
            
        }

        private void pictureBoxSearch2_Click(object sender, EventArgs e)
        {
            switch (ComboBoxFilter.Text)
            {
                case "CaseID":
                    UpdateDataGrid("select f.subject as type,f.description from cases c, " + 
                    " fir_details f where c.firno = f.firno and c.firno = '" 
                        + textBoxSearch.Text +" ' ;");
                    break;
                case "Type":
                    UpdateDataGrid("select f.subject as type,f.description from cases c, " + 
                        "fir_details f where c.firno = f.firno and f.subject like '%"
                        + textBoxSearch.Text + "%' ;");
                    break;
            }

        }

        private void textBoxFIRID_TextChanged(object sender, EventArgs e)
        {

        }
         private void InitFIRids()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
        
            connector.open();
            string command = "select distinct firno from fir_details ;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add(""+connector.GetReaderItem(0));
            connector.Close();
            textBoxCaseID.AutoCompleteCustomSource = data;
            textBoxCaseID.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private string DateGenerator()
        {
            return "2012-02-05";
        }
        private int GetPoliceID()
        {
            connector.open();
            string command = "select policeid from username_pid  where username = '"+username+"';";
            int cid = -1;
            if (connector.runCommand(command) == 1)
            {
                connector.ReaderRead();
                cid = (int)connector.GetReaderItem(0);
                connector.Close();
            }
            return cid;
        }
        private void buttonTakeUp_Click(object sender, EventArgs e)
        {
           try
                {
                    run("insert into fir_inv_by values('" + textBoxCaseID.Text + "','" + GetPoliceID() + "');");
                    run("insert into cases values('" + textBoxCaseID.Text + "','" + DateGenerator() + "','" + 
                        comboBoxFIRStatus.Text+ "');");
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            
            InitFIRids();
            UpdateDataGrid("select * from fir_inv_by  ;");
            SetNull();
            
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            run("update fir_details set status = ' " 
                + comboBoxFIRStatus.Text + "'  where firno = '" + textBoxCaseID.Text + "';");
            SetNull();
        }

        private void pictureBoxRun_Click(object sender, EventArgs e)
        {
            string command = "SELECT DISTINCT   f.status FROM " +
           " fir_details f, fir_victim v," +
           "fir_criminal c, victim vic, criminal crim WHERE " +
           " f.firno = '" + textBoxCaseID.Text + "' and f.firno=v.firno AND vic.victimid = v.victimid " +
           "AND crim.criminalid=c.criminalid and f.firno = c.firno;";
            connector.open();
            connector.runCommand(command);
            if (connector.ReaderRead())
            {
                
                comboBoxFIRStatus.Text = (string)connector.GetReaderItem(0);
                
            }
            connector.Close();
        }
    }
}
/*    if (buttonSubmit.Text == "Take Up")
           {
               string command = "SELECT DISTINCT f.subject, f.description, vic.name, crim.name, f.status FROM " +
               " fir_details f, fir_victim v," +
               "fir_criminal c, victim vic, criminal crim WHERE " +
               " f.firno = '" + textBoxFIRID.Text + "' and f.firno=v.firno AND vic.victimid = v.victimid " +
               "AND crim.criminalid=c.criminalid and f.firno = c.firno;";
               connector.open();
               connector.runCommand(command);
               if (connector.ReaderRead())
               {
                   textBoxSubject.Text = (string)connector.GetReaderItem(0);
                   textBoxDescription.Text = (string)connector.GetReaderItem(1);
                   textBoxVicName.Text = (string)connector.GetReaderItem(2);
                   textBoxCrimaName.Text = (string)connector.GetReaderItem(3);
                   status = ""+connector.GetReaderItem(4);
                   labelStatus.Text = "FIR Status : " + status;
               }
               connector.Close();
           }
           else
           {
               string command = "select start_date, status from cases where firno = '" + textBoxFIRID.Text + "';";
               connector.open();
               connector.runCommand(command);
               if (connector.ReaderRead())
               {
                   textBoxSubject.Text = "" + connector.GetReaderItem(0);
                   textBoxDescription.Text = "" + connector.GetReaderItem(1);
               }
               connector.Close();
           }*/