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
    public partial class Answers_of_question : Form
    {
        int user_id = 0;
        int q_id = 0;
        public Answers_of_question(int u , int q)
        {
            InitializeComponent();
            user_id = u;
            q_id = q;
        }

        private void Answers_of_question_Load(object sender, EventArgs e)
        {
            int q = q_id;
            string constr = "Data source=orcl;User Id=hr; Password=hr;";
            string cmd = "select ANSWER_TEXT,ANSWER_RATE from ANSWERS where QUESTION_ID=:id ";

            OracleDataAdapter db = new OracleDataAdapter(cmd, constr);
            db.SelectCommand.Parameters.Add("id", q);
            DataSet ds = new DataSet();
            db.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            int i = user_id;
            Profile p = new Profile(i);
            p.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
