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
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        private string connectionString;
        public daneStacja()
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
