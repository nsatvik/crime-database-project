using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class MySqlConnector
    {
        private string MyConString = "SERVER=localhost;" +
               "DATABASE=crimedb;" +
               "UID=root;" +
               "PASSWORD=nsat_123;";
        private MySqlConnection connection;
        private MySqlDataReader Reader;
        private MySqlCommand command;
        public MySqlConnector()
        {
            connection = new MySqlConnection(MyConString);
            command = connection.CreateCommand();

        }
        public MySqlCommand CreateCommand()
        {
            return command;
        }
        public int  runCommand(string comndstr)
        {
            command.CommandText = comndstr;
            try
            {

                Reader = command.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Errno: " + ex.ErrorCode + "  " + ex.Message);
                return -1;
            }
            if (Reader != null)
            {
                //MessageBox.Show("Data Base Operation was Successful");
                return 1;
            }
            else
                return -1;
            
        }
        public void open()
        {
            connection.Open();
        }
        public bool ReaderRead()
        {
            return Reader.Read();
        }
        public object GetReaderItem(int i)
        {
            return Reader.GetValue(i);
        }
        public void Close()
        {
            connection.Close();
        }
        public MySqlConnection GetConnection()
        {
            return connection;
        }
        
    }
}
/*
 string MyConString = "SERVER=localhost;" +
               "DATABASE=crimedb;" +
               "UID=root;" +
               "PASSWORD=nsat_123;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            if (UserTypeBox.Text == "Normal User")
                command.CommandText = "select password, Name from registered_users where username = '" +
                     textBoxUName.Text + "';";
            else
                command.CommandText = "select password, Name from police_users where username = '" +
                    textBoxUName.Text + "';";
            connection.Open();
            Reader = command.ExecuteReader();
            string usertype = this.UserTypeBox.Text;
            if (Reader.Read() && textBoxPasswd.Text == (string)Reader.GetValue(0))
            {
                this.Hide();
                
                if (usertype == "Normal User")
                {
                    Normal_User nuser_form = new Normal_User((string) Reader.GetValue(1));
                    nuser_form.ShowDialog();

                }
                else if (usertype == "Police Dept")
                {
                    Police_Users puser_form = new Police_Users((string)Reader.GetValue(1));
                    puser_form.ShowDialog();

                }
*/