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
    public partial class pg4_Registration : Form
    {

        MySqlConnection connection = ConnectionDB.GetConnection();

        public pg4_Registration()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();

                string datenow = DateTime.Now.Date.ToString();
                string timenow = DateTime.Now.TimeOfDay.ToString();
                string query = @"INSERT INTO useraccounts 
                    (`user_fname`, `user_mname`, `user_sname`, `act_status`, `TUA_email`, `acct_number`, `act_pwrd`, `coll_acrnym`, `crt_date`, `crt_time`, `apvl_date`, `apvl_time`, `act_aprvr`, `act_type`) 
                    VALUES 
                    (@firstname, @middlename, @lastname, 'Not approved', @email, @accountnumber, @password, @college, @date, @time, NULL, NULL, NULL, @accounttype)";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                cmd.Parameters.AddWithValue("@middlename", middlename.Text);
                cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.Parameters.AddWithValue("@accountnumber", accountnumber.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@college", college.Text);
                cmd.Parameters.AddWithValue("@date", datenow);
                cmd.Parameters.AddWithValue("@time", timenow);
                cmd.Parameters.AddWithValue("@accounttype", accounttype.Text);

                cmd.ExecuteNonQuery();

            }

            MessageBox.Show("Account created successfully!");

            pg2_Log_in_Your_Account pglogin = new pg2_Log_in_Your_Account();
            pglogin.Show();
            this.Close();
        }
    }
}
