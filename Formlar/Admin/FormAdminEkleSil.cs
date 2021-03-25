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

namespace HastaneTakipSon.Formlar.Admin
{
    public partial class FormAdminEkleSil : MetroFramework.Forms.MetroForm
    {
        public FormAdminEkleSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanici = new Kullanicilar
            {
                tcno = tBoxTc.Text,
                ad = tBoxAd.Text,
                soyad = tBoxSoyad.Text,
                yetki = cBoxYetki.Text,
                kullanici_ad = tBoxKullaniciAdi.Text,
                parola = tBoxParola.Text,
                brans = cBoxBrans.Text
            };

            try
            {
                baglanti.Open(); //veri tabanını açtık.
                SqlCommand ekle_sorgu = new SqlCommand("INSERT INTO calisan (tcno, ad, soyad," +
                    "yetki, kullanici_ad, parola, brans)" +
                    "VALUES (@tcno, @ad, @soyad, @yetki, " +
                    "@kullanici_ad, @parola, @brans)", baglanti);

                ekle_sorgu.Parameters.AddWithValue("@tcno", kullanici.tcno);
                ekle_sorgu.Parameters.AddWithValue("@ad", kullanici.ad);
                ekle_sorgu.Parameters.AddWithValue("@soyad", kullanici.soyad);
                ekle_sorgu.Parameters.AddWithValue("@yetki", kullanici.yetki);
                ekle_sorgu.Parameters.AddWithValue("@kullanici_ad", kullanici.kullanici_ad);
                ekle_sorgu.Parameters.AddWithValue("@parola", kullanici.parola);
                ekle_sorgu.Parameters.AddWithValue("@brans", kullanici.brans);

                ekle_sorgu.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kullanıcı Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı Eklenemedi","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
                baglanti.Close();
            }
            
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            tBoxAd.Text = "";
            tBoxKullaniciAdi.Text = "";
            tBoxParola.Text = "";
            tBoxSoyad.Text = "";
            tBoxTc.Text = "";
            cBoxBrans.Text = "";
            cBoxYetki.Text = "";
        }


        private void calisanSil(string tc)
        {
            try
            {
                baglanti.Open(); //veri tabanını açtık.

                SqlCommand ekle_sorgu = new SqlCommand("DELETE FROM calisan WHERE tcno LIKE '" + tc + "' ", baglanti);
                ekle_sorgu.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kullanıcı başarı ile silindi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                baglanti.Close();
                MessageBox.Show("Kullanıcı Silinemedi","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult uyar;

            uyar = MessageBox.Show(this, tBoxTcSil.Text + " Üye No'lu Kişinin Kaydını Silmek istiyor musunuz?", "SİLME UYARISI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (uyar == DialogResult.Yes)
            {
                calisanSil(tBoxTcSil.Text);
            }
        }
    }
}
