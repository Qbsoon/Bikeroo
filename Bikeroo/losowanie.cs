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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Bikeroo
{
    public partial class losowanie : Form
    {
        private int userId;
        private string connectionString;
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public losowanie(int userId)
        {
            InitializeComponent();
            this.userId= userId;
            this.Load += clientLoad;
            this.Resize += clientResize;
        }
        public void setConnectionString(string connString)
        {
            connectionString = connString;
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
        private void randomButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int randomNumber = rand.Next(1, 101); // Losowa liczba od 1 do 100
            if (randomNumber == 86)
            {
                MessageBox.Show("Gratulacje! Wygrałeś rower!");

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE users SET winner = 1 WHERE id = @userId";
                    SqliteCommand command = new SqliteCommand(query, connection);
                    command.Parameters.AddWithValue("@userId", userId);
                    command.ExecuteNonQuery();
                    string insertQuery = "INSERT INTO reports(title, body, type, reportingUser) VALUES (@title,@body,@type,@reportingUser)";
                    using (var insertCommand = new SqliteCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@title", "WYGRANA W LOSOWANIU");
                        insertCommand.Parameters.AddWithValue("@body", "UŻYTKOWNIK WYGRAŁ ROWER" );
                        insertCommand.Parameters.AddWithValue("@type", 2);
                        insertCommand.Parameters.AddWithValue("@reportingUser", userId);
                        insertCommand.ExecuteNonQuery();
                    }
                }
            }
            else
            {
                MessageBox.Show("Niestety, spróbuj ponownie.");
            }
            this.Close();
        }
    }
}
