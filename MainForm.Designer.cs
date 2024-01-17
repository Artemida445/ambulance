namespace skoraya
{
    partial class MainForm
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label ___бригадыLabel;
            System.Windows.Forms.Label ___врачаLabel;
            System.Windows.Forms.Label постоянный_диагнозLabel;
            System.Windows.Forms.Label телефонLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label дата_обращенияLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ПН-СБ круглосуточно");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ВС 9:00-23:00");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("График работы", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tb_callCode = new System.Windows.Forms.TextBox();
            this.tb_mlMPers = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.Нврача = new System.Windows.Forms.ComboBox();
            this.медПерсоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skorayaDBDataSet = new skoraya.skorayaDBDataSet();
            this.Нбригады = new System.Windows.Forms.ComboBox();
            this.бригадаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.вызовыDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выгрузитьВCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзCsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_addPacient = new System.Windows.Forms.Button();
            this.btn_createCall = new System.Windows.Forms.Button();
            this.постоянный_диагнозTextBox = new System.Windows.Forms.TextBox();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.фИОComboBox = new System.Windows.Forms.ComboBox();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дата_обращенияDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьВызовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВызовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатВызовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникБригадыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникВрачейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникПациентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеПрофиляToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTime = new System.Windows.Forms.ToolStripMenuItem();
            this.вызовыTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.ВызовыTableAdapter();
            this.пациентTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.ПациентTableAdapter();
            this.бригадаTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.БригадаTableAdapter();
            this.мед_персоналTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.Мед_персоналTableAdapter();
            this.timeUpdate = new System.Windows.Forms.Timer(this.components);
            this.eventTime = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_filter = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.btn_delete = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ___бригадыLabel = new System.Windows.Forms.Label();
            ___врачаLabel = new System.Windows.Forms.Label();
            постоянный_диагнозLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            фИОLabel = new System.Windows.Forms.Label();
            дата_обращенияLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медПерсоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригадаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовыDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.вызовыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(22, 80);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 13);
            label4.TabIndex = 65;
            label4.Text = "Код вызова:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(8, 261);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 13);
            label2.TabIndex = 63;
            label2.Text = "Мл. мед. персонал:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label1.Location = new System.Drawing.Point(101, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(78, 26);
            label1.TabIndex = 62;
            label1.Text = "Вызов";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(320, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 13);
            label3.TabIndex = 61;
            label3.Text = "Поиск:";
            // 
            // ___бригадыLabel
            // 
            ___бригадыLabel.AutoSize = true;
            ___бригадыLabel.Location = new System.Drawing.Point(8, 285);
            ___бригадыLabel.Name = "___бригадыLabel";
            ___бригадыLabel.Size = new System.Drawing.Size(67, 13);
            ___бригадыLabel.TabIndex = 53;
            ___бригадыLabel.Text = "№ бригады:";
            // 
            // ___врачаLabel
            // 
            ___врачаLabel.AutoSize = true;
            ___врачаLabel.Location = new System.Drawing.Point(142, 283);
            ___врачаLabel.Name = "___врачаLabel";
            ___врачаLabel.Size = new System.Drawing.Size(53, 13);
            ___врачаLabel.TabIndex = 52;
            ___врачаLabel.Text = "№ врача:";
            // 
            // постоянный_диагнозLabel
            // 
            постоянный_диагнозLabel.AutoSize = true;
            постоянный_диагнозLabel.Location = new System.Drawing.Point(2, 210);
            постоянный_диагнозLabel.Name = "постоянный_диагнозLabel";
            постоянный_диагнозLabel.Size = new System.Drawing.Size(117, 13);
            постоянный_диагнозLabel.TabIndex = 49;
            постоянный_диагнозLabel.Text = "Постоянный диагноз:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Location = new System.Drawing.Point(64, 184);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(55, 13);
            телефонLabel.TabIndex = 47;
            телефонLabel.Text = "Телефон:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(78, 158);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(41, 13);
            адресLabel.TabIndex = 45;
            адресLabel.Text = "Адрес:";
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(32, 131);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(87, 13);
            фИОLabel.TabIndex = 43;
            фИОLabel.Text = "ФИО пациента:";
            // 
            // дата_обращенияLabel
            // 
            дата_обращенияLabel.AutoSize = true;
            дата_обращенияLabel.Location = new System.Drawing.Point(22, 106);
            дата_обращенияLabel.Name = "дата_обращенияLabel";
            дата_обращенияLabel.Size = new System.Drawing.Size(96, 13);
            дата_обращенияLabel.TabIndex = 41;
            дата_обращенияLabel.Text = "Дата обращения:";
            // 
            // tb_callCode
            // 
            this.tb_callCode.Location = new System.Drawing.Point(94, 77);
            this.tb_callCode.Name = "tb_callCode";
            this.tb_callCode.Size = new System.Drawing.Size(53, 20);
            this.tb_callCode.TabIndex = 66;
            // 
            // tb_mlMPers
            // 
            this.tb_mlMPers.Location = new System.Drawing.Point(124, 258);
            this.tb_mlMPers.Name = "tb_mlMPers";
            this.tb_mlMPers.Size = new System.Drawing.Size(139, 20);
            this.tb_mlMPers.TabIndex = 64;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(364, 47);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(599, 20);
            this.search.TabIndex = 60;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(10, 348);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(121, 23);
            this.btn_save.TabIndex = 59;
            this.btn_save.Tag = "root";
            this.btn_save.Text = "Сохранить вызов ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Нврача
            // 
            this.Нврача.DataSource = this.медПерсоналBindingSource;
            this.Нврача.DisplayMember = "№ мед персонала";
            this.Нврача.FormattingEnabled = true;
            this.Нврача.Location = new System.Drawing.Point(207, 283);
            this.Нврача.Name = "Нврача";
            this.Нврача.Size = new System.Drawing.Size(56, 21);
            this.Нврача.TabIndex = 58;
            // 
            // медПерсоналBindingSource
            // 
            this.медПерсоналBindingSource.DataMember = "Мед персонал";
            this.медПерсоналBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // skorayaDBDataSet
            // 
            this.skorayaDBDataSet.DataSetName = "skorayaDBDataSet";
            this.skorayaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Нбригады
            // 
            this.Нбригады.DataSource = this.бригадаBindingSource;
            this.Нбригады.DisplayMember = "№ бригады";
            this.Нбригады.FormattingEnabled = true;
            this.Нбригады.Location = new System.Drawing.Point(76, 283);
            this.Нбригады.Name = "Нбригады";
            this.Нбригады.Size = new System.Drawing.Size(56, 21);
            this.Нбригады.TabIndex = 57;
            // 
            // бригадаBindingSource
            // 
            this.бригадаBindingSource.DataMember = "Бригада";
            this.бригадаBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // вызовыDataGridView
            // 
            this.вызовыDataGridView.AllowUserToAddRows = false;
            this.вызовыDataGridView.AllowUserToDeleteRows = false;
            this.вызовыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.вызовыDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.вызовыDataGridView.Location = new System.Drawing.Point(322, 74);
            this.вызовыDataGridView.Name = "вызовыDataGridView";
            this.вызовыDataGridView.ReadOnly = true;
            this.вызовыDataGridView.Size = new System.Drawing.Size(642, 329);
            this.вызовыDataGridView.TabIndex = 55;
            this.вызовыDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.вызовыDataGridView_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выгрузитьВCsvToolStripMenuItem,
            this.загрузитьИзCsvToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // выгрузитьВCsvToolStripMenuItem
            // 
            this.выгрузитьВCsvToolStripMenuItem.Name = "выгрузитьВCsvToolStripMenuItem";
            this.выгрузитьВCsvToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выгрузитьВCsvToolStripMenuItem.Text = "Выгрузить в csv...";
            this.выгрузитьВCsvToolStripMenuItem.Click += new System.EventHandler(this.выгрузитьВCsvToolStripMenuItem_Click);
            // 
            // загрузитьИзCsvToolStripMenuItem
            // 
            this.загрузитьИзCsvToolStripMenuItem.Name = "загрузитьИзCsvToolStripMenuItem";
            this.загрузитьИзCsvToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.загрузитьИзCsvToolStripMenuItem.Text = "Загрузить из csv...";
            this.загрузитьИзCsvToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзCsvToolStripMenuItem_Click);
            // 
            // вызовыBindingSource
            // 
            this.вызовыBindingSource.DataMember = "Вызовы";
            this.вызовыBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // btn_addPacient
            // 
            this.btn_addPacient.Location = new System.Drawing.Point(268, 128);
            this.btn_addPacient.Name = "btn_addPacient";
            this.btn_addPacient.Size = new System.Drawing.Size(31, 21);
            this.btn_addPacient.TabIndex = 56;
            this.btn_addPacient.Tag = "root";
            this.btn_addPacient.Text = "...";
            this.btn_addPacient.UseVisualStyleBackColor = true;
            this.btn_addPacient.Click += new System.EventHandler(this.btn_addPacient_Click);
            // 
            // btn_createCall
            // 
            this.btn_createCall.Location = new System.Drawing.Point(142, 348);
            this.btn_createCall.Name = "btn_createCall";
            this.btn_createCall.Size = new System.Drawing.Size(121, 23);
            this.btn_createCall.TabIndex = 54;
            this.btn_createCall.Tag = "root";
            this.btn_createCall.Text = "Создать вызов ";
            this.btn_createCall.UseVisualStyleBackColor = true;
            this.btn_createCall.Click += new System.EventHandler(this.btn_createCall_Click);
            // 
            // постоянный_диагнозTextBox
            // 
            this.постоянный_диагнозTextBox.Location = new System.Drawing.Point(124, 206);
            this.постоянный_диагнозTextBox.Name = "постоянный_диагнозTextBox";
            this.постоянный_диагнозTextBox.Size = new System.Drawing.Size(139, 20);
            this.постоянный_диагнозTextBox.TabIndex = 50;
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.Location = new System.Drawing.Point(124, 180);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(139, 20);
            this.телефонTextBox.TabIndex = 48;
            // 
            // адресTextBox
            // 
            this.адресTextBox.Location = new System.Drawing.Point(124, 154);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(139, 20);
            this.адресTextBox.TabIndex = 46;
            // 
            // фИОComboBox
            // 
            this.фИОComboBox.DataSource = this.пациентBindingSource;
            this.фИОComboBox.DisplayMember = "ФИО пациента";
            this.фИОComboBox.FormattingEnabled = true;
            this.фИОComboBox.Location = new System.Drawing.Point(124, 128);
            this.фИОComboBox.Name = "фИОComboBox";
            this.фИОComboBox.Size = new System.Drawing.Size(139, 21);
            this.фИОComboBox.TabIndex = 44;
            this.фИОComboBox.SelectedIndexChanged += new System.EventHandler(this.фИОComboBox_SelectedIndexChanged);
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // дата_обращенияDateTimePicker
            // 
            this.дата_обращенияDateTimePicker.Location = new System.Drawing.Point(124, 102);
            this.дата_обращенияDateTimePicker.Name = "дата_обращенияDateTimePicker";
            this.дата_обращенияDateTimePicker.Size = new System.Drawing.Size(139, 20);
            this.дата_обращенияDateTimePicker.TabIndex = 42;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.currentTime});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1178, 24);
            this.menuStrip1.TabIndex = 51;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьВызовToolStripMenuItem,
            this.сохранитьВызовToolStripMenuItem,
            this.результатВызовToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.операцииToolStripMenuItem.Tag = "root";
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // создатьВызовToolStripMenuItem
            // 
            this.создатьВызовToolStripMenuItem.Name = "создатьВызовToolStripMenuItem";
            this.создатьВызовToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.создатьВызовToolStripMenuItem.Text = "Создать вызов";
            this.создатьВызовToolStripMenuItem.Click += new System.EventHandler(this.создатьВызовToolStripMenuItem_Click);
            // 
            // сохранитьВызовToolStripMenuItem
            // 
            this.сохранитьВызовToolStripMenuItem.Name = "сохранитьВызовToolStripMenuItem";
            this.сохранитьВызовToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.сохранитьВызовToolStripMenuItem.Text = "Сохранить вызов";
            this.сохранитьВызовToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВызовToolStripMenuItem_Click);
            // 
            // результатВызовToolStripMenuItem
            // 
            this.результатВызовToolStripMenuItem.Name = "результатВызовToolStripMenuItem";
            this.результатВызовToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.результатВызовToolStripMenuItem.Text = "Результат вызов";
            this.результатВызовToolStripMenuItem.Click += new System.EventHandler(this.результатВызовToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникБригадыToolStripMenuItem,
            this.справочникВрачейToolStripMenuItem,
            this.справочникПациентаToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // справочникБригадыToolStripMenuItem
            // 
            this.справочникБригадыToolStripMenuItem.Name = "справочникБригадыToolStripMenuItem";
            this.справочникБригадыToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.справочникБригадыToolStripMenuItem.Text = "Справочник бригады";
            this.справочникБригадыToolStripMenuItem.Click += new System.EventHandler(this.справочникБригадыToolStripMenuItem_Click);
            // 
            // справочникВрачейToolStripMenuItem
            // 
            this.справочникВрачейToolStripMenuItem.Name = "справочникВрачейToolStripMenuItem";
            this.справочникВрачейToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.справочникВрачейToolStripMenuItem.Text = "Справочник врачей";
            this.справочникВрачейToolStripMenuItem.Click += new System.EventHandler(this.справочникВрачейToolStripMenuItem_Click);
            // 
            // справочникПациентаToolStripMenuItem
            // 
            this.справочникПациентаToolStripMenuItem.Name = "справочникПациентаToolStripMenuItem";
            this.справочникПациентаToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.справочникПациентаToolStripMenuItem.Text = "Справочник пациента ";
            this.справочникПациентаToolStripMenuItem.Click += new System.EventHandler(this.справочникПациентаToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.редактированиеПрофиляToolStripMenuItem,
            this.картаToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // редактированиеПрофиляToolStripMenuItem
            // 
            this.редактированиеПрофиляToolStripMenuItem.Name = "редактированиеПрофиляToolStripMenuItem";
            this.редактированиеПрофиляToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.редактированиеПрофиляToolStripMenuItem.Text = "Редактирование профиля";
            this.редактированиеПрофиляToolStripMenuItem.Click += new System.EventHandler(this.редактированиеПрофиляToolStripMenuItem_Click);
            // 
            // картаToolStripMenuItem
            // 
            this.картаToolStripMenuItem.Name = "картаToolStripMenuItem";
            this.картаToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.картаToolStripMenuItem.Text = "Карта филиалов";
            this.картаToolStripMenuItem.Click += new System.EventHandler(this.картаToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.выходToolStripMenuItem.Text = "Выход ";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // currentTime
            // 
            this.currentTime.Margin = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(46, 20);
            this.currentTime.Text = "00:00";
            // 
            // вызовыTableAdapter
            // 
            this.вызовыTableAdapter.ClearBeforeFill = true;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // бригадаTableAdapter
            // 
            this.бригадаTableAdapter.ClearBeforeFill = true;
            // 
            // мед_персоналTableAdapter
            // 
            this.мед_персоналTableAdapter.ClearBeforeFill = true;
            // 
            // timeUpdate
            // 
            this.timeUpdate.Tick += new System.EventHandler(this.timeUpdate_Tick);
            // 
            // eventTime
            // 
            this.eventTime.AutoSize = true;
            this.eventTime.Location = new System.Drawing.Point(721, 4);
            this.eventTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventTime.Name = "eventTime";
            this.eventTime.Size = new System.Drawing.Size(353, 13);
            this.eventTime.TabIndex = 67;
            this.eventTime.Text = "До поступления нового транспорта осталось: 1 день 5 ч. 12 м. 20 с.";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Menu;
            this.treeView1.Location = new System.Drawing.Point(969, 75);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел1";
            treeNode1.Text = "ПН-СБ круглосуточно";
            treeNode2.Name = "Узел2";
            treeNode2.Text = "ВС 9:00-23:00";
            treeNode3.Name = "Узел0";
            treeNode3.Text = "График работы";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(168, 272);
            this.treeView1.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(969, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 69;
            this.label5.Text = " Количество строк: ";
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(969, 48);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(167, 22);
            this.btn_filter.TabIndex = 70;
            this.btn_filter.Tag = "root";
            this.btn_filter.Text = "Фильтрация ";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // printPreviewDialog2
            // 
            this.printPreviewDialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog2.Document = this.printDocument2;
            this.printPreviewDialog2.Enabled = true;
            this.printPreviewDialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog2.Icon")));
            this.printPreviewDialog2.Name = "printPreviewDialog2";
            this.printPreviewDialog2.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(186, 380);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 23);
            this.btn_delete.TabIndex = 71;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 438);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.eventTime);
            this.Controls.Add(label4);
            this.Controls.Add(this.tb_callCode);
            this.Controls.Add(label2);
            this.Controls.Add(this.tb_mlMPers);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(this.search);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Нврача);
            this.Controls.Add(this.Нбригады);
            this.Controls.Add(this.вызовыDataGridView);
            this.Controls.Add(this.btn_addPacient);
            this.Controls.Add(this.btn_createCall);
            this.Controls.Add(___бригадыLabel);
            this.Controls.Add(___врачаLabel);
            this.Controls.Add(постоянный_диагнозLabel);
            this.Controls.Add(this.постоянный_диагнозTextBox);
            this.Controls.Add(телефонLabel);
            this.Controls.Add(this.телефонTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.фИОComboBox);
            this.Controls.Add(дата_обращенияLabel);
            this.Controls.Add(this.дата_обращенияDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Оформление вызова";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медПерсоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.бригадаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вызовыDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.вызовыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_callCode;
        private System.Windows.Forms.TextBox tb_mlMPers;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox Нврача;
        private System.Windows.Forms.ComboBox Нбригады;
        private System.Windows.Forms.DataGridView вызовыDataGridView;
        private System.Windows.Forms.Button btn_addPacient;
        private System.Windows.Forms.Button btn_createCall;
        private System.Windows.Forms.TextBox постоянный_диагнозTextBox;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.ComboBox фИОComboBox;
        private System.Windows.Forms.DateTimePicker дата_обращенияDateTimePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьВызовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВызовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатВызовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникБригадыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникВрачейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникПациентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentTime;
        private skorayaDBDataSet skorayaDBDataSet;
        private System.Windows.Forms.BindingSource вызовыBindingSource;
        private skorayaDBDataSetTableAdapters.ВызовыTableAdapter вызовыTableAdapter;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private skorayaDBDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Windows.Forms.BindingSource бригадаBindingSource;
        private skorayaDBDataSetTableAdapters.БригадаTableAdapter бригадаTableAdapter;
        private System.Windows.Forms.BindingSource медПерсоналBindingSource;
        private skorayaDBDataSetTableAdapters.Мед_персоналTableAdapter мед_персоналTableAdapter;
        private System.Windows.Forms.Timer timeUpdate;
        private System.Windows.Forms.Label eventTime;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выгрузитьВCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзCsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеПрофиляToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem картаToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_filter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog2;
        private System.Windows.Forms.Button btn_delete;
    }
}