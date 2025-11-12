using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class zgloszeniaWidok : Form
    {

        private int userId;
        private int userType;
        private string connectionString;
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public zgloszeniaWidok()
        {
            InitializeComponent();
            this.Load += zglwLoad;
            this.Resize += zglwResize;
        }
        private void zglwLoad(object sender, EventArgs e)
        {
            originalSize = this.Size;
            StoreOriginalBoundsRecursive(this);
        }
        private void zglwResize(object sender, EventArgs E)
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
        public void setConnectionString(string connnString)
        {
            connectionString = connnString;
            userType=loadUserType();
            loadReports();
        }
        private int loadUserType()
        {
            using(var connection= new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT type FROM users WHERE Id=@id";
                SqliteCommand command=new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("id",userId);
                object result=command.ExecuteScalar();
                userType = Convert.ToInt32(result);
                return userType;
            }
        }
        private void loadReports()
        {
            if (connectionString != null && userId > 0)
            {
                reportList.Rows.Clear();
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    string query = ("SELECT Id, title, type, state, reportingUser, handlingUser FROM reports");
                    if (userType == 1)
                    {
                        query += " WHERE type IN (0,1)";
                    }
                    SqliteCommand command = new SqliteCommand(query, connection);
                    SqliteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int reportId = reader.GetInt32(0);
                        string reportTitle = reader.GetString(1);
                        int reportType = reader.GetInt32(2);
                        string reportType_n = "";
                        if (reportType == 0)
                        {
                            reportType_n = "System i rowery/stacje";
                        }
                        else if (reportType == 1)
                        {
                            reportType_n = "Rowery i stacje";
                        }
                        else if (reportType == 2)
                        {
                            reportType_n = "System";
                        }
                        int reportState = reader.GetInt32(3);
                        string reportState_n = "";
                        if (reportState == 0)
                        {
                            reportState_n = "Nie przydzielono";
                        }
                        else if (reportState == 1)
                        {
                            reportState_n = "Podczas wykonywania";
                        }
                        else if (reportState == 2)
                        {
                            reportState_n = "Wykonano";
                        }
                        int reportUser = reader.GetInt32(4);
                        int reportHelper = reader.GetInt32(5);
                        reportList.Rows.Add(reportId, reportTitle, reportType_n, reportState_n, reportUser, reportHelper);
                    }
                }
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (deleteReport.Checked)
            {
                deleteSelected("reports", reportList, loadReports);
            }
            else if (finishReport.Checked)
            {
                finishTask("reports", reportList, loadReports);
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej z opcji");
            }
        }
        private void deleteSelected(string table, DataGridView tableObj, Action reloadMethod)
        {
            if (tableObj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz zgłoszenie do usunięcia");
                return;
            }
            var result = new usun().ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            int id = Convert.ToInt32(tableObj.SelectedRows[0].Cells[0].Value);
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
        private void finishTask(string table, DataGridView tableObj, Action reloadMethod)
        {
            if (tableObj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz zgłoszenie do zamknięcia");
                return;
            }
            var result = new usun().ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            int id = Convert.ToInt32(tableObj.SelectedRows[0].Cells[0].Value);
            int reportState = 2;
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = $"UPDATE {table} SET state=@reportState WHERE Id=@id";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@reportState", reportState);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            reloadMethod();
        }

        private void takeButton_Click(object sender, EventArgs e)
        {
            reportTake("reports", reportList, loadReports, userId);
        }
        private void reportTake(string table, DataGridView tableObj, Action reloadMethod, int userId)
        {
            if (tableObj.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz zgłoszenie do przejęcia");
                return;
            }
            var result = new usun().ShowDialog();
            if (result != DialogResult.OK)
            {
                return;
            }
            int id = Convert.ToInt32(tableObj.SelectedRows[0].Cells[0].Value);
            int reportState = 1;
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = $"UPDATE {table} SET state=@reportState, handlingUser=@userId WHERE Id=@id";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@reportState", reportState);
                command.Parameters.AddWithValue("@userId", userId);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
            reloadMethod();
        }
        private void reportListSelectionChanged(object sender, EventArgs e)
        {
            if (reportList.SelectedRows.Count == 0)
            {
                reportBodyShow.Text = "";
                return;
            }
            int id = Convert.ToInt32(reportList.SelectedRows[0].Cells[0].Value);
            using (var connection=new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT body FROM reports WHERE Id=@id";
                SqliteCommand command= new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                object results=command.ExecuteScalar();
                if (results != null)
                {
                    reportBodyShow.Text = results.ToString();
                }
                else
                {
                    reportBodyShow.Text = "Brak treści zgłoszenia";
                }
            }
        }
    }
}
