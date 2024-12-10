using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
                cahsval.Text = collegerec.ToString();
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
                ceisval.Text = collegerec.ToString();
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
                slcnval.Text = collegerec.ToString();
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
                cmtval.Text = collegerec.ToString();
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
                ibamval.Text = collegerec.ToString();
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
                caseval.Text = collegerec.ToString();
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

        private void btnreportSLCN_Click(object sender, EventArgs e)
        {

            String URLREPORT = $"http://{ConnectionDB.IP}/tuafms/report.php?college=SLCN";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {URLREPORT}") { CreateNoWindow = true });

        }

        private void btnreportCEIS_Click(object sender, EventArgs e)
        {
            String URLREPORT = $"http://{ConnectionDB.IP}/tuafms/report.php?college=CEIS";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {URLREPORT}") { CreateNoWindow = true });

        }

        private void btnreportCASE_Click(object sender, EventArgs e)
        {
            String URLREPORT = $"http://{ConnectionDB.IP}/tuafms/report.php?college=CASE";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {URLREPORT}") { CreateNoWindow = true });

        }

        private void btnreportCMT_Click(object sender, EventArgs e)
        {
            String URLREPORT = $"http://{ConnectionDB.IP}/tuafms/report.php?college=CMT";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {URLREPORT}") { CreateNoWindow = true });

        }

        private void btnreportIBAM_Click(object sender, EventArgs e)
        {
            String URLREPORT = $"http://{ConnectionDB.IP}/tuafms/report.php?college=IBAM";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {URLREPORT}") { CreateNoWindow = true });

        }

        private void btnreportCAHS_Click(object sender, EventArgs e)
        {
            String URLREPORT = $"http://{ConnectionDB.IP}/tuafms/report.php?college=CAHS";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {URLREPORT}") { CreateNoWindow = true });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String URLREPORT = $"http://{ConnectionDB.IP}/tuafms/report.php?college=ALL";
            Process.Start(new ProcessStartInfo("cmd", $"/c start {URLREPORT}") { CreateNoWindow = true });

        }
    }
}