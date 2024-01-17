using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skoraya
{
    public partial class FilterForm : Form
    {
        public FilterForm()
        {
            InitializeComponent();
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Мед_персонал". При необходимости она может быть перемещена или удалена.
            //this.мед_персоналTableAdapter.Fill(this.skorayaDBDataSet.Мед_персонал);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            //this.пациентTableAdapter.Fill(this.skorayaDBDataSet.Пациент);
            //// TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Бригада". При необходимости она может быть перемещена или удалена.
            //this.бригадаTableAdapter.Fill(this.skorayaDBDataSet.Бригада);

            MySqlDataAdapter ada = DB.ada;
            ada.SelectCommand.CommandText = "SELECT `№ бригады` FROM `Бригада`";
            DataTable dt = new DataTable();
            ada.Fill(dt);
            cb_brigada.Items.Clear();
            foreach (DataRow line in dt.Rows)
                cb_brigada.Items.Add(line.ItemArray[0]);

            ada.SelectCommand.CommandText = "SELECT `№ пациента` FROM `Пациент`";
            dt = new DataTable();
            ada.Fill(dt);
            cb_paicent.Items.Clear();
            foreach (DataRow line in dt.Rows)
                cb_paicent.Items.Add(line.ItemArray[0]);

            ada.SelectCommand.CommandText = "SELECT `№ мед персонала` FROM `Мед персонал`";
            dt = new DataTable();
            ada.Fill(dt);
            cb_medPers.Items.Clear();
            foreach (DataRow line in dt.Rows)
                cb_medPers.Items.Add(line.ItemArray[0]);
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            string cmdText = "SELECT * FROM Вызовы WHERE `№ бригады` like '%%' ";

            if (cb_brigada.Text != null && cb_brigada.Text != "")
                cmdText += "AND `№ бригады` = " + cb_brigada.Text + " ";
            if (cb_paicent.Text != null && cb_paicent.Text != "")
                cmdText += "AND `№ пациента` = " + cb_paicent.Text + " ";
            if (cb_medPers.Text != null && cb_medPers.Text != "")
                cmdText += "AND `№ мед персонала` = " + cb_medPers.Text + " ";
            DB.ada.SelectCommand.CommandText = cmdText;

            Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            DB.ada.SelectCommand.CommandText = "SELECT * FROM Вызовы";

            Close();
        }
    }
}
