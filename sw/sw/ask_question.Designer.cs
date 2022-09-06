
namespace sw
{
    partial class ask_question
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
            this.question_txt = new System.Windows.Forms.RichTextBox();
            this.tag_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_ques = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // question_txt
            // 
            this.question_txt.Location = new System.Drawing.Point(100, 75);
            this.question_txt.Name = "question_txt";
            this.question_txt.Size = new System.Drawing.Size(337, 45);
            this.question_txt.TabIndex = 0;
            this.question_txt.Text = "";
            // 
            // tag_txt
            // 
            this.tag_txt.Location = new System.Drawing.Point(100, 175);
            this.tag_txt.Name = "tag_txt";
            this.tag_txt.Size = new System.Drawing.Size(337, 22);
            this.tag_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tag";
            // 
            // add_ques
            // 
            this.add_ques.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_ques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_ques.Location = new System.Drawing.Point(211, 230);
            this.add_ques.Name = "add_ques";
            this.add_ques.Size = new System.Drawing.Size(124, 35);
            this.add_ques.TabIndex = 4;
            this.add_ques.Text = "Add question";
            this.add_ques.UseVisualStyleBackColor = false;
            this.add_ques.Click += new System.EventHandler(this.add_ques_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "<--";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ask_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 372);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.add_ques);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tag_txt);
            this.Controls.Add(this.question_txt);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ask_question";
            this.Text = "ask_question";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ask_question_FormClosing);
            this.Load += new System.EventHandler(this.ask_question_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox question_txt;
        private System.Windows.Forms.TextBox tag_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_ques;
        private System.Windows.Forms.Button back_button;
    }
}