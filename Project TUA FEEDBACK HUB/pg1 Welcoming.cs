using System.Windows.Forms;

namespace Project_TUA_FEEDBACK_HUB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pg2_Log_in_Your_Account LoginPage = new pg2_Log_in_Your_Account();
            LoginPage.Show();
            this.Hide();
        }
    }

}
