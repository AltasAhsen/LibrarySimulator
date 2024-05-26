namespace LibrarySimulator2
{
    partial class Form2
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
            this.Img_Bck_Grn_Clr = new System.Windows.Forms.Panel();
            this.welcome_label = new System.Windows.Forms.Label();
            this.library_image = new System.Windows.Forms.PictureBox();
            this.nickname_label = new System.Windows.Forms.Label();
            this.mail_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.mail_textbox = new System.Windows.Forms.TextBox();
            this.login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pass_confirm_label = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.warn_mail = new System.Windows.Forms.Label();
            this.warn_nick = new System.Windows.Forms.Label();
            this.warn_pass = new System.Windows.Forms.Label();
            this.warn_pass_match = new System.Windows.Forms.Label();
            this.Img_Bck_Grn_Clr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Img_Bck_Grn_Clr
            // 
            this.Img_Bck_Grn_Clr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Img_Bck_Grn_Clr.Controls.Add(this.welcome_label);
            this.Img_Bck_Grn_Clr.Controls.Add(this.library_image);
            this.Img_Bck_Grn_Clr.Dock = System.Windows.Forms.DockStyle.Right;
            this.Img_Bck_Grn_Clr.Location = new System.Drawing.Point(305, 0);
            this.Img_Bck_Grn_Clr.Name = "Img_Bck_Grn_Clr";
            this.Img_Bck_Grn_Clr.Size = new System.Drawing.Size(299, 376);
            this.Img_Bck_Grn_Clr.TabIndex = 2;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcome_label.Location = new System.Drawing.Point(30, 260);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(254, 28);
            this.welcome_label.TabIndex = 1;
            this.welcome_label.Text = "We are happy to see you join";
            // 
            // library_image
            // 
            this.library_image.BackgroundImage = global::LibrarySimulator2.Properties.Resources.library_picture_2;
            this.library_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.library_image.Location = new System.Drawing.Point(25, 40);
            this.library_image.Name = "library_image";
            this.library_image.Size = new System.Drawing.Size(252, 177);
            this.library_image.TabIndex = 0;
            this.library_image.TabStop = false;
            // 
            // nickname_label
            // 
            this.nickname_label.AutoSize = true;
            this.nickname_label.Location = new System.Drawing.Point(35, 135);
            this.nickname_label.Name = "nickname_label";
            this.nickname_label.Size = new System.Drawing.Size(61, 13);
            this.nickname_label.TabIndex = 15;
            this.nickname_label.Text = "Nickname :";
            // 
            // mail_label
            // 
            this.mail_label.AutoSize = true;
            this.mail_label.Location = new System.Drawing.Point(35, 70);
            this.mail_label.Name = "mail_label";
            this.mail_label.Size = new System.Drawing.Size(32, 13);
            this.mail_label.TabIndex = 14;
            this.mail_label.Text = "Mail :";
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.DarkGray;
            this.login_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(105, 325);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 40);
            this.login_button.TabIndex = 13;
            this.login_button.Text = "Register";
            this.login_button.UseVisualStyleBackColor = false;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(37, 150);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(140, 20);
            this.password_textbox.TabIndex = 11;
            // 
            // mail_textbox
            // 
            this.mail_textbox.Location = new System.Drawing.Point(37, 85);
            this.mail_textbox.Name = "mail_textbox";
            this.mail_textbox.Size = new System.Drawing.Size(140, 20);
            this.mail_textbox.TabIndex = 10;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_label.Location = new System.Drawing.Point(80, 20);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(153, 24);
            this.login_label.TabIndex = 9;
            this.login_label.Text = "Register Page";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(35, 200);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(62, 13);
            this.password_label.TabIndex = 17;
            this.password_label.Text = "Password : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // pass_confirm_label
            // 
            this.pass_confirm_label.AutoSize = true;
            this.pass_confirm_label.Location = new System.Drawing.Point(35, 265);
            this.pass_confirm_label.Name = "pass_confirm_label";
            this.pass_confirm_label.Size = new System.Drawing.Size(100, 13);
            this.pass_confirm_label.TabIndex = 19;
            this.pass_confirm_label.Text = "Password Confirm : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 280);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // warn_mail
            // 
            this.warn_mail.AutoSize = true;
            this.warn_mail.ForeColor = System.Drawing.Color.Firebrick;
            this.warn_mail.Location = new System.Drawing.Point(35, 105);
            this.warn_mail.Name = "warn_mail";
            this.warn_mail.Size = new System.Drawing.Size(35, 13);
            this.warn_mail.TabIndex = 20;
            this.warn_mail.Text = "label3";
            this.warn_mail.Visible = false;
            // 
            // warn_nick
            // 
            this.warn_nick.AutoSize = true;
            this.warn_nick.ForeColor = System.Drawing.Color.Firebrick;
            this.warn_nick.Location = new System.Drawing.Point(35, 170);
            this.warn_nick.Name = "warn_nick";
            this.warn_nick.Size = new System.Drawing.Size(35, 13);
            this.warn_nick.TabIndex = 21;
            this.warn_nick.Text = "label3";
            this.warn_nick.Visible = false;
            // 
            // warn_pass
            // 
            this.warn_pass.AutoSize = true;
            this.warn_pass.ForeColor = System.Drawing.Color.Firebrick;
            this.warn_pass.Location = new System.Drawing.Point(35, 235);
            this.warn_pass.Name = "warn_pass";
            this.warn_pass.Size = new System.Drawing.Size(35, 13);
            this.warn_pass.TabIndex = 22;
            this.warn_pass.Text = "label1";
            this.warn_pass.Visible = false;
            // 
            // warn_pass_match
            // 
            this.warn_pass_match.AutoSize = true;
            this.warn_pass_match.ForeColor = System.Drawing.Color.Firebrick;
            this.warn_pass_match.Location = new System.Drawing.Point(35, 300);
            this.warn_pass_match.Name = "warn_pass_match";
            this.warn_pass_match.Size = new System.Drawing.Size(35, 13);
            this.warn_pass_match.TabIndex = 23;
            this.warn_pass_match.Text = "label1";
            this.warn_pass_match.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.Controls.Add(this.warn_pass_match);
            this.Controls.Add(this.warn_pass);
            this.Controls.Add(this.warn_nick);
            this.Controls.Add(this.warn_mail);
            this.Controls.Add(this.pass_confirm_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nickname_label);
            this.Controls.Add(this.mail_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.mail_textbox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.Img_Bck_Grn_Clr);
            this.Name = "Form2";
            this.Text = "Library Central Register Page";
            this.Img_Bck_Grn_Clr.ResumeLayout(false);
            this.Img_Bck_Grn_Clr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Img_Bck_Grn_Clr;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.PictureBox library_image;
        private System.Windows.Forms.Label nickname_label;
        private System.Windows.Forms.Label mail_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.TextBox mail_textbox;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label pass_confirm_label;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label warn_mail;
        private System.Windows.Forms.Label warn_nick;
        private System.Windows.Forms.Label warn_pass;
        private System.Windows.Forms.Label warn_pass_match;
    }
}