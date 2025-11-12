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
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private int userId;
        private string connectionString;
        public admin()
        {
            InitializeComponent();
            loadUsers();
            loadBikes();
            loadStations();
            this.Load += adminLoad;
            this.Resize += adminResize;
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
            if (userId == id && table=="users")
            {
                MessageBox.Show("Nie możesz usunąć samego siebie");
                return;
            }
            /* jeśli admin chciałby usuąć wszystkich adminów to i tak nie może usunąć siebie, czyli zawsze będzie co najmniej jeden admin
               if (table=="users"&& tableObj.SelectedRows[0].Cells[2].Value.ToString()=="Admin")
            {
                int adminCount;
                using (var connection=new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE type=0";
                    SqliteCommand command=new SqliteCommand(query, connection);
                    adminCount = Convert.ToInt32(command.ExecuteScalar());
                }
                if (adminCount == 1)
                {
                    MessageBox.Show("Nie można usunąć jedynego Admina");
                    return;
                }
            }
            */
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
            daneUżytkownik.setConnectionString(connectionString);
            daneUżytkownik.FormClosed += addAccouunt;
            daneUżytkownik.Show();
        }
        private void addAccouunt(object sender, EventArgs e)
        {
            loadUsers();
            MessageBox.Show("Dodano konto");
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
            loadBikes();
            MessageBox.Show("Rower dodano pomyślnie");
        }
        private void addStation_Click(object sender, EventArgs e)
        {
            daneStacja daneStacji = new daneStacja();
            daneStacji.setConnectionString(connectionString);
            daneStacji.FormClosed += addStationEnd;
            daneStacji.Show();
        }
        private void addStationEnd(object sender, EventArgs e)
        {
            loadStations();
            MessageBox.Show("Stacja dodana pomyślnie");
        }

        private void reports_Click(object sender, EventArgs e)
        {
            zgloszenia zgloszenie = new zgloszenia();
            zgloszenie.setUserId(userId);
            zgloszenie.setConnectionString(connectionString);
            zgloszenie.Show();
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
        private void adminLoad(object sender, EventArgs e)
        {
            originalSize = this.Size;
            StoreOriginalBoundsRecursive(this);
        }
        private void adminResize(object sender, EventArgs E)
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
    }
}
