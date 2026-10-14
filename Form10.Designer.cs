namespace PersonelTakipSOP
{
    partial class Form10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxYılSec = new System.Windows.Forms.ComboBox();
            this.comboBoxAySec = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPersonelSec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNetOdenen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEkMesaiUcreti = new System.Windows.Forms.TextBox();
            this.txtKesintiler = new System.Windows.Forms.TextBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMaasBodroTemizle = new System.Windows.Forms.Button();
            this.btnMaasBodroKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bordroIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ekMesaiUcretiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kesintilerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.netOdenenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maasBordroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTakipSistemiOPDataSet2 = new PersonelTakipSOP.PersonelTakipSistemiOPDataSet2();
            this.maasBordroTableAdapter = new PersonelTakipSOP.PersonelTakipSistemiOPDataSet2TableAdapters.MaasBordroTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasBordroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxYılSec);
            this.groupBox1.Controls.Add(this.comboBoxAySec);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxPersonelSec);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel";
            // 
            // comboBoxYılSec
            // 
            this.comboBoxYılSec.FormattingEnabled = true;
            this.comboBoxYılSec.Items.AddRange(new object[] {
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.comboBoxYılSec.Location = new System.Drawing.Point(246, 210);
            this.comboBoxYılSec.Name = "comboBoxYılSec";
            this.comboBoxYılSec.Size = new System.Drawing.Size(140, 33);
            this.comboBoxYılSec.TabIndex = 5;
            // 
            // comboBoxAySec
            // 
            this.comboBoxAySec.FormattingEnabled = true;
            this.comboBoxAySec.Items.AddRange(new object[] {
            "Ocak",
            "Şubat",
            "Mart",
            "Nisan",
            "Mayıs",
            "Haziran",
            "Temmuz",
            "Ağustos",
            "Eylül",
            "Ekim",
            "Kasım",
            "Aralık"});
            this.comboBoxAySec.Location = new System.Drawing.Point(246, 134);
            this.comboBoxAySec.Name = "comboBoxAySec";
            this.comboBoxAySec.Size = new System.Drawing.Size(140, 33);
            this.comboBoxAySec.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(159, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yıl :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(152, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ay : ";
            // 
            // comboBoxPersonelSec
            // 
            this.comboBoxPersonelSec.FormattingEnabled = true;
            this.comboBoxPersonelSec.Location = new System.Drawing.Point(246, 60);
            this.comboBoxPersonelSec.Name = "comboBoxPersonelSec";
            this.comboBoxPersonelSec.Size = new System.Drawing.Size(300, 33);
            this.comboBoxPersonelSec.TabIndex = 1;
            this.comboBoxPersonelSec.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonelSec_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Seç : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtNetOdenen);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtEkMesaiUcreti);
            this.groupBox2.Controls.Add(this.txtKesintiler);
            this.groupBox2.Controls.Add(this.txtMaas);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(581, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 394);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finansal Alan";
            // 
            // txtNetOdenen
            // 
            this.txtNetOdenen.Enabled = false;
            this.txtNetOdenen.Location = new System.Drawing.Point(259, 323);
            this.txtNetOdenen.Name = "txtNetOdenen";
            this.txtNetOdenen.Size = new System.Drawing.Size(153, 30);
            this.txtNetOdenen.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(47, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Net Ödenen : ";
            // 
            // txtEkMesaiUcreti
            // 
            this.txtEkMesaiUcreti.Location = new System.Drawing.Point(259, 178);
            this.txtEkMesaiUcreti.Name = "txtEkMesaiUcreti";
            this.txtEkMesaiUcreti.Size = new System.Drawing.Size(153, 30);
            this.txtEkMesaiUcreti.TabIndex = 11;
            this.txtEkMesaiUcreti.TextChanged += new System.EventHandler(this.txtEkMesaiUcreti_TextChanged);
            // 
            // txtKesintiler
            // 
            this.txtKesintiler.Location = new System.Drawing.Point(259, 122);
            this.txtKesintiler.Name = "txtKesintiler";
            this.txtKesintiler.Size = new System.Drawing.Size(153, 30);
            this.txtKesintiler.TabIndex = 10;
            this.txtKesintiler.TextChanged += new System.EventHandler(this.txtKesintiler_TextChanged);
            // 
            // txtMaas
            // 
            this.txtMaas.Enabled = false;
            this.txtMaas.Location = new System.Drawing.Point(259, 67);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(153, 30);
            this.txtMaas.TabIndex = 9;
            this.txtMaas.TextChanged += new System.EventHandler(this.txtMaas_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ek Mesai Ücreti :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(89, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kesintiler :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(145, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Maaş :";
            // 
            // btnMaasBodroTemizle
            // 
            this.btnMaasBodroTemizle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMaasBodroTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasBodroTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasBodroTemizle.Location = new System.Drawing.Point(1012, 274);
            this.btnMaasBodroTemizle.Name = "btnMaasBodroTemizle";
            this.btnMaasBodroTemizle.Size = new System.Drawing.Size(122, 47);
            this.btnMaasBodroTemizle.TabIndex = 15;
            this.btnMaasBodroTemizle.Text = "Temizle";
            this.btnMaasBodroTemizle.UseVisualStyleBackColor = false;
            this.btnMaasBodroTemizle.Click += new System.EventHandler(this.btnMaasBodroTemizle_Click);
            // 
            // btnMaasBodroKaydet
            // 
            this.btnMaasBodroKaydet.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMaasBodroKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasBodroKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasBodroKaydet.Location = new System.Drawing.Point(1012, 205);
            this.btnMaasBodroKaydet.Name = "btnMaasBodroKaydet";
            this.btnMaasBodroKaydet.Size = new System.Drawing.Size(122, 47);
            this.btnMaasBodroKaydet.TabIndex = 16;
            this.btnMaasBodroKaydet.Text = "Kaydet";
            this.btnMaasBodroKaydet.UseVisualStyleBackColor = false;
            this.btnMaasBodroKaydet.Click += new System.EventHandler(this.btnMaasBodroKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bordroIDDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.ayDataGridViewTextBoxColumn,
            this.yilDataGridViewTextBoxColumn,
            this.ekMesaiUcretiDataGridViewTextBoxColumn,
            this.kesintilerDataGridViewTextBoxColumn,
            this.netOdenenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.maasBordroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 412);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1122, 314);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bordroIDDataGridViewTextBoxColumn
            // 
            this.bordroIDDataGridViewTextBoxColumn.DataPropertyName = "BordroID";
            this.bordroIDDataGridViewTextBoxColumn.HeaderText = "BordroID";
            this.bordroIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bordroIDDataGridViewTextBoxColumn.Name = "bordroIDDataGridViewTextBoxColumn";
            this.bordroIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bordroIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // ayDataGridViewTextBoxColumn
            // 
            this.ayDataGridViewTextBoxColumn.DataPropertyName = "Ay";
            this.ayDataGridViewTextBoxColumn.HeaderText = "Ay";
            this.ayDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ayDataGridViewTextBoxColumn.Name = "ayDataGridViewTextBoxColumn";
            this.ayDataGridViewTextBoxColumn.Width = 150;
            // 
            // yilDataGridViewTextBoxColumn
            // 
            this.yilDataGridViewTextBoxColumn.DataPropertyName = "Yil";
            this.yilDataGridViewTextBoxColumn.HeaderText = "Yil";
            this.yilDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.yilDataGridViewTextBoxColumn.Name = "yilDataGridViewTextBoxColumn";
            this.yilDataGridViewTextBoxColumn.Width = 150;
            // 
            // ekMesaiUcretiDataGridViewTextBoxColumn
            // 
            this.ekMesaiUcretiDataGridViewTextBoxColumn.DataPropertyName = "EkMesaiUcreti";
            this.ekMesaiUcretiDataGridViewTextBoxColumn.HeaderText = "EkMesaiUcreti";
            this.ekMesaiUcretiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ekMesaiUcretiDataGridViewTextBoxColumn.Name = "ekMesaiUcretiDataGridViewTextBoxColumn";
            this.ekMesaiUcretiDataGridViewTextBoxColumn.Width = 150;
            // 
            // kesintilerDataGridViewTextBoxColumn
            // 
            this.kesintilerDataGridViewTextBoxColumn.DataPropertyName = "Kesintiler";
            this.kesintilerDataGridViewTextBoxColumn.HeaderText = "Kesintiler";
            this.kesintilerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.kesintilerDataGridViewTextBoxColumn.Name = "kesintilerDataGridViewTextBoxColumn";
            this.kesintilerDataGridViewTextBoxColumn.Width = 150;
            // 
            // netOdenenDataGridViewTextBoxColumn
            // 
            this.netOdenenDataGridViewTextBoxColumn.DataPropertyName = "NetOdenen";
            this.netOdenenDataGridViewTextBoxColumn.HeaderText = "NetOdenen";
            this.netOdenenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.netOdenenDataGridViewTextBoxColumn.Name = "netOdenenDataGridViewTextBoxColumn";
            this.netOdenenDataGridViewTextBoxColumn.Width = 150;
            // 
            // maasBordroBindingSource
            // 
            this.maasBordroBindingSource.DataMember = "MaasBordro";
            this.maasBordroBindingSource.DataSource = this.personelTakipSistemiOPDataSet2;
            // 
            // personelTakipSistemiOPDataSet2
            // 
            this.personelTakipSistemiOPDataSet2.DataSetName = "PersonelTakipSistemiOPDataSet2";
            this.personelTakipSistemiOPDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // maasBordroTableAdapter
            // 
            this.maasBordroTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1012, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 47);
            this.button1.TabIndex = 18;
            this.button1.Text = "Geri Git";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1012, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 47);
            this.button2.TabIndex = 19;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(1012, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 47);
            this.button3.TabIndex = 20;
            this.button3.Text = "Güncelle";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::PersonelTakipSOP.Properties.Resources.pexels_photo_13164530;
            this.ClientSize = new System.Drawing.Size(1153, 738);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMaasBodroTemizle);
            this.Controls.Add(this.btnMaasBodroKaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maaş/Bordro";
            this.Load += new System.EventHandler(this.Form10_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maasBordroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxYılSec;
        private System.Windows.Forms.ComboBox comboBoxAySec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPersonelSec;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEkMesaiUcreti;
        private System.Windows.Forms.TextBox txtKesintiler;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNetOdenen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMaasBodroTemizle;
        private System.Windows.Forms.Button btnMaasBodroKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelTakipSistemiOPDataSet2 personelTakipSistemiOPDataSet2;
        private System.Windows.Forms.BindingSource maasBordroBindingSource;
        private PersonelTakipSistemiOPDataSet2TableAdapters.MaasBordroTableAdapter maasBordroTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bordroIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ekMesaiUcretiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kesintilerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn netOdenenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}