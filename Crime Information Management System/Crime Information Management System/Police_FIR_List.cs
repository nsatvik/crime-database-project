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
    public partial class Police_FIR_List : Form
    {
        string username, usertype,status;
        string[] statuses = { "Pending", "Solved", "Withdrawn", "Stopped" };
        MySqlConnector connector = new MySqlConnector();
        public Police_FIR_List(string usernam , string usert)
        {
            InitializeComponent();
            username = usernam;
            usertype = usert;
            InitFIRids();
            InitMyFIRs();
            InitVicsandCrims();
            InitEfficiency();
            UpdateDataGridFIRsByMe("select distinct firno from fir_by  where submittedby = '"+username+"';");
            
        }

        private void InitVicsandCrims()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            InitEfficiency();
            connector.open();
            string command = "select name from criminal ;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add("" + connector.GetReaderItem(0));
            connector.Close();
            textBoxCrimaName.AutoCompleteCustomSource = data;
            textBoxCrimaName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            connector.open();
            command = "select name from victim;";
            data = new AutoCompleteStringCollection();
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add("" + connector.GetReaderItem(0));
            connector.Close();
            textBoxVicName.AutoCompleteCustomSource = data;
            textBoxVicName.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void InitFIRids()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();
            InitEfficiency();
            connector.open();
            string command = "select distinct firno from fir_details ;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add(""+connector.GetReaderItem(0));
            connector.Close();
            textBoxFIRID.AutoCompleteCustomSource = data;
            textBoxFIRID.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        private void SetNull()
        {
            textBoxCrimaName.Text = textBoxDescription.Text = textBoxCriminals.Text = textBoxVictims.Text= 
                textBoxFIRID.Text = textBoxSubject.Text = textBoxVicName.Text = "";
            labelStatus.Text = "Status : ";
            comboBoxFIRStatus.Text = "";
            labelDate.Text = "Date :  ";


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
            labelDate.Visible = comboBoxFIRStatus.Visible= true; 
            pictureBoxSearch2.Visible = true;
            buttonCancelFIR.Visible = buttonSubmit.Visible = true;
            textBoxCrimaName.Visible = textBoxDescription.Visible = textBoxVicName.Visible = textBoxSubject.Visible =
            textBoxDescription.ReadOnly = textBoxSubject.ReadOnly    = true;
            pictureBoxAddC.Visible = pictureBoxAddV.Visible = textBoxVictims.Visible = textBoxCriminals.Visible = true;
            labelSubject.Text = "Subject: ";
            labelDescription.Text = "Description:  ";
            labelCrimName.Visible = labelVicName.Visible = labelStatus.Visible = true;
            buttonCancelFIR.Text = "Update FIR";
            buttonSubmit.Text = "Take Up";
            labelStatus.Text = " FIR Status : ";
            textBoxCrimaName.Visible = textBoxVicName.Visible = true;
            labelStatus.Visible = true;

            //SetNull();
            labelCrimName.Visible = labelDescription.Visible = labelFIRID.Visible = labelSubject.Visible = true;
            labelVicName.Visible = pictureBoxSearch.Visible = textBoxFIRID.Visible = true;
            labelFIRID.Text = "FIR ID:";
            labelVicName.Visible = true;

            

        }
        private void InitEfficiency()
        {
            int count;
            connector.open();
            connector.runCommand("select count(distinct fd.firno) FROM fir_inv_by fby, fir_details fd, username_pid usrpid WHERE " +
                "fby.officerid= usrpid.policeid AND fby.firno = fd.firno and fd.status = 'Solved' and usrpid.username = '" + username + "';");
            if (connector.ReaderRead())
            {
                Object obj = connector.GetReaderItem(0);
                if (obj == null)
                    count = 0;
                else
                {

                    count = StringToInt("" + obj) ;
                }
            }
            else
                count = 0;
            connector.Close();

            progressBarEfficiency.Value = (count*10)%100;
        }
        private int StringToInt(string number)
        {
            int n = 0;
            for (int i = 0; i < number.Length; i++)
                n = n * 10 + number[i]-'0';
            return n;
        }
        private void pictureBoxQMe_Click(object sender, EventArgs e)
        {
            pictureBoxSearch2.Visible = true;
            labelSubject.Text = "Start Date: ";
            labelDescription.Text = "Status:  ";
            labelCrimName.Visible = labelVicName.Visible = labelStatus.Visible = false;
            buttonCancelFIR.Text = "Remove Case";
            buttonSubmit.Text = "Update";
            textBoxCrimaName.Visible = textBoxVicName.Visible = false;
            labelStatus.Visible = false;
            buttonCancelFIR.Visible = buttonSubmit.Visible = true;
            
            AutoCompleteStringCollection data =  new AutoCompleteStringCollection();
            for(int i=0; i<statuses.Length;i++)
                data.Add(statuses[i]);

            textBoxDescription.AutoCompleteCustomSource = data;
            textBoxFIRID.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
            if (buttonCancelFIR.Text == "Update FIR")
            {
               
                run("update fir_details set status = ' " + comboBoxFIRStatus.Text + "'  where firno = '" + textBoxFIRID.Text+"';");
                InitEfficiency();
            }
           
            InitFIRids();
            SetNull();
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
        private void SubmitFIR()
        {

            labelFIRID.Text = "" + IDGenerator(); 
                string command = "insert into fir_details values('" + labelFIRID.Text + "','" + textBoxSubject.Text + "','"
                    + textBoxDescription.Text + "','"+DateGenerator()+"','Pending');";
                run(command);
                MessageBox.Show("FIR Submitted");
                run("insert into fir_by values('" + labelFIRID.Text + "','" + username + "');");
                
                int cid = 132;
                if (textBoxCrimaName.Text != "")
                {
                    connector.open();
                    command = "select criminalid from criminal where name = '"+textBoxCrimaName.Text+"';";
                    if (connector.runCommand(command) == 1)
                    {
                        connector.ReaderRead();
                        cid = (int)connector.GetReaderItem(0);
                        connector.Close();

                        run("insert into fir_criminal values('" + labelFIRID.Text + "','" + cid + "');");
                        //MessageBox.Show("Success Criminal");
                    }
                }
                if (textBoxVicName.Text != "")
                {
                    connector.open();
                    command = "select victimid from victim where name = '" + textBoxVicName.Text + "';";
                    
                    if (connector.runCommand(command) == 1)
                    {
                        connector.ReaderRead();
                        cid = (int)connector.GetReaderItem(0);

                        //run("insert into victim values('" + cid + "','" + textBoxVicName.Text + "',NULL,NULL,NULL,NULL,NULL);");
                        connector.Close();
                        run("insert into fir_victim values('" + labelFIRID.Text + "','" + cid + "');");
                    }
                }
                InitFIRids();
                SetNull();
                UpdateDataGridFIRsByMe("select f.firno from fir_by f where f.submittedby = ' " + username + "';");        
        }
        private void buttonTakeUp_Click(object sender, EventArgs e)
        {
            if (buttonSubmit.Text == "Submit")
            {
                SubmitFIR();
            }
            else
            {
                try
                {
                    run("insert into fir_inv_by values('" + textBoxFIRID.Text + "','" + GetPoliceID() + "');");
                    run("insert into cases values('" + textBoxFIRID.Text + "','" + DateGenerator() + "','" + status + "');");
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
                
                
            }
            InitMyFIRs();
            InitFIRids();
            UpdateDataGridFIRsByMe("select firno from fir_by  where submittedby = ' " + username + "';");
            SetNull();
            InitEfficiency();
        }
        private void InitMyFIRs()
        {
            
            string command = "SELECT distinct firno FROM fir_inv_by fby, username_pid usrpid WHERE " +
                "fby.officerid= usrpid.policeid AND usrpid.username = '" + username + "';";
          

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
            //UpdateDataGridFIRsByMe("select firno from fir_by  where submittedby = ' " + username + "';");

        }
        private void UpdateDataGridFIRsByMe(string command)
        {
           // MessageBox.Show(command);
            //command = "select firno from fir_by where submittedby = '" + username + "' ; ";
            connector.open();
            try
            {
                MySqlDataAdapter MyDA = new MySqlDataAdapter();

                MyDA.SelectCommand = new MySqlCommand(command, connector.GetConnection());

                DataTable table = new DataTable();
                MyDA.Fill(table);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = table;


                dataGridFIRsbyMe.DataSource = bSource;
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


        private void picHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxSearch2_Click(object sender, EventArgs e)
        {
            //labelFIRID.Text = "" + IDGenerator();
            string command = "SELECT DISTINCT f.subject, f.description, vic.name, crim.name, f.status, f.date FROM " +
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
                //textBoxVicName.Text = (string)connector.GetReaderItem(2);
                //textBoxCrimaName.Text = (string)connector.GetReaderItem(3);
                comboBoxFIRStatus.Text = (string) connector.GetReaderItem(4);
                labelDate.Text = "Date : " + connector.GetReaderItem(5);
            }
            connector.Close();
            InitCrimsVics();
       
        }

        private void InitCrimsVics()
        {
            connector.open();
            connector.runCommand("select c.name from fir_criminal f, criminal c where c.criminalid = f.criminalid and " +
                " f.firno = '" + textBoxFIRID.Text + "';");
            textBoxCriminals.Text = "";
            while (connector.ReaderRead())
            {
                textBoxCriminals.Text += connector.GetReaderItem(0) + " , ";
            }
            connector.Close();
            connector.open();
            connector.runCommand("select v.name from fir_victim f, victim v where v.victimid = f.victimid and " +
                " f.firno = '" + textBoxFIRID.Text + "';");
            textBoxVictims.Text = "";
            while (connector.ReaderRead())
            {
                textBoxVictims.Text += connector.GetReaderItem(0) + " , ";
            }
            connector.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (CheckCriminalExits(textBoxCrimaName.Text))
            {
                if (1 == run("insert into fir_criminal values ('" + textBoxFIRID.Text + "','" +
                    GetID(textBoxCrimaName.Text, 1) + "');"))
                {
                    
                    textBoxCriminals.Text = textBoxCriminals.Text + "," + textBoxCrimaName.Text + ",";
                    textBoxCrimaName.Text = "";
                }
            }
            else
            {
                this.Hide();
                (new InsertCriminal(textBoxCrimaName.Text,true)).ShowDialog();
                this.Show();
            }
        }

        private bool CheckCriminalExits(string criminalname)
        {
            connector.open();
            bool result = false ;
            connector.runCommand("select criminalid from criminal where name = '" + criminalname + "';");
            if ( connector.ReaderRead())
            {
                if (connector.GetReaderItem(0) == null)
                    result = false
                        ;
                else
                    result = true;
             

            }
            
            connector.Close();
            return result;
            
        }

        private string GetID(string name, int type)
        {
            connector.open();
            string command;
            int cid = -1;
            
            if (type == 1)
            {
                command = "select criminalid from criminal  where name = '" + name + "';";
            }
            else
            {
                command = "select victimid from victim  where name = '" + name + "';";
            }
            if (connector.runCommand(command) == 1)
            {
                if (connector.ReaderRead())
                {
                    cid = (int)connector.GetReaderItem(0);
                }
                connector.Close();
                return "" + cid;
            }
            return "";
        }

        private void pictureBoxAddV_Click(object sender, EventArgs e)
        {
            if(CheckVictimExits(textBoxVicName.Text))
            {
                if (1 == run("insert into fir_victim values ('" + textBoxFIRID.Text + "','" +
                 GetID(textBoxVicName.Text, 0) + "');"))
                {
                   
                    textBoxVictims.Text = textBoxVictims.Text + "," + textBoxVicName.Text + ",";
                    textBoxVicName.Text = "";
                }
                
            }
            else
            {
                this.Hide();
                (new InsertCriminal(textBoxVictims.Text,false)).ShowDialog();
                this.Show();
            }
            
        }

        private bool CheckVictimExits(string vicname)
        {
            connector.open();
            bool result = false;
            connector.runCommand("select victimid from victim where name = '" + vicname + "';");
            if (connector.ReaderRead())
            {
                if (connector.GetReaderItem(0) == null)
                    result = false
                        ;
                else
                    result = true;
             
            }
           
            connector.Close();
            return result;
        }

        private void pictureBoxInsert_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new InsertCriminal()).ShowDialog();
            this.Show();
        }

        private void pictureBoxFIR_Click(object sender, EventArgs e)
        {
            labelDate.Visible = comboBoxFIRStatus.Visible = 
            textBoxDescription.ReadOnly = textBoxSubject.ReadOnly = false;
            SetNull();            
            //labelDate.Visible = true;
            buttonSubmit.Text = "Submit";
            buttonCancelFIR.Text = "Cancel";
            buttonCancelFIR.Visible = buttonSubmit.Visible = true;
            textBoxCrimaName.Visible = textBoxDescription.Visible = textBoxVicName.Visible = textBoxSubject.Visible =
            labelStatus.Visible = true;

            pictureBoxAddC.Visible = pictureBoxAddV.Visible = textBoxVictims.Visible = textBoxCriminals.Visible = true;
            labelCrimName.Visible = labelDescription.Visible = labelFIRID.Visible = labelSubject.Visible = true;
            labelVicName.Visible = true;
            textBoxFIRID.Visible = false;
            
            textBoxFIRID.Visible = false;
            labelStatus.Text = "FIR Status : Pending";
            labelFIRID.Text = "FIR ID:To be Assigned";
        }
    }
}
