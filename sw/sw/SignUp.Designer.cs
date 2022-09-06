
namespace sw
{
    partial class SignUp
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
            this.user_name_box = new System.Windows.Forms.TextBox();
            this.pass_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sign_up = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.card_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_name_box
            // 
            this.user_name_box.Location = new System.Drawing.Point(302, 104);
            this.user_name_box.Name = "user_name_box";
            this.user_name_box.Size = new System.Drawing.Size(229, 22);
            this.user_name_box.TabIndex = 0;
            // 
            // pass_box
            // 
            this.pass_box.Location = new System.Drawing.Point(302, 156);
            this.pass_box.Name = "pass_box";
            this.pass_box.Size = new System.Drawing.Size(229, 22);
            this.pass_box.TabIndex = 1;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(302, 209);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(229, 22);
            this.email_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "User name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(192, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "E-mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Sign_up
            // 
            this.Sign_up.Location = new System.Drawing.Point(373, 304);
            this.Sign_up.Name = "Sign_up";
            this.Sign_up.Size = new System.Drawing.Size(87, 44);
            this.Sign_up.TabIndex = 6;
            this.Sign_up.Text = "Sign up";
            this.Sign_up.UseVisualStyleBackColor = true;
            this.Sign_up.Click += new System.EventHandler(this.Sign_up_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(24, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "<--";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // card_box
            // 
            this.card_box.Location = new System.Drawing.Point(302, 257);
            this.card_box.Name = "card_box";
            this.card_box.Size = new System.Drawing.Size(229, 22);
            this.card_box.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Card(optional)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.card_box);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.Sign_up);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.pass_box);
            this.Controls.Add(this.user_name_box);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_name_box;
        private System.Windows.Forms.TextBox pass_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sign_up;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox card_box;
        private System.Windows.Forms.Label label4;
    }
}