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
    public partial class Questions : Form
    {

        int q_id = 0;
        int user_id = 0;
        OracleDataAdapter db;
        DataSet ds;
        OracleCommandBuilder builder;
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Questions(int id)
        {
            InitializeComponent();
            user_id = id;
        }
        private void load_grid()
        {
            string constr = "Data source=orcl;User Id=hr; Password=hr;";
            string cmd = "select * from questions";
            db = new OracleDataAdapter(cmd, constr);
            ds = new DataSet();
            db.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns["QUESTION_ID"].Visible = false;
            dataGridView1.Columns["USER_ID"].Visible = false;
            dataGridView1.ReadOnly = true;
        }
        private void Questions_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            load_grid();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (search_txt.Text.Length != 0)
            {

                string constr = "Data source=orcl;User Id=hr; Password=hr;";
                string cmd = "select * from questions where QUESTION_TAG =:tag";
                OracleDataAdapter adapter = new OracleDataAdapter(cmd, constr);
                adapter.SelectCommand.Parameters.Add("tag", search_txt.Text);

                DataSet ds_ad = new DataSet();
                adapter.Fill(ds_ad);
                dataGridView1.DataSource = ds_ad.Tables[0];
                dataGridView1.Columns["QUESTION_ID"].Visible = false;
                dataGridView1.Columns["USER_ID"].Visible = false;
                dataGridView1.ReadOnly = true;
            }
            else
                load_grid();
        }
        private void Questions_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            q_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
        }

        private void upvote_Click(object sender, EventArgs e)
        {
            int i = user_id;
            if (i == 0)
                MessageBox.Show("You should register ");
            else
            {
                int x = q_id;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select Question_RATE from questions where QUESTION_ID =:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", x);
                OracleDataReader dr = cmd.ExecuteReader();
                int rate = 0;
                if (dr.Read())
                    rate = Int32.Parse(dr[0].ToString());
                rate++;
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "update questions set QUESTION_RATE =:re where QUESTION_ID =:id";
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
        private void back_button_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void downvote_Click_1(object sender, EventArgs e)
        {
            int i = user_id;
            if (i == 0)
                MessageBox.Show("You should register");
            else
            {
                int x = q_id;
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select Question_RATE from questions where QUESTION_ID =:id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("id", x);
                OracleDataReader dr = cmd.ExecuteReader();
                int rate = 0;
                if (dr.Read())
                    rate = Int32.Parse(dr[0].ToString());
                rate--;
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "update questions set QUESTION_RATE =:re where QUESTION_ID =:id";
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

        private void ask_ques_Click(object sender, EventArgs e)
        {
            int x = user_id;
            if (x == 0)
            {
                MessageBox.Show("You should register");
            }
            else
            {
            ask_question aq = new ask_question(x);
            aq.Show();
                this.Hide();
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int u = user_id;
            int q = q_id;
            Answers a = new Answers(u, q);
            a.Show();
            this.Hide();
        }
        private void my_profile_Click(object sender, EventArgs e)
        {
            int u = user_id;
            if (u==0)
            {
                MessageBox.Show("You should register");
            }
            else
            {
              Profile p = new Profile(u);
              p.Show();
              this.Hide();
            }
        }
    }
}
