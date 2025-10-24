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
    public partial class daneStacja : Form
    {
        private string connectionString;
        public daneStacja()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void setConnectionString(string connnString)
        {
            connectionString = connnString;
        }
        private void addStation_Click(object sender, EventArgs e)
        {
            string stationText = stationName.Text;
            if (string.IsNullOrWhiteSpace(stationText))
            {
                MessageBox.Show("Proszę wprowadzić Nazwę nowej stacji.");
                return;
            }
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string checkStation = "SELECT COUNT(*) FROM stations WHERE name=@name";
                using (var checkCommand = new SqliteCommand(checkStation, connection))
                {
                    checkCommand.Parameters.AddWithValue("@name",stationText);
                    long count = (long)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Stacja o tej nazwie istnieje");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO stations(name) VALUES (@name)";
                using (var insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@name", stationText);
                    insertCommand.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}
