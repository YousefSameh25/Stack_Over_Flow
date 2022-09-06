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
    public partial class ask_question : Form
    {


        int user_id = 10;
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public ask_question(int id)
        {
            InitializeComponent();
            user_id = id;
        }

        private void ask_question_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void add_ques_Click(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "insert into QUESTIONS values(ques_id.nextval,:u_id,:q_text,:q_tag,0)";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("u_id", user_id);
            c.Parameters.Add("q_text", question_txt.Text);
            c.Parameters.Add("q_tag", tag_txt.Text);
            int r = c.ExecuteNonQuery();
            if (r!=-1)
            {
                MessageBox.Show("Question added successfully");
            }
        }
        private void ask_question_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Questions q = new Questions(user_id);
            q.Show();
            this.Hide();
        }
    }
}
