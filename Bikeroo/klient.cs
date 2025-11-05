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
            reloadBalance();
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
            reloadBalance();
            reloadRentList();
            reloadReturnList();
        }

        private void reloadBalance()
        {
            if (connectionString != null && userId > 0)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT balance FROM users WHERE Id=@userId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    SqliteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        balanceLabel.Text = "Saldo: " + reader.GetDouble(0) + " PLN";
                    }
                }
            }
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
            var selected = rentList.SelectedItem as string;
            if (selected != null && connectionString != null && userId > 0)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE bikes SET statusBorrowed=@userId WHERE Id=@bikeId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@bikeId", selected);
                    command.ExecuteNonQuery();
                }
                reloadRentList();
                reloadReturnList();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var selected = returnList.SelectedItem as string;
            var stationName = stationInput.Text;
            int stationId = 0;
            if (stationName == "")
            {
                MessageBox.Show("Proszę podać ID stacji, do której zwracasz rower.");
                return;
            }
            else
            {
                if (connectionString != null && userId > 0)
                {
                    using (var connection = new SqliteConnection(connectionString))
                    {
                        connection.Open();
                        string query = "SELECT Id FROM stations WHERE name=@stationName";
                        SqliteCommand command = new SqliteCommand(query, connection);
                        command.Parameters.AddWithValue("@stationName", stationName);
                        SqliteDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            stationId = reader.GetInt32(0);

                        }
                        else
                        {
                            MessageBox.Show("Podana stacja nie istnieje.");
                            return;
                        }
                    }
                }
            }
            if (selected != null)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE bikes SET statusBorrowed=NULL, station=@stationId WHERE Id=@bikeId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@bikeId", selected);
                    command.Parameters.AddWithValue("@stationId", stationId);
                    command.ExecuteNonQuery();
                }
                reloadRentList();
                reloadReturnList();
            }
        }
        private void reportButton_Click(object sender, EventArgs e)
        {
            zgloszenia zgloszenie = new zgloszenia();
            zgloszenie.setUserId(userId);
            zgloszenie.setConnectionString(connectionString);
            zgloszenie.Show();
            zgloszenie.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mainForm = new main();
            mainForm.ShowDialog();
            this.Close();
        }
    }
}
