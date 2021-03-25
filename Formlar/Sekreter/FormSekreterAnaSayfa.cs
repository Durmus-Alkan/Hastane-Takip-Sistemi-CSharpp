using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneTakipSon.Formlar.Sekreter
{
    public partial class FormSekreterAnaSayfa : MetroFramework.Forms.MetroForm
    {
        public FormSekreterAnaSayfa()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            FormSekreterHastaKayit formSekreterHastaKayit = new FormSekreterHastaKayit();
            formSekreterHastaKayit.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Giris.Giris giris = new Giris.Giris();
            this.Hide();
            giris.Show();
        }
    }
}
