using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static PersonelTakipSOP.Form2;




namespace PersonelTakipSOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();


        private void VerileriYukle()
        {
            
            SqlCommand komut1 = new SqlCommand("SELECT COUNT(*) FROM Personeller", bgl.baglanti());
            ToplamPersonelSayisi.Text = komut1.ExecuteScalar().ToString();

            
            SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM IzinKayitlari WHERE BaslangicTarihi BETWEEN GETDATE() AND GETDATE()+7", bgl.baglanti());
            İzniYaklasanPersoneller.Text = komut2.ExecuteScalar().ToString();


            SqlDataAdapter da = new SqlDataAdapter("SELECT PersonelID, TC, Ad, Soyad, Telefon, Eposta, DepartmanID FROM Personeller", bgl.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            bgl.baglanti().Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void btnPersonelislemler_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
            
        }

        private void btnDepartmanYon_Click(object sender, EventArgs e)
        {
            Form8 frm8 = new Form8();
            frm8.Show();
            this.Hide();

        }

        private void btnİzintkp_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        private void btnMaasBodro_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();

        }

        private void btnGCık_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
