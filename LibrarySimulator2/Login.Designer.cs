namespace LibrarySimulator2
{
    partial class Login_page
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Img_Bck_Grn_Clr = new System.Windows.Forms.Panel();
            this.welcome_label = new System.Windows.Forms.Label();
            this.library_image = new System.Windows.Forms.PictureBox();
            this.login_label = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.id_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.warn_msg = new System.Windows.Forms.Label();
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
            this.Img_Bck_Grn_Clr.TabIndex = 1;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcome_label.Location = new System.Drawing.Point(30, 260);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(247, 28);
            this.welcome_label.TabIndex = 1;
            this.welcome_label.Text = "Welcome to Library Central";
            // 
            // library_image
            // 
            this.library_image.BackgroundImage = global::LibrarySimulator2.Properties.Resources.library_picture;
            this.library_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.library_image.Location = new System.Drawing.Point(25, 40);
            this.library_image.Name = "library_image";
            this.library_image.Size = new System.Drawing.Size(252, 177);
            this.library_image.TabIndex = 0;
            this.library_image.TabStop = false;
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_label.Location = new System.Drawing.Point(80, 30);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(125, 24);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login Page";
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(37, 110);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(140, 20);
            this.id_textbox.TabIndex = 3;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(37, 175);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(140, 20);
            this.password_textbox.TabIndex = 4;
            this.password_textbox.UseSystemPasswordChar = true;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.DarkGray;
            this.login_button.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(105, 260);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(100, 40);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(35, 85);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(24, 13);
            this.id_label.TabIndex = 7;
            this.id_label.Text = "ID :";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(35, 150);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(62, 13);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "Password : ";
            // 
            // warn_msg
            // 
            this.warn_msg.AutoSize = true;
            this.warn_msg.ForeColor = System.Drawing.Color.Firebrick;
            this.warn_msg.Location = new System.Drawing.Point(120, 315);
            this.warn_msg.Name = "warn_msg";
            this.warn_msg.Size = new System.Drawing.Size(66, 13);
            this.warn_msg.TabIndex = 9;
            this.warn_msg.Text = "Wrong Input";
            this.warn_msg.Visible = false;
            // 
            // Login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(604, 376);
            this.Controls.Add(this.warn_msg);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.Img_Bck_Grn_Clr);
            this.Name = "Login_page";
            this.Text = "Library Central Login Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_page_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Enter += new System.EventHandler(this.Login_button_Click);
            this.Img_Bck_Grn_Clr.ResumeLayout(false);
            this.Img_Bck_Grn_Clr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.library_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox library_image;
        private System.Windows.Forms.Panel Img_Bck_Grn_Clr;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label warn_msg;
    }
}

