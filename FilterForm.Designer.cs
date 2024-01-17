namespace skoraya
{
    partial class FilterForm
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
            this.btn_apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_brigada = new System.Windows.Forms.ComboBox();
            this.бригадаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.skorayaDBDataSet = new skoraya.skorayaDBDataSet();
            this.cb_paicent = new System.Windows.Forms.ComboBox();
            this.пациентBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cb_medPers = new System.Windows.Forms.ComboBox();
            this.медПерсоналBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.бригадаTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.БригадаTableAdapter();
            this.пациентTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.ПациентTableAdapter();
            this.мед_персоналTableAdapter = new skoraya.skorayaDBDataSetTableAdapters.Мед_персоналTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.бригадаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.медПерсоналBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(173, 227);
            this.btn_apply.Margin = new System.Windows.Forms.Padding(2);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(74, 19);
            this.btn_apply.TabIndex = 0;
            this.btn_apply.Text = "Применить";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(41, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фильтрация";
            // 
            // cb_brigada
            // 
            this.cb_brigada.FormattingEnabled = true;
            this.cb_brigada.Location = new System.Drawing.Point(46, 71);
            this.cb_brigada.Margin = new System.Windows.Forms.Padding(2);
            this.cb_brigada.Name = "cb_brigada";
            this.cb_brigada.Size = new System.Drawing.Size(156, 21);
            this.cb_brigada.TabIndex = 2;
            // 
            // бригадаBindingSource
            // 
            this.бригадаBindingSource.DataMember = "Бригада";
            this.бригадаBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // skorayaDBDataSet
            // 
            this.skorayaDBDataSet.DataSetName = "skorayaDBDataSet";
            this.skorayaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_paicent
            // 
            this.cb_paicent.FormattingEnabled = true;
            this.cb_paicent.Location = new System.Drawing.Point(46, 115);
            this.cb_paicent.Margin = new System.Windows.Forms.Padding(2);
            this.cb_paicent.Name = "cb_paicent";
            this.cb_paicent.Size = new System.Drawing.Size(156, 21);
            this.cb_paicent.TabIndex = 3;
            // 
            // пациентBindingSource
            // 
            this.пациентBindingSource.DataMember = "Пациент";
            this.пациентBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // cb_medPers
            // 
            this.cb_medPers.FormattingEnabled = true;
            this.cb_medPers.Location = new System.Drawing.Point(46, 164);
            this.cb_medPers.Margin = new System.Windows.Forms.Padding(2);
            this.cb_medPers.Name = "cb_medPers";
            this.cb_medPers.Size = new System.Drawing.Size(156, 21);
            this.cb_medPers.TabIndex = 4;
            // 
            // медПерсоналBindingSource
            // 
            this.медПерсоналBindingSource.DataMember = "Мед персонал";
            this.медПерсоналBindingSource.DataSource = this.skorayaDBDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "№ пациента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "№ мед персонала";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "№ бригады";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(9, 227);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(74, 19);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Сброс";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // бригадаTableAdapter
            // 
            this.бригадаTableAdapter.ClearBeforeFill = true;
            // 
            // пациентTableAdapter
            // 
            this.пациентTableAdapter.ClearBeforeFill = true;
            // 
            // мед_персоналTableAdapter
            // 
            this.мед_персоналTableAdapter.ClearBeforeFill = true;
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 255);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_medPers);
            this.Controls.Add(this.cb_paicent);
            this.Controls.Add(this.cb_brigada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_apply);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FilterForm";
            this.Text = "Фильтрация";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бригадаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skorayaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пациентBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.медПерсоналBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_brigada;
        private System.Windows.Forms.ComboBox cb_paicent;
        private System.Windows.Forms.ComboBox cb_medPers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_reset;
        private skorayaDBDataSet skorayaDBDataSet;
        private System.Windows.Forms.BindingSource бригадаBindingSource;
        private skorayaDBDataSetTableAdapters.БригадаTableAdapter бригадаTableAdapter;
        private System.Windows.Forms.BindingSource пациентBindingSource;
        private skorayaDBDataSetTableAdapters.ПациентTableAdapter пациентTableAdapter;
        private System.Windows.Forms.BindingSource медПерсоналBindingSource;
        private skorayaDBDataSetTableAdapters.Мед_персоналTableAdapter мед_персоналTableAdapter;
    }
}