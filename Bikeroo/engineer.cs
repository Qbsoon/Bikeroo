using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class engineer : Form
    {
        public engineer()
        {
            InitializeComponent();
        }

        private int userId;
        private string connectionString;
        public void setUserId(int id)
        {
            userId = id;
        }
        public void setConnectionString(string connnString)
        {
            connectionString = connnString;
            loadAvailableBikes();
            loadRepairBikes();
        }
        private void loadAvailableBikes()
        {
            bikeList.Items.Clear();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM bikes WHERE statusMaintenance IS NULL OR statusMaintenance=''";
                var command = new SqliteCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    bikeList.Items.Add(reader.GetInt32(0).ToString());
                }

            }
        }
        private void loadRepairBikes()
        {
            repeirList.Items.Clear();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM bikes WHERE statusMaintenance=@userId";
                var command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@userID", userId);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    repeirList.Items.Add(reader.GetInt32(0).ToString());
                }

            }
        }

        private void bikeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void toRepeir_Click(object sender, EventArgs e)
        {
            var selected = bikeList.SelectedItems.Count > 0 ? bikeList.SelectedItems[0].Text : null;
            if (selected != null)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE bikes SET statusMaintenance=@userId WHERE Id=@bikeId";
                    var command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@bikeId", selected);
                    command.ExecuteNonQuery();
                }
                loadAvailableBikes();
                loadRepairBikes();
            }
            else
            {
                MessageBox.Show("Wybierz rower do naprawy");
                return;
            }
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            var selected = repeirList.SelectedItems.Count > 0 ? repeirList.SelectedItems[0].Text : null;
            if (selected == null)
            {
                MessageBox.Show("Wybierz rower z listy napraw");
                return;
            }
            if (deleteBike.Checked)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM bikes WHERE Id=@bikeId";
                    var command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@bikeId", selected);
                    command.ExecuteNonQuery();
                }
                loadAvailableBikes();
                loadRepairBikes();
            }
            if (toStation.Checked)
            {
                if (string.IsNullOrWhiteSpace(nrStation.Text))
                {
                    MessageBox.Show("Podaj ID stacji, na którą zwracasz rower");
                    return;
                }
                int stationId;
                if (!int.TryParse(nrStation.Text, out stationId))
                {
                    MessageBox.Show("Nieprawidłowy numer stacji");
                }
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    var checkStation = new SqliteCommand("SELECT COUNT(*) FROM stations WHERE Id=@id", connection);
                    checkStation.Parameters.AddWithValue("@id", stationId);
                    long count = (long)checkStation.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Stacja o takim ID nie istnieje");
                        return;
                    }
                    string query = "UPDATE bikes SET statusMaintenance = NULL, station=@stationId WHERE Id=@bikeId";
                    var command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@bikeId", selected);
                    command.Parameters.AddWithValue("@stationId", stationId);
                    command.ExecuteNonQuery();
                }
                loadAvailableBikes();
                loadRepairBikes();
                return;
            }
            MessageBox.Show("Wybierz, czy chcesz usunąć rower, czy zwrócić go na wybraną stację");
        }

        private void reports_Click(object sender, EventArgs e)
        {
            zgloszenia zgloszenia_pokaz = new zgloszenia();
            zgloszenia_pokaz.Show();
        }
    }
}
