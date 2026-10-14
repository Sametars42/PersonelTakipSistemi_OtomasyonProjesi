using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static PersonelTakipSOP.Form2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PersonelTakipSOP
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

            this.departmanlarTableAdapter.Fill(this.personelTakipSistemiOPDataSet1.Departmanlar);

        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Departmanlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void btnDepartmanListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;

            txtDepartmanID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            txtDepartmanAdı.Text = dataGridView2.Rows[secilen].Cells[1].Value.ToString();
            txtYoneticiİsmi.Text = dataGridView2.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnDepartmanKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDepartmanAdı.Text) || string.IsNullOrWhiteSpace(txtYoneticiİsmi.Text))
            {
                MessageBox.Show("Lütfen Departman Adı ve Yönetici İsmi alanlarını boş bırakmayın!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            try
            {
                
                SqlCommand komut = new SqlCommand("INSERT INTO Departmanlar (DepartmanAd, MudurAd) VALUES (@p1, @p2)", bgl.baglanti());

              
                komut.Parameters.AddWithValue("@p1", txtDepartmanAdı.Text);
                komut.Parameters.AddWithValue("@p2", txtYoneticiİsmi.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Departman başarıyla kaydedildi. (ID Otomatik Atandı)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message);
                bgl.baglanti().Close();
            }
        }

        private void btnDepartmanSil_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtDepartmanID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz departmanı tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            DialogResult onay = MessageBox.Show("Bu departman kaydını silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    
                    SqlCommand komut = new SqlCommand("DELETE FROM Departmanlar WHERE DepartmanID = @p1", bgl.baglanti());

                   
                    komut.Parameters.AddWithValue("@p1", txtDepartmanID.Text);

                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   
                    listele();
                    txtDepartmanID.Clear();
                    txtDepartmanAdı.Clear();
                    txtYoneticiİsmi.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme hatası: " + ex.Message);
                    bgl.baglanti().Close();
                }
            }
        }

        private void btnDepartmanGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("UPDATE Departmanlar SET DepartmanAd=@p1, MudurAd=@p2 WHERE DepartmanID=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtDepartmanAdı.Text);
            komut.Parameters.AddWithValue("@p2", txtYoneticiİsmi.Text);
            komut.Parameters.AddWithValue("@p3", txtDepartmanID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Departman Bilgileri Güncellendi", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnDepartmanTemizle_Click(object sender, EventArgs e)
        {
            txtDepartmanID.Text = "";
            txtDepartmanAdı.Text = "";
            txtYoneticiİsmi.Text = "";
        }

        private void btnGeriGitDepartmandaki_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                txtDepartmanID.Text = row.Cells[0].Value?.ToString();
                txtDepartmanAdı.Text = row.Cells[1].Value?.ToString();
                txtYoneticiİsmi.Text = row.Cells[2].Value?.ToString();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
