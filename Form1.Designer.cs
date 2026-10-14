namespace PersonelTakipSOP
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPersonelislemler = new System.Windows.Forms.Button();
            this.btnDepartmanYon = new System.Windows.Forms.Button();
            this.btnİzintkp = new System.Windows.Forms.Button();
            this.btnMaasBodro = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGCık = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.İzniYaklasanPersoneller = new System.Windows.Forms.Label();
            this.ToplamPersonelSayisi = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personellerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTakipSistemiOPDataSet = new PersonelTakipSOP.PersonelTakipSistemiOPDataSet();
            this.personellerTableAdapter = new PersonelTakipSOP.PersonelTakipSistemiOPDataSetTableAdapters.PersonellerTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPersonelislemler
            // 
            this.btnPersonelislemler.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPersonelislemler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonelislemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonelislemler.Location = new System.Drawing.Point(7, 39);
            this.btnPersonelislemler.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPersonelislemler.Name = "btnPersonelislemler";
            this.btnPersonelislemler.Size = new System.Drawing.Size(369, 69);
            this.btnPersonelislemler.TabIndex = 0;
            this.btnPersonelislemler.Text = "Personel İşlemleri";
            this.btnPersonelislemler.UseVisualStyleBackColor = false;
            this.btnPersonelislemler.Click += new System.EventHandler(this.btnPersonelislemler_Click);
            // 
            // btnDepartmanYon
            // 
            this.btnDepartmanYon.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDepartmanYon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanYon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanYon.Location = new System.Drawing.Point(7, 115);
            this.btnDepartmanYon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDepartmanYon.Name = "btnDepartmanYon";
            this.btnDepartmanYon.Size = new System.Drawing.Size(369, 69);
            this.btnDepartmanYon.TabIndex = 1;
            this.btnDepartmanYon.Text = "Departman Yönetimi";
            this.btnDepartmanYon.UseVisualStyleBackColor = false;
            this.btnDepartmanYon.Click += new System.EventHandler(this.btnDepartmanYon_Click);
            // 
            // btnİzintkp
            // 
            this.btnİzintkp.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnİzintkp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİzintkp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİzintkp.Location = new System.Drawing.Point(7, 191);
            this.btnİzintkp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnİzintkp.Name = "btnİzintkp";
            this.btnİzintkp.Size = new System.Drawing.Size(369, 69);
            this.btnİzintkp.TabIndex = 2;
            this.btnİzintkp.Text = "İzin Takibi";
            this.btnİzintkp.UseVisualStyleBackColor = false;
            this.btnİzintkp.Click += new System.EventHandler(this.btnİzintkp_Click);
            // 
            // btnMaasBodro
            // 
            this.btnMaasBodro.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnMaasBodro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaasBodro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMaasBodro.Location = new System.Drawing.Point(7, 267);
            this.btnMaasBodro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMaasBodro.Name = "btnMaasBodro";
            this.btnMaasBodro.Size = new System.Drawing.Size(369, 69);
            this.btnMaasBodro.TabIndex = 3;
            this.btnMaasBodro.Text = "Maaş/Bordro";
            this.btnMaasBodro.UseVisualStyleBackColor = false;
            this.btnMaasBodro.Click += new System.EventHandler(this.btnMaasBodro_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnGCık);
            this.groupBox1.Controls.Add(this.btnPersonelislemler);
            this.groupBox1.Controls.Add(this.btnMaasBodro);
            this.groupBox1.Controls.Add(this.btnDepartmanYon);
            this.groupBox1.Controls.Add(this.btnİzintkp);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 761);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // btnGCık
            // 
            this.btnGCık.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGCık.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGCık.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGCık.Location = new System.Drawing.Point(7, 686);
            this.btnGCık.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGCık.Name = "btnGCık";
            this.btnGCık.Size = new System.Drawing.Size(369, 69);
            this.btnGCık.TabIndex = 5;
            this.btnGCık.Text = "Güvenli Çıkış";
            this.btnGCık.UseVisualStyleBackColor = false;
            this.btnGCık.Click += new System.EventHandler(this.btnGCık_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.İzniYaklasanPersoneller);
            this.groupBox2.Controls.Add(this.ToplamPersonelSayisi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(385, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(873, 254);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(467, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "İzni Yaklaşan Personeller";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(102, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Toplam Personel Sayısı";
            // 
            // İzniYaklasanPersoneller
            // 
            this.İzniYaklasanPersoneller.AutoSize = true;
            this.İzniYaklasanPersoneller.BackColor = System.Drawing.Color.Transparent;
            this.İzniYaklasanPersoneller.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.İzniYaklasanPersoneller.ForeColor = System.Drawing.Color.Red;
            this.İzniYaklasanPersoneller.Location = new System.Drawing.Point(605, 143);
            this.İzniYaklasanPersoneller.Name = "İzniYaklasanPersoneller";
            this.İzniYaklasanPersoneller.Size = new System.Drawing.Size(55, 59);
            this.İzniYaklasanPersoneller.TabIndex = 1;
            this.İzniYaklasanPersoneller.Text = "0";
            // 
            // ToplamPersonelSayisi
            // 
            this.ToplamPersonelSayisi.AutoSize = true;
            this.ToplamPersonelSayisi.BackColor = System.Drawing.Color.Transparent;
            this.ToplamPersonelSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ToplamPersonelSayisi.ForeColor = System.Drawing.Color.Red;
            this.ToplamPersonelSayisi.Location = new System.Drawing.Point(218, 143);
            this.ToplamPersonelSayisi.Name = "ToplamPersonelSayisi";
            this.ToplamPersonelSayisi.Size = new System.Drawing.Size(55, 59);
            this.ToplamPersonelSayisi.TabIndex = 0;
            this.ToplamPersonelSayisi.Text = "0";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(385, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(873, 507);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personelIDDataGridViewTextBoxColumn,
            this.tCDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.epostaDataGridViewTextBoxColumn,
            this.departmanIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personellerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(869, 416);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.personelIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // tCDataGridViewTextBoxColumn
            // 
            this.tCDataGridViewTextBoxColumn.DataPropertyName = "TC";
            this.tCDataGridViewTextBoxColumn.HeaderText = "TC";
            this.tCDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tCDataGridViewTextBoxColumn.Name = "tCDataGridViewTextBoxColumn";
            this.tCDataGridViewTextBoxColumn.Width = 150;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 150;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 150;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 150;
            // 
            // epostaDataGridViewTextBoxColumn
            // 
            this.epostaDataGridViewTextBoxColumn.DataPropertyName = "Eposta";
            this.epostaDataGridViewTextBoxColumn.HeaderText = "Eposta";
            this.epostaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.epostaDataGridViewTextBoxColumn.Name = "epostaDataGridViewTextBoxColumn";
            this.epostaDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            this.departmanIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // personellerBindingSource
            // 
            this.personellerBindingSource.DataMember = "Personeller";
            this.personellerBindingSource.DataSource = this.personelTakipSistemiOPDataSet;
            // 
            // personelTakipSistemiOPDataSet
            // 
            this.personelTakipSistemiOPDataSet.DataSetName = "PersonelTakipSistemiOPDataSet";
            this.personelTakipSistemiOPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::PersonelTakipSOP.Properties.Resources.pexels_photo_13164530;
            this.ClientSize = new System.Drawing.Size(1258, 761);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlemler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personellerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonelislemler;
        private System.Windows.Forms.Button btnDepartmanYon;
        private System.Windows.Forms.Button btnİzintkp;
        private System.Windows.Forms.Button btnMaasBodro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGCık;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label İzniYaklasanPersoneller;
        private System.Windows.Forms.Label ToplamPersonelSayisi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PersonelTakipSistemiOPDataSet personelTakipSistemiOPDataSet;
        private System.Windows.Forms.BindingSource personellerBindingSource;
        private PersonelTakipSistemiOPDataSetTableAdapters.PersonellerTableAdapter personellerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn epostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
    }
}

