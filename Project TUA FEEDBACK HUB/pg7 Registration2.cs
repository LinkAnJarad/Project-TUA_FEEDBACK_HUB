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
    public partial class pg7_Registration2 : Form
    {

        String account_number = "";
        MySqlConnection connection = ConnectionDB.GetConnection();

        public pg7_Registration2(String act_number)
        {
            InitializeComponent();
            account_number = act_number;
            load_details();
        }

        private void pg7_Registration2_Load(object sender, EventArgs e)
        {

        }

        private void load_details()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT * FROM useraccounts WHERE acct_number=@acct_number;";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                // Use parameterized queries to prevent SQL injection
                cmd.Parameters.AddWithValue("@acct_number", account_number);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //string user_fname = reader["user_fname"].ToString();
                    //string user_mname = reader["user_mname"].ToString();
                    //string user_lname = reader["user_sname"].ToString();
                    //string acct_number = reader["acct_number"].ToString();
                    //string act_type = reader["act_type"].ToString();
                    //string coll_acrnym = reader["coll_acrnym"].ToString();

                    firstname.Text = reader["user_fname"].ToString();
                    middlename.Text = reader["user_mname"].ToString();
                    lastname.Text = reader["user_sname"].ToString();
                    accountnumber.Text = reader["acct_number"].ToString();
                    accounttype.Text = reader["act_type"].ToString();
                    college.Text = reader["coll_acrnym"].ToString();
                    password.Text = reader["act_pwrd"].ToString();
                    email.Text = reader["TUA_email"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"UPDATE useraccounts SET act_status='Approved' WHERE acct_number=@actnum;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@actnum", account_number);
                cmd.ExecuteNonQuery();

            }

            MessageBox.Show("Account number " + account_number + " approved!");
            this.Hide();
        }
    }
}
