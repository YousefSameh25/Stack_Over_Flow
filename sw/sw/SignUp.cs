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
    public partial class SignUp : Form
    {
        OracleDataAdapter db;
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;

        public SignUp()
        {
            InitializeComponent();
        }
        private void SignUp_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Sign_up_Click(object sender, EventArgs e)
        {
            if (user_name_box.Text.Length == 0 || pass_box.Text.Length == 0 || email_box.Text.Length == 0)
            {
                MessageBox.Show("Invalid data");
            }
            else
            {
                conn = new OracleConnection(ordb);
                conn.Open();
                OracleCommand cmd2 = new OracleCommand();
                cmd2.Connection = conn;
                cmd2.CommandText = "select user_name from users where user_name =:name ";
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("name", user_name_box.Text);
                OracleDataReader dr = cmd2.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("user name is already exist");
                }
                else
                {
                    int c = 0;
                    if (card_box.Text.Length == 0)
                       c = 0;
                    else 
                    c = Int32.Parse(card_box.Text);
                   
                    string constr = "Data source=orcl;User Id=hr; Password=hr;";
                    string cmd = "insert into users values (id_seq.nextval,:name,:pass,:email,:card)";
                    db = new OracleDataAdapter(cmd, constr);
                    db.SelectCommand.Parameters.Add("name", user_name_box.Text);
                    db.SelectCommand.Parameters.Add("pass", pass_box.Text);
                    db.SelectCommand.Parameters.Add("email", email_box.Text);
                    db.SelectCommand.Parameters.Add("card", c);
                    DataSet ds = new DataSet();
                    db.Fill(ds);
                    Signin s = new Signin();
                    s.Show();
                    this.Hide();
                }
            }
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
