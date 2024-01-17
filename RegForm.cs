using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace skoraya
{
    public partial class RegForm : Form
    {
        public string title = "Регистрация";
        public bool editMode = false;
        Regex regexLetters = new Regex("([A-Z])|([А-Я])");
        Regex regexDigits = new Regex("([0-9])");
        Regex regexSymbols = new Regex("!|@|#|$|%|^");

        public RegForm()
        {
            InitializeComponent();
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (tb_pwd.Text.Length < 6)
            {
                MessageBox.Show("Пароль слишком короткий!");
                return;
            }
            if(regexLetters.Matches(tb_pwd.Text).Count == 0 || regexDigits.Matches(tb_pwd.Text).Count == 0 || regexSymbols.Matches(tb_pwd.Text).Count == 0)
            {
                MessageBox.Show("Пароль не удовлетворяет условиям.\nПароль должен содержать:\n\n•	Минимум 6 символов\n•	Минимум 1 прописная буква\n•	Минимум 1 цифра\n•	По крайней мере один из следующих символов: ! @ # $ % ^");
                return;
            }

            if (tb_pwd.Text != tb_pwdVerify.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
                return;
            }

            MySqlConnection c = DB.c;
            MySqlCommand cmd = DB.cmd;

            if (!editMode)
            {
                cmd.CommandText = "INSERT INTO `Регистрация` (Логин, Пароль, Email, Имя, Фамилия, Пол, [Дата Рождения], Страна, Роль) " +
                   "VALUES (\"" +
                   tb_login.Text + "\", \"" +
                   tb_pwd.Text + "\", \"" +
                   tb_mail.Text + "\", \"" +
                   tb_name.Text + "\", \"" +
                   tb_lastName.Text + "\", \"" +
                   cb_sex.Text + "\", \"" +
                   dtp_dateBirth.Value.ToShortDateString() + "\", \"" +
                   tb_country.Text + "\", \"" +
                   "Пользователь" + "\")";
            }
            else
            {
                cmd.CommandText = "UPDATE Регистрация SET " +
                    "Логин = '" + tb_login.Text + "', " +
                    "Пароль = '" + tb_pwd.Text + "', " +
                    "Email = '" + tb_mail.Text + "', " +
                    "Имя = '" + tb_name.Text + "', " +
                    "Фамилия = '" + tb_lastName.Text + "', " +
                    "Пол = '" + cb_sex.Text + "', " +
                    "[Дата Рождения] = '" + dtp_dateBirth.Value.ToShortDateString() + "', " +
                    "Страна = '" + tb_country.Text + "' " +
                    "WHERE Код = " + User.id;
                    }
            c.Open();
            cmd.ExecuteNonQuery();
            c.Close();

            MessageBox.Show(title + " успешно!");
            Close();
        }

        private void RegForm_Load(object sender, EventArgs e)
        {
            label1.Text = title;

            if (editMode)
            {
                cb_sex.Text = User.sex;
                tb_name.Text = User.name;
                tb_lastName.Text = User.lastName;
                tb_mail.Text = User.email;
                tb_country.Text = User.country;
                tb_login.Text = User.log;
            }
        }
    }
}
