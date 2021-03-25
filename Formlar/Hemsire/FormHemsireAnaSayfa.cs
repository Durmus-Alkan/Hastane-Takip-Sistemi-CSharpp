using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneTakipSon.Formlar.Hemsire
{
    public partial class FormHemsireAnaSayfa : MetroFramework.Forms.MetroForm
    {
        public FormHemsireAnaSayfa()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");


        private void kullanicilari_goster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter calisanlari_listele = new SqlDataAdapter("SELECT hasta_ad AS[AD], hasta_soyad AS[SOYAD], " +
                    "yas AS[YAS], doktorAd AS[Doktor Adı], muayne_bolum AS[Poliklinik] FROM hasta", baglanti);

                DataSet dshafiza = new DataSet();
                calisanlari_listele.Fill(dshafiza);
                dgwYatakHastaListe.DataSource = dshafiza.Tables[0];
                baglanti.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "İnşallah anlatırken karşına çıkmaz kardeşim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void FormHemsireAnaSayfa_Load(object sender, EventArgs e)
        {
            kullanicilari_goster();
            radioButton2.Checked = true;
            if (radioButton1.Checked == true)
            {
                gBoxYemek.Visible = true;
            }
            else
            {
                gBoxYemek.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gBoxYemek.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gBoxYemek.Visible = false;
        }

        private void dgwYatakHastaListe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblHastaAd.Text = dgwYatakHastaListe.Rows[e.RowIndex].Cells[0].Value.ToString(); //[0] sütun numarası
            lblHastaSoyad.Text = dgwYatakHastaListe.CurrentRow.Cells[1].Value.ToString(); //[0] sütun numarası
            lblHastaYas.Text = dgwYatakHastaListe.CurrentRow.Cells[2].Value.ToString(); //[0] sütun numarası
            lblHastaDoktorAd.Text = dgwYatakHastaListe.CurrentRow.Cells[3].Value.ToString(); //[0] sütun numarası
            lblPoliklinik.Text = dgwYatakHastaListe.CurrentRow.Cells[4].Value.ToString(); //[0] sütun numarası
        }
        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Tablolar.MuayneTakip muayneTakip = new Tablolar.MuayneTakip
            {
                ad = lblHastaAd.Text,
                soyad = lblHastaSoyad.Text,
                yas = lblHastaYas.Text,
                doktorAd = lblHastaDoktorAd.Text,
                poliklinik = lblPoliklinik.Text,
                tansiyon = tBoxTansiyon.Text,
                nabiz = tBoxNabiz.Text,
                satursayon = tBoxSaturasyon.Text,
                ameliyat = true,
                ilac = richTextBox1.Text,
                kan_grubu = cBoxKanGrubu.Text,
                yemekDurumu = "Aç"

            };


            try
           {
                baglanti.Open(); //veri tabanını açtık.
                SqlCommand ekle_sorgu = new SqlCommand("INSERT INTO muayneTakip (ad, soyad," +
                    "yas, doktorAd, poliklinik, tansiyon, nabiz, saturasyon, ameliyat," +
                    "kan_grubu, ilac, yemek_durumu )" +
                    "VALUES(@ad, @soyad, @yas, @doktorAd, @poliklinik, @tansiyon, @nabiz, @saturasyon, @ameliyat, @kan_grubu, @ilac, @yemek_durumu)", baglanti);

                ekle_sorgu.Parameters.AddWithValue("@ad", muayneTakip.ad);
                ekle_sorgu.Parameters.AddWithValue("@soyad", muayneTakip.soyad);
                ekle_sorgu.Parameters.AddWithValue("@yas", muayneTakip.yas);
                ekle_sorgu.Parameters.AddWithValue("@doktorAd", muayneTakip.doktorAd);
                ekle_sorgu.Parameters.AddWithValue("@poliklinik", muayneTakip.poliklinik);
                ekle_sorgu.Parameters.AddWithValue("@tansiyon", muayneTakip.tansiyon);
                ekle_sorgu.Parameters.AddWithValue("@nabiz", muayneTakip.nabiz);
                ekle_sorgu.Parameters.AddWithValue("@saturasyon", muayneTakip.satursayon);
                ekle_sorgu.Parameters.AddWithValue("@ameliyat", muayneTakip.ameliyat);
                ekle_sorgu.Parameters.AddWithValue("@kan_grubu", muayneTakip.kan_grubu);
                ekle_sorgu.Parameters.AddWithValue("@ilac", muayneTakip.ilac);
                ekle_sorgu.Parameters.AddWithValue("@yemek_durumu", muayneTakip.yemekDurumu);

                ekle_sorgu.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kullanıcı Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Giris.Giris giris = new Giris.Giris();
            this.Hide();
            giris.Show();
        }
    }



}
