using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Numerics;

namespace Bikeroo
{
    public partial class main : Form
    {
        private string connectionString;
        public main()
        {
            InitializeComponent();
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite");
            connectionString = $"Data Source={databasePath}";

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usernameText = login.Text;
            string passwordText = password.Text;
            int userId = -1;
            int type = -1;
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Id, type FROM users WHERE username=@username AND password=@password";
                SqliteCommand command = new SqliteCommand(query, connection);
                command.Parameters.AddWithValue("@username", usernameText);
                command.Parameters.AddWithValue("@password", passwordText);
                SqliteDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    userId = reader.GetInt32(0);
                    type = reader.GetInt32(1);
                }
            }
            if (type == 2)
            {
                this.Hide();
                klient klientForm = new klient();
                klientForm.setUserId(userId);
                klientForm.setConnectionString(connectionString);
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

        private void singInButton_Click(object sender, EventArgs e)
        {
            string usernameText = login.Text;
            string passwordText = password.Text;
            if (string.IsNullOrWhiteSpace(usernameText) || string.IsNullOrWhiteSpace(passwordText))
            {
                MessageBox.Show("Proszê wprowadziæ nazwê u¿ytkownika i has³o.");
                return;
            }
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();

                string checkUser = "SELECT COUNT(*) FROM users WHERE username=@username";
                using (var checkCommand = new SqliteCommand(checkUser, connection))
                {
                    checkCommand.Parameters.AddWithValue("@username", usernameText);
                    long count = (long)checkCommand.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("U¿ytkownik o tej samej nazwie ju¿ istnieje.");
                        return;
                    }
                }
                string insertQuery = "INSERT INTO users (username, password, type, balance) VALUES (@username, @password, 2, 0)";
                using (var insertCommand = new SqliteCommand(insertQuery, connection))
                {
                    insertCommand.Parameters.AddWithValue("@username", usernameText);
                    insertCommand.Parameters.AddWithValue("@password", passwordText);
                    insertCommand.ExecuteNonQuery();
                }
                login.Text = "";
                password.Text = "";
                login.Focus();
                MessageBox.Show("Rejestracja zakoñczona, mo¿esz siê teraz zalogowaæ");
                //dodaj zapisywanie trwa³e bazy
            }
        }

        private void report_Click(object sender, EventArgs e)
        {
            
            zgloszenia zgloszenie = new zgloszenia();
            zgloszenie.Show();
        }
    }
}
