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
    public partial class pg9_ComplainList : Form
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
        public pg9_ComplainList()
        {
            InitializeComponent();
            dgComplaintList.CellContentClick += dgComplaintList_CellContentClick;
            dgComplaintList.ForeColor = System.Drawing.Color.Black;
            load_complaints();
        }

        public void load_complaints()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT fdbk_refno, fdbk_type, CONCAT(u.user_fname, "" "", u.user_sname) as name FROM feedback JOIN useraccounts as u WHERE feedback.user_id = u.acct_number;";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Clear existing rows in the DataGridView
                    dgComplaintList.Rows.Clear();

                    // Loop through the data reader and populate the DataGridView
                    while (reader.Read())
                    {
                        // Assuming you have the columns in the DataGridView set up correctly
                        int rowIndex = dgComplaintList.Rows.Add();
                        DataGridViewRow row = dgComplaintList.Rows[rowIndex];

                        // Populate the row with data from the reader
                        row.Cells["hdrComplainID"].Value = reader["fdbk_refno"];
                        row.Cells["hdrComplainType"].Value = reader["fdbk_type"];
                        row.Cells["hdrName"].Value = reader["name"];
                        row.Cells["hdrOpen"].Value = "Open";
                        //row.Cells["hdrPriorityLevel"].Value = "Default Priority"; // Set your default value here
                    }
                }
            }

        }

        private void dgComplaintList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the button column
            //dfsdf
            if (e.ColumnIndex == dgComplaintList.Columns["hdrOpen"].Index && e.RowIndex >= 0)
            {
                // Retrieve the value of hdrComplainID from the same row
                var complainID = dgComplaintList.Rows[e.RowIndex].Cells["hdrComplainID"].Value.ToString();

                // Now you can use the complainID as needed
                //MessageBox.Show("Open button clicked for Complain ID: " + complainID);
                Feedback_Form feedbacackform = new Feedback_Form(complainID);
                feedbacackform.Show();

                // You can also perform other actions, such as opening a detailed view of the complaint
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg5_Welcoming2 LoginPage = new pg5_Welcoming2();
            LoginPage.Show();
            this.Close();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg6_AccountApproval accountApproval = new pg6_AccountApproval();
            accountApproval.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Feedback_Form feedbackForm = new Feedback_Form();
            //feedbackForm.Show();
            //this.Hide();
        }

        private void pg9_ComplainList_Load(object sender, EventArgs e)
        {

        }
    }
}
