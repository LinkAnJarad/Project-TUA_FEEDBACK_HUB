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
    public partial class pg10_ComplainGraph : Form
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
        public pg10_ComplainGraph()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbCAHS_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'CAHS';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbCAHS.Value = collegerec;
                pbCAHS.Maximum = 10;
                MessageBox.Show(collegerec + "");
            }
        }

        private void pbCEIS_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'CEIS';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbCEIS.Value = collegerec;
                pbCEIS.Maximum = 10;
                MessageBox.Show(collegerec + "");
            }
        }

        private void progressBar6_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'SLCN';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                //pbSLCN.Value  = collegerec;
                //pbSLCN.Maximum = 10;
                MessageBox.Show(collegerec + "");
            }
        }
    }
}