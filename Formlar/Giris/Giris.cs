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

namespace HastaneTakipSon.Formlar.Giris
{
    public partial class Giris : MetroFramework.Forms.MetroForm
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");
        public static string tcno, ad, soyad, yetki, brans; //Tüm formlarda işe yarayacak değişkenler

        private void Giris_Load(object sender, EventArgs e)
        {
            // Style
            this.AcceptButton = btnGiris; //Enter'a basınca giriş butonu çalışacak.
            this.CancelButton = btnTemizle; //ESC'ye basınca iptal butonu çalışacak.
            this.StartPosition = FormStartPosition.CenterScreen; //Uygulama açıldığında ortada açılacak.
            
            // Style

        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open(); //veri tabanını açtık.
            SqlCommand kontrolSorgu = new SqlCommand("SELECT * FROM dbo.calisan", baglanti); //Veri tabanında sorgu işlemi yaptık
            SqlDataReader veri_oku = kontrolSorgu.ExecuteReader(); //Sorgunun sonuçlarının SqlDataReader'da sakladık.
            while (veri_oku.Read()) // Veri tabanında bir bilgiye rastlandıysa şunları yap
            {
                if (cBoxYetki.Text == "Admin")
                {
                    if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                    {
                        tcno = veri_oku.GetValue(0).ToString();
                        ad = veri_oku.GetValue(1).ToString();
                        soyad = veri_oku.GetValue(2).ToString();
                        yetki = veri_oku.GetValue(3).ToString();
                        brans = veri_oku.GetValue(6).ToString();
                        this.Hide();
                        Admin.FormAdminAnaSayfa formAdminAnaSayfa = new Admin.FormAdminAnaSayfa();
                        formAdminAnaSayfa.Show();
                        break;
                    }
                }
                else if (cBoxYetki.Text == "Doktor")
                {
                    if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                    {
                        if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                        {
                            tcno = veri_oku.GetValue(0).ToString();
                            ad = veri_oku.GetValue(1).ToString();
                            soyad = veri_oku.GetValue(2).ToString();
                            yetki = veri_oku.GetValue(3).ToString();
                            brans = veri_oku.GetValue(6).ToString();
                            this.Hide();
                            Doktor.FormDoktorAnaSayfa formDoktorAnaSayfa = new Doktor.FormDoktorAnaSayfa();
                            formDoktorAnaSayfa.Show();
                            break;
                        }
                    }
                }
                else if (cBoxYetki.Text == "Hemşire")
                {
                    if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                    {
                        if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                        {
                            tcno = veri_oku.GetValue(0).ToString();
                            ad = veri_oku.GetValue(1).ToString();
                            soyad = veri_oku.GetValue(2).ToString();
                            yetki = veri_oku.GetValue(3).ToString();
                            brans = veri_oku.GetValue(6).ToString();
                            this.Hide();
                            Hemsire.FormHemsireAnaSayfa formHemsireAnaSayfa = new Hemsire.FormHemsireAnaSayfa();
                            formHemsireAnaSayfa.Show();
                            break;
                        }
                    }
                }
                else if (cBoxYetki.Text == "Sekreter")
                {
                    //koşullar bununla ibaret değil buraya devamını yaz
                    if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                    {
                        tcno = veri_oku.GetValue(0).ToString();
                        ad = veri_oku.GetValue(1).ToString();
                        soyad = veri_oku.GetValue(2).ToString();
                        yetki = veri_oku.GetValue(3).ToString();
                        brans = veri_oku.GetValue(6).ToString();
                        this.Hide();
                        Sekreter.FormSekreterAnaSayfa formSekreterAnaSayfa = new Sekreter.FormSekreterAnaSayfa();
                        formSekreterAnaSayfa.Show();
                        break;
                    }


                }
                else if (cBoxYetki.Text == "Eczane")
                {
                    if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                    {
                        if (veri_oku["kullanici_ad"].ToString() == tBoxAd.Text && veri_oku["parola"].ToString() == tBoxParola.Text && veri_oku["yetki"].ToString() == cBoxYetki.Text)
                        {
                            tcno = veri_oku.GetValue(0).ToString();
                            ad = veri_oku.GetValue(1).ToString();
                            soyad = veri_oku.GetValue(2).ToString();
                            yetki = veri_oku.GetValue(3).ToString();
                            brans = veri_oku.GetValue(6).ToString();
                            this.Hide();
                            Eczane.FormEczaneCalisani formEczaneCalisani = new Eczane.FormEczaneCalisani();
                            formEczaneCalisani.Show();
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Böyle bir branş bulunmamaktadır.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }


            baglanti.Close();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            tBoxAd.Text = "";
            tBoxParola.Text = "";
            cBoxYetki.Text = "";
        }
    }
}
