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
    public partial class pg6_AccountApproval : Form
    {


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

        MySqlConnection connection = GetConnection();

        public pg6_AccountApproval()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg5_Welcoming2 LoginPage = new pg5_Welcoming2();
            LoginPage.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg9_ComplainList ComplainPage = new pg9_ComplainList();
            ComplainPage.Show();
            this.Close();


        }

        private void load_data()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM useraccounts;";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string user_fname = reader["user_fname"].ToString();
                    string user_mname = reader["user_mname"].ToString();
                    string user_lname = reader["user_lname"].ToString();
                    string acct_number = reader["acct_number"].ToString();
                    string act_type = reader["act_type"].ToString();
                    string coll_acrnym = reader["coll_acrnym"].ToString();

                    approval_table.Rows.Add(
                        user_fname,
                        user_mname,
                        user_lname,
                        acct_number,
                        act_type,
                        coll_acrnym,
                        "View Details");
                }
            }

        }

        private void pg6_AccountApproval_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
