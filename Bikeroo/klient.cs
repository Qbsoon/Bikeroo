using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Bikeroo
{
    public partial class klient : Form
    {
        private int userId;
        private string connectionString;
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public klient()
        {
            InitializeComponent();
            reloadBalance();
            reloadRentList();
            reloadReturnList();
            this.Load += clientLoad;
            this.Resize += clientResize;
        }
        private void clientLoad(object sender, EventArgs e)
        {
            originalSize = this.Size;
            StoreOriginalBoundsRecursive(this);
        }
        private void clientResize(object sender, EventArgs E)
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

        public void setConnectionString(string connString)
        {
            connectionString = connString;
            reloadBalance();
            reloadRentList();
            reloadReturnList();
            loadStations();
            reloadPoints();
        }
        private void reloadPoints()
        {
            if (connectionString != null && userId > 0)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT points FROM users WHERE Id=@userId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    SqliteDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        pointsLable.Text = "Punkty: " + reader.GetDouble(0);
                    }
                }
            }
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
                rentList.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT bikes.Id AS BikeId, bikes.model AS Model, stations.name AS StationName FROM bikes JOIN stations ON bikes.station=stations.Id WHERE (statusBorrowed IS NULL or statusBorrowed = '') AND (statusMaintenance IS NULL or statusMaintenance = '') ORDER BY stations.name ASC, bikes.Id ASC";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        rentList.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2));
                    }
                }
            }
        }

        private void reloadReturnList()
        {
            if (connectionString != null && userId > 0)
            {
                returnList.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"SELECT Id, model, timeOfRent FROM bikes WHERE statusBorrowed=@userId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        returnList.Rows.Add(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetDateTime(2));
                    }
                }
            }
        }
        private void loadStations()
        {
            if (connectionString != null)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT name FROM stations ORDER BY name ASC";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    stationToReturn.Items.Clear();
                    while (reader.Read())
                    {
                        string stationName = reader.GetString(0);
                        stationToReturn.Items.Add(stationName);
                    }
                }
            }
        }

        private void klient_Load(object sender, EventArgs e)
        {

        }

        private void rentBtn_click(object sender, EventArgs e)
        {
            double balacneOriginal = 0;
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT balance FROM users WHERE Id=@userId";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    if (reader.GetDouble(0) < 10)
                    {
                        MessageBox.Show("Nie masz wystarczających środków na koncie, aby wypożyczyć rower. Minimalne saldo to 10 PLN.");
                        return;
                    }
                    else
                    {
                        balacneOriginal = reader.GetDouble(0);
                    }
                }
            }
            var selected = rentList.SelectedRows[0].Cells[0].Value as string;
            if (selected != null && connectionString != null && userId > 0)
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE bikes SET statusBorrowed=@userId, timeOfRent=@date WHERE Id=@bikeId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.Parameters.AddWithValue("@date", DateTime.UtcNow);
                    command.Parameters.AddWithValue("@bikeId", selected);
                    command.ExecuteNonQuery();

                    query = "UPDATE users SET balance=@balance WHERE Id=@userId";
                    SqliteCommand updateCommand = new SqliteCommand(query, connection);
                    updateCommand.Parameters.AddWithValue("@userId", userId);
                    updateCommand.Parameters.AddWithValue("@balance", balacneOriginal - 1);
                    updateCommand.ExecuteReader();
                    reloadBalance();
                }
                reloadRentList();
                reloadReturnList();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            var selected = returnList.SelectedRows[0].Cells[0].Value as string;
            if (selected == null)
            {
                MessageBox.Show("Proszę wybrać rower do zwrócenia.");
                return;
            }
            var selectedStation = stationToReturn.SelectedItem;
            if (selectedStation == null)
            {
                MessageBox.Show("Proszę podać stację, do której zwracasz rower.");
                return;
            }

            string stationName = selectedStation.ToString();
            int stationId = 0;
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
                    MessageBox.Show("Nie znaleziono podanej stacji.");
                    return;
                }
                double cost = 0;
                query = "SELECT timeOfRent FROM bikes WHERE Id=@bikeId";
                SqliteCommand timeCommand = new SqliteCommand(query, connection);
                timeCommand.Parameters.AddWithValue("@bikeId", selected);
                var rentTimeObj = timeCommand.ExecuteScalar();
                if (rentTimeObj != DBNull.Value && rentTimeObj != null)
                {
                    DateTime timeOfRent = DateTime.Parse(rentTimeObj.ToString());
                    DateTime now = DateTime.Now;
                    TimeSpan rentalDuration = now - timeOfRent;
                    double hours = rentalDuration.TotalHours;
                    cost = 5 * hours;

                    query = "UPDATE users SET balance = ROUND(balance - @cost, 2) WHERE Id = @userId";
                    SqliteCommand costCommand = new SqliteCommand(query, connection);
                    costCommand.Parameters.AddWithValue("@cost", cost);
                    costCommand.Parameters.AddWithValue("@userId", userId);
                    costCommand.ExecuteNonQuery();

                    query = "UPDATE users SET points = ROUND(points + FLOOR(@cost), 2) WHERE Id = @userId";
                    SqliteCommand pointsCommand = new SqliteCommand(query, connection);
                    pointsCommand.Parameters.AddWithValue("@cost", cost);
                    pointsCommand.Parameters.AddWithValue("@userId", userId);
                    pointsCommand.ExecuteNonQuery();
                }

                query = "UPDATE bikes SET statusBorrowed=NULL, station=@stationId WHERE Id=@bikeId";
                SqliteCommand updateCommand = new SqliteCommand(query, connection);
                updateCommand.Parameters.AddWithValue("@bikeId", selected);
                updateCommand.Parameters.AddWithValue("@stationId", stationId);
                updateCommand.ExecuteNonQuery();
            }
            reloadBalance();
            reloadRentList();
            reloadReturnList();
            reloadPoints();
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

        private void addMoney_Click(object sender, EventArgs e)
        {
            klientZasilenie addMoney = new klientZasilenie();
            if (addMoney.ShowDialog() == DialogResult.OK)
            {
                decimal amountToAdd = addMoney.amountToAdd;
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users SET balance = ROUND(balance + @amount, 2) WHERE Id = @userId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@amount", amountToAdd);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.ExecuteNonQuery();
                }
                reloadBalance();
            }
        }

        private void gambleButton_Click(object sender, EventArgs e)
        {
            losowanie gamble = new losowanie(userId); //testowałem jak działa takie przekazywanie danych
            gamble.setConnectionString(connectionString);
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT points FROM users WHERE Id=@userId";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@userId", userId);
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    double points = reader.GetDouble(0);
                    reader.Close();
                    if (points >= 100)
                    {
                        gamble.ShowDialog();
                        reloadPoints();
                    }
                    else
                    {
                        MessageBox.Show("Nie masz wystarczającej ilości punktów aby wziąć udział w losowaniu. Minimalna ilość punktów to 100.");
                        return;
                    }
                }
            }
        }
    }
}
