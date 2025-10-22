using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikeroo
{
    public partial class admin : Form
    {
        private int userId;
        private string connectionString;
        public admin()
        {
            InitializeComponent();
            loadUsers();
            loadBikes();
            loadStations();
        }

        public void setUserId(int id)
        {
            userId = id;
        }

        public void setConnectionString(string connString)
        {
            connectionString = connString;
            loadUsers();
            loadBikes();
            loadStations();
        }

        private void loadUsers()
        {
            if (connectionString != null && userId > 0)
            {
                userTable.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = ("SELECT Id, username, type, balance FROM users");
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int type = reader.GetInt32(2);
                        string type_n = "";
                        if (type == 0)
                        {
                            type_n = "Admin";
                        }
                        else if (type == 1)
                        {
                            type_n = "Inżynier";
                        }
                        else if (type == 2)
                        {
                            type_n = "Klient";
                        }
                        float balance = reader.GetFloat(3);
                        userTable.Rows.Add(id, name, type_n, balance);
                    }
                }
            }
        }
        private void loadBikes()
        {
            if (connectionString != null && userId > 0)
            {
                bikeTable.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT b.Id,b.model,s.name AS stationName, b.statusBorrowed, b.statusMaintenance FROM bikes b JOIN stations s ON b.station=s.Id";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string model = reader.GetString(1);
                        string stationName = reader.GetString(2);
                        string statusBorrowed = reader.IsDBNull(3) ? "" : reader.GetString(3);
                        string statusMaintenance = reader.IsDBNull(4) ? "" : reader.GetString(4);
                        bikeTable.Rows.Add(id, model, stationName, statusBorrowed, statusMaintenance);
                    }
                }
            }
        }
        private void loadStations()
        {
            if (connectionString != null && userId > 0)
            {
                stationTable.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT s.Id,s.name,COUNT(b.Id) AS bikesCount FROM stations s LEFT JOIN bikes b ON b.station=s.Id GROUP BY s.Id, s.name";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        int bikesCount = reader.GetInt32(2);
                        stationTable.Rows.Add(id, name, bikesCount);
                    }
                }
            }
        }
        private void deleteSelected(string table, DataGridView tableObj, Action reloadMethod)
        {
            if (tableObj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz element do usunięcia");
                return;
            }
            var result = new usun().ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            int id = Convert.ToInt32(tableObj.SelectedRows[0].Cells[0].Value);
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = $"DELETE FROM {table} WHERE Id=@id";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            reloadMethod();
        }
        private void deleteStation_Click(object sender, EventArgs e)
        {
            deleteSelected("stations", stationTable, loadStations);
        }
        private void deleteBike_Click(object sender, EventArgs e)
        {
            deleteSelected("bikes", bikeTable, loadBikes);
        }
        private void deleteAccounts_Click(object sender, EventArgs e)
        {
            deleteSelected("users", userTable, loadUsers);
        }
        private void addAccounts_Click(object sender, EventArgs e)
        {
            daneUżytkownicy daneUżytkownik = new daneUżytkownicy();
            daneUżytkownik.Show();
        }
        private void addBike_Click(object sender, EventArgs e)
        {
            daneRowery daneRowerow = new daneRowery();
            daneRowerow.Show();
        }
        private void addStation_Click(object sender, EventArgs e)
        {
            daneStacja daneStacji = new daneStacja();
            daneStacji.Show();
        }

        private void reports_Click(object sender, EventArgs e)
        {
            zgloszenia zgloszenia_sprawdz = new zgloszenia();
            zgloszenia_sprawdz.Show();
        }
    }
}
