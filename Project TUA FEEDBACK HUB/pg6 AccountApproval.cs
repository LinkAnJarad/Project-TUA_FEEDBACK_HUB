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
    public partial class pg6_AccountApproval : Form
    {
        public pg6_AccountApproval()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg5_Welcoming2 LoginPage = new pg5_Welcoming2();
            LoginPage.Show();
            this.Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg9_ComplainList ComplainPage = new pg9_ComplainList();
            ComplainPage.Show();
            this.Close();


        }

        private void pg6_AccountApproval_Load(object sender, EventArgs e)
        {

        }
    }
}
