using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

            sendemail_approve();

            MessageBox.Show("Account number " + account_number + " approved!\n\nApproval email sent.");
            
            this.Hide();
        }


        private void sendemail_approve()
        {
            try
            {
                string from = "tuafmsa@gmail.com";
                //string password = "tuafms000111#";
                string password = "cita euqu izgt hwiw";

                MailMessage msg = new MailMessage();
                msg.Subject = "No-Reply Account Number " + accountnumber.Text;
                msg.From = new MailAddress(from);
                msg.Body = "Dear " + firstname.Text + " " + lastname.Text + ", We are pleased to inform you that your application for providing TUA feedback has been approved!\n\nWe appreciate you interest and dedication, and we look forward to your participation.\n\nIf you have any questions, pleae feel free to reach out.\n\nBest regards,\nTUA admin";
                msg.To.Add(new MailAddress(email.Text));

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;

                smtp.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential(from, password);
                smtp.Credentials = nc;
                smtp.Send(msg);


            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                MessageBox.Show(ex.ToString());
            }

        }


        private void sendemail_reject()
        {
            try
            {
                string from = "tuafmsa@gmail.com";
                //string password = "tuafms000111#";
                string password = "cita euqu izgt hwiw";

                MailMessage msg = new MailMessage();
                msg.Subject = "No-Reply Account Number " + accountnumber.Text;
                msg.From = new MailAddress(from);
                msg.Body = "Dear " + firstname.Text + " " + lastname.Text + ", Thank you for your application for providing TUA feedback. We appreciate your interest and the effort you put into your submission.\n\nAfter careful consideration, we regret to inform you that your application has not been approved due to you are not enrolled to this school at Trinity University of Asia.\n\nIf you have any questions or would like further clarification, please feel free to reach out.\n\nBest regards,\nTUA admin";
                msg.To.Add(new MailAddress(email.Text));

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;

                smtp.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential(from, password);
                smtp.Credentials = nc;
                smtp.Send(msg);




            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                MessageBox.Show(ex.ToString());
            }






        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendemail_reject();
            MessageBox.Show("Account number " + account_number + " rejected.\n\nRejection email sent.");

        }
    }
}
