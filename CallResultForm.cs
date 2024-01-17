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
    public partial class CallResultForm : Form
    {
        public string callId;
        public CallResultForm()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Сохранено!");
        }

        private void CallResultForm_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            //this.пациентTableAdapter.Fill(this.skorayaDBDataSet.Пациент);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Мед_персонал". При необходимости она может быть перемещена или удалена.
            //this.мед_персоналTableAdapter.Fill(this.skorayaDBDataSet.Мед_персонал);
            
            MySqlDataAdapter ada = DB.ada;
            ada.SelectCommand.CommandText = "SELECT `ФИО` FROM `Мед персонал`";
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cb_docFio.Items.Clear();
            foreach (var line in dt.Rows)
                cb_docFio.Items.Add(line);

            ada.SelectCommand.CommandText = "SELECT `ФИО пациента` FROM `Пациент`";
            dt = new DataTable();
            ada.Fill(dt);
            cb_pacientFio.Items.Clear();
            foreach (var line in dt.Rows)
                cb_pacientFio.Items.Add(line);

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string s = null;
            s = "\tРезультат вызова\n";
            s += "\nКод вызова: " + tb_callId.Text
                + "\nФИО врача: " + cb_docFio.Text
                + "\nФИО пациента: " + cb_pacientFio.Text
                + "\nНаправление: " + rtb_napr.Text
                + "\nДиагноз: " + rtb_diag.Text
                + "\nЛекарство: " + rtb_cure.Text;


            e.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));

        }
    }
}
