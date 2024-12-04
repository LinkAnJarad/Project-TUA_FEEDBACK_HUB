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
        public Feedback_Form(string fdbk_refno)
        {
            InitializeComponent();
            lblEmail.Text = fdbk_refno;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
