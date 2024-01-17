namespace skoraya
{
    partial class DirPacientForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label постоянный_диагнозLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label дата_рожденияLabel;
            System.Windows.Forms.Label label2;
            this.search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.фИОTextBox = new System.Windows.Forms.TextBox();
            this.постоянный_диагнозTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.дата_рожденияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.пациентDataGridView = new System.Windows.Forms.DataGridView();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skorayaDBDataSet = new skoraya.skorayaDBDataSet();
            this.пациентTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.ПациентTableAdapter();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            постоянный_диагнозLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            дата_рожденияLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(363, 69);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 17);
            label3.TabIndex = 58;
            label3.Text = "Поиск:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(124, 98);
            фИОLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(46, 17);
            фИОLabel.TabIndex = 53;
            фИОLabel.Text = "ФИО:";
            // 
            // постоянный_диагнозLabel
            // 
            постоянный_диагнозLabel.AutoSize = true;
            постоянный_диагнозLabel.Location = new System.Drawing.Point(17, 226);
            постоянный_диагнозLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            постоянный_диагнозLabel.Name = "постоянный_диагнозLabel";
            постоянный_диагнозLabel.Size = new System.Drawing.Size(150, 17);
            постоянный_диагнозLabel.TabIndex = 51;
            постоянный_диагнозLabel.Text = "Постоянный диагноз:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(100, 194);
            телефонLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(72, 17);
            телефонLabel.TabIndex = 49;
            телефонLabel.Text = "Телефон:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(119, 162);
            адресLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(52, 17);
            адресLabel.TabIndex = 47;
            адресLabel.Text = "Адрес:";
            // 
            // дата_рожденияLabel
            // 
            дата_рожденияLabel.AutoSize = true;
            дата_рожденияLabel.Location = new System.Drawing.Point(55, 133);
            дата_рожденияLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            дата_рожденияLabel.Name = "дата_рожденияLabel";
            дата_рожденияLabel.Size = new System.Drawing.Size(115, 17);
            дата_рожденияLabel.TabIndex = 45;
            дата_рожденияLabel.Text = "Дата рождения:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label2.Location = new System.Drawing.Point(13, 22);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(291, 31);
            label2.TabIndex = 65;
            label2.Text = "Справочник пациента";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(440, 66);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(769, 22);
            this.search.TabIndex = 57;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(240, 267);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 28);
            this.btn_add.TabIndex = 56;
            this.btn_add.Text = "Создать";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // фИОTextBox
            // 
            this.фИОTextBox.Location = new System.Drawing.Point(181, 96);
            this.фИОTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.фИОTextBox.Name = "фИОTextBox";
            this.фИОTextBox.Size = new System.Drawing.Size(160, 22);
            this.фИОTextBox.TabIndex = 55;
            // 
            // постоянный_диагнозTextBox
            // 
            this.постоянный_диагнозTextBox.Location = new System.Drawing.Point(181, 224);
            this.постоянный_диагнозTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.постоянный_диагнозTextBox.Name = "постоянный_диагнозTextBox";
            this.постоянный_диагнозTextBox.Size = new System.Drawing.Size(160, 22);
            this.постоянный_диагнозTextBox.TabIndex = 52;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.Location = new System.Drawing.Point(181, 192);
            this.телефонTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(160, 22);
            this.телефонTextBox.TabIndex = 50;
            // 
            // адресTextBox
            // 
            this.адресTextBox.Location = new System.Drawing.Point(181, 160);
            this.адресTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(160, 22);
            this.адресTextBox.TabIndex = 48;
            // 
            // дата_рожденияDateTimePicker
            // 
            this.дата_рожденияDateTimePicker.Location = new System.Drawing.Point(181, 128);
            this.дата_рожденияDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.дата_рожденияDateTimePicker.Name = "дата_рожденияDateTimePicker";
            this.дата_рожденияDateTimePicker.Size = new System.Drawing.Size(160, 22);
            this.дата_рожденияDateTimePicker.TabIndex = 46;
            // 
            // пациентDataGridView
            // 
            this.пациентDataGridView.AllowUserToAddRows = false;
            this.пациентDataGridView.AllowUserToDeleteRows = false;
            this.пациентDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.пациентDataGridView.Location = new System.Drawing.Point(365, 96);
            this.пациентDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.пациентDataGridView.Name = "пациентDataGridView";
            this.пациентDataGridView.ReadOnly = true;
            this.пациентDataGridView.Size = new System.Drawing.Size(845, 272);
            this.пациентDataGridView.TabIndex = 44;
            this.пациентDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.пациентDataGridView_CellClick);
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // skorayaDBDataSet
            // 
            this.skorayaDBDataSet.DataSetName = "skorayaDBDataSet";
            this.skorayaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(240, 322);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 28);
            this.btn_delete.TabIndex = 71;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(20, 267);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 28);
            this.btn_save.TabIndex = 70;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // DirPacientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 388);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОTextBox);
            this.Controls.Add(постоянный_диагнозLabel);
            this.Controls.Add(this.постоянный_диагнозTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(дата_рожденияLabel);
            this.Controls.Add(this.дата_рожденияDateTimePicker);
            this.Controls.Add(this.пациентDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DirPacientForm";
            this.Text = "Справочник пациента";
            this.Load += new System.EventHandler(this.DirPacientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.пациентDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox фИОTextBox;
        private System.Windows.Forms.TextBox постоянный_диагнозTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.DateTimePicker дата_рожденияDateTimePicker;
        private System.Windows.Forms.DataGridView пациентDataGridView;
        private skorayaDBDataSet skorayaDBDataSet;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private skorayaDBDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
    }
}