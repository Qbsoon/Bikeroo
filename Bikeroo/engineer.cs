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
        private int userId;
        private string connectionString;
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();

        public engineer()
        {
            InitializeComponent();
            loadAvailableBikes();
            loadRepairBikes();
            this.Load += engineerLoad;
            this.Resize += engineerResize;
        }
        private void engineerLoad(object sender, EventArgs e)
        {
            originalSize = this.Size;
            StoreOriginalBoundsRecursive(this);
        }
        private void engineerResize(object sender, EventArgs E)
        {
            ResizeControlsRecursive(this);
        }
        private void StoreOriginalBoundsRecursive(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (!originalControlBounds.ContainsKey(ctrl))
                    originalControlBounds[ctrl] = ctrl.Bounds;

                if (ctrl.Controls.Count > 0)
                    StoreOriginalBoundsRecursive(ctrl);
            }
        }
        private void ResizeControlsRecursive(Control parent)
        {
            if (originalSize.Width == 0 || originalSize.Height == 0) return;

            float xRatio = (float)this.Width / originalSize.Width;
            float yRatio = (float)this.Height / originalSize.Height;

            foreach (Control ctrl in parent.Controls)
            {
                if (originalControlBounds.ContainsKey(ctrl))
                {
                    Rectangle orig = originalControlBounds[ctrl];
                    int newX = (int)(orig.X * xRatio);
                    int newY = (int)(orig.Y * yRatio);
                    int newWidth = (int)(orig.Width * xRatio);
                    int newHeight = (int)(orig.Height * yRatio);
                    ctrl.Bounds = new Rectangle(newX, newY, newWidth, newHeight);
                }
                if (ctrl.Controls.Count > 0)
                {
                    ResizeControlsRecursive(ctrl);
                }
            }
        }

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
            if (connectionString != null && userId > 0)
            {
                bikeList.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT b.Id,b.model,s.name AS stationName, b.statusBorrowed FROM bikes b JOIN stations s ON b.station=s.Id WHERE (statusBorrowed IS NULL or statusBorrowed = '') AND (statusMaintenance IS NULL or statusMaintenance = '')";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string status = reader.IsDBNull(3) ? "Nie" : "Tak";
                        bikeList.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), status);
                    }

                }
            }
        }
        private void loadRepairBikes()
        {
            if (connectionString != null && userId > 0)
            {
                repairList.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, Model FROM bikes WHERE statusMaintenance=@userId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        repairList.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1));
                    }
                }
            }
        }

        private void bikeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Placeholder
        }
        private void toRepair_Click(object sender, EventArgs e)
        {
            if (connectionString != null && userId > 0)
            {
                var selected = bikeList.SelectedRows.Count > 0 ? bikeList.SelectedRows[0].Cells[0].Value as string : null;
                if (selected != null)
                {
                    using (var connection = new SqliteConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE bikes SET statusMaintenance=@userId WHERE Id=@bikeId";
                        SqliteCommand command = new SqliteCommand(query, connection);
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
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            if (connectionString != null && userId > 0)
            {
                var selected = repairList.SelectedRows.Count > 0 ? repairList.SelectedRows[0].Cells[0].Value as string : null;
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
                        SqliteCommand command = new SqliteCommand(query, connection);
                        command.Parameters.AddWithValue("@bikeId", selected);
                        command.ExecuteNonQuery();
                    }
                    loadAvailableBikes();
                    loadRepairBikes();
                    return;
                }
                else if (toStation.Checked)
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
                        string query = "SELECT COUNT(*) FROM stations WHERE Id=@id";
                        SqliteCommand checkStation = new SqliteCommand(query, connection);
                        checkStation.Parameters.AddWithValue("@id", stationId);
                        long count = (long)checkStation.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("Stacja o takim ID nie istnieje");
                            return;
                        }
                        query = "UPDATE bikes SET statusMaintenance = NULL, station=@stationId WHERE Id=@bikeId";
                        SqliteCommand command = new SqliteCommand(query, connection);
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
        }

        private void reports_Click(object sender, EventArgs e)
        {
            zgloszenia zgloszenie = new zgloszenia();
            zgloszenie.setUserId(userId);
            zgloszenie.setConnectionString(connectionString);
            zgloszenie.Show();
            zgloszenie.Show();
        }

        private void addBike_Click(object sender, EventArgs e)
        {
            daneRowery dodajRower = new daneRowery();
            dodajRower.setConnectionString(connectionString);
            dodajRower.FormClosed += addBikeEnd;
            dodajRower.Show();
        }
        private void addBikeEnd(object sender, EventArgs e)
        {
            loadAvailableBikes();
            MessageBox.Show("Rower dodano pomyślnie");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void logOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mainForm = new main();
            mainForm.ShowDialog();
            this.Close();
        }

        private void reportsList_Click(object sender, EventArgs e)
        {
            zgloszeniaWidok zgloszenie = new zgloszeniaWidok();
            zgloszenie.setUserId(userId);
            zgloszenie.setConnectionString(connectionString);
            zgloszenie.Show();
        }
    }
}
