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
    public partial class FormAdminKullanicilariGoruntule : MetroFramework.Forms.MetroForm
    {
        public FormAdminKullanicilariGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");

        private void kullanicilari_goster(String yetkim)
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter calisanlari_listele = new SqlDataAdapter("SELECT tcno AS[KİMLİK NUMARASI], ad AS[AD], soyad AS[SOYAD], " +
                    "yetki AS[YETKİ], brans AS[BRANŞ], kullanici_ad AS[KULLANICI ADI], parola AS[PAROLA] FROM Calisan WHERE yetki LIKE  @yetkim", baglanti);

                calisanlari_listele.SelectCommand.Parameters.AddWithValue("@yetkim", yetkim);
                DataSet dshafiza = new DataSet();
                calisanlari_listele.Fill(dshafiza);
                dgwKullanicilar.DataSource = dshafiza.Tables[0];
                baglanti.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "İnşallah anlatırken karşına çıkmaz kardeşim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void tamami_goster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter calisanlari_listele = new SqlDataAdapter("SELECT tcno AS[KİMLİK NUMARASI], ad AS[AD], soyad AS[SOYAD], " +
                    "yetki AS[YETKİ], brans AS[BRANŞ], kullanici_ad AS[KULLANICI ADI], parola AS[PAROLA] FROM Calisan", baglanti);


                DataSet dshafiza = new DataSet();
                calisanlari_listele.Fill(dshafiza);
                dgwKullanicilar.DataSource = dshafiza.Tables[0];
                baglanti.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "İnşallah anlatırken karşına çıkmaz kardeşim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void FormAdminKullanicilariGoruntule_Load(object sender, EventArgs e)
        {
            tamami_goster();
        }

        
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            kullanicilari_goster("Admin");
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            kullanicilari_goster("Doktor");

        }

        private void btnHemsire_Click(object sender, EventArgs e)
        {
            kullanicilari_goster("Hemsire");
        }

        private void btnSekreter_Click(object sender, EventArgs e)
        {
            kullanicilari_goster("Sekreter");
        }

        private void btnEczane_Click(object sender, EventArgs e)
        {
            kullanicilari_goster("Eczane");
        }
    }
}
