using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;


namespace sw
{
    public partial class Crystal1 : Form
    {
        CrystalReport2 cr;
        public Crystal1()
        {
            InitializeComponent();
        }

        private void Crystal1_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport2();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                report_txt.Items.Add(v.Value);
        }

        private void report_txt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void generate_report_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, report_txt.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
