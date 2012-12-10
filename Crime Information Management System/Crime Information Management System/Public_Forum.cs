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
    public partial class Public_Forum : Form
    {
        MySqlConnector connector = new MySqlConnector();
        string username, usertype;
        public Public_Forum(string username, string usertype)
        {
            InitializeComponent();
            InitSearchBox();
            this.username = username;
            this.usertype = usertype;
            
        }
        private void InitSearchBox()
        {
            AutoCompleteStringCollection data = new AutoCompleteStringCollection();

            connector.open();
            string command = "select question from questionanswer;";
            connector.runCommand(command);
            while (connector.ReaderRead())
                data.Add((string)connector.GetReaderItem(0));
            connector.Close();
            textBoxSearch.AutoCompleteCustomSource = data;
            textBoxSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
        }
       
        private void Public_Forum_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAskQuestion_Click(object sender, EventArgs e)
        {
            labelQuestion.Visible = textBoxQuestion.Visible = buttonCancel.Visible = buttonSubmit.Visible = true;
            labelAnswer.Visible = false;
            textBoxSearch.Visible = picboxSearch.Visible = false;
            pictureBoxSearch.Visible = true;
            labelSearch.Visible = true;
            textBoxAnswer.Visible = false;
            buttonSubmitAnswer.Visible = false;
           
        }

        private void pictureBoxSearch_Click(object sender, EventArgs e)
        {
            SetNull();
            textBoxAnswer.Visible = labelAnswer.Visible = true;
            labelQuestion.Visible = textBoxQuestion.Visible = buttonCancel.Visible = buttonSubmit.Visible = false;
            labelSearch.Visible = false;
            pictureBoxSearch.Visible = false;
            textBoxSearch.Visible = picboxSearch.Visible = true;
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            labelQuestion.Visible = textBoxQuestion.Visible = buttonCancel.Visible = buttonSubmit.Visible = false;
           
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            
            string command = "insert into questionanswer values('" + textBoxQuestion.Text + "','');";
            run(command);
            MessageBox.Show("Submitted!");
            InitSearchBox();
            SetNull();
            
        }
        private void run(string command)
        {
            connector.open();
            connector.runCommand(command);
            connector.Close();
        }
        private void SetNull()
        {
            textBoxSearch.Text = 
                textBoxAnswer.Text = textBoxQuestion.Text = "";

        }
        private void picboxSearch_Click(object sender, EventArgs e)
        {
            textBoxAnswer.Visible = true;
            labelAnswer.Visible = true;
            if (usertype == "Police Dept")
            {
                textBoxAnswer.ReadOnly = false;
                buttonSubmitAnswer.Visible = true;
            }
            else
            {
                textBoxAnswer.ReadOnly = true;
                buttonSubmitAnswer.Visible = false;
            }

            string command = "select answer from questionanswer where question = '" + textBoxSearch.Text + "';";
            connector.open();
            if (connector.runCommand(command) == 1)
            {
                connector.ReaderRead();
                textBoxAnswer.Text = ""+connector.GetReaderItem(0);
                connector.Close();

            }
            else
            {
                MessageBox.Show("Error!");
            }
            
        }

        private void buttonSubmitAnswer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("I don't know the alter command!");
            run("delete from questionanswer where question= '" + textBoxSearch.Text + "';");
            run("insert into questionanswer values('" + textBoxSearch.Text + "','" + textBoxAnswer.Text + "' );");
            SetNull();
        }

       
    }
}
