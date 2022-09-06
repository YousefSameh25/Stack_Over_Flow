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
    public partial class Signin : Form
    {
        int id = 0;
        string ordb = "Data source=orcl;User Id=hr; Password=hr;";
        OracleConnection conn;
        public Signin()
        {
            InitializeComponent();
        }
        private void Form_load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SIGN_IN";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("u_name", un_txt.Text);
            cmd.Parameters.Add("u_pass", pass_txt.Text);
            cmd.Parameters.Add("u_id",OracleDbType.Int32, ParameterDirection.Output);            
                try
                {
                    cmd.ExecuteNonQuery();
                    id = Convert.ToInt32(cmd.Parameters["u_id"].Value.ToString());        
                    Questions q = new Questions(id);
                    q.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Invalid username or password");
                }
             
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
