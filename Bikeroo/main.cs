using Microsoft.Data.Sqlite;
using System.Data;

namespace Bikeroo
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usernameText = login.Text;
            string passwordText = password.Text;
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite");
            string connectionString = $"Data Source={databasePath}";
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT type FROM users WHERE username=@username AND password=@password";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@username", usernameText);
                command.Parameters.AddWithValue("@password", passwordText);
                object result = command.ExecuteScalar();
                int type = result != null ? Convert.ToInt32(result) : -1;
                if (type == 2)
                {
                    this.Hide();
                    klient klientForm = new klient();
                    klientForm.ShowDialog();
                    this.Close();
                }
                else if (type == 1)
                {
                    this.Hide();
                    engineer engineerForm = new engineer();
                    engineerForm.ShowDialog();
                    this.Close();
                }
                else if (type == 0)
                {
                    this.Hide();
                    admin adminForm = new admin();
                    adminForm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }
    }
}
