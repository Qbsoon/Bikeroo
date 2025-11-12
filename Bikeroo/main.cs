using Microsoft.Data.Sqlite;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data;
using System.Numerics;

namespace Bikeroo
{
    public partial class main : Form
    {
        private string connectionString;
        private Size originalSize;
        private Dictionary<Control, Rectangle> originalControlBounds = new Dictionary<Control, Rectangle>();
        public main()
        {
            InitializeComponent();
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "database.sqlite");
            connectionString = $"Data Source={databasePath}";
            this.Load += mainLoad;
            this.Resize += mainResize;
        }
        private void mainLoad(object sender, EventArgs e)
        {
            originalSize = this.Size;
            StoreOriginalBoundsRecursive(this);
        }
        private void mainResize(object sender, EventArgs E)
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
                engineerForm.setUserId(userId);
                engineerForm.setConnectionString(connectionString);
                engineerForm.ShowDialog();
                this.Close();
            }
            else if (type == 0)
            {
                this.Hide();
                admin adminForm = new admin();
                adminForm.setUserId(userId);
                adminForm.setConnectionString(connectionString);
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
            zgloszenie.setUserId(1);
            zgloszenie.setConnectionString(connectionString);
            zgloszenie.Show();
        }
    }
}
