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
        public klient()
        {
            InitializeComponent();
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite");
            string connectionString = $"Data Source={databasePath}";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM bikes";
                SqliteCommand command = new SqliteCommand(query, connection);
                SqliteDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    rentList.Items.Add(reader.GetString(0));
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
