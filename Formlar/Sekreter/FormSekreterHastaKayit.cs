using HastaneTakipSon.Tablolar;
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

namespace HastaneTakipSon.Formlar.Sekreter
{
    public partial class FormSekreterHastaKayit : MetroFramework.Forms.MetroForm
    {
        public FormSekreterHastaKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");

        private void FormSekreterHastaKayit_Load(object sender, EventArgs e)
        {
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Hastalar hasta = new Hastalar
            {
                kimlik_no = tBoxtc_no.Text,
                hasta_ad = tBoxHasta_ad.Text,
                hasta_soyad = tBoxHasta_soyad.Text,
                yas = tBoxYas.Text,
                muayne_bolum = tBoxPoliklinik.Text,
                doktor_ad = tBoxDoktor_ad.Text,
                sosyal_Guvenlik = tBoxSosyalG.Text,
                tel = tBoxTel_no.Text

            };

            baglanti.Open(); //veri tabanını açtık.

            SqlCommand ekle_sorgu = new SqlCommand("INSERT INTO hasta (hasta_ad, " +
                "hasta_soyad, yas, kimlik_no, muayne_bolum, doktorAd," +
                "sosyalGüvenlik, tel)" +
                "VALUES (@hasta_ad, @hasta_soyad, " +
                "@yas, @kimlik_no, @muayne_bolum, @doktorAd, " +
                "@sosyalGuvenlik, @tel)", baglanti);

            ekle_sorgu.Parameters.AddWithValue("@hasta_ad", hasta.hasta_ad);
            ekle_sorgu.Parameters.AddWithValue("@hasta_soyad", hasta.hasta_soyad);
            ekle_sorgu.Parameters.AddWithValue("@yas", hasta.yas);
            ekle_sorgu.Parameters.AddWithValue("@kimlik_no", hasta.kimlik_no);
            ekle_sorgu.Parameters.AddWithValue("@muayne_bolum", hasta.muayne_bolum);
            ekle_sorgu.Parameters.AddWithValue("@doktorAd", hasta.doktor_ad);
            ekle_sorgu.Parameters.AddWithValue("@sosyalGuvenlik", hasta.sosyal_Guvenlik);
            ekle_sorgu.Parameters.AddWithValue("@tel", hasta.tel);

            ekle_sorgu.ExecuteNonQuery();

            baglanti.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            tBoxDoktor_ad.Text = "";
            tBoxHasta_ad.Text = "";
            tBoxHasta_soyad.Text = "";
            tBoxPoliklinik.Text = "";
            tBoxSosyalG.Text = "";
            tBoxtc_no.Text = "";
            tBoxTel_no.Text = "";
            tBoxYas.Text = "";
        }
    }
}
