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
    public partial class daneUżytkownicy : Form
    {
        private string connectionString;
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public daneUżytkownicy()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void adminAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            string loginText = login.Text;
            string passwordText = password.Text;
            int type = 3;
            if (adminAdd.Checked)
            {
                type = 0;
            }else if (engenierAdd.Checked)
            {
                type = 1;
            }else if (clientAdd.Checked)
            {
                type = 2;
            }
            if (string.IsNullOrWhiteSpace(loginText) || string.IsNullOrWhiteSpace(passwordText) || type == 3)
            {
                MessageBox.Show("Proszę wprowadzić login, hasło oraz zaznaczyć rodzaj konta.");
                return;
            }
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string checkStation = "SELECT COUNT(*) FROM users WHERE username=@username";
                using (var checkCommand = new SqliteCommand(checkStation, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", loginText);
                    long count = (long)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Osoba o takim login-ie już istnieje zmień go na inny");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO users(username, password,type) VALUES (@username,@password,@type)";
                using (var insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@username", loginText);
                    insertCommand.Parameters.AddWithValue("@password", passwordText);
                    insertCommand.Parameters.AddWithValue("@type", type);
                    insertCommand.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}
