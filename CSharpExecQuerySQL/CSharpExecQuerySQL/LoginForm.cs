using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpExecQuerySQL
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            serverNameTextBox.Text = SettingFile.Default.SettingNameSv;
            dbNameTextBox.Text = SettingFile.Default.SettingNameDb;
        }

        public string ServerName, DbName;

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Save the input
            SettingFile.Default.SettingNameSv = serverNameTextBox.Text;
            SettingFile.Default.SettingNameDb = dbNameTextBox.Text;
            SettingFile.Default.Save();

            //Get the input
            ServerName = serverNameTextBox.Text;
            DbName = dbNameTextBox.Text;

            //Check SQL connection
            using (System.Data.SqlClient.SqlConnection connection = new System.Data.SqlClient.SqlConnection(Connect.ConnectToDatabase(ServerName, DbName)))
            {
                try
                {
                    connection.Open();
                }
                catch (System.Data.SqlClient.SqlException)
                {
                    MessageBox.Show("SQL Connection Failed.");
                    Application.Restart();
                }

                MessageBox.Show("SQL Connection Successfull.");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
