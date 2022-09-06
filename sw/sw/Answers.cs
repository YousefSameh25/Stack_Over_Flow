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
    public partial class Answers : Form
    {
        int user_id=0;
        int q_id = 0;
        int a_id = 0;
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        private void load_grid()
        {
            string constr = "Data source=orcl;User Id=hr; Password=hr;";
            string cmd = "select * from ANSWERS where QUESTION_ID =: q";
            OracleDataAdapter db = new OracleDataAdapter(cmd, constr);
            db.SelectCommand.Parameters.Add("q", q_id);
            DataSet ds = new DataSet();
            db.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["QUESTION_ID"].Visible = false;
            dataGridView1.Columns["ANSWER_ID"].Visible = false;
            dataGridView1.Columns["USER_ID"].Visible = false;
            dataGridView1.ReadOnly = true;
        }
        public Answers(int u, int q)
        {
            InitializeComponent();
            user_id = u;
            q_id = q;
        }
        private void Answers_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            load_grid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            a_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            int i = user_id;
            Questions q = new Questions(i);
            q.Show();
            this.Hide();
        }

        private void upvote_Click(object sender, EventArgs e)
        {
            int i = user_id;
            if (i == 0)
                MessageBox.Show("You should register ");
            else
            {

                int x = a_id; 
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select ANSWER_RATE from ANSWERS where ANSWER_ID =:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", x);
                OracleDataReader dr = cmd.ExecuteReader();
                int rate = 0;
                if (dr.Read())
                    rate = Int32.Parse(dr[0].ToString());
                rate++;
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "update ANSWERS set ANSWER_RATE =:re where ANSWER_ID =:id";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("re", rate);
                cmd2.Parameters.Add("id", x);
                int r = cmd2.ExecuteNonQuery();
                if (r != -1)
                {
                    load_grid();
                }

            }
        }

        private void downvote_Click(object sender, EventArgs e)
        {
            int i = user_id;
            if (i == 0)
                MessageBox.Show("You should register ");
            else
            {
                int x = a_id;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select ANSWER_RATE from ANSWERS where ANSWER_ID =:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", x);
                OracleDataReader dr = cmd.ExecuteReader();
                int rate = 0;
                if (dr.Read())
                    rate = Int32.Parse(dr[0].ToString());
                rate--;
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "update ANSWERS set ANSWER_RATE =:re where ANSWER_ID =:id";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("re", rate);
                cmd2.Parameters.Add("id", x);
                int r = cmd2.ExecuteNonQuery();
                if (r != -1)
                {
                    load_grid();
                }

            }
        }

        private void ask_ans_Click(object sender, EventArgs e)
        {
            int u = user_id;
            int q = q_id; 
            if (u == 0)
            {
                MessageBox.Show("You should register");
            }
            else
            {
                Add_Answer a = new Add_Answer(u, q);
                a.Show();
                this.Hide();
            }
        }
    }
}
