using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bikeroo
{
    public partial class daneRowery : Form
    {
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private string connectionString;
        public daneRowery()
        {
            InitializeComponent();
            this.Load += daneLoad;
            this.Resize += adneResize;
        }
        private void daneLoad(object sender, EventArgs e)
        {
            originalSize = this.Size;
            StoreOriginalBoundsRecursive(this);
        }
        private void adneResize(object sender, EventArgs E)
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
            try 
            {
                int nrStation = Convert.ToInt32(bikeStation.Text);
                if (string.IsNullOrWhiteSpace(modelText) || string.IsNullOrWhiteSpace(bikeStation.Text))
                {
                    MessageBox.Show("Proszę wprowadzić model roweru i stację na którą jest wprowadzany.");
                    return;
                }
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string checkStation = "SELECT COUNT(*) FROM stations WHERE Id=@station";
                    using (var checkCommand = new SqliteCommand(checkStation, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@station", nrStation);
                        long count = (long)checkCommand.ExecuteScalar();
                        if (count <= 0)
                        {
                            MessageBox.Show("Wybrano stację o nieistniejącym ID");
                            return;
                        }
                    }
                    string insertQuery = "INSERT INTO bikes(model, station) VALUES (@model,@station)";
                    using (var insertCommand = new SqliteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@model", modelText);
                        insertCommand.Parameters.AddWithValue("@station", nrStation);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Podaj numer stacji, nie jej nazwę");
            }
            this.Close();
        }

        
    }
}
