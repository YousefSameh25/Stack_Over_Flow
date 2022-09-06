using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace sw
{
    public partial class Add_Answer : Form
    {
        int user_id = 0;
        int q_id = 0;
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public Add_Answer(int u ,int q)
        {
            InitializeComponent();
            user_id = u;
            q_id = q;
        }
        private void Add_Answer_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void add_ans_Click(object sender, EventArgs e)
        {
            int q = q_id;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert into ANSWERS values(ans_id.nextval,:u_id,:q,:ans_text,0)";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("u_id", user_id);
            c.Parameters.Add("q",q );
            c.Parameters.Add("ans_text",ans_txt.Text);
            int r = c.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Answer added successfully");
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            int i = user_id;
            Questions q = new Questions(i);
            q.Show();
            this.Hide();
        }
    }
}
