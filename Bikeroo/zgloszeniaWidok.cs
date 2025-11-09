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
        private string connectionString;
        public zgloszeniaWidok()
        {
            InitializeComponent();
        }
        public void setUserId(int id)
        {
            userId = id;
        }
        public void setConnectionString(string connnString)
        {
            connectionString = connnString;
            loadReports();
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
                            reportType_n = "System";
                        }
                        else if (reportType == 2)
                        {
                            reportType_n = "Rowery i stacje";
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
                        int reportUser=reader.GetInt32(4);
                        int reportHelper=reader.GetInt32(5);
                        reportList.Rows.Add(reportId, reportTitle, reportType_n, reportState_n, reportUser, reportHelper);
                    }
                }
            }
        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }
    }
}
