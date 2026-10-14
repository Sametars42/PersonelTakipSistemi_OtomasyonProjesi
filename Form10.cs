using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;
using static PersonelTakipSOP.Form2;

namespace PersonelTakipSOP
{
    public partial class Form10 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=PersonelTakipSistemiOP;Integrated Security=True");
        public Form10()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MaasBordro", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       
        public void PersonelKomboDoldur()
        {
            try
            {
                
                string sorgu = "SELECT PersonelID, Ad + ' ' + Soyad AS AdSoyad FROM Personeller";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);

                
                comboBoxPersonelSec.DataSource = dt;
                comboBoxPersonelSec.DisplayMember = "AdSoyad"; 
                comboBoxPersonelSec.ValueMember = "PersonelID";

                
                comboBoxPersonelSec.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                bgl.baglanti().Close();
            }
        }



        private void Form10_Load(object sender, EventArgs e)
        {
            listele();
            PersonelKomboDoldur();

            // Personelleri ComboBox'a çekme
            SqlCommand komut = new SqlCommand("SELECT PersonelID, Ad + ' ' + Soyad AS AdSoyad FROM Personeller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            
           
        }

        private void cmbPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("SELECT Maas FROM Personeller WHERE Ad + ' ' + Soyad = @p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", comboBoxPersonelSec.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtMaas.Text = dr["Maas"].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnMaasBodroHesapla_Click(object sender, EventArgs e)
        {
            try
            {

                decimal maas = string.IsNullOrEmpty(txtMaas.Text) ? 0 : Convert.ToDecimal(txtMaas.Text);
                decimal kesintiler = string.IsNullOrEmpty(txtKesintiler.Text) ? 0 : Convert.ToDecimal(txtKesintiler.Text);
                decimal ekMesai = string.IsNullOrEmpty(txtEkMesaiUcreti.Text) ? 0 : Convert.ToDecimal(txtEkMesaiUcreti.Text);


                decimal netOdenen = (maas + ekMesai) - kesintiler;


                txtNetOdenen.Text = netOdenen.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hesaplama sırasında hata: " + ex.Message);
            }
        }

        private void btnMaasBodroKaydet_Click(object sender, EventArgs e)
        {
            
            if (comboBoxPersonelSec.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir personel seçin!");
                return;
            }

            try
            {
                
            
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                baglanti.Open();

                
                string kontrolSorgu = "SELECT COUNT(*) FROM MaasBordro WHERE PersonelID = @p1 AND Ay = @p2 AND Yil = @p3";
                using (SqlCommand kontrolKomut = new SqlCommand(kontrolSorgu, baglanti))
                {
                    kontrolKomut.Parameters.AddWithValue("@p1", comboBoxPersonelSec.SelectedValue);
                    kontrolKomut.Parameters.AddWithValue("@p2", comboBoxAySec.Text);
                    kontrolKomut.Parameters.AddWithValue("@p3", comboBoxYılSec.Text);

                    int varMi = (int)kontrolKomut.ExecuteScalar();

                    if (varMi > 0)
                    {
                        MessageBox.Show("Bu personel için bu aya ait bordro zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; 
                    }
                }

                // 3. KAYIT İŞLEMİ 
                string sorgu = "INSERT INTO MaasBordro (PersonelID, Ay, Yil, EkMesaiUcreti, Kesintiler, NetOdenen) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                using (SqlCommand komut = new SqlCommand(sorgu, baglanti))
                {
                    komut.Parameters.AddWithValue("@p1", comboBoxPersonelSec.SelectedValue);
                    komut.Parameters.AddWithValue("@p2", comboBoxAySec.Text);
                    komut.Parameters.AddWithValue("@p3", comboBoxYılSec.Text);

                    decimal m, k, n;
                    decimal.TryParse(txtEkMesaiUcreti.Text, out m);
                    decimal.TryParse(txtKesintiler.Text, out k);
                    decimal.TryParse(txtNetOdenen.Text, out n);

                    komut.Parameters.AddWithValue("@p4", m);
                    komut.Parameters.AddWithValue("@p5", k);
                    komut.Parameters.AddWithValue("@p6", n);

                    komut.ExecuteNonQuery();
                    MessageBox.Show("Bordro başarıyla kaydedildi.");

                    listele(); // Tabloyu yenile
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme Hatası: " + ex.Message);
            }
            finally
            {
                // İşlem bitince veya hata alınca bağlantıyı her zaman kapat
                if (baglanti.State == ConnectionState.Open)
                {
                    baglanti.Close();
                }
            }
            
        }

        private void btnMaasBodroTemizle_Click(object sender, EventArgs e)
        {
            comboBoxPersonelSec.Text = "";
            comboBoxAySec.Text = "";
            comboBoxYılSec.Text = "";
            txtMaas.Clear();
            txtMaas.Text = "";
            txtEkMesaiUcreti.Clear();
            txtKesintiler.Clear();
            txtNetOdenen.Clear();

            
        }

        private void comboBoxPersonelSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPersonelSec.SelectedValue == null || comboBoxPersonelSec.SelectedIndex == -1)
                return;

            if (comboBoxPersonelSec.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            try
            {
                using (SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=PersonelTakipSistemiOP;Trusted_Connection=True;"))
                {
                    baglanti.Open();

                    string query = "SELECT Maas FROM Personeller WHERE PersonelID = @pID";

                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@pID", comboBoxPersonelSec.SelectedValue);

                    object sonuc = komut.ExecuteScalar();

                    if (sonuc != null && sonuc != DBNull.Value)
                    {
                        txtMaas.Text = Convert.ToDecimal(sonuc).ToString("N2");
                    }
                    else
                    {
                        txtMaas.Text = "0,00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Maaş getirilirken hata oluştu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            try
            {
                using (SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=PersonelTakipSistemiOP;Trusted_Connection=True;"))
                {
                    baglanti.Open();
                    string sorgu = "SELECT Maas FROM Personeller WHERE PersonelID = @p1";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", comboBoxPersonelSec.SelectedValue);

                    object sonuc = komut.ExecuteScalar();
                    if (sonuc != null)
                    {
                        txtMaas.Text = sonuc.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void txtMaas_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Database=PersonelTakipSistemiOP;Trusted_Connection=True;"))
                {
                    baglanti.Open();
                    string sorgu = "SELECT Maas FROM Personeller WHERE PersonelID = @p1";
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("@p1", comboBoxPersonelSec.SelectedValue);

                    object sonuc = komut.ExecuteScalar();
                    if (sonuc != null)
                    {
                        txtMaas.Text = sonuc.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void BordroHesapla()
        {
            decimal m, k, e;
            decimal.TryParse(txtMaas.Text, out m);
            decimal.TryParse(txtKesintiler.Text, out k);
            decimal.TryParse(txtEkMesaiUcreti.Text, out e);

            decimal sonuc = (m + e) - k;
            txtNetOdenen.Text = sonuc.ToString("N2");
        }

        private void txtKesintiler_TextChanged(object sender, EventArgs e)
        {
            BordroHesapla();
        }

        private void txtEkMesaiUcreti_TextChanged(object sender, EventArgs e)
        {
            BordroHesapla();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        void bordroListele()
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MaasBordro", bgl.baglanti());

                DataTable dt = new DataTable();
                da.Fill(dt); 

                dataGridView1.DataSource = dt; 

                bgl.baglanti().Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste yüklenirken hata oluştu: " + ex.Message);
                bgl.baglanti().Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(secilenBordroID))
                {
                    MessageBox.Show("Lütfen silmek istediğiniz bordro kaydını alttaki tablodan seçin!", "Uyarı");
                    return;
                }

                DialogResult onay = MessageBox.Show("Bu maaş bordrosu kaydını silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    
                    SqlCommand komutSil = new SqlCommand("DELETE FROM MaasBordro WHERE BordroID = @p1", bgl.baglanti());
                    komutSil.Parameters.AddWithValue("@p1", secilenBordroID);

                    komutSil.ExecuteNonQuery();
                    bgl.baglanti().Close();

                    MessageBox.Show("Bordro kaydı başarıyla silindi.", "Bilgi");

                    // Tabloyu yeniledim
                    bordroListele();

                    // Seçimi sıfırladım
                    secilenBordroID = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message);
                bgl.baglanti().Close();
            }
        }

        void personelleriGetir()
        {
            SqlCommand komut = new SqlCommand("SELECT PersonelID, (Ad + ' ' + Soyad) AS AdSoyad FROM Personeller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            comboBoxPersonelSec.DataSource = dt;
            comboBoxPersonelSec.DisplayMember = "AdSoyad"; // Ekranda görünecek olan
            comboBoxPersonelSec.ValueMember = "PersonelID"; // Arka planda tutulacak olan ID
            bgl.baglanti().Close();
        }

        string secilenBordroID = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                secilenBordroID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

                
            }
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // BordroID'yi sakla
                secilenBordroID = row.Cells[0].Value.ToString();

                // ComboBox'ta ismi seçili hale getir
                string pID = row.Cells[1].Value.ToString();
                comboBoxPersonelSec.SelectedValue = pID;

                // Diğer kutuları doldur
                comboBoxAySec.Text = row.Cells[2].Value.ToString();
                comboBoxYılSec.Text = row.Cells[3].Value.ToString();
                txtEkMesaiUcreti.Text = row.Cells[4].Value.ToString();
                txtKesintiler.Text = row.Cells[5].Value.ToString();
                txtNetOdenen.Text = row.Cells[6].Value.ToString();

                // MAAŞI ÇEKME 
                using (SqlConnection conn = bgl.baglanti())
                {
                    // Bağlantıyı açalım
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    using (SqlCommand komutMaas = new SqlCommand("SELECT Maas FROM Personeller WHERE PersonelID = @id", conn))
                    {
                        komutMaas.Parameters.AddWithValue("@id", pID);

                        object sonuc = komutMaas.ExecuteScalar(); // Tek bir değer (Maaş) döneceği için Scalar daha güvenli
                        if (sonuc != null)
                        {
                            txtMaas.Text = sonuc.ToString();
                        }
                    }
                }
            }
        }
        

        private void button3_Click(object sender, EventArgs e)
        {

            decimal maas = decimal.Parse(txtMaas.Text);
            decimal ekMesai = decimal.Parse(txtEkMesaiUcreti.Text);
            decimal kesinti = decimal.Parse(txtKesintiler.Text);

            decimal net = maas + ekMesai - kesinti;
            txtNetOdenen.Text = net.ToString();

            try
            {
                if (string.IsNullOrEmpty(secilenBordroID))
                {
                    MessageBox.Show("Lütfen önce tablodan güncellenecek kaydı seçin!");
                    return;
                }

               
                string sorgu = "UPDATE MaasBordro SET PersonelID=@p1, Ay=@p2, Yil=@p3, EkMesaiUcreti=@p4, Kesintiler=@p5, NetOdenen=@p6 WHERE BordroID=@p7";

                using (SqlConnection conn = bgl.baglanti())
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    using (SqlCommand komut = new SqlCommand(sorgu, conn))
                    {
                        
                        komut.Parameters.AddWithValue("@p1", comboBoxPersonelSec.SelectedValue);
                        komut.Parameters.AddWithValue("@p2", comboBoxAySec.Text);
                        komut.Parameters.AddWithValue("@p3", comboBoxYılSec.Text);
                        komut.Parameters.AddWithValue("@p4", decimal.Parse(txtEkMesaiUcreti.Text));
                        komut.Parameters.AddWithValue("@p5", decimal.Parse(txtKesintiler.Text));
                        komut.Parameters.AddWithValue("@p6", decimal.Parse(txtNetOdenen.Text));
                        komut.Parameters.AddWithValue("@p7", secilenBordroID);

                        komut.ExecuteNonQuery();
                    }
                    conn.Close();
                }

                MessageBox.Show("Bordro başarıyla güncellendi.");
                bordroListele(); // Tabloyu yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message);
            }
        }
    }
}
