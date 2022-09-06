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
    public partial class Profile : Form
    {
        int user_id = 0;
        int flag = -1;
        int temp_id = 0;
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public Profile(int id)
        {
            InitializeComponent();
            user_id = id;

        }
        private void Profile_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
        private void answers_button_Click(object sender, EventArgs e)
        {
            flag = 0;
            int i = user_id;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "ANSWER_PROC";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("u_id", i);
            c.Parameters.Add("answer_data", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();
            DataTable d = new DataTable();
            d.Load(dr);
            dataGridView1.DataSource = d;
            dataGridView1.Columns["ANSWER_ID"].Visible = false;
            dataGridView1.Columns["USER_ID1"].Visible = false;
            dataGridView1.Columns["USER_ID"].Visible = false;
            dataGridView1.Columns["QUESTION_ID1"].Visible = false;
            dataGridView1.Columns["QUESTION_ID"].Visible = false;
            dataGridView1.Columns["QUESTION_Rate"].Visible = false;

            dr.Close();
        }

        private void question_button_Click(object sender, EventArgs e)
        {
            flag = 1;
            int i = user_id;
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "QUESTION_PROC";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("u_id", i);
            c.Parameters.Add("question_data", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = c.ExecuteReader();
            DataTable d = new DataTable();
            d.Load(dr);
            dataGridView1.DataSource = d;
            dataGridView1.Columns["QUESTION_ID"].Visible = false;
            dataGridView1.Columns["USER_ID"].Visible = false;

            dr.Close();
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            int i = temp_id;
            if (flag == 0)//answer
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = " delete from ANSWERS where ANSWER_ID =:i ";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("i", i);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Deleted successfully");
                    answers_button_Click(sender, e);
                }
            }
            else if (flag == 1) // questions
            {
                OracleCommand c2 = new OracleCommand();
                c2.Connection = conn;
                c2.CommandText = "Delete from answers where Question_id =:i";
                c2.Parameters.Add("i", i);
                int r2 = c2.ExecuteNonQuery();
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = " delete from QUESTIONS where QUESTION_ID =:i";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("i", i);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Deleted successfully");
                    question_button_Click(sender, e);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;
            temp_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Questions q = new Questions(user_id);
            q.Show();
            this.Hide();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            int i = temp_id;
            if (flag == 0)
            {
                OracleCommand c = new OracleCommand();
                c.Connection = conn;
                c.CommandText = "update ANSWERS set ANSWER_TEXT =:a_txt where ANSWER_ID =:id";
                c.CommandType = CommandType.Text;
                c.Parameters.Add("a_txt", content_txt.Text);
                c.Parameters.Add("id", i);
                int r = c.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("Updated successfully");
                    answers_button_Click(sender, e);
                }
            }
            else if (flag == 1)
            {
                if (content_txt.Text.Length != 0 && tag_txt.Text.Length == 0)
                {

                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "update QUESTIONS set QUSTION_TEXT =:a_txt where QUESTION_ID =:id";
                    c.CommandType = CommandType.Text;
                    c.Parameters.Add("a_txt", content_txt.Text);
                    c.Parameters.Add("id", i);
                    int r = c.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Updated successfully");
                        question_button_Click(sender, e);
                    }
                }
                else if (content_txt.Text.Length == 0 && tag_txt.Text.Length != 0)
                {
                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "update QUESTIONS set QUESTION_TAG =:a_txt where QUESTION_ID =:id";
                    c.CommandType = CommandType.Text;
                    c.Parameters.Add("a_txt", tag_txt.Text);
                    c.Parameters.Add("id", i);
                    int r = c.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Updated successfully");
                        question_button_Click(sender, e);
                    }
                }
                else if (content_txt.Text.Length != 0 && tag_txt.Text.Length != 0)
                {
                    OracleCommand c = new OracleCommand();
                    c.Connection = conn;
                    c.CommandText = "update QUESTIONS set QUSTION_TEXT =:a_txt,QUESTION_TAG=:t_txt where QUESTION_ID =:id";
                    c.CommandType = CommandType.Text;
                    c.Parameters.Add("a_txt", content_txt.Text);
                    c.Parameters.Add("t_txt", tag_txt.Text);
                    c.Parameters.Add("id", i);
                    int r = c.ExecuteNonQuery();
                    if (r != -1)
                    {
                        MessageBox.Show("Updated successfully");
                        question_button_Click(sender, e);
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int u = user_id;
            int q = temp_id;
            Answers_of_question aq = new Answers_of_question(u, q);
            aq.Show();
            this.Hide();
        }
    }
}
