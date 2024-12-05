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



        MySqlConnection connection = ConnectionDB.GetConnection();
        public pg9_ComplainList()
        {
            InitializeComponent();
            dgComplaintList.CellContentClick += dgComplaintList_CellContentClick;
            load_complaints();
            dgComplaintList.CellValueChanged += dgComplaintList_CellValueChanged;

            dgComplaintList.ForeColor = System.Drawing.Color.Black;
            
        }

        public void load_complaints()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT fdbk_refno, fdbk_type, fdbk_priority, CONCAT(u.user_fname, "" "", u.user_sname) as name FROM feedback JOIN useraccounts as u WHERE feedback.user_id = u.acct_number AND feedback.fdbk_status='Pending';";
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
                        row.Cells["hdrPriorityLevel"].Value = reader["fdbk_priority"]; // Set your default value heregdg
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
                var name = dgComplaintList.Rows[e.RowIndex].Cells["hdrName"].Value.ToString();


                // Now you can use the complainID as needed
                //MessageBox.Show("Open button clicked for Complain ID: " + complainID);
                Feedback_Form feedbacackform = new Feedback_Form(complainID, name);
                feedbacackform.Show();

                // You can also perform other actions, such as opening a detailed view of the complaint
            }
        }

        private void dgComplaintList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the event is for the Priority ComboBox column
            if (e.ColumnIndex == dgComplaintList.Columns["hdrPriorityLevel"].Index && e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgComplaintList.Rows[e.RowIndex];

                // Access the hdrComplainID value (assuming it's in another column)
                var hdrComplainID = selectedRow.Cells["hdrComplainID"].Value;

                // Get the selected value from the combobox (Priority Level)
                var selectedPriority = selectedRow.Cells["hdrPriorityLevel"].Value;

                using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
                {
                    conn.Open();
                    string query = @"UPDATE feedback SET fdbk_priority=@priority WHERE fdbk_refno=@refno;";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@priority", selectedPriority);
                    cmd.Parameters.AddWithValue("@refno", hdrComplainID);
                    cmd.ExecuteNonQuery();

                }

                MessageBox.Show("Row updated.");

                //string update_slots_query = @"UPDATE parkingslotmotorcycle SET status='occupied', user_id=@user_id WHERE slot_number=@slot_number";
                //MySqlCommand cmd = new MySqlCommand(update_slots_query, conn);

                //// Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@slot_number", slot_number);
                //cmd.Parameters.AddWithValue("@user_id", current_owner_id);
                //cmd.ExecuteNonQuery();
                // Example: Display or use the hdrComplainID
                //MessageBox.Show($"Complain ID: {hdrComplainID}, Selected Priority: {selectedPriority}");

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

        private void dgComplaintList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
