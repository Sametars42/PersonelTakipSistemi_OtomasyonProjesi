namespace PersonelTakipSOP
{
    partial class Form9
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ızinIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baslangicTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitisTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ızinTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.onayDurumuDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ızinKayitlariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTakipSistemiOPDataSet3 = new PersonelTakipSOP.PersonelTakipSistemiOPDataSet3();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GunKadarİzinKullanacak = new System.Windows.Forms.Label();
            this.btnİzinGeriGit = new System.Windows.Forms.Button();
            this.btnİzinKaydet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerİzinBitis = new System.Windows.Forms.DateTimePicker();
            this.txtİzinTürü = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxİzneCıkacak = new System.Windows.Forms.ComboBox();
            this.dateTimePickerİzinBaslangic = new System.Windows.Forms.DateTimePicker();
            this.izinKayitlariTableAdapter = new PersonelTakipSOP.PersonelTakipSistemiOPDataSet3TableAdapters.IzinKayitlariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ızinKayitlariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ızinIDDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.baslangicTarihiDataGridViewTextBoxColumn,
            this.bitisTarihiDataGridViewTextBoxColumn,
            this.ızinTuruDataGridViewTextBoxColumn,
            this.onayDurumuDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.ızinKayitlariBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(687, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(649, 798);
            this.dataGridView1.TabIndex = 14;
            // 
            // ızinIDDataGridViewTextBoxColumn
            // 
            this.ızinIDDataGridViewTextBoxColumn.DataPropertyName = "IzinID";
            this.ızinIDDataGridViewTextBoxColumn.HeaderText = "IzinID";
            this.ızinIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ızinIDDataGridViewTextBoxColumn.Name = "ızinIDDataGridViewTextBoxColumn";
            this.ızinIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ızinIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // baslangicTarihiDataGridViewTextBoxColumn
            // 
            this.baslangicTarihiDataGridViewTextBoxColumn.DataPropertyName = "BaslangicTarihi";
            this.baslangicTarihiDataGridViewTextBoxColumn.HeaderText = "BaslangicTarihi";
            this.baslangicTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.baslangicTarihiDataGridViewTextBoxColumn.Name = "baslangicTarihiDataGridViewTextBoxColumn";
            this.baslangicTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // bitisTarihiDataGridViewTextBoxColumn
            // 
            this.bitisTarihiDataGridViewTextBoxColumn.DataPropertyName = "BitisTarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.HeaderText = "BitisTarihi";
            this.bitisTarihiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bitisTarihiDataGridViewTextBoxColumn.Name = "bitisTarihiDataGridViewTextBoxColumn";
            this.bitisTarihiDataGridViewTextBoxColumn.Width = 150;
            // 
            // ızinTuruDataGridViewTextBoxColumn
            // 
            this.ızinTuruDataGridViewTextBoxColumn.DataPropertyName = "IzinTuru";
            this.ızinTuruDataGridViewTextBoxColumn.HeaderText = "IzinTuru";
            this.ızinTuruDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ızinTuruDataGridViewTextBoxColumn.Name = "ızinTuruDataGridViewTextBoxColumn";
            this.ızinTuruDataGridViewTextBoxColumn.Width = 150;
            // 
            // onayDurumuDataGridViewCheckBoxColumn
            // 
            this.onayDurumuDataGridViewCheckBoxColumn.DataPropertyName = "OnayDurumu";
            this.onayDurumuDataGridViewCheckBoxColumn.HeaderText = "OnayDurumu";
            this.onayDurumuDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.onayDurumuDataGridViewCheckBoxColumn.Name = "onayDurumuDataGridViewCheckBoxColumn";
            this.onayDurumuDataGridViewCheckBoxColumn.Width = 150;
            // 
            // ızinKayitlariBindingSource
            // 
            this.ızinKayitlariBindingSource.DataMember = "IzinKayitlari";
            this.ızinKayitlariBindingSource.DataSource = this.personelTakipSistemiOPDataSet3;
            // 
            // personelTakipSistemiOPDataSet3
            // 
            this.personelTakipSistemiOPDataSet3.DataSetName = "PersonelTakipSistemiOPDataSet3";
            this.personelTakipSistemiOPDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(687, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "İzin Talepleri..";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GunKadarİzinKullanacak);
            this.groupBox1.Controls.Add(this.btnİzinGeriGit);
            this.groupBox1.Controls.Add(this.btnİzinKaydet);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePickerİzinBitis);
            this.groupBox1.Controls.Add(this.txtİzinTürü);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboboxİzneCıkacak);
            this.groupBox1.Controls.Add(this.dateTimePickerİzinBaslangic);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 823);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Talep ";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(312, 724);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(154, 72);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(340, 575);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 29);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Onayla";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(25, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Onay Durumu (1/0) : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(322, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(320, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gün kadar İzin Kullanacak ";
            // 
            // GunKadarİzinKullanacak
            // 
            this.GunKadarİzinKullanacak.AutoSize = true;
            this.GunKadarİzinKullanacak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GunKadarİzinKullanacak.ForeColor = System.Drawing.Color.Red;
            this.GunKadarİzinKullanacak.Location = new System.Drawing.Point(283, 342);
            this.GunKadarİzinKullanacak.Name = "GunKadarİzinKullanacak";
            this.GunKadarİzinKullanacak.Size = new System.Drawing.Size(27, 29);
            this.GunKadarİzinKullanacak.TabIndex = 9;
            this.GunKadarİzinKullanacak.Text = "0";
            // 
            // btnİzinGeriGit
            // 
            this.btnİzinGeriGit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnİzinGeriGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİzinGeriGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİzinGeriGit.Location = new System.Drawing.Point(12, 724);
            this.btnİzinGeriGit.Name = "btnİzinGeriGit";
            this.btnİzinGeriGit.Size = new System.Drawing.Size(135, 72);
            this.btnİzinGeriGit.TabIndex = 10;
            this.btnİzinGeriGit.Text = "Geri Git";
            this.btnİzinGeriGit.UseVisualStyleBackColor = false;
            this.btnİzinGeriGit.Click += new System.EventHandler(this.btnİzinGeriGit_Click);
            // 
            // btnİzinKaydet
            // 
            this.btnİzinKaydet.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnİzinKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİzinKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİzinKaydet.Location = new System.Drawing.Point(489, 724);
            this.btnİzinKaydet.Name = "btnİzinKaydet";
            this.btnİzinKaydet.Size = new System.Drawing.Size(154, 72);
            this.btnİzinKaydet.TabIndex = 4;
            this.btnİzinKaydet.Text = "Kaydet";
            this.btnİzinKaydet.UseVisualStyleBackColor = false;
            this.btnİzinKaydet.Click += new System.EventHandler(this.btnİzinKaydet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "izin Türü  : ";
            // 
            // dateTimePickerİzinBitis
            // 
            this.dateTimePickerİzinBitis.Location = new System.Drawing.Point(327, 273);
            this.dateTimePickerİzinBitis.Name = "dateTimePickerİzinBitis";
            this.dateTimePickerİzinBitis.Size = new System.Drawing.Size(316, 30);
            this.dateTimePickerİzinBitis.TabIndex = 6;
            this.dateTimePickerİzinBitis.ValueChanged += new System.EventHandler(this.dateTimePickerİzinBitis_ValueChanged);
            // 
            // txtİzinTürü
            // 
            this.txtİzinTürü.Location = new System.Drawing.Point(184, 401);
            this.txtİzinTürü.Multiline = true;
            this.txtİzinTürü.Name = "txtİzinTürü";
            this.txtİzinTürü.Size = new System.Drawing.Size(477, 119);
            this.txtİzinTürü.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(80, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "İzin Bitiş Tarihi : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "İzin Başlangıç Tarihi : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(101, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "izine Çıkacak : ";
            // 
            // comboboxİzneCıkacak
            // 
            this.comboboxİzneCıkacak.FormattingEnabled = true;
            this.comboboxİzneCıkacak.Location = new System.Drawing.Point(327, 130);
            this.comboboxİzneCıkacak.Name = "comboboxİzneCıkacak";
            this.comboboxİzneCıkacak.Size = new System.Drawing.Size(316, 33);
            this.comboboxİzneCıkacak.TabIndex = 1;
            this.comboboxİzneCıkacak.SelectedIndexChanged += new System.EventHandler(this.comboboxİzneCıkacak_SelectedIndexChanged);
            // 
            // dateTimePickerİzinBaslangic
            // 
            this.dateTimePickerİzinBaslangic.Location = new System.Drawing.Point(327, 200);
            this.dateTimePickerİzinBaslangic.Name = "dateTimePickerİzinBaslangic";
            this.dateTimePickerİzinBaslangic.Size = new System.Drawing.Size(316, 30);
            this.dateTimePickerİzinBaslangic.TabIndex = 0;
            this.dateTimePickerİzinBaslangic.ValueChanged += new System.EventHandler(this.dateTimePickerİzinBaslangic_ValueChanged);
            // 
            // izinKayitlariTableAdapter
            // 
            this.izinKayitlariTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::PersonelTakipSOP.Properties.Resources.pexels_photo_13164530;
            this.ClientSize = new System.Drawing.Size(1336, 823);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Takibi";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ızinKayitlariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label GunKadarİzinKullanacak;
        private System.Windows.Forms.Button btnİzinGeriGit;
        private System.Windows.Forms.Button btnİzinKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerİzinBitis;
        private System.Windows.Forms.TextBox txtİzinTürü;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxİzneCıkacak;
        private System.Windows.Forms.DateTimePicker dateTimePickerİzinBaslangic;
        private PersonelTakipSistemiOPDataSet3 personelTakipSistemiOPDataSet3;
        private System.Windows.Forms.BindingSource ızinKayitlariBindingSource;
        private PersonelTakipSistemiOPDataSet3TableAdapters.IzinKayitlariTableAdapter izinKayitlariTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ızinIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baslangicTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bitisTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ızinTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn onayDurumuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnTemizle;
    }
}