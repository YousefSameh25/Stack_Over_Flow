using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sw
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();           
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Signin s = new Signin();
            s.Show();
            this.Hide();
        }

        private void sign_up_button_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.Show();
            this.Hide();
        }

        private void not_now_Click(object sender, EventArgs e)
        {
            Questions q = new Questions(0);
            q.Show();
            this.Hide();
        }

        private void report_button_Click(object sender, EventArgs e)
        {
            Crystal1 c = new Crystal1();
            c.Show();
            
        }

        private void question_button_Click(object sender, EventArgs e)
        {
            Crystal2 c = new Crystal2();
            c.Show();
        }
    }
}
