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
    public partial class pg5_Welcoming2 : Form
    {
        public pg5_Welcoming2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg5_Welcoming2 pg5_Welcoming2 = new pg5_Welcoming2();
            pg5_Welcoming2.Show();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg6_AccountApproval accountApproval = new pg6_AccountApproval();
            accountApproval.Show();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg9_ComplainList complainList = new pg9_ComplainList();
            complainList.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pg2_Log_in_Your_Account logout = new pg2_Log_in_Your_Account();

            logout.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg10_ComplainGraph ComplainPage = new pg10_ComplainGraph();
            ComplainPage.Show();
            this.Close();
        }

        private void pg5_Welcoming2_Load(object sender, EventArgs e)
        {

        }
    }
}
