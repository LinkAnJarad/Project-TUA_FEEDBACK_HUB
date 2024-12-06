﻿using MySql.Data.MySqlClient;
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
        

        MySqlConnection connection = ConnectionDB.GetConnection();
        string connectionstring = ConnectionDB.connectionString;
        public pg10_ComplainGraph()
        {
            InitializeComponent();
            //MessageBox.Show(connection.ConnectionString);
            load_graph();
        }

        private void load_graph()
        {

            int total_feedback = 0;
            using (MySqlConnection conn = new MySqlConnection(connectionstring))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback;";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                total_feedback = Convert.ToInt32(cmd.ExecuteScalar());


            }

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'CAHS';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbCAHS.Maximum = total_feedback;
                pbCAHS.Value = collegerec;
            }

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'CEIS';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbCEIS.Maximum = total_feedback;
                pbCEIS.Value = collegerec;
            }

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'SLCN';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbSLCN.Maximum = total_feedback;
                pbSLCN.Value = collegerec;
            }

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'CMT';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbCMT.Maximum = total_feedback;
                pbCMT.Value = collegerec;
            }

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'IBAM';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbIBAM.Maximum = total_feedback;
                pbIBAM.Value = collegerec;
            }

            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM feedback WHERE coll_acrnym = 'CASE';";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                int collegerec = Convert.ToInt32(cmd.ExecuteScalar());

                // Use parameterized queries to prevent SQL injection
                //cmd.Parameters.AddWithValue("@owner_id", owner_id);
                MySqlDataReader reader = cmd.ExecuteReader();
                pbCASE.Maximum = total_feedback;
                pbCASE.Value = collegerec;
            }


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
                pbIBAM.Value = collegerec;
                pbIBAM.Maximum = 10;
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