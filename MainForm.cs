using skoraya.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skoraya
{
    public partial class MainForm : Form
    {
        int callId = -1;
        public MainForm()
        {
            InitializeComponent();
        }
        
        DateTime eventDate = new DateTime (2019/9/14);
        Pacient p;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if(!AuthForm.admin)
            {
                операцииToolStripMenuItem.Visible = false;
                btn_createCall.Visible = false;
                btn_save.Visible = false;
                btn_addPacient.Visible = false;
            }
            
            p = new Pacient(1);

            timeUpdate.Start();

            DataSet ds = new DataSet();
            string tName = "Вызовы";

            DB.ada.SelectCommand.CommandText = "SELECT * FROM " + tName;
            DB.ada.Fill(ds, tName);

            вызовыDataGridView.Refresh();
            вызовыDataGridView.DataSource = ds;
            вызовыDataGridView.DataMember = tName;


            // TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Мед_персонал". При необходимости она может быть перемещена или удалена.
            this.мед_персоналTableAdapter.Fill(this.skorayaDBDataSet.Мед_персонал);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Бригада". При необходимости она может быть перемещена или удалена.
            this.бригадаTableAdapter.Fill(this.skorayaDBDataSet.Бригада);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Пациент". При необходимости она может быть перемещена или удалена.
            this.пациентTableAdapter.Fill(this.skorayaDBDataSet.Пациент);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "skorayaDBDataSet.Вызовы". При необходимости она может быть перемещена или удалена.
            this.вызовыTableAdapter.Fill(this.skorayaDBDataSet.Вызовы);

            label5.Text = " Количество строк: " + вызовыDataGridView.Rows.Count;

        }

        private void вызовыDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedRow = вызовыDataGridView.SelectedCells[0].OwningRow.Cells;
            int pacientId = Convert.ToInt32(clickedRow[2].Value.ToString());
            p = new Pacient(pacientId);

            callId = int.Parse(clickedRow[0].Value.ToString());
            tb_callCode.Text = clickedRow[0].Value.ToString();

            tb_mlMPers.Text = clickedRow[4].Value.ToString();
            фИОComboBox.Text = p.name;
            адресTextBox.Text = p.address;
            телефонTextBox.Text = p.phone;
            постоянный_диагнозTextBox.Text = p.diagnoz;

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

            вызовыDataGridView.ClearSelection();

            if (search.Text == "")
                return;

            string strToFind = search.Text;
            for (int i = 0; i < вызовыDataGridView.Rows.Count; i++)
            {
                for(int j = 0; j < вызовыDataGridView.Columns.Count; j++)
                if (вызовыDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(strToFind.ToLower()))
                {
                    вызовыDataGridView.Rows[i].Selected = true;
                        break;
                }
            }

        }

        private void btn_addPacient_Click(object sender, EventArgs e)
        {
            DirPacientForm f = new DirPacientForm();
            f.Show();
        }

        private void справочникБригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirBrigadaForm f = new DirBrigadaForm();
            f.Show();
        }

        private void справочникВрачейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirMedPersForm f = new DirMedPersForm();
            f.Show();
        }

        private void справочникПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DirPacientForm f = new DirPacientForm();
            f.Show();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Это программа создана для диспетчеров скорой помощи.");
        }

        private void timeUpdate_Tick(object sender, EventArgs e)
        {
            currentTime.Text = "Текущее время: " + DateTime.Now.ToShortTimeString();

            TimeSpan t = eventDate.Subtract(DateTime.Now);
            eventTime.Text = "До поступления нового транспорта осталось: " + t.Days + " дней " + t.Hours + " ч. " + t.Minutes + " м. " + t.Seconds + " с.";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(callId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }

            DB.c.Open();
            
            DB.cmd.CommandText = "UPDATE `Вызовы` SET `№ бригады` = " + Нбригады.Text +
                ", `№ пациента` = " + p.id +
                ", `№ мед персонала` = " + Нврача.Text +
                ", `Младшй мед персонал` = '" + tb_mlMPers.Text +
                "', `ФИО врача` = '" + фИОComboBox.Text +
                "', `Дата обращения` = '" + дата_обращенияDateTimePicker.Value.ToShortDateString() +
                 "' WHERE `Код вызова` = " + tb_callCode.Text;
            DB.cmd.ExecuteNonQuery();

            DB.c.Close();

            MainForm_Load(sender, e);

            MessageBox.Show("Изменения успешно сохранены!");

        }

        private void btn_createCall_Click(object sender, EventArgs e)
        {
            DB.c.Open();

            DB.cmd.CommandText = "INSERT INTO Вызовы (`№ бригады`, `№ пациента`, `№ мед персонала`, `Младшй мед персонал`, `ФИО врача`, `Дата обращения` ) VALUES (" +
                Нбригады.Text + ", " +
                p.id + ", " +
                Нврача.Text + ", '" +
                tb_mlMPers.Text + "', '" +
                фИОComboBox.Text + "', '" +
                дата_обращенияDateTimePicker.Value.ToShortDateString() + "')";
            DB.cmd.ExecuteNonQuery();

            DB.c.Close();

            MainForm_Load(sender, e);

            MessageBox.Show("Вызов успешно добавлен!");

            printPreviewDialog2.ShowDialog();
        }

        private void создатьВызовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_createCall_Click(sender, e);
        }

        private void сохранитьВызовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_save_Click(sender, e);
        }

        private void результатВызовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallResultForm f = new CallResultForm();
            f.Show();
        }

        private void печатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Bitmap bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
        }

        private void выгрузитьВCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "";

            for (int i = 0; i < вызовыDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < вызовыDataGridView.Columns.Count; j++)
                {
                    text += вызовыDataGridView.Rows[i].Cells[j].Value.ToString().Replace(';', '\0') + ";";
                }
                text += "\n";
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
            string path = sfd.FileName;
            File.WriteAllText(path, text, Encoding.UTF8);
            MessageBox.Show("Копия базы успешно создана.");
        }

        private void редактированиеПрофиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegForm f = new RegForm();
            f.title = "Изменение профиля";
            f.editMode = true;
            f.Show();
        }

        private void картаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MapForm f = new MapForm();
            f.Show();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            FilterForm f = new FilterForm();
            f.ShowDialog();
            DataSet ds = new DataSet();
            string tName = "Вызовы";

            DB.ada.Fill(ds, tName);

            вызовыDataGridView.Refresh();
            вызовыDataGridView.DataSource = ds;
            вызовыDataGridView.DataMember = tName;

            label5.Text = " Количество строк: " + вызовыDataGridView.Rows.Count;
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(вызовыDataGridView.Size.Width + 10, вызовыDataGridView.Size.Height + 10);
            вызовыDataGridView.DrawToBitmap(bmp, вызовыDataGridView.Bounds);
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void загрузитьИзCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.ShowDialog();

            MessageBox.Show("База успешно загружена.");
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string s = null;

            s = "\tВызов №" + tb_callCode.Text
                + "\n\nДата обращения: " + дата_обращенияDateTimePicker.Value.ToShortDateString()
                + "\nФИО пациента: " + фИОComboBox.Text
                + "\nАдрес: " + адресTextBox.Text
                + "\nТелефон: " + телефонTextBox.Text
                + "\nПостоянный диагноз: " + постоянный_диагнозTextBox.Text
                + "\n"
                + "\nМладший мед. персонал: " + tb_mlMPers.Text
                + "\n№ бригады: " + Нбригады.Text
                + "\n№ врача: " + Нврача.Text;

            e.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, printDocument1.DefaultPageSettings.PrintableArea.Width, printDocument1.DefaultPageSettings.PrintableArea.Height));

        }

        private void фИОComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.id = p.GetId("ФИО пациента", фИОComboBox.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (callId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }
            DB.cmd.CommandText = "DELETE FROM Вызовы WHERE `Код вызова` = " + callId;
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();

            MessageBox.Show("Запись успешно удалена.");
            MainForm_Load(sender, e);
        }
    }
    class Pacient
    {
        public string id, name, date, phone, address, diagnoz;
        public Pacient(int pId)
        {
            DB.ada.SelectCommand.CommandText = "SELECT * FROM Пациент WHERE `№ пациента` = " + pId;
            DataTable dt = new DataTable();
            DB.ada.Fill(dt);

            id = pId.ToString();
            name = dt.Rows[0].ItemArray[1].ToString();
            date = dt.Rows[0].ItemArray[2].ToString();
            phone = dt.Rows[0].ItemArray[3].ToString();
            address = dt.Rows[0].ItemArray[4].ToString();
            diagnoz = dt.Rows[0].ItemArray[5].ToString();
        }
        public string GetId(string col, string val)
        {
            string res = "";

            DB.cmd.CommandText = "SELECT `№ пациента` FROM Пациент WHERE `" + col + "` = '" + val + "'";
            DB.c.Open();
            res = DB.cmd.ExecuteScalar().ToString();
            DB.c.Close();

            return res;
        }
    }
}
