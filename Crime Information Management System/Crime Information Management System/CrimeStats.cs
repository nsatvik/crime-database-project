using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class CrimeStats : Form
    {
        MySqlConnector connector = new MySqlConnector();
        public CrimeStats()
        {
            InitializeComponent();
        }

        private void pictureBoxHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void pictureBoxMWL_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            connector.open();
            try
            {

                MySqlDataAdapter MyDA = new MySqlDataAdapter();
                string sql_query = textBoxQuery.Text;
                MyDA.SelectCommand = new MySqlCommand(sql_query, connector.GetConnection());

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

        private void UpdateDataGrid(string command)
        {
            textBoxQuery.Text = command;
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
        private void HideAll()
        {
            labelDescription.Visible = labelStatus.Visible = labelType.Visible = false;
            textBoxDescription.Visible = comboBoxType.Visible = comboBoxStatus.Visible = false;

        }

        private void textBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxQuery.Visible = false;
            textBoxQuery.Text = ComboBoxFilter.Text;
            string command = "";
            bool typeadded = false;
            bool statusadded = false;
            HideAll();
            switch (ComboBoxFilter.Text)
            {
                case "List FIRs":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;
                    
                    command = "select * from fir_details ";
                    typeadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where subject like '%" + comboBoxType.Text +"%'";
                        typeadded = true;
                    }
                    if (comboBoxStatus.Text != "")
                    {
                        if (!typeadded)
                            command += "where status like '%" + comboBoxType.Text + "%'";
                        else
                            command += " and status like '%" + comboBoxStatus.Text + "%'";
                    }
                    command += " ; ";

                    UpdateDataGrid(command);
                    break;
                case "List of Criminals":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    labelDescription.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;
                    textBoxDescription.Visible = true;
                   command = "select * from criminal ";
                    typeadded = false;
                    statusadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where type like '%" + comboBoxType.Text +"%'";
                        typeadded = true;
                    }
                    if (comboBoxStatus.Text != "")
                    {
                        if (!typeadded)
                            command += "where status like '%" + comboBoxType.Text + "%'";
                        else
                            command += " and status like '%" + comboBoxStatus.Text + "%'";
                        statusadded = true;
                    }
                    if (textBoxDescription.Text != "")
                    {
                        if (!statusadded)
                            command += "where description like '%" + textBoxDescription.Text + "%'";
                        else
                            command += " and description like '%" + textBoxDescription.Text + "%'";
                        
                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "List of Police Users":
                    UpdateDataGrid("select pd.policeid, ru.name, pd.designation from " +
                    " registered_users ru, police_details pd,  username_pid upid  " +
                    "where ru.type = 'Police Dept'  and upid.username = ru.username and upid.policeid = pd.policeid order by pd.policeid;  ");
                    break;
                //select * from registered_users ru, police_details pd, username_pid upid  where type = 'Police Dept'  and upid.username = ru.username and upid.policeid = p.policeid;  
                case "List of Victims":
                    labelDescription.Visible = true;
                    textBoxDescription.Visible = true;
                    command = "select * from victim ";
                    if (textBoxDescription.Text != "")
                    {
                        
                            command += "where description like '%" + textBoxDescription.Text + "%'";
                        

                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "Crimes - By Area":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;
                    command = "select f.firno,f.subject, f.description, ru.name, ru.address from fir_details f ," +
                        " registered_users ru, fir_by fb where fb.submittedby = ru.username and f.firno = fb.firno ";
                    typeadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where f.subject like '%" + comboBoxType.Text +"%'";
                        
                    }
                    if (comboBoxStatus.Text != "")
                    {
                        
                            command += " and f.status like '%" + comboBoxStatus.Text + "%'";
                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "List of Cases":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;
                    
                    command = "select * from fir_details ";
                    typeadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where subject like '%" + comboBoxType.Text +"%'";
                        typeadded = true;
                    }
                    if (comboBoxStatus.Text != "")
                    {
                        if (!typeadded)
                            command += "where status like '%" + comboBoxType.Text + "%'";
                        else
                            command += " and status like '%" + comboBoxStatus.Text + "%'";
                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "Most Wanted Criminals":
                    UpdateDataGrid("select * from criminal where "
                     +" type in ( 'Most Wanted', 'Underworld Don', 'Terrorist') and status not in ('Dead', 'Jailed');");
                    break;
                case "FIR -> Investigation Officer":
                    {


                        UpdateDataGrid("select f.firno, f.description, ru.name, pd.designation " +    " from fir_details f, fir_inv_by finvby , registered_users ru, username_pid upid,  police_details pd " +
    " where f.firno = finvby.firno and finvby.officerid = upid.policeid AND upid.policeid = upid.policeid " +     " and upid.username = ru.username " +
    " ORDER BY f.firno;");
                        MessageBox.Show("Squery Incorrect change it!");
                    }

                    break;
                case "User -> FIR":
                    UpdateDataGrid("select fd.firno, fd.subject, ru.name as User, fd.status " +
       "from fir_by fby, fir_details fd, registered_users ru where fby.firno = fd.firno and fby.submittedby = ru.username;");
                    break;
                                 
            }
        }

        private void pictureBoxTerminal_Click(object sender, EventArgs e)
        {
            textBoxQuery.Visible = true;
            textBoxQuery.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBoxQuery.Text = ComboBoxFilter.Text;
            string command = "";
            bool typeadded = false;
            bool statusadded = false;
            HideAll();
            switch (ComboBoxFilter.Text)
            {
                case "List FIRs":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;

                    command = "select * from fir_details ";
                    typeadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where subject like '%" + comboBoxType.Text + "%'";
                        typeadded = true;
                    }
                    if (comboBoxStatus.Text != "")
                    {
                        if (!typeadded)
                            command += "where status like '%" + comboBoxType.Text + "%'";
                        else
                            command += " and status like '%" + comboBoxStatus.Text + "%'";
                    }
                    command += " ; ";

                    UpdateDataGrid(command);
                    break;
                case "List of Criminals":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    labelDescription.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;
                    textBoxDescription.Visible = true;
                    command = "select * from criminal ";
                    typeadded = false;
                    statusadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where type like '%" + comboBoxType.Text + "%'";
                        typeadded = true;
                    }
                    if (comboBoxStatus.Text != "")
                    {
                        if (!typeadded)
                            command += "where status like '%" + comboBoxType.Text + "%'";
                        else
                            command += " and status like '%" + comboBoxStatus.Text + "%'";
                        statusadded = true;
                    }
                    if (textBoxDescription.Text != "")
                    {
                        if (!statusadded)
                            command += "where description like '%" + textBoxDescription.Text + "%'";
                        else
                            command += " and description like '%" + textBoxDescription.Text + "%'";

                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "List of Police Users":
                    UpdateDataGrid("select pd.policeid, ru.name, pd.designation from " +
                    " registered_users ru, police_details pd,  username_pid upid  " +
                    "where ru.type = 'Police Dept'  and upid.username = ru.username and upid.policeid = pd.policeid order by pd.policeid;  ");
                    
                    break;
                //select * from registered_users ru, police_details pd, username_pid upid  where type = 'Police Dept'  and upid.username = ru.username and upid.policeid = p.policeid;  
                case "List of Victims":
                    labelDescription.Visible = true;
                    textBoxDescription.Visible = true;
                    command = "select * from victim ";
                    if (textBoxDescription.Text != "")
                    {

                        command += "where description like '%" + textBoxDescription.Text + "%'";


                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "Crimes - By Area":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;
                    command = "select f.firno,f.subject, f.description, ru.name, ru.address from fir_details f ," +
                        " registered_users ru, fir_by fb where fb.submittedby = ru.username and f.firno = fb.firno ";
                    typeadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where f.subject like '%" + comboBoxType.Text + "%'";

                    }
                    if (comboBoxStatus.Text != "")
                    {

                        command += " and f.status like '%" + comboBoxStatus.Text + "%'";
                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "List of Cases":
                    labelStatus.Visible = true;
                    labelType.Visible = true;
                    comboBoxType.Visible = true;
                    comboBoxStatus.Visible = true;

                    command = "select * from fir_details ";
                    typeadded = false;
                    if (comboBoxType.Text != "")
                    {

                        command += "where subject like '%" + comboBoxType.Text + "%'";
                        typeadded = true;
                    }
                    if (comboBoxStatus.Text != "")
                    {
                        if (!typeadded)
                            command += "where status like '%" + comboBoxType.Text + "%'";
                        else
                            command += " and status like '%" + comboBoxStatus.Text + "%'";
                    }
                    command += " ; ";
                    UpdateDataGrid(command);
                    break;
                case "Most Wanted Criminals":
                    UpdateDataGrid("select * from criminal where "
                     + " type in ( 'Most Wanted', 'Underworld Don', 'Terrorist') and status not in ('Dead', 'Jailed');");
                    break;
                case "FIR -> Investigation Officer":
                    {


                        UpdateDataGrid("select distinct (f.firno), f.subject, ru.name, pd.designation " +
" from fir_details f, fir_inv_by finvby , registered_users ru, username_pid upid,  police_details pd  " +
" where f.firno = finvby.firno and finvby.officerid = upid.policeid AND upid.policeid = pd.policeid  and upid.username = ru.username  ORDER BY f.firno;");
  
                    }

                    break;
                case "User -> FIR":
                    UpdateDataGrid("select fd.firno, fd.subject, ru.name as User, fd.status "+
       "from fir_by fby, fir_details fd, registered_users ru where fby.firno = fd.firno and fby.submittedby = ru.username;");
                    break;

            }
        }

        private void textBoxQuery_TextChanged(object sender, EventArgs e)
        {

        }       
    }
}