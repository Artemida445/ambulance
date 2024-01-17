namespace skoraya
{
    partial class DirBrigadaForm
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label фИО_водителяLabel;
            System.Windows.Forms.Label ___водител_удостоверенияLabel;
            System.Windows.Forms.Label ___машиныLabel;
            System.Windows.Forms.Label label1;
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.фИО_водителяTextBox = new System.Windows.Forms.TextBox();
            this.___водител_удостоверенияTextBox = new System.Windows.Forms.TextBox();
            this.___машиныTextBox = new System.Windows.Forms.TextBox();
            this.бригадаDataGridView = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            фИО_водителяLabel = new System.Windows.Forms.Label();
            ___водител_удостоверенияLabel = new System.Windows.Forms.Label();
            ___машиныLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.бригадаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(256, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 13);
            label3.TabIndex = 48;
            label3.Text = "Поиск:";
            // 
            // фИО_водителяLabel
            // 
            фИО_водителяLabel.AutoSize = true;
            фИО_водителяLabel.Location = new System.Drawing.Point(10, 180);
            фИО_водителяLabel.Name = "фИО_водителяLabel";
            фИО_водителяLabel.Size = new System.Drawing.Size(87, 13);
            фИО_водителяLabel.TabIndex = 43;
            фИО_водителяLabel.Text = "ФИО водителя:";
            // 
            // ___водител_удостоверенияLabel
            // 
            ___водител_удостоверенияLabel.AutoSize = true;
            ___водител_удостоверенияLabel.Location = new System.Drawing.Point(10, 141);
            ___водител_удостоверенияLabel.Name = "___водител_удостоверенияLabel";
            ___водител_удостоверенияLabel.Size = new System.Drawing.Size(144, 13);
            ___водител_удостоверенияLabel.TabIndex = 41;
            ___водител_удостоверенияLabel.Text = "№ водител удостоверения:";
            // 
            // ___машиныLabel
            // 
            ___машиныLabel.AutoSize = true;
            ___машиныLabel.Location = new System.Drawing.Point(10, 98);
            ___машиныLabel.Name = "___машиныLabel";
            ___машиныLabel.Size = new System.Drawing.Size(66, 13);
            ___машиныLabel.TabIndex = 39;
            ___машиныLabel.Text = "№ машины:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            label1.Location = new System.Drawing.Point(29, 26);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(227, 26);
            label1.TabIndex = 63;
            label1.Text = "Справочник бригады";
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(302, 72);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(398, 20);
            this.tb_search.TabIndex = 47;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(148, 210);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 46;
            this.btn_add.Text = "Создать";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // фИО_водителяTextBox
            // 
            this.фИО_водителяTextBox.Location = new System.Drawing.Point(100, 177);
            this.фИО_водителяTextBox.Name = "фИО_водителяTextBox";
            this.фИО_водителяTextBox.Size = new System.Drawing.Size(125, 20);
            this.фИО_водителяTextBox.TabIndex = 44;
            // 
            // ___водител_удостоверенияTextBox
            // 
            this.___водител_удостоверенияTextBox.Location = new System.Drawing.Point(157, 141);
            this.___водител_удостоверенияTextBox.Name = "___водител_удостоверенияTextBox";
            this.___водител_удостоверенияTextBox.Size = new System.Drawing.Size(68, 20);
            this.___водител_удостоверенияTextBox.TabIndex = 42;
            // 
            // ___машиныTextBox
            // 
            this.___машиныTextBox.Location = new System.Drawing.Point(157, 96);
            this.___машиныTextBox.Name = "___машиныTextBox";
            this.___машиныTextBox.Size = new System.Drawing.Size(68, 20);
            this.___машиныTextBox.TabIndex = 40;
            // 
            // бригадаDataGridView
            // 
            this.бригадаDataGridView.AllowUserToAddRows = false;
            this.бригадаDataGridView.AllowUserToDeleteRows = false;
            this.бригадаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.бригадаDataGridView.Location = new System.Drawing.Point(258, 96);
            this.бригадаDataGridView.Name = "бригадаDataGridView";
            this.бригадаDataGridView.ReadOnly = true;
            this.бригадаDataGridView.Size = new System.Drawing.Size(441, 210);
            this.бригадаDataGridView.TabIndex = 38;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 210);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 68;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(148, 257);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 23);
            this.btn_delete.TabIndex = 69;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // DirBrigadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 318);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(label1);
            this.Controls.Add(label3);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(фИО_водителяLabel);
            this.Controls.Add(this.фИО_водителяTextBox);
            this.Controls.Add(___водител_удостоверенияLabel);
            this.Controls.Add(this.___водител_удостоверенияTextBox);
            this.Controls.Add(___машиныLabel);
            this.Controls.Add(this.___машиныTextBox);
            this.Controls.Add(this.бригадаDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DirBrigadaForm";
            this.Text = "Справочник бригады";
            this.Load += new System.EventHandler(this.DirBrigadaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.бригадаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox фИО_водителяTextBox;
        private System.Windows.Forms.TextBox ___водител_удостоверенияTextBox;
        private System.Windows.Forms.TextBox ___машиныTextBox;
        private System.Windows.Forms.DataGridView бригадаDataGridView;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
    }
}