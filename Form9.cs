using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static PersonelTakipSOP.Form2;

namespace PersonelTakipSOP
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }


        private void Form9_Load(object sender, EventArgs e)
        {
            this.izinKayitlariTableAdapter.Fill(this.personelTakipSistemiOPDataSet3.IzinKayitlari);


            SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelID, (Ad + ' ' + Soyad) AS AdSoyad FROM Personeller", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);


            comboboxİzneCıkacak.ValueMember = "PersonelID";
            comboboxİzneCıkacak.DisplayMember = "AdSoyad";


            comboboxİzneCıkacak.DataSource = dt;
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM IzinKayitlari", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void TarihHesapla()
        {
            DateTime baslangic = dateTimePickerİzinBaslangic.Value;
            DateTime bitis = dateTimePickerİzinBitis.Value;

            TimeSpan sonuc = bitis - baslangic;


            if (sonuc.Days < 0)
            {
                GunKadarİzinKullanacak.Text = "Geçersiz Tarih";
            }
            else
            {
                GunKadarİzinKullanacak.Text = sonuc.Days.ToString();
            }
        }
        public void IzinListele()
        {

            string sorgu = "SELECT * FROM IzinKayitlari";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            bgl.baglanti().Close();
        }

        private void btnİzinKaydet_Click(object sender, EventArgs e)
        {

            if (comboboxİzneCıkacak.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtİzinTürü.Text))
            {
                MessageBox.Show("Lütfen Personel ve İzin Türü alanlarını doldurun!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string sorgu = "INSERT INTO IzinKayitlari (PersonelID, BaslangicTarihi, BitisTarihi, IzinTuru, OnayDurumu) VALUES (@p1, @p2, @p3, @p4, @p5)";

                SqlCommand komut = new SqlCommand(sorgu, bgl.baglanti());


                komut.Parameters.AddWithValue("@p1", comboboxİzneCıkacak.SelectedValue);
                komut.Parameters.AddWithValue("@p2", dateTimePickerİzinBaslangic.Value);
                komut.Parameters.AddWithValue("@p3", dateTimePickerİzinBitis.Value);
                komut.Parameters.AddWithValue("@p4", txtİzinTürü.Text);

                if (checkBox1.Checked == true)
                {
                    komut.Parameters.AddWithValue("@p5", true);
                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", false);
                }

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("İzin talebi başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                IzinListele();
            }
            catch (Exception ex)
            {
                if (bgl.baglanti().State == ConnectionState.Open) bgl.baglanti().Close();
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void btnİzinGeriGit_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }

        private void GunHesapla()
        {
            DateTime baslangic = dateTimePickerİzinBaslangic.Value;
            DateTime bitis = dateTimePickerİzinBitis.Value;

            TimeSpan fark = bitis - baslangic;


            int gunSayisi = fark.Days;

            if (gunSayisi < 0)
            {
                GunKadarİzinKullanacak.Text = "0";
                GunKadarİzinKullanacak.ForeColor = Color.Red;
            }
            else
            {

                GunKadarİzinKullanacak.Text = (gunSayisi).ToString();
                GunKadarİzinKullanacak.ForeColor = Color.Black;
            }
        }

        private void dateTimePickerİzinBaslangic_ValueChanged(object sender, EventArgs e)
        {
            GunHesapla();
        }

        private void dateTimePickerİzinBitis_ValueChanged(object sender, EventArgs e)
        {
            GunHesapla();
        }

        public void PersonelListesiGetir()
        {

            string sorgu = "SELECT PersonelID, (Ad + ' ' + Soyad) AS PersonelAdSoyad FROM Personeller";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);

            comboboxİzneCıkacak.DisplayMember = "PersonelAdSoyad";
            comboboxİzneCıkacak.ValueMember = "PersonelID";
            comboboxİzneCıkacak.DataSource = dt;

            bgl.baglanti().Close();

        }

        private void comboboxİzneCıkacak_SelectedIndexChanged(object sender, EventArgs e)// Personelleri getiren metodun içinde
        {

            comboboxİzneCıkacak.ValueMember = "PersonelID";
            comboboxİzneCıkacak.DisplayMember = "AdSoyad";

        }


        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
           
            txtİzinTürü.Clear();

            comboboxİzneCıkacak.SelectedIndex = -1; 
            dateTimePickerİzinBaslangic.Value = DateTime.Now;
            dateTimePickerİzinBitis.Value = DateTime.Now;
            checkBox1.Checked = false;
            GunKadarİzinKullanacak.Text = "0";
            comboboxİzneCıkacak.Focus();


        }
    }
}
