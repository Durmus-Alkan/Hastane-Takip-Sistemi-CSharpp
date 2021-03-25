using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneTakipSon.Formlar.Admin
{
    public partial class FormAdminAnaSayfa : MetroFramework.Forms.MetroForm
    {
        public FormAdminAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnKullaniciEkleSil_Click(object sender, EventArgs e)
        {
            FormAdminEkleSil formAdminEkleSil = new FormAdminEkleSil();
            formAdminEkleSil.Show();
        }

        private void FormAdminAnaSayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKullaniciGoruntule_Click(object sender, EventArgs e)
        {
            FormAdminKullanicilariGoruntule formAdminKullanicilariGoruntule = new FormAdminKullanicilariGoruntule();
            formAdminKullanicilariGoruntule.Show();
        }

        private void btnBransDegistir_Click(object sender, EventArgs e)
        {
            FormAdminBransGuncelle formAdminBransGuncelle = new FormAdminBransGuncelle();
            formAdminBransGuncelle.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Giris.Giris giris = new Giris.Giris();
            this.Hide();
            giris.Show();
        }
    }
}
