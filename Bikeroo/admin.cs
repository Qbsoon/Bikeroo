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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        private void adminLoad(object sender, EventArgs e)
        {
            loadUsers();
            loadBikes();
            loadStations();
        }
        private void loadUsers()
        {
            userList.Items.Clear();
            using (var connection = new SqliteConnection("Data Source=database.sqlite"))
            {
                connection.Open();
                using (var command=new SqliteCommand("SELECT Id, username, type, balance FROM users",connection))
                {
                    using (var reader=command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int type = reader.GetInt32(2);
                            float balance = reader.GetFloat(3);
                            userList.Items.Add($"{id}: {name}, rola: {type}, balans konta: {balance}");
                        }
                    }
                }
            }
        }
        private void loadBikes()
        {
            bikeList.Items.Clear();
            using (var connection = new SqliteConnection("Data Source=database.sqlite"))
            {
                connection.Open();
                string query = @"SELECT b.Id,b.model,s.name AS stationName, b.statusMaintenance FROM bikes b JOIN stations s ON b.station=s.Id";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string model = reader.GetString(1);
                            string stationName=reader.GetString(2);
                            bool inMaintenance=!reader.IsDBNull(3);
                            bikeList.Items.Add($"{id}: {model}, Stacja:{stationName}, Naprawa: {inMaintenance}");
                        }
                    }
                }
            }
        }
        private void loadStations()
        {
            stationList.Items.Clear();
            using (var connection = new SqliteConnection("Data Source=database.sqlite"))
            {
                connection.Open();
                string query = @"SELECT s.Id,s.name,COUNT(b.Id) AS bikesCount, FROM stations s LEFT JOIN bikes b ON b.station=s.Id GROUP BY s.Id, s.name";
                using (var command = new SqliteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            int bikesCount = reader.GetInt32(2);

                            stationList.Items.Add($"{id}: {name}, Rowety na stacji: {bikesCount}");
                        }
                    }
                }
            }
        }
        private void deleteSelected(string table, ListView list, Action reloadMethod)
        {
            if (list.SelectedItems.Count == 0)
            {
                MessageBox.Show("Wybierz element do usunięcia");
                return;
            }
            var result = new usun().ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            string selected = list.SelectedItems[0].Text;
            int id = int.Parse(selected.Split(':')[0]);
            using (var connection = new SqliteConnection("Data Source=database.sqlite"))
            {
                connection.Open();
                using (var command = new SqliteCommand($"DELETE FROM {table} WHERE Id=@id",connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
            reloadMethod();
        }
        private void deleteStation_Click(object sender, EventArgs e)
        {
            deleteSelected("stations", stationList, loadStations);
        }
        private void deleteBike_Click(object sender, EventArgs e)
        {
            deleteSelected("bikes", bikeList, loadBikes);
        }
        private void deleteAccounts_Click(object sender, EventArgs e)
        {
            deleteSelected("users", userList, loadUsers);
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
