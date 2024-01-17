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
    public partial class DirPacientForm : Form
    {
        int pacientId = -1;
        public DirPacientForm()
        {
            InitializeComponent();
        }

        private void DirPacientForm_Load(object sender, EventArgs e)
        {
            if (!AuthForm.admin)
            {
                btn_add.Visible = false;
            }

            DataSet ds = new DataSet();
            string tName = "Пациент";

            DB.ada.SelectCommand.CommandText = "SELECT * FROM " + tName;
            DB.ada.Fill(ds, tName);

            пациентDataGridView.Refresh();
            пациентDataGridView.DataSource = ds;
            пациентDataGridView.DataMember = tName;

            // TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.skorayaDBDataSet.Пациент);

        }

        private void пациентDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedRow = пациентDataGridView.SelectedCells[0].OwningRow.Cells;

            pacientId = int.Parse(clickedRow[0].Value.ToString());
            фИОTextBox.Text = clickedRow[1].Value.ToString();
            дата_рожденияDateTimePicker.Text = clickedRow[2].Value.ToString();
            телефонTextBox.Text = clickedRow[3].Value.ToString();
            адресTextBox.Text = clickedRow[4].Value.ToString();
            постоянный_диагнозTextBox.Text = clickedRow[5].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DB.cmd.CommandText = "INSERT INTO Пациент (`ФИО пациента`, `Дата рождения`, Телефон, Адрес, `Постоянный диагноз`) VALUES ( " +
                "'" + фИОTextBox.Text + "', " +
                "'" + дата_рожденияDateTimePicker.Value.ToShortDateString() + "', " +
                "'" + телефонTextBox.Text + "', " +
                "'" + адресTextBox.Text + "', " +
                "'" + постоянный_диагнозTextBox.Text + "')";
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();

            DirPacientForm_Load(sender, e);

            MessageBox.Show("Успешно!");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            пациентDataGridView.ClearSelection();
            string strToFind = search.Text;
            if (strToFind == null || strToFind == "")
                return;
            for (int i = 0; i < пациентDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < пациентDataGridView.ColumnCount; j++)
                    if (пациентDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(strToFind.ToLower()))
                    {
                        пациентDataGridView.Rows[i].Selected = true;
                        break;
                    }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (pacientId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }
            DB.cmd.CommandText = "UPDATE Пациент SET " +
                "`ФИО пациента` = '" + фИОTextBox.Text + "', " +
                "`Дата рождения` = '" + дата_рожденияDateTimePicker.Value.ToShortDateString() + "', " +
                "`Телефон` = '" + телефонTextBox.Text + "', " +
                "`Адрес` = '" + адресTextBox.Text + "', " +
                "`Постоянный диагноз` = '" + постоянный_диагнозTextBox.Text + "' " +
                "WHERE `№ пациента` = " + pacientId;
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();
            MessageBox.Show("Успешно!");

            RefreshDGV();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (pacientId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }
            DB.cmd.CommandText = " DELETE FROM `Бригада` WHERE `№ бригады` = " + pacientId;
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();
            MessageBox.Show("Успешно!");

            RefreshDGV();
        }
        void RefreshDGV()
        {
            DataSet ds = new DataSet();
            string tName = "`Мед персонал`";

            DB.ada.SelectCommand.CommandText = "SELECT * FROM " + tName;
            DB.ada.Fill(ds, tName);

            пациентDataGridView.Refresh();
            пациентDataGridView.DataSource = ds;
            пациентDataGridView.DataMember = tName;
        }

    }
   
}
