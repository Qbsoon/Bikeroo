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
    public partial class zgloszenia : Form
    {
        private int userId;
        private string connectionString;
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public zgloszenia()
        {
            InitializeComponent();
            this.Load += zglLoad;
            this.Resize += zglResize;
        }
        private void zglLoad(object sender, EventArgs e)
        {
            originalSize = this.Size;
            StoreOriginalBoundsRecursive(this);
        }
        private void zglResize(object sender, EventArgs E)
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
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            string title=reportTitle.Text;
            string body = reportText.Text;
            int reportingUser= userId;
            int type;
            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(body))
            {
                MessageBox.Show("Musisz podać tytuł zgłoszenia oraz je opisać");
                return;
            }
            if (bikesAndStations.Checked && system.Checked) 
            {
                type = 0;
            }else if (bikesAndStations.Checked){
                type = 1;
            }else if (system.Checked)
            {
                type = 2;
            }
            else
            {
                MessageBox.Show("Nie wybrano jakiej kategorii jest to zgłoszenie, wybierz jedną z opcji, lub obie jeśli nie jesteś pewien");
                return;
            }
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO reports(title, body, type, reportingUser) VALUES (@title,@body,@type,@reportingUser)";
                using (var insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@title", title);
                    insertCommand.Parameters.AddWithValue("@body", body);
                    insertCommand.Parameters.AddWithValue("@type", type);
                    insertCommand.Parameters.AddWithValue("@reportingUser", userId);
                    insertCommand.ExecuteNonQuery();
                }
            }
            this.Close();
        }
    }
}
