
namespace sw
{
    partial class Crystal1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.report_txt = new System.Windows.Forms.ComboBox();
            this.generate_report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.AutoSize = true;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(12, 89);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1125, 613);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // report_txt
            // 
            this.report_txt.FormattingEnabled = true;
            this.report_txt.Location = new System.Drawing.Point(320, 40);
            this.report_txt.Name = "report_txt";
            this.report_txt.Size = new System.Drawing.Size(170, 24);
            this.report_txt.TabIndex = 1;
            this.report_txt.SelectedIndexChanged += new System.EventHandler(this.report_txt_SelectedIndexChanged);
            // 
            // generate_report
            // 
            this.generate_report.Location = new System.Drawing.Point(550, 34);
            this.generate_report.Name = "generate_report";
            this.generate_report.Size = new System.Drawing.Size(134, 35);
            this.generate_report.TabIndex = 2;
            this.generate_report.Text = "Generate report";
            this.generate_report.UseVisualStyleBackColor = true;
            this.generate_report.Click += new System.EventHandler(this.generate_report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tags";
            // 
            // Crystal1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 706);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generate_report);
            this.Controls.Add(this.report_txt);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Crystal1";
            this.Text = "Crystal1";
            this.Load += new System.EventHandler(this.Crystal1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox report_txt;
        private System.Windows.Forms.Button generate_report;
        private System.Windows.Forms.Label label1;
    }
}