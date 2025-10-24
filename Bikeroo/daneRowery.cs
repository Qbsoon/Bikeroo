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
    public partial class daneRowery : Form
    {
        private string connectionString;
        public daneRowery()
        {
            InitializeComponent();
        }
        public void setConnectionString(string connnString)
        {
            connectionString = connnString;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addBikes_Click(object sender, EventArgs e)
        {
            string modelText = addBikeModel.Text;
            int nrStation = Convert.ToInt32(bikeStation.Text);
            if (string.IsNullOrWhiteSpace(modelText) || string.IsNullOrWhiteSpace(bikeStation.Text))
            {
                MessageBox.Show("Proszę wprowadzić model roweru i stację na którą jest wprowadzany.");
                return;
            }
            using (var connection=new SqliteConnection(connectionString))
            {
                connection.Open();
                string checkStation = "SELECT COUNT(*) FROM stations WHERE Id=@station";
                using (var checkCommand = new SqliteCommand(checkStation,connection)) 
                {
                    checkCommand.Parameters.AddWithValue("@station", nrStation);
                    long count=(long)checkCommand.ExecuteScalar();
                    if (count<=0)
                    {
                        MessageBox.Show("Wybrano stację o nieistniejącym ID");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO bikes(model, station) VALUES (@model,@station)";
                using (var insertCommand=new SqliteCommand(insertQuery,connection))
                {
                    insertCommand.Parameters.AddWithValue("@model",modelText);
                    insertCommand.Parameters.AddWithValue("@station", nrStation);
                    insertCommand.ExecuteNonQuery();
                }
            }
            this.Close();
        }

        
    }
}
