using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static PersonelTakipSOP.Form2;

namespace PersonelTakipSOP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Personeller", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.personellerTableAdapter.Fill(this.personelTakipSistemiOPDataSet.Personeller);

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //listeleme 
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];

                // İsim yerine hücre numaralarını yazıdım
                txtTC.Text = satir.Cells[1].Value?.ToString();         //  TC
                txtAd.Text = satir.Cells[2].Value?.ToString();         //  Ad
                txtSoyad.Text = satir.Cells[3].Value?.ToString();      //  Soyad
                txtCepNo.Text = satir.Cells[4].Value?.ToString();      //  Telefon
                txtEposta.Text = satir.Cells[5].Value?.ToString();     //  Eposta
                txtDepartmanID.Text = satir.Cells[6].Value?.ToString();//  DepartmanID
                maskedTextBox1.Text = satir.Cells[7].Value?.ToString();//  Maas
                textBox1.Text = satir.Cells[8].Value?.ToString();      //  IseGirisTarihi
            }
        }


        private void btnKaydet_Click(object sender, EventArgs e) // kaydet butonu kısmı 
        {
            try
            {
                SqlCommand komut = new SqlCommand("INSERT INTO Personeller (Ad, Soyad, TC, Telefon, Eposta, Maas, IseGirisTarihi, DepartmanID) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtTC.Text);
                komut.Parameters.AddWithValue("@p4", txtCepNo.Text);
                komut.Parameters.AddWithValue("@p5", txtEposta.Text);
                komut.Parameters.AddWithValue("@p6", decimal.Parse(maskedTextBox1.Text));
                komut.Parameters.AddWithValue("@p7", textBox1.Text);
                komut.Parameters.AddWithValue("@p8", txtDepartmanID.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme hatası: " + ex.Message);
                bgl.baglanti().Close();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)  // Silme işlemini TC üzerinden yaptım 
        {
            try
            {
                if (string.IsNullOrEmpty(txtTC.Text))
                {
                    MessageBox.Show("Lütfen tablodan silinecek personeli seçin!");
                    return;
                }

                DialogResult onay = MessageBox.Show("Bu personeli ve ona bağlı tüm kayıtları (izin, bordro vb.) silmek istediğinize emin misiniz?", "Kritik Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (onay == DialogResult.Yes)
                {
                    SqlConnection baglanti = bgl.baglanti();

                   
                    string altSorgu = " (SELECT PersonelID FROM Personeller WHERE TC = @p1) ";

                    SqlCommand komutIzin = new SqlCommand("DELETE FROM IzinKayitlari WHERE PersonelID =" + altSorgu, baglanti);
                    komutIzin.Parameters.AddWithValue("@p1", txtTC.Text);
                    komutIzin.ExecuteNonQuery();

                    SqlCommand komutBordro = new SqlCommand("DELETE FROM MaasBordro WHERE PersonelID =" + altSorgu, baglanti);
                    komutBordro.Parameters.AddWithValue("@p1", txtTC.Text);
                    komutBordro.ExecuteNonQuery();

                    // 2. ADIM: Artık personelin kendisini silebiliriz
                    SqlCommand komutAna = new SqlCommand("DELETE FROM Personeller WHERE TC = @p1", baglanti);
                    komutAna.Parameters.AddWithValue("@p1", txtTC.Text);
                    komutAna.ExecuteNonQuery();

                    baglanti.Close();
                    MessageBox.Show("Personel ve tüm ilişkili verileri silindi.");
                    listele();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
                bgl.baglanti().Close();
            }
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("UPDATE Personeller SET Ad=@p1, Soyad=@p2, Telefon=@p3, Eposta=@p4, Maas=@p5, IseGirisTarihi=@p6, DepartmanID=@p7 WHERE TC=@p8", bgl.baglanti());

                komut.Parameters.AddWithValue("@p1", txtAd.Text);
                komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", txtCepNo.Text);
                komut.Parameters.AddWithValue("@p4", txtEposta.Text);
                komut.Parameters.AddWithValue("@p5", decimal.Parse(maskedTextBox1.Text));
                komut.Parameters.AddWithValue("@p6", textBox1.Text);
                komut.Parameters.AddWithValue("@p7", txtDepartmanID.Text);
                komut.Parameters.AddWithValue("@p8", txtTC.Text); 

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bilgiler güncellendi.");
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
                bgl.baglanti().Close();
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTC.Text = "";
            txtCepNo.Text = "";
            txtEposta.Text = "";
            txtDepartmanID.Text = "";
            textBox1.Text= "";
            maskedTextBox1.Text = "";
        }

        private void btnAnaSayfayaDon_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
