
namespace sw
{
    partial class Questions
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
            this.search_txt = new System.Windows.Forms.TextBox();
            this.search_tag = new System.Windows.Forms.Button();
            this.upvote = new System.Windows.Forms.Button();
            this.downvote = new System.Windows.Forms.Button();
            this.ask_ques = new System.Windows.Forms.Button();
            this.my_profile = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_txt
            // 
            this.search_txt.Location = new System.Drawing.Point(878, 146);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(123, 22);
            this.search_txt.TabIndex = 2;
            this.search_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search_tag
            // 
            this.search_tag.Location = new System.Drawing.Point(893, 184);
            this.search_tag.Name = "search_tag";
            this.search_tag.Size = new System.Drawing.Size(98, 36);
            this.search_tag.TabIndex = 3;
            this.search_tag.Text = "Search tag";
            this.search_tag.UseVisualStyleBackColor = true;
            this.search_tag.Click += new System.EventHandler(this.button1_Click);
            // 
            // upvote
            // 
            this.upvote.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.upvote.Location = new System.Drawing.Point(893, 295);
            this.upvote.Name = "upvote";
            this.upvote.Size = new System.Drawing.Size(98, 32);
            this.upvote.TabIndex = 4;
            this.upvote.Text = "Up vote";
            this.upvote.UseVisualStyleBackColor = true;
            this.upvote.Click += new System.EventHandler(this.upvote_Click);
            // 
            // downvote
            // 
            this.downvote.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.downvote.Location = new System.Drawing.Point(893, 346);
            this.downvote.Name = "downvote";
            this.downvote.Size = new System.Drawing.Size(98, 32);
            this.downvote.TabIndex = 5;
            this.downvote.Text = "Down vote";
            this.downvote.UseVisualStyleBackColor = true;
            this.downvote.Click += new System.EventHandler(this.downvote_Click_1);
            // 
            // ask_ques
            // 
            this.ask_ques.Location = new System.Drawing.Point(369, 459);
            this.ask_ques.Name = "ask_ques";
            this.ask_ques.Size = new System.Drawing.Size(129, 39);
            this.ask_ques.TabIndex = 8;
            this.ask_ques.Text = "Ask a question";
            this.ask_ques.UseVisualStyleBackColor = true;
            this.ask_ques.Click += new System.EventHandler(this.ask_ques_Click);
            // 
            // my_profile
            // 
            this.my_profile.Location = new System.Drawing.Point(893, 12);
            this.my_profile.Name = "my_profile";
            this.my_profile.Size = new System.Drawing.Size(104, 42);
            this.my_profile.TabIndex = 9;
            this.my_profile.Text = "My Profile";
            this.my_profile.UseVisualStyleBackColor = true;
            this.my_profile.Click += new System.EventHandler(this.my_profile_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(837, 377);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 11;
            this.back_button.Text = "<--";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(348, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Stack overflow";
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.my_profile);
            this.Controls.Add(this.ask_ques);
            this.Controls.Add(this.downvote);
            this.Controls.Add(this.upvote);
            this.Controls.Add(this.search_tag);
            this.Controls.Add(this.search_txt);
            this.Name = "Questions";
            this.Text = "Questions";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Questions_FormClosed);
            this.Load += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Button search_tag;
        private System.Windows.Forms.Button upvote;
        private System.Windows.Forms.Button downvote;
        private System.Windows.Forms.Button ask_ques;
        private System.Windows.Forms.Button my_profile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
    }
}