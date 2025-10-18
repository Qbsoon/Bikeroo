using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Data.SqlClient;

namespace Bikeroo
{
    public partial class klient : Form
    {
        public klient()
        {
            InitializeComponent();
            /*
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;
                            AttachDbFilename={databasePath};
                            Integrated Security=True;
                            Connect Timeout=30";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id FROM bikes WHERE statusBorrowed IS NULL AND statusMaintenance IS NULL";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                rentList.DataSource = dataTable;
                rentList.DisplayMember = "Id";
            }
            */
        }

        private void klient_Load(object sender, EventArgs e)
        {

        }

        private void rentBtn_click(object sender, EventArgs e)
        {

        }
    }
}
