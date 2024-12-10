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
    public partial class Complain_Archive : Form
    {
        MySqlConnection connection = ConnectionDB.GetConnection();

        public Complain_Archive()
        {
            InitializeComponent();
            load_archives();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void load_archives()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT fdbk_refno, fdbk_type, fdbk_status FROM feedback WHERE fdbk_status='Resolved';";
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
                        row.Cells["ComplainID"].Value = reader["fdbk_refno"];
                        row.Cells["ComplainType"].Value = reader["fdbk_type"];
                        row.Cells["Progress"].Value = reader["fdbk_status"];
                        row.Cells["View"].Value = "View";
                    }
                }
            }
        }

        private void dgComplaintList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgComplaintList.Columns["View"].Index && e.RowIndex >= 0)
            {
                // Retrieve the value of hdrComplainID from the same row
                var complainID = dgComplaintList.Rows[e.RowIndex].Cells["ComplainID"].Value.ToString();
                Feedback_Form feedbackform = new Feedback_Form(complainID, "_archive");

                feedbackform.Show();   
            }
        }
    }
}
