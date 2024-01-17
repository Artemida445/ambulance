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
    public partial class DirBrigadaForm : Form
    {
        int brigadaId = -1;
        public DirBrigadaForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DB.cmd.CommandText = "INSERT INTO Бригада (`№ машины`, `№ водительского удостоверения`, `ФИО водителя`) VALUES ( " +
                "'" + ___машиныTextBox.Text + "', " +
                "'" + ___водител_удостоверенияTextBox.Text + "', " +
                "'" + фИО_водителяTextBox.Text + "')";
            Clipboard.SetText(DB.cmd.CommandText);
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();

            DirBrigadaForm_Load(sender, e);

            MessageBox.Show("Успешно!");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {

            бригадаDataGridView.ClearSelection();
            string strToFind = tb_search.Text;
            if (strToFind == null || strToFind == "")
                return;
            for (int i = 0; i < бригадаDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < бригадаDataGridView.ColumnCount; j++)
                    if (бригадаDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(strToFind.ToLower()))
                    {
                        бригадаDataGridView.Rows[i].Selected = true;
                        break;
                    }
            }
        }

        private void DirBrigadaForm_Load(object sender, EventArgs e)
        {
            if (!AuthForm.admin)
            {
                btn_add.Visible = false;
            }

            DataSet ds = new DataSet();
            string tName = "Бригада";

            DB.ada.SelectCommand.CommandText = "SELECT * FROM " + tName;
            DB.ada.Fill(ds, tName);

            бригадаDataGridView.Refresh();
            бригадаDataGridView.DataSource = ds;
            бригадаDataGridView.DataMember = tName;
        }
    

    private void бригадаDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedRow = бригадаDataGridView.SelectedCells[0].OwningRow.Cells;

            brigadaId = int.Parse(clickedRow[0].Value.ToString());
            ___машиныTextBox.Text = clickedRow[1].Value.ToString();
            ___водител_удостоверенияTextBox.Text = clickedRow[2].Value.ToString();
            фИО_водителяTextBox.Text = clickedRow[3].Value.ToString();
        }
        

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (brigadaId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }
            DB.cmd.CommandText = "UPDATE Бригада SET " +
                "`№ машины` = '" + ___машиныTextBox.Text + "', " +
                "`№ водительского удостоверения` = '" + ___водител_удостоверенияTextBox.Text + "', " +
                "`ФИО водителя` = '" + фИО_водителяTextBox.Text + "' " +
                "WHERE `№ бригады` = " + brigadaId;
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();
            MessageBox.Show("Успешно!");

            RefreshDGV();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (brigadaId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }
            DB.cmd.CommandText = " DELETE FROM `Бригада` WHERE `№ бригады` = " + brigadaId;
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

            бригадаDataGridView.Refresh();
            бригадаDataGridView.DataSource = ds;
            бригадаDataGridView.DataMember = tName;
        }
    }
}
