
namespace sw
{
    partial class Home
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
            this.label2 = new System.Windows.Forms.Label();
            this.sign_in_button = new System.Windows.Forms.Button();
            this.sign_up_button = new System.Windows.Forms.Button();
            this.not_now = new System.Windows.Forms.Label();
            this.report_button = new System.Windows.Forms.Button();
            this.question_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stack OverFlow";
            // 
            // sign_in_button
            // 
            this.sign_in_button.Location = new System.Drawing.Point(226, 94);
            this.sign_in_button.Name = "sign_in_button";
            this.sign_in_button.Size = new System.Drawing.Size(220, 43);
            this.sign_in_button.TabIndex = 2;
            this.sign_in_button.Text = "Sign in";
            this.sign_in_button.UseVisualStyleBackColor = true;
            this.sign_in_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // sign_up_button
            // 
            this.sign_up_button.Location = new System.Drawing.Point(226, 172);
            this.sign_up_button.Name = "sign_up_button";
            this.sign_up_button.Size = new System.Drawing.Size(220, 43);
            this.sign_up_button.TabIndex = 4;
            this.sign_up_button.Text = "Sign up";
            this.sign_up_button.UseVisualStyleBackColor = true;
            this.sign_up_button.Click += new System.EventHandler(this.sign_up_button_Click);
            // 
            // not_now
            // 
            this.not_now.AutoSize = true;
            this.not_now.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.not_now.Location = new System.Drawing.Point(308, 233);
            this.not_now.Name = "not_now";
            this.not_now.Size = new System.Drawing.Size(57, 17);
            this.not_now.TabIndex = 5;
            this.not_now.Text = "not now";
            this.not_now.Click += new System.EventHandler(this.not_now_Click);
            // 
            // report_button
            // 
            this.report_button.Location = new System.Drawing.Point(548, 290);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(130, 44);
            this.report_button.TabIndex = 6;
            this.report_button.Text = "Generate report";
            this.report_button.UseVisualStyleBackColor = true;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // question_button
            // 
            this.question_button.Location = new System.Drawing.Point(548, 219);
            this.question_button.Name = "question_button";
            this.question_button.Size = new System.Drawing.Size(130, 44);
            this.question_button.TabIndex = 7;
            this.question_button.Text = "Questions report";
            this.question_button.UseVisualStyleBackColor = true;
            this.question_button.Click += new System.EventHandler(this.question_button_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 361);
            this.Controls.Add(this.question_button);
            this.Controls.Add(this.report_button);
            this.Controls.Add(this.not_now);
            this.Controls.Add(this.sign_up_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sign_in_button);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sign_in_button;
        private System.Windows.Forms.Button sign_up_button;
        private System.Windows.Forms.Label not_now;
        private System.Windows.Forms.Button report_button;
        private System.Windows.Forms.Button question_button;
    }
}