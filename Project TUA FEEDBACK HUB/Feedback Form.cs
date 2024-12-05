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
    public partial class Feedback_Form : Form
    {

        MySqlConnection connection = ConnectionDB.GetConnection();
        public string refno = "";
        public Feedback_Form(string fdbk_refno)
        {
            InitializeComponent();
            refno = fdbk_refno;
            load_user();
        }

        private void load_user()
        {
            using (MySqlConnection conn = new MySqlConnection(connection.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT u.TUA_email, u.coll_acrnym, f.fdbk_type, f.fdbk_detail FROM feedback f JOIN useraccounts u WHERE u.acct_number=f.user_id AND f.fdbk_refno=" + refno;
                MySqlCommand cmd = new MySqlCommand(query, conn);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        lblEmail.Text = reader["TUA_email"].ToString();
                        lblCollege.Text = reader["coll_acrnym"].ToString();
                        lblCategory.Text = reader["fdbk_type"].ToString();
                        lblInquiry.Text = reader["fdbk_detail"].ToString();
                    }
                }
            }
        }
        
    }
}
