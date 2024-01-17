namespace skoraya
{
    partial class RegForm
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
            this.label9 = new System.Windows.Forms.Label();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.btn_done = new System.Windows.Forms.Button();
            this.dtp_dateBirth = new System.Windows.Forms.DateTimePicker();
            this.tb_pwdVerify = new System.Windows.Forms.TextBox();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 108;
            this.label9.Text = "Логин";
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(128, 280);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(131, 20);
            this.tb_login.TabIndex = 107;
            // 
            // cb_sex
            // 
            this.cb_sex.AutoCompleteCustomSource.AddRange(new string[] {
            "Мужской",
            "Женский"});
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cb_sex.Location = new System.Drawing.Point(128, 91);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(131, 21);
            this.cb_sex.TabIndex = 106;
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(22, 401);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(235, 30);
            this.btn_done.TabIndex = 105;
            this.btn_done.Text = "ОК";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // dtp_dateBirth
            // 
            this.dtp_dateBirth.Location = new System.Drawing.Point(128, 193);
            this.dtp_dateBirth.Name = "dtp_dateBirth";
            this.dtp_dateBirth.Size = new System.Drawing.Size(131, 20);
            this.dtp_dateBirth.TabIndex = 104;
            // 
            // tb_pwdVerify
            // 
            this.tb_pwdVerify.Location = new System.Drawing.Point(128, 347);
            this.tb_pwdVerify.Name = "tb_pwdVerify";
            this.tb_pwdVerify.Size = new System.Drawing.Size(131, 20);
            this.tb_pwdVerify.TabIndex = 103;
            // 
            // tb_pwd
            // 
            this.tb_pwd.Location = new System.Drawing.Point(128, 323);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(131, 20);
            this.tb_pwd.TabIndex = 102;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 101;
            this.label8.Text = "Дата рождения";
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(128, 217);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(131, 20);
            this.tb_mail.TabIndex = 100;
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(128, 158);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(131, 20);
            this.tb_lastName.TabIndex = 99;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(128, 133);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(131, 20);
            this.tb_name.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 97;
            this.label7.Text = "Пол";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 96;
            this.label6.Text = "Повторите пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 95;
            this.label5.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 91;
            this.label1.Text = "Регистрация";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Страна";
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(128, 240);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(131, 20);
            this.tb_country.TabIndex = 109;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 453);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_country);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.cb_sex);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.dtp_dateBirth);
            this.Controls.Add(this.tb_pwdVerify);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.DateTimePicker dtp_dateBirth;
        private System.Windows.Forms.TextBox tb_pwdVerify;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_country;
    }
}