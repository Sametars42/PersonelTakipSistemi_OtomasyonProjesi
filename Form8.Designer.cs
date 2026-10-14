namespace PersonelTakipSOP
{
    partial class Form8
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
            this.btnGeriGitDepartmandaki = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.departmanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mudurAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelTakipSistemiOPDataSet1 = new PersonelTakipSOP.PersonelTakipSistemiOPDataSet1();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDepartmanID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDepartmanTemizle = new System.Windows.Forms.Button();
            this.btnDepartmanGuncelle = new System.Windows.Forms.Button();
            this.btnDepartmanSil = new System.Windows.Forms.Button();
            this.btnDepartmanKaydet = new System.Windows.Forms.Button();
            this.btnDepartmanListele = new System.Windows.Forms.Button();
            this.txtYoneticiİsmi = new System.Windows.Forms.TextBox();
            this.txtDepartmanAdı = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.departmanlarTableAdapter = new PersonelTakipSOP.PersonelTakipSistemiOPDataSet1TableAdapters.DepartmanlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeriGitDepartmandaki
            // 
            this.btnGeriGitDepartmandaki.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGeriGitDepartmandaki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriGitDepartmandaki.Location = new System.Drawing.Point(835, 675);
            this.btnGeriGitDepartmandaki.Name = "btnGeriGitDepartmandaki";
            this.btnGeriGitDepartmandaki.Size = new System.Drawing.Size(122, 57);
            this.btnGeriGitDepartmandaki.TabIndex = 18;
            this.btnGeriGitDepartmandaki.Text = "Geri Git";
            this.btnGeriGitDepartmandaki.UseVisualStyleBackColor = false;
            this.btnGeriGitDepartmandaki.Click += new System.EventHandler(this.btnGeriGitDepartmandaki_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmanIDDataGridViewTextBoxColumn,
            this.departmanAdDataGridViewTextBoxColumn,
            this.mudurAdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.departmanlarBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 297);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(734, 435);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick_1);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // departmanIDDataGridViewTextBoxColumn
            // 
            this.departmanIDDataGridViewTextBoxColumn.DataPropertyName = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.HeaderText = "DepartmanID";
            this.departmanIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmanIDDataGridViewTextBoxColumn.Name = "departmanIDDataGridViewTextBoxColumn";
            this.departmanIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmanIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmanAdDataGridViewTextBoxColumn
            // 
            this.departmanAdDataGridViewTextBoxColumn.DataPropertyName = "DepartmanAd";
            this.departmanAdDataGridViewTextBoxColumn.HeaderText = "DepartmanAd";
            this.departmanAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.departmanAdDataGridViewTextBoxColumn.Name = "departmanAdDataGridViewTextBoxColumn";
            this.departmanAdDataGridViewTextBoxColumn.Width = 150;
            // 
            // mudurAdDataGridViewTextBoxColumn
            // 
            this.mudurAdDataGridViewTextBoxColumn.DataPropertyName = "MudurAd";
            this.mudurAdDataGridViewTextBoxColumn.HeaderText = "MudurAd";
            this.mudurAdDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mudurAdDataGridViewTextBoxColumn.Name = "mudurAdDataGridViewTextBoxColumn";
            this.mudurAdDataGridViewTextBoxColumn.Width = 150;
            // 
            // departmanlarBindingSource
            // 
            this.departmanlarBindingSource.DataMember = "Departmanlar";
            this.departmanlarBindingSource.DataSource = this.personelTakipSistemiOPDataSet1;
            // 
            // personelTakipSistemiOPDataSet1
            // 
            this.personelTakipSistemiOPDataSet1.DataSetName = "PersonelTakipSistemiOPDataSet1";
            this.personelTakipSistemiOPDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtDepartmanID);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.btnDepartmanTemizle);
            this.groupBox3.Controls.Add(this.btnDepartmanGuncelle);
            this.groupBox3.Controls.Add(this.btnDepartmanSil);
            this.groupBox3.Controls.Add(this.btnDepartmanKaydet);
            this.groupBox3.Controls.Add(this.btnDepartmanListele);
            this.groupBox3.Controls.Add(this.txtYoneticiİsmi);
            this.groupBox3.Controls.Add(this.txtDepartmanAdı);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(946, 266);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "İşlemler";
            // 
            // txtDepartmanID
            // 
            this.txtDepartmanID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtDepartmanID.Enabled = false;
            this.txtDepartmanID.Location = new System.Drawing.Point(269, 214);
            this.txtDepartmanID.Name = "txtDepartmanID";
            this.txtDepartmanID.Size = new System.Drawing.Size(53, 30);
            this.txtDepartmanID.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(35, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 32);
            this.label7.TabIndex = 10;
            this.label7.Text = "DepartmanID : ";
            // 
            // btnDepartmanTemizle
            // 
            this.btnDepartmanTemizle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDepartmanTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanTemizle.Location = new System.Drawing.Point(768, 140);
            this.btnDepartmanTemizle.Name = "btnDepartmanTemizle";
            this.btnDepartmanTemizle.Size = new System.Drawing.Size(148, 46);
            this.btnDepartmanTemizle.TabIndex = 9;
            this.btnDepartmanTemizle.Text = "Temizle";
            this.btnDepartmanTemizle.UseVisualStyleBackColor = false;
            this.btnDepartmanTemizle.Click += new System.EventHandler(this.btnDepartmanTemizle_Click);
            // 
            // btnDepartmanGuncelle
            // 
            this.btnDepartmanGuncelle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDepartmanGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanGuncelle.Location = new System.Drawing.Point(768, 63);
            this.btnDepartmanGuncelle.Name = "btnDepartmanGuncelle";
            this.btnDepartmanGuncelle.Size = new System.Drawing.Size(148, 46);
            this.btnDepartmanGuncelle.TabIndex = 8;
            this.btnDepartmanGuncelle.Text = "Güncelle";
            this.btnDepartmanGuncelle.UseVisualStyleBackColor = false;
            this.btnDepartmanGuncelle.Click += new System.EventHandler(this.btnDepartmanGuncelle_Click);
            // 
            // btnDepartmanSil
            // 
            this.btnDepartmanSil.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDepartmanSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanSil.Location = new System.Drawing.Point(586, 175);
            this.btnDepartmanSil.Name = "btnDepartmanSil";
            this.btnDepartmanSil.Size = new System.Drawing.Size(148, 46);
            this.btnDepartmanSil.TabIndex = 7;
            this.btnDepartmanSil.Text = "Sil";
            this.btnDepartmanSil.UseVisualStyleBackColor = false;
            this.btnDepartmanSil.Click += new System.EventHandler(this.btnDepartmanSil_Click);
            // 
            // btnDepartmanKaydet
            // 
            this.btnDepartmanKaydet.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDepartmanKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanKaydet.Location = new System.Drawing.Point(586, 103);
            this.btnDepartmanKaydet.Name = "btnDepartmanKaydet";
            this.btnDepartmanKaydet.Size = new System.Drawing.Size(148, 46);
            this.btnDepartmanKaydet.TabIndex = 6;
            this.btnDepartmanKaydet.Text = "Kaydet";
            this.btnDepartmanKaydet.UseVisualStyleBackColor = false;
            this.btnDepartmanKaydet.Click += new System.EventHandler(this.btnDepartmanKaydet_Click);
            // 
            // btnDepartmanListele
            // 
            this.btnDepartmanListele.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDepartmanListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmanListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmanListele.Location = new System.Drawing.Point(586, 30);
            this.btnDepartmanListele.Name = "btnDepartmanListele";
            this.btnDepartmanListele.Size = new System.Drawing.Size(148, 46);
            this.btnDepartmanListele.TabIndex = 5;
            this.btnDepartmanListele.Text = "Listele";
            this.btnDepartmanListele.UseVisualStyleBackColor = false;
            this.btnDepartmanListele.Click += new System.EventHandler(this.btnDepartmanListele_Click);
            // 
            // txtYoneticiİsmi
            // 
            this.txtYoneticiİsmi.Location = new System.Drawing.Point(269, 135);
            this.txtYoneticiİsmi.Name = "txtYoneticiİsmi";
            this.txtYoneticiİsmi.Size = new System.Drawing.Size(275, 30);
            this.txtYoneticiİsmi.TabIndex = 3;
            // 
            // txtDepartmanAdı
            // 
            this.txtDepartmanAdı.Location = new System.Drawing.Point(269, 63);
            this.txtDepartmanAdı.Name = "txtDepartmanAdı";
            this.txtDepartmanAdı.Size = new System.Drawing.Size(275, 30);
            this.txtDepartmanAdı.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(39, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Yönetici İsmi : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(11, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Departman Adı : ";
            // 
            // departmanlarTableAdapter
            // 
            this.departmanlarTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::PersonelTakipSOP.Properties.Resources.pexels_photo_13164530;
            this.ClientSize = new System.Drawing.Size(969, 746);
            this.Controls.Add(this.btnGeriGitDepartmandaki);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Yönetimi";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTakipSistemiOPDataSet1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGeriGitDepartmandaki;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDepartmanID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDepartmanTemizle;
        private System.Windows.Forms.Button btnDepartmanGuncelle;
        private System.Windows.Forms.Button btnDepartmanSil;
        private System.Windows.Forms.Button btnDepartmanKaydet;
        private System.Windows.Forms.Button btnDepartmanListele;
        private System.Windows.Forms.TextBox txtYoneticiİsmi;
        private System.Windows.Forms.TextBox txtDepartmanAdı;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private PersonelTakipSistemiOPDataSet1 personelTakipSistemiOPDataSet1;
        private System.Windows.Forms.BindingSource departmanlarBindingSource;
        private PersonelTakipSistemiOPDataSet1TableAdapters.DepartmanlarTableAdapter departmanlarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmanAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mudurAdDataGridViewTextBoxColumn;
    }
}