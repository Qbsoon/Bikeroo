using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Bikeroo
{
    public partial class klient : Form
    {
        private int userId;
        private string connectionString;
        public klient()
        {
            InitializeComponent();
            reloadRentList();
            reloadReturnList();
        }

        public void setUserId(int id)
        {
            userId = id;
        }

        public void setConnectionString(string connString)
        {
            connectionString = connString;
            reloadRentList();
            reloadReturnList();
        }

        private void reloadRentList()
        {
            if (connectionString != null && userId > 0)
            {
                rentList.Items.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id FROM bikes WHERE (statusBorrowed IS NULL or statusBorrowed = '') AND (statusMaintenance IS NULL or statusMaintenance = '')";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rentList.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void reloadReturnList()
        {
            if (connectionString != null && userId > 0)
            {
                returnList.Items.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT Id FROM bikes WHERE statusBorrowed = {userId}";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void klient_Load(object sender, EventArgs e)
        {

        }

        private void rentBtn_click(object sender, EventArgs e)
        {

        }
    }
}
