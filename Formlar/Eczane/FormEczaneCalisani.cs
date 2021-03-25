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

namespace HastaneTakipSon.Formlar.Eczane
{
    public partial class FormEczaneCalisani : MetroFramework.Forms.MetroForm
    {
        public FormEczaneCalisani()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");

        private void ilaclariGoster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter calisanlari_listele = new SqlDataAdapter("SELECT ad AS[İLAC ADI], adet AS[ADET], skt AS[SON KULLANMA TARİHİ] FROM ilac", baglanti);


                DataSet dshafiza = new DataSet();
                calisanlari_listele.Fill(dshafiza);
                dgwIlac.DataSource = dshafiza.Tables[0];
                baglanti.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "İnşallah anlatırken karşına çıkmaz kardeşim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void FormEczaneCalisani_Load(object sender, EventArgs e)
        {
            ilaclariGoster();
        }
        private void tBoxAra_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT ad AS[İLAC ADI], adet AS[ADET], skt AS[SON KULLANMA TARİHİ] FROM ilac where ad like '" + tBoxAra.Text + "%'", baglanti);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dgwIlac.DataSource = dt;
            baglanti.Close();


        }
        private void btnAz_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter calisanlari_listele = new SqlDataAdapter("SELECT ad AS[İLAC ADI], adet AS[ADET], skt AS[SON KULLANMA TARİHİ] FROM ilac WHERE adet < 20", baglanti);


            DataSet dshafiza = new DataSet();
            calisanlari_listele.Fill(dshafiza);
            dgwIlac.DataSource = dshafiza.Tables[0];
            baglanti.Close();
        }

        private void btnIlacKaydet_Click(object sender, EventArgs e)
        {
            Tablolar.Ilac ilac = new Tablolar.Ilac
            {
                ilacad = tBoxAd.Text,
                adet = Convert.ToInt32(tBoxAdet.Text),
                skt = dtTarih.Value

            };

            //try
            //{
                baglanti.Open();
                SqlCommand ilac_ekle_sorgu = new SqlCommand("INSERT INTO ilac (ad, adet, skt)" +
                    "VALUES(@ilacad, @adet, @skt)", baglanti);

                ilac_ekle_sorgu.Parameters.AddWithValue("@ilacad", ilac.ilacad);
                ilac_ekle_sorgu.Parameters.AddWithValue("@adet", ilac.adet);
                ilac_ekle_sorgu.Parameters.AddWithValue("@skt", ilac.skt);

                ilac_ekle_sorgu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ekleme İşlemi Başarılı","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
            //catch (Exception)
            //{
            //    baglanti.Close();
            //    MessageBox.Show("Ekleme İşlemi Başarısız", "", MessageBoxButtons.OK, MessageBoxIcon.Err);
            //}
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Giris.Giris giris = new Giris.Giris();
            this.Hide();
            giris.Show();
        }
    }
}
