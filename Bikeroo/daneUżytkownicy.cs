using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikeroo
{
    public partial class daneUżytkownicy : Form
    {
        private string connectionString;
        public daneUżytkownicy()
        {
            InitializeComponent();
        }
        public void setConnectionString(string connnString)
        {
            connectionString = connnString;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void adminAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string loginText = login.Text;
            string passwordText = password.Text;
            int type = 3;
            if (adminAdd.Checked)
            {
                type = 0;
            }else if (engenierAdd.Checked)
            {
                type = 1;
            }else if (clientAdd.Checked)
            {
                type = 2;
            }
            if (string.IsNullOrWhiteSpace(loginText) || string.IsNullOrWhiteSpace(passwordText) || type == 3)
            {
                MessageBox.Show("Proszę wprowadzić login, hasło oraz zaznaczyć rodzaj konta.");
                return;
            }
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string checkStation = "SELECT COUNT(*) FROM users WHERE username=@username";
                using (var checkCommand = new SqliteCommand(checkStation, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", loginText);
                    long count = (long)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Osoba o takim login-ie już istnieje zmień go na inny");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO users(username, password,type) VALUES (@username,@password,@type)";
                using (var insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@username", loginText);
                    insertCommand.Parameters.AddWithValue("@password", passwordText);
                    insertCommand.Parameters.AddWithValue("@type", type);
                    insertCommand.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}
