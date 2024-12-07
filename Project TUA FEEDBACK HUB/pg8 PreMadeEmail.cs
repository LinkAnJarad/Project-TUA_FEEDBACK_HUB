using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_TUA_FEEDBACK_HUB
{
    public partial class pg8_PreMadeEmail : Form
    {
        string emailto = "";
        string refno = "";
        string name = "";

        MySqlConnection connection = ConnectionDB.GetConnection();

        public pg8_PreMadeEmail(string to_email, string id_num, string passed_name)
        {
            InitializeComponent();
            emailto = to_email;
            refno = id_num;
            name = passed_name;
        }

        private void pg8_PreMadeEmail_Load(object sender, EventArgs e)
        {
            // email tuafmsa@gmail.com tuafms000111#

            lblName.Text = name;
            lblTo.Text = emailto;


        }

        private void sendemail()
        {
            try
            {
                string from = "tuafmsa@gmail.com";
                //string password = "tuafms000111#";
                string password = "cita euqu izgt hwiw";

                MailMessage msg = new MailMessage();
                msg.Subject = "No-Reply Complain ID Number " + refno;
                msg.From = new MailAddress(from);
                msg.Body = "Dear " + name + ", Thank you for reaching out to us regarding your concern. We appreciate taking the time to share your thoughts, and we want to assure you that your feedback is important to us.\n" + tbReply.Text + "\n\nBest regards,\nTUA admin";
                msg.To.Add(new MailAddress(emailto));

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;

                smtp.EnableSsl = true;

                NetworkCredential nc = new NetworkCredential(from, password);
                smtp.Credentials = nc;
                smtp.Send(msg);

                MessageBox.Show("Email sent!");




            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
                MessageBox.Show(ex.ToString());
            }


            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                conn.Open();
                string query = @"UPDATE feedback SET fdbk_status='Resolved' WHERE fdbk_refno=@refno;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@refno", refno);
                cmd.ExecuteNonQuery();

            }
            this.Hide();



        }



        private void button1_Click(object sender, EventArgs e)
        {
            sendemail();
        }
    }
}
