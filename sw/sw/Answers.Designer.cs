
namespace sw
{
    partial class Answers
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
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ask_ans = new System.Windows.Forms.Button();
            this.downvote = new System.Windows.Forms.Button();
            this.upvote = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Stack overflow";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 10);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 20;
            this.back_button.Text = "<--";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(837, 377);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ask_ans
            // 
            this.ask_ans.Location = new System.Drawing.Point(362, 456);
            this.ask_ans.Name = "ask_ans";
            this.ask_ans.Size = new System.Drawing.Size(129, 39);
            this.ask_ans.TabIndex = 17;
            this.ask_ans.Text = "Add answer";
            this.ask_ans.UseVisualStyleBackColor = true;
            this.ask_ans.Click += new System.EventHandler(this.ask_ans_Click);
            // 
            // downvote
            // 
            this.downvote.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.downvote.Location = new System.Drawing.Point(877, 256);
            this.downvote.Name = "downvote";
            this.downvote.Size = new System.Drawing.Size(98, 32);
            this.downvote.TabIndex = 16;
            this.downvote.Text = "Down vote";
            this.downvote.UseVisualStyleBackColor = true;
            this.downvote.Click += new System.EventHandler(this.downvote_Click);
            // 
            // upvote
            // 
            this.upvote.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.upvote.Location = new System.Drawing.Point(877, 205);
            this.upvote.Name = "upvote";
            this.upvote.Size = new System.Drawing.Size(98, 32);
            this.upvote.TabIndex = 15;
            this.upvote.Text = "Up vote";
            this.upvote.UseVisualStyleBackColor = true;
            this.upvote.Click += new System.EventHandler(this.upvote_Click);
            // 
            // Answers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ask_ans);
            this.Controls.Add(this.downvote);
            this.Controls.Add(this.upvote);
            this.Name = "Answers";
            this.Text = "Answers";
            this.Load += new System.EventHandler(this.Answers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ask_ans;
        private System.Windows.Forms.Button downvote;
        private System.Windows.Forms.Button upvote;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}