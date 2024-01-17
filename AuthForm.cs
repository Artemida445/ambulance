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

namespace skoraya
{
    public partial class AuthForm : Form
    {
        static public bool admin;
        static public int cap;
        int ch;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            ch = 3;
            admin = false;
            object ex = new object();
            EventArgs ee = new EventArgs();
            auth_button_refreshCapcha_Click(ex, ee);
            auth_textBox_capcha.Text = cap.ToString();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            admin = false;

            MySqlConnection c = DB.c;
            MySqlCommand cmd = DB.cmd;
            MySqlDataAdapter ada = DB.ada;
            DataTable dt = new DataTable();
            //проверка пары логин+пароль
            ada.SelectCommand.CommandText = "SELECT * FROM Регистрация WHERE Логин = '" + tb_login.Text + "' AND Пароль = '" + tb_password.Text + "'";

            ada.Fill(dt);

            try
            {

                User.id = dt.Rows[0].ItemArray[0].ToString();
                User.log = dt.Rows[0].ItemArray[1].ToString();
                User.pwd = dt.Rows[0].ItemArray[2].ToString();
                User.email = dt.Rows[0].ItemArray[3].ToString();
                User.name = dt.Rows[0].ItemArray[4].ToString();
                User.lastName = dt.Rows[0].ItemArray[5].ToString();
                User.sex = dt.Rows[0].ItemArray[6].ToString();
                User.date = dt.Rows[0].ItemArray[7].ToString();
                User.country = dt.Rows[0].ItemArray[8].ToString();
                User.role = dt.Rows[0].ItemArray[9].ToString();
            }
            catch (Exception) { }
            if (cap != Convert.ToInt32(auth_textBox_capcha.Text))
            {
                MessageBox.Show("Неверна введена каптча.");
                return;
            }
            else if (User.log == "" || User.log == null)
            {
                ch--;
                if (ch > 0)
                    MessageBox.Show("Неверный пароль, Осталось попыток: " + ch);
                else
                {
                    MessageBox.Show("Пароль введен неверно слишком много раз. Закрытие программы...");
                    Application.Exit();
                }
            }
            else
            {
                Hide();

                if (User.role.Contains("ратор"))
                    admin = true;

                if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 12)
                {
                    if (User.sex == "Мужской")
                    {
                        MessageBox.Show("Доброе утро уважаемый, " + User.name + " " + User.lastName);
                    }
                    if (User.sex == "Женский")
                    {
                        MessageBox.Show("Доброе утро уважаемая, " + User.name + " " + User.lastName);
                    }
                }
                if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16)
                {
                    if (User.sex == "Мужской")
                    {
                        MessageBox.Show("Добрый день уважаемый, " + User.name + " " + User.lastName);
                    }
                    if (User.sex == "Женский")
                    {
                        MessageBox.Show("Добрый день уважаемая, " + User.name + " " + User.lastName);
                    }
                }
                if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 24)
                {
                    if (User.sex == "Мужской")
                    {
                        MessageBox.Show("Добрый вечер уважаемый, " + User.name + " " + User.lastName);
                    }
                    if (User.sex == "Женский")
                    {
                        MessageBox.Show("Добрый вечер уважаемая, " + User.name + " " + User.lastName);
                    }
                }

                MainForm f = new MainForm();
                f.ShowDialog();
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void auth_button_refreshCapcha_Click(object sender, EventArgs e)
        {
            Random r1 = new Random();
            cap = r1.Next(10000, 99999);
            var image = new Bitmap(this.auth_pictureBox_capcha.Width, this.auth_pictureBox_capcha.Height);
            var font = new Font("TimesNewRoman", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(cap.ToString(), font, Brushes.Green, new Point(0, 0));
            auth_pictureBox_capcha.Image = image;
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegForm f = new RegForm();
            f.ShowDialog();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public static class User
    {
        public static string id, log, pwd, email, name, lastName, sex, date, country, role;
    }
}
