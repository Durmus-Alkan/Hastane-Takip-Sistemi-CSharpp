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

namespace HastaneTakipSon.Formlar.Doktor
{
    public partial class FormDoktorAnaSayfa : MetroFramework.Forms.MetroForm
    {
        public FormDoktorAnaSayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-TRD2I50G\\SQLEXPRESS;Initial Catalog=hastaneTakip;Integrated Security=True");

        public int i = 0;
        private void hastalari_goster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter calisanlari_listele = new SqlDataAdapter("SELECT hasta_no AS[SIRA], hasta_ad AS[AD], hasta_soyad AS[SOYAD], " +
                    "yas AS[YAS] FROM hasta ORDER BY hasta_no ASC", baglanti);

                DataSet dshafiza = new DataSet();
                calisanlari_listele.Fill(dshafiza);
                dgwHastaSiradan.DataSource = dshafiza.Tables[0];
                baglanti.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message, "İnşallah anlatırken karşına çıkmaz kardeşim", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }

        private void hasta_bak()
        {

            
            if (rbtnEvet.Checked)
            {
                hastalari_goster();
                baglanti.Open();
                Tablolar.ITedavi yatak = new Tablolar.YatakHasta
                {
                    ad = hastaAd.Text,
                    soyad = hastaSoyad.Text,
                    sikayet = rtBoxsikayet.Text,
                    teshis = rtBoxTeshis.Text,
                    tetkit = cBoxTetkit.Text,
                    recete = lBoxRecete.Text
                };
                SqlCommand hastam = new SqlCommand("INSERT INTO tedavi (ad," +
                    "soyad, sikayet, teshis, tetkit, recete, yatakHasta) Values (@hastaAd, @hastaSoyad, " +
                    "@sikayet, @teshis, @tetkit," +
                    "@recete, @durum)", baglanti);

                hastam.Parameters.AddWithValue("@hastaAd", yatak.ad);
                hastam.Parameters.AddWithValue("@hastaSoyad", yatak.soyad);
                hastam.Parameters.AddWithValue("@sikayet", yatak.sikayet);
                hastam.Parameters.AddWithValue("@teshis", yatak.teshis);
                hastam.Parameters.AddWithValue("@tetkit", yatak.tetkit);
                hastam.Parameters.AddWithValue("@recete", yatak.recete);
                hastam.Parameters.AddWithValue("@durum", true);

                hastam.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarılı sıradaki hastaya geçebilirsiniz");
            }
            else if (rbtnHayir.Checked)
            {
                hastalari_goster();
                baglanti.Open();
                Tablolar.ITedavi yatak = new Tablolar.YatakHasta
                {
                    ad = hastaAd.Text,
                    soyad = hastaSoyad.Text,
                    sikayet = rtBoxsikayet.Text,
                    teshis = rtBoxTeshis.Text,
                    tetkit = cBoxTetkit.Text,
                    recete = lBoxRecete.Text
                };
                SqlCommand hastam = new SqlCommand("INSERT INTO tedavi (ad," +
                    "soyad, sikayet, teshis, tetkit, recete, yatakHasta) Values (@hastaAd, @hastaSoyad, " +
                    "@sikayet, @teshis, @tetkit," +
                    "@recete, @durum)", baglanti);

                hastam.Parameters.AddWithValue("@hastaAd", yatak.ad);
                hastam.Parameters.AddWithValue("@hastaSoyad", yatak.soyad);
                hastam.Parameters.AddWithValue("@sikayet", yatak.sikayet);
                hastam.Parameters.AddWithValue("@teshis", yatak.teshis);
                hastam.Parameters.AddWithValue("@tetkit", yatak.tetkit);
                hastam.Parameters.AddWithValue("@recete", yatak.recete);
                hastam.Parameters.AddWithValue("@durum", false);

                hastam.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Başarılı sıradaki hastaya geçebilirsiniz");
            }
            
        }
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnHastaCagir_Click(object sender, EventArgs e)
        {
            try
            {
                hastaSira.Text = dgwHastaSiradan.Rows[i].Cells["SIRA"].Value.ToString();
                hastaAd.Text = dgwHastaSiradan.Rows[i].Cells["AD"].Value.ToString();
                hastaSoyad.Text = dgwHastaSiradan.Rows[i].Cells["SOYAD"].Value.ToString();
                hastaYas.Text = dgwHastaSiradan.Rows[i].Cells["YAS"].Value.ToString();
                dgwHastaSiradan.Rows.RemoveAt(0);
                dgwHastaSiradan.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("Hasta Bitti","Tebrikler",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
        }

        private void FormDoktorAnaSayfa_Load(object sender, EventArgs e)
        {
            hastalari_goster();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            hasta_bak();
            MessageBox.Show("Sıradaki Hastaya Geçebilirsiniz."," ",MessageBoxButtons.OK,MessageBoxIcon.None);

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            rtBoxsikayet.Text = "";
            rtBoxTeshis.Text = "";
            cBoxRecete.Text = "";
            lBoxRecete.Text = "";
        }



        private void metroButton1_Click(object sender, EventArgs e)
        {
            lBoxRecete.Items.Add(cBoxRecete.Text);

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Giris.Giris giris = new Giris.Giris();
            this.Hide();
            giris.Show();
        }
    }
}
