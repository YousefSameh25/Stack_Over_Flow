
namespace sw
{
    partial class Add_Answer
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
            this.back_button = new System.Windows.Forms.Button();
            this.add_ans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ans_txt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(24, 13);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 11;
            this.back_button.Text = "<--";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // add_ans
            // 
            this.add_ans.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_ans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ans.Location = new System.Drawing.Point(200, 182);
            this.add_ans.Name = "add_ans";
            this.add_ans.Size = new System.Drawing.Size(124, 35);
            this.add_ans.TabIndex = 10;
            this.add_ans.Text = "Add answer";
            this.add_ans.UseVisualStyleBackColor = false;
            this.add_ans.Click += new System.EventHandler(this.add_ans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Answer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ans_txt
            // 
            this.ans_txt.Location = new System.Drawing.Point(109, 105);
            this.ans_txt.Name = "ans_txt";
            this.ans_txt.Size = new System.Drawing.Size(337, 45);
            this.ans_txt.TabIndex = 6;
            this.ans_txt.Text = "";
            // 
            // Add_Answer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 301);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_ans);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ans_txt);
            this.Name = "Add_Answer";
            this.Text = "Add_Answer";
            this.Load += new System.EventHandler(this.Add_Answer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button add_ans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox ans_txt;
    }
}