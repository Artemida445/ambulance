namespace skoraya
{
    partial class CallResultForm
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
            System.Windows.Forms.Label фИОLabel;
            System.Windows.Forms.Label ___врачаLabel;
            System.Windows.Forms.Label код_вызоваLabel;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallResultForm));
            this.cb_docFio = new System.Windows.Forms.ComboBox();
            this.медПерсоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skorayaDBDataSet = new skoraya.skorayaDBDataSet();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.rtb_cure = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_diag = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_napr = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pacientFio = new System.Windows.Forms.ComboBox();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_callId = new System.Windows.Forms.TextBox();
            this.мед_персоналTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.Мед_персоналTableAdapter();
            this.пациентTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.ПациентTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            фИОLabel = new System.Windows.Forms.Label();
            ___врачаLabel = new System.Windows.Forms.Label();
            код_вызоваLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.медПерсоналBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // фИОLabel
            // 
            фИОLabel.AutoSize = true;
            фИОLabel.Location = new System.Drawing.Point(283, 99);
            фИОLabel.Name = "фИОLabel";
            фИОLabel.Size = new System.Drawing.Size(87, 13);
            фИОLabel.TabIndex = 20;
            фИОLabel.Text = "ФИО пациента:";
            // 
            // ___врачаLabel
            // 
            ___врачаLabel.AutoSize = true;
            ___врачаLabel.Location = new System.Drawing.Point(28, 96);
            ___врачаLabel.Name = "___врачаLabel";
            ___врачаLabel.Size = new System.Drawing.Size(69, 13);
            ___врачаLabel.TabIndex = 19;
            ___врачаLabel.Text = "ФИО врача:";
            // 
            // код_вызоваLabel
            // 
            код_вызоваLabel.AutoSize = true;
            код_вызоваLabel.Location = new System.Drawing.Point(186, 68);
            код_вызоваLabel.Name = "код_вызоваLabel";
            код_вызоваLabel.Size = new System.Drawing.Size(70, 13);
            код_вызоваLabel.TabIndex = 17;
            код_вызоваLabel.Text = "Код вызова:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label4.Location = new System.Drawing.Point(166, 15);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(199, 26);
            label4.TabIndex = 66;
            label4.Text = "Результат вызова";
            // 
            // cb_docFio
            // 
            this.cb_docFio.FormattingEnabled = true;
            this.cb_docFio.Location = new System.Drawing.Point(100, 93);
            this.cb_docFio.Name = "cb_docFio";
            this.cb_docFio.Size = new System.Drawing.Size(127, 21);
            this.cb_docFio.TabIndex = 31;
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
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(328, 332);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 23);
            this.btn_print.TabIndex = 30;
            this.btn_print.Text = "Печать";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(189, 332);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 29;
            this.btn_save.Text = "Сохранить ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(20, 332);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 28;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // rtb_cure
            // 
            this.rtb_cure.Location = new System.Drawing.Point(100, 257);
            this.rtb_cure.Name = "rtb_cure";
            this.rtb_cure.Size = new System.Drawing.Size(396, 54);
            this.rtb_cure.TabIndex = 27;
            this.rtb_cure.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Лекарство:";
            // 
            // rtb_diag
            // 
            this.rtb_diag.Location = new System.Drawing.Point(100, 194);
            this.rtb_diag.Name = "rtb_diag";
            this.rtb_diag.Size = new System.Drawing.Size(396, 54);
            this.rtb_diag.TabIndex = 25;
            this.rtb_diag.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Диагноз:";
            // 
            // rtb_napr
            // 
            this.rtb_napr.Location = new System.Drawing.Point(100, 134);
            this.rtb_napr.Name = "rtb_napr";
            this.rtb_napr.Size = new System.Drawing.Size(396, 54);
            this.rtb_napr.TabIndex = 23;
            this.rtb_napr.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Направление:";
            // 
            // cb_pacientFio
            // 
            this.cb_pacientFio.FormattingEnabled = true;
            this.cb_pacientFio.Location = new System.Drawing.Point(376, 97);
            this.cb_pacientFio.Name = "cb_pacientFio";
            this.cb_pacientFio.Size = new System.Drawing.Size(121, 21);
            this.cb_pacientFio.TabIndex = 21;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // tb_callId
            // 
            this.tb_callId.Location = new System.Drawing.Point(262, 65);
            this.tb_callId.Name = "tb_callId";
            this.tb_callId.Size = new System.Drawing.Size(100, 20);
            this.tb_callId.TabIndex = 18;
            // 
            // мед_персоналTableAdapter
            // 
            this.мед_персоналTableAdapter.ClearBeforeFill = true;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
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
            // CallResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 379);
            this.Controls.Add(label4);
            this.Controls.Add(this.cb_docFio);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.rtb_cure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_diag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_napr);
            this.Controls.Add(this.label1);
            this.Controls.Add(фИОLabel);
            this.Controls.Add(this.cb_pacientFio);
            this.Controls.Add(___врачаLabel);
            this.Controls.Add(код_вызоваLabel);
            this.Controls.Add(this.tb_callId);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CallResultForm";
            this.Text = "Результат вызова";
            this.Load += new System.EventHandler(this.CallResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.медПерсоналBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_docFio;
        public System.Windows.Forms.Button btn_print;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_back;
        public System.Windows.Forms.RichTextBox rtb_cure;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.RichTextBox rtb_diag;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.RichTextBox rtb_napr;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cb_pacientFio;
        public System.Windows.Forms.TextBox tb_callId;
        private skorayaDBDataSet skorayaDBDataSet;
        private System.Windows.Forms.BindingSource медПерсоналBindingSource;
        private skorayaDBDataSetTableAdapters.Мед_персоналTableAdapter мед_персоналTableAdapter;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private skorayaDBDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}