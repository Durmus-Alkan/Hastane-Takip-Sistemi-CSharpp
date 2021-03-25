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
    public partial class FormAdminBransGuncelle : MetroFramework.Forms.MetroForm
    {
        public FormAdminBransGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");

        private void kullanicilari_goster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter calisanlari_listele = new SqlDataAdapter("SELECT tcno AS[KİMLİK NUMARASI], ad AS[AD], soyad AS[SOYAD], " +
                    "yetki AS[YETKİ], brans AS[BRANŞ], kullanici_ad AS[KULLANICI ADI], parola AS[PAROLA] FROM Calisan", baglanti);

                DataSet dshafiza = new DataSet();
                calisanlari_listele.Fill(dshafiza);
                dgwKullaniciListesi.DataSource = dshafiza.Tables[0];
                baglanti.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "İnşallah anlatırken karşına çıkmaz kardeşim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void FormAdminBransGuncelle_Load(object sender, EventArgs e)
        {
            kullanicilari_goster();
        }
        private void dgwKullaniciListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            tBoxTc.Text = dgwKullaniciListesi.Rows[e.RowIndex].Cells[0].Value.ToString(); //[0] sütun numarası
            tBoxAd.Text = dgwKullaniciListesi.CurrentRow.Cells[1].Value.ToString(); //[0] sütun numarası
            tBoxSoyad.Text = dgwKullaniciListesi.CurrentRow.Cells[2].Value.ToString(); //[0] sütun numarası
            cBoxYetki.Text = dgwKullaniciListesi.CurrentRow.Cells[3].Value.ToString(); //[0] sütun numarası
            tBoxKullaniciAdi.Text = dgwKullaniciListesi.CurrentRow.Cells[5].Value.ToString(); //[0] sütun numarası
            tBoxParola.Text = dgwKullaniciListesi.CurrentRow.Cells[6].Value.ToString(); //[0] sütun numarası
            cBoxBrans.Text = dgwKullaniciListesi.CurrentRow.Cells[4].Value.ToString(); //[0] sütun numarası
        }

        private void update()
        {
            string tc, adi, soy, yetkim, bransi, k_ad, parolaa;
            tc = tBoxTc.Text;
            adi = tBoxAd.Text;
            soy = tBoxSoyad.Text;
            yetkim = cBoxYetki.Text;
            bransi = cBoxBrans.Text;
            k_ad = tBoxKullaniciAdi.Text;
            parolaa = tBoxParola.Text;
            baglanti.Open();
            SqlCommand calisanGuncelle = new SqlCommand("UPDATE Calisan SET(brans = 'KBB') WHERE tcno ='" + @tc+ "'", baglanti);


            calisanGuncelle.Parameters.AddWithValue("@tc", tc);

            calisanGuncelle.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            update();
            kullanicilari_goster();
        }

       
    }
}
