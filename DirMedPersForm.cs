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
    public partial class DirMedPersForm : Form
    {
        bool loadPicMode;
        Image[] pics = new Image[5];
        int curPicId;
        int medPersId = -1;
        public DirMedPersForm()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            врачиDataGridView.ClearSelection();
            string strToFind = search.Text;

            if (strToFind == null || strToFind == "")
                return;
            for (int i = 0; i < врачиDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < врачиDataGridView.ColumnCount; j++)
                    if (врачиDataGridView.Rows[i].Cells[j].Value.ToString().ToLower().Contains(strToFind.ToLower()))
                    {
                        врачиDataGridView.Rows[i].Selected = true;
                        break;
                    }
            }
        }

        private void врачиDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var clickedRow = врачиDataGridView.SelectedCells[0].OwningRow.Cells;

            medPersId = int.Parse(clickedRow[0].Value.ToString());
            фИОTextBox.Text = clickedRow[1].Value.ToString();
            tb_spec.Text = clickedRow[2].Value.ToString();
            должностьTextBox.Text = clickedRow[3].Value.ToString();
            телефонTextBox.Text = clickedRow[4].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            DB.cmd.CommandText = "INSERT INTO [Мед персонал] (ФИО, Специальность, Должность, Телефон) VALUES ( " +
                "'" + фИОTextBox.Text + "', " +
                "'" + tb_spec.Text + "', " +
                "'" + должностьTextBox.Text + "', " +
                "'" + телефонTextBox.Text + "')";
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();

            DirMedPersForm_Load(sender, e);

            MessageBox.Show("Успешно!");
        }

        private void DirMedPersForm_Load(object sender, EventArgs e)
        {
            if (!AuthForm.admin)
            {
                btn_add.Visible = false;
                btn_loadPic.Visible = false;
            }

            curPicId = 0;
            loadPicMode = false;


            //start tick for carousel
            timer1.Start();

            //fill images array
            pics[0] = GetImg("1", pictureBox41.Image);
            pics[1] = GetImg("2", pictureBox4.Image);
            pics[2] = GetImg("3", pictureBox75.Image);
            pics[3] = GetImg("4", pictureBox63.Image);
            pics[4] = GetImg("5", pictureBox52.Image);

            //set images on carousel
            pictureBox41.Image = GetImg("1", pictureBox41.Image);
            pictureBox4.Image = GetImg("2", pictureBox4.Image);
            pictureBox75.Image = GetImg("3", pictureBox75.Image);
            pictureBox63.Image = GetImg("4", pictureBox63.Image);
            pictureBox52.Image = GetImg("5", pictureBox52.Image);

            //start counter for pics
            curPicId = 0;

            DataSet ds = new DataSet();
            string tName = "`Мед персонал`";

            DB.ada.SelectCommand.CommandText = "SELECT * FROM " + tName;
            DB.ada.Fill(ds, tName);

            врачиDataGridView.Refresh();
            врачиDataGridView.DataSource = ds;
            врачиDataGridView.DataMember = tName;

        }
        Image GetImg(string id, Image defImg = null)
        {
            Image res = defImg;

            try
            {
                DB.cmd.CommandText = "SELECT Изображение FROM `Травмы и заболевания` WHERE `Код` = " + id;
                DB.c.Open();
                string path = DB.cmd.ExecuteScalar().ToString();
                DB.c.Close();

                res = Image.FromFile(path, true);
            }
            catch (Exception) {
                try
                {
                    DB.c.Close();
                }
                catch (Exception) { }
            }

            return res;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!loadPicMode)
            {
                pb_bigPic.Image = (sender as PictureBox).Image;

                string labelText = null;

                if ((sender as PictureBox).Name.Contains("41"))
                    labelText = label41.Text;
                else if ((sender as PictureBox).Name.Contains("4"))
                    labelText = label4.Text;
                else if ((sender as PictureBox).Name.Contains("75"))
                    labelText = label75.Text;
                else if ((sender as PictureBox).Name.Contains("63"))
                    labelText = label63.Text;
                else if ((sender as PictureBox).Name.Contains("52"))
                    labelText = label52.Text;

                l_bigPic.Text = labelText;
            }
            else
            {
                OpenFileDialog f = new OpenFileDialog();
                f.ShowDialog();
                string path = f.FileName;
                Image tmp = Image.FromFile(path, true);

                int num = int.Parse((sender as PictureBox).Name.Split('x')[1]);
                if (num == 41) num = 1;
                else if (num == 4) num = 2;
                else if (num == 75) num = 3;
                else if (num == 63) num = 4;
                else if (num == 52) num = 5;

                DB.cmd.CommandText = "UPDATE `Травмы и заболевания` SET `Изображение` = \"" + path + "\" WHERE Код = " + num;
                DB.c.Open();
                DB.cmd.ExecuteNonQuery();
                DB.c.Close();

                MessageBox.Show("Успешно!");
                loadPicMode = false;
                DirMedPersForm_Load(sender, e);
            }
        }

        private void btn_loadPic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Нажмите на изображение, которое вы хотите заменить");
            loadPicMode = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pb_bigPic.Image = pics[curPicId];

            string labelText = null;

            if (curPicId == 0)
                labelText = label41.Text;
            else if (curPicId == 1)
                labelText = label4.Text;
            else if (curPicId == 2)
                labelText = label75.Text;
            else if (curPicId == 3)
                labelText = label63.Text;
            else if (curPicId == 4)
                labelText = label52.Text;

            l_bigPic.Text = labelText;


            curPicId++;
            if (curPicId == 5)
                curPicId = 0;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(medPersId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }
            DB.cmd.CommandText = "UPDATE `Мед персонал` SET " +
                "ФИО = '" + фИОTextBox.Text + "', " +
                "Специальность = '" + tb_spec.Text + "', " +
                "Должность = '" + должностьTextBox.Text + "', " +
                "Телефон = '" + телефонTextBox.Text + "' " +
                "WHERE `№ мед персонала` = " + medPersId;
            DB.c.Open();
            DB.cmd.ExecuteNonQuery();
            DB.c.Close();
            MessageBox.Show("Успешно!");

            RefreshDGV();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (medPersId == -1)
            {
                MessageBox.Show("Сначала выберите запись для редактирования.");
                return;
            }
            DB.cmd.CommandText = " DELETE FROM `Мед персонал` WHERE `№ мед персонала` = " + medPersId;
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

            врачиDataGridView.Refresh();
            врачиDataGridView.DataSource = ds;
            врачиDataGridView.DataMember = tName;
        }
    }
}
