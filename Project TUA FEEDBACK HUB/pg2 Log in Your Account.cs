using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TUA_FEEDBACK_HUB
{
    public partial class pg2_Log_in_Your_Account : Form
    {

        public pg2_Log_in_Your_Account()
        {
            InitializeComponent();

        }
        static string server = "localhost";
        static string port = "3306";
        static string username = "root";
        static string password = "";
        static string database = "tuafms";

        static string connectionString = $"server={server};port={port};username={username};password={password};database={database};";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connectionString);
            try
            {
                mySqlConnection.Open();
                return mySqlConnection;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
                return null;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            p3_Forgot_password p3_Forgot_Password = new p3_Forgot_password();
            p3_Forgot_Password.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg4_Registration p4_Registration = new pg4_Registration();
            p4_Registration.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = emailTXTbox.Text;
            string password = passTXTbox.Text;
            MySqlConnection connection = GetConnection();



            string query = "SELECT COUNT(*) FROM admin_info WHERE admin_name = @username AND admin_pass = @password";
            MySqlCommand commandSql = new MySqlCommand(query, connection);

            commandSql.Parameters.AddWithValue("@username", username);
            commandSql.Parameters.AddWithValue("@password", password);

            int count = Convert.ToInt32(commandSql.ExecuteScalar());
            if (count > 0)
            {
                // Successful login, proceed to the dashboard
                pg5_Welcoming2 dashboard = new pg5_Welcoming2();
                dashboard.Show();
                /*Fullhistory fullhistory = new Fullhistory();
                fullhistory.Show();*/
                this.Hide(); // Hide the login form
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private void pg2_Log_in_Your_Account_Load(object sender, EventArgs e)
        {

        }
    }

}
  
