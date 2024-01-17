using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;

namespace skoraya
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            GreetForm first = new GreetForm();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(0.3f);
            first.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();
            Application.Run(new AuthForm());
        }
    }
    public static class DB
    {
        public static MySqlConnection c = new MySqlConnection("server=localhost;user=root;database=ambulance;password=;");
        public static MySqlCommand cmd = new MySqlCommand("", c);
        public static MySqlDataAdapter ada = new MySqlDataAdapter("", c);
    }
}
