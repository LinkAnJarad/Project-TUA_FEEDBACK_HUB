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
    public partial class pg9_ComplainList : Form
    {
        public pg9_ComplainList()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg5_Welcoming2 LoginPage = new pg5_Welcoming2();
            LoginPage.Show();
            this.Close();


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg6_AccountApproval accountApproval = new pg6_AccountApproval();
            accountApproval.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Feedback_Form feedbackForm = new Feedback_Form();
            feedbackForm.Show();
            this.Hide();
        }

        private void pg9_ComplainList_Load(object sender, EventArgs e)
        {

        }
    }
}
