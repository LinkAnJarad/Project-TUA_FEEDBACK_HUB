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
            this.Close();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg6_AccountApproval accountApproval = new pg6_AccountApproval();
            accountApproval.Show();
            this.Close();

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pg9_ComplainList pg9_ComplainListc = new pg9_ComplainList();
            pg9_ComplainListc.Show();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
