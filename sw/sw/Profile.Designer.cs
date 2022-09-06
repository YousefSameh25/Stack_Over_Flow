
namespace sw
{
    partial class Profile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.question_button = new System.Windows.Forms.Button();
            this.answers_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.remove_button = new System.Windows.Forms.Button();
            this.content_txt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tag_txt = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(904, 315);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // question_button
            // 
            this.question_button.Location = new System.Drawing.Point(943, 84);
            this.question_button.Name = "question_button";
            this.question_button.Size = new System.Drawing.Size(133, 35);
            this.question_button.TabIndex = 1;
            this.question_button.Text = "Show questions";
            this.question_button.UseVisualStyleBackColor = true;
            this.question_button.Click += new System.EventHandler(this.question_button_Click);
            // 
            // answers_button
            // 
            this.answers_button.Location = new System.Drawing.Point(944, 171);
            this.answers_button.Name = "answers_button";
            this.answers_button.Size = new System.Drawing.Size(132, 35);
            this.answers_button.TabIndex = 2;
            this.answers_button.Text = "Show answers";
            this.answers_button.UseVisualStyleBackColor = true;
            this.answers_button.Click += new System.EventHandler(this.answers_button_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(71, 24);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "<--";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // remove_button
            // 
            this.remove_button.Location = new System.Drawing.Point(945, 264);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(131, 35);
            this.remove_button.TabIndex = 4;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // content_txt
            // 
            this.content_txt.Location = new System.Drawing.Point(122, 397);
            this.content_txt.Name = "content_txt";
            this.content_txt.Size = new System.Drawing.Size(188, 43);
            this.content_txt.TabIndex = 5;
            this.content_txt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Content ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tag_txt
            // 
            this.tag_txt.Location = new System.Drawing.Point(122, 487);
            this.tag_txt.Name = "tag_txt";
            this.tag_txt.Size = new System.Drawing.Size(188, 22);
            this.tag_txt.TabIndex = 7;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(377, 474);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(96, 35);
            this.update_button.TabIndex = 8;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tag";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.tag_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.content_txt);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.answers_button);
            this.Controls.Add(this.question_button);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Profile";
            this.Text = "Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button question_button;
        private System.Windows.Forms.Button answers_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button remove_button;
        private System.Windows.Forms.RichTextBox content_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tag_txt;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Label label2;
    }
}