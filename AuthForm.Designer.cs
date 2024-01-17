namespace skoraya
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.auth_button_refreshCapcha = new System.Windows.Forms.Button();
            this.auth_textBox_capcha = new System.Windows.Forms.TextBox();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_login = new System.Windows.Forms.Button();
            this.auth_pictureBox_capcha = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.auth_pictureBox_capcha)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.label4.Location = new System.Drawing.Point(82, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "CAPTCHA";
            // 
            // auth_button_refreshCapcha
            // 
            this.auth_button_refreshCapcha.BackgroundImage = global::skoraya.Properties.Resources.w256h2561339195956Refresh256x256;
            this.auth_button_refreshCapcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.auth_button_refreshCapcha.Cursor = System.Windows.Forms.Cursors.Default;
            this.auth_button_refreshCapcha.FlatAppearance.BorderSize = 0;
            this.auth_button_refreshCapcha.Location = new System.Drawing.Point(170, 148);
            this.auth_button_refreshCapcha.Name = "auth_button_refreshCapcha";
            this.auth_button_refreshCapcha.Size = new System.Drawing.Size(28, 28);
            this.auth_button_refreshCapcha.TabIndex = 37;
            this.auth_button_refreshCapcha.UseVisualStyleBackColor = true;
            this.auth_button_refreshCapcha.Click += new System.EventHandler(this.auth_button_refreshCapcha_Click);
            // 
            // auth_textBox_capcha
            // 
            this.auth_textBox_capcha.BackColor = System.Drawing.SystemColors.Menu;
            this.auth_textBox_capcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_textBox_capcha.Location = new System.Drawing.Point(209, 148);
            this.auth_textBox_capcha.Name = "auth_textBox_capcha";
            this.auth_textBox_capcha.Size = new System.Drawing.Size(75, 29);
            this.auth_textBox_capcha.TabIndex = 36;
            // 
            // link_register
            // 
            this.link_register.AutoSize = true;
            this.link_register.Location = new System.Drawing.Point(168, 115);
            this.link_register.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(121, 13);
            this.link_register.TabIndex = 34;
            this.link_register.TabStop = true;
            this.link_register.Text = "Новый пользователь?";
            this.link_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_register_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(101, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 27);
            this.label3.TabIndex = 33;
            this.label3.Text = "Вход в профиль";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(163, 72);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(122, 20);
            this.tb_login.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(81, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Логин:";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(163, 94);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(122, 20);
            this.tb_password.TabIndex = 29;
            this.tb_password.TextChanged += new System.EventHandler(this.tb_password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(81, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Пароль:";
            // 
            // b_exit
            // 
            this.b_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_exit.Location = new System.Drawing.Point(33, 192);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(75, 23);
            this.b_exit.TabIndex = 32;
            this.b_exit.Text = "Отмена";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_login
            // 
            this.b_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_login.Location = new System.Drawing.Point(256, 192);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 27;
            this.b_login.Text = "ОК";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // auth_pictureBox_capcha
            // 
            this.auth_pictureBox_capcha.Location = new System.Drawing.Point(85, 148);
            this.auth_pictureBox_capcha.Name = "auth_pictureBox_capcha";
            this.auth_pictureBox_capcha.Size = new System.Drawing.Size(75, 28);
            this.auth_pictureBox_capcha.TabIndex = 35;
            this.auth_pictureBox_capcha.TabStop = false;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 250);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.auth_button_refreshCapcha);
            this.Controls.Add(this.auth_textBox_capcha);
            this.Controls.Add(this.auth_pictureBox_capcha);
            this.Controls.Add(this.link_register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AuthForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auth_pictureBox_capcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button auth_button_refreshCapcha;
        private System.Windows.Forms.TextBox auth_textBox_capcha;
        private System.Windows.Forms.PictureBox auth_pictureBox_capcha;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_login;
    }
}

