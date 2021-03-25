
namespace HastaneTakipSon.Formlar.Admin
{
    partial class FormAdminBransGuncelle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwKullaniciListesi = new System.Windows.Forms.DataGridView();
            this.cBoxBrans = new System.Windows.Forms.ComboBox();
            this.tBoxParola = new System.Windows.Forms.TextBox();
            this.tBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.cBoxYetki = new System.Windows.Forms.ComboBox();
            this.tBoxSoyad = new System.Windows.Forms.TextBox();
            this.tBoxAd = new System.Windows.Forms.TextBox();
            this.tBoxTc = new System.Windows.Forms.TextBox();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullaniciListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKullaniciListesi
            // 
            this.dgwKullaniciListesi.BackgroundColor = System.Drawing.Color.White;
            this.dgwKullaniciListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullaniciListesi.Location = new System.Drawing.Point(39, 341);
            this.dgwKullaniciListesi.Name = "dgwKullaniciListesi";
            this.dgwKullaniciListesi.RowHeadersWidth = 51;
            this.dgwKullaniciListesi.RowTemplate.Height = 24;
            this.dgwKullaniciListesi.Size = new System.Drawing.Size(712, 251);
            this.dgwKullaniciListesi.TabIndex = 49;
            this.dgwKullaniciListesi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKullaniciListesi_CellClick);
            // 
            // cBoxBrans
            // 
            this.cBoxBrans.FormattingEnabled = true;
            this.cBoxBrans.Location = new System.Drawing.Point(498, 162);
            this.cBoxBrans.Name = "cBoxBrans";
            this.cBoxBrans.Size = new System.Drawing.Size(121, 24);
            this.cBoxBrans.TabIndex = 48;
            // 
            // tBoxParola
            // 
            this.tBoxParola.Location = new System.Drawing.Point(498, 129);
            this.tBoxParola.Name = "tBoxParola";
            this.tBoxParola.Size = new System.Drawing.Size(121, 22);
            this.tBoxParola.TabIndex = 47;
            // 
            // tBoxKullaniciAdi
            // 
            this.tBoxKullaniciAdi.Location = new System.Drawing.Point(498, 88);
            this.tBoxKullaniciAdi.Name = "tBoxKullaniciAdi";
            this.tBoxKullaniciAdi.Size = new System.Drawing.Size(121, 22);
            this.tBoxKullaniciAdi.TabIndex = 46;
            // 
            // cBoxYetki
            // 
            this.cBoxYetki.FormattingEnabled = true;
            this.cBoxYetki.Items.AddRange(new object[] {
            "Doktor",
            "Hemsire",
            "Sekreter",
            "Eczane"});
            this.cBoxYetki.Location = new System.Drawing.Point(158, 204);
            this.cBoxYetki.Name = "cBoxYetki";
            this.cBoxYetki.Size = new System.Drawing.Size(121, 24);
            this.cBoxYetki.TabIndex = 45;
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(158, 164);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(121, 22);
            this.tBoxSoyad.TabIndex = 44;
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(158, 128);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(121, 22);
            this.tBoxAd.TabIndex = 43;
            // 
            // tBoxTc
            // 
            this.tBoxTc.Location = new System.Drawing.Point(158, 88);
            this.tBoxTc.Name = "tBoxTc";
            this.tBoxTc.Size = new System.Drawing.Size(121, 22);
            this.tBoxTc.TabIndex = 42;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(509, 249);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 50);
            this.btnIptal.TabIndex = 41;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(377, 249);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 50);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 39;
            this.label7.Text = "Branş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Parola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Yetki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Soayd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Kimlik no";
            // 
            // FormAdminBransGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 607);
            this.Controls.Add(this.dgwKullaniciListesi);
            this.Controls.Add(this.cBoxBrans);
            this.Controls.Add(this.tBoxParola);
            this.Controls.Add(this.tBoxKullaniciAdi);
            this.Controls.Add(this.cBoxYetki);
            this.Controls.Add(this.tBoxSoyad);
            this.Controls.Add(this.tBoxAd);
            this.Controls.Add(this.tBoxTc);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAdminBransGuncelle";
            this.Text = "Branş Güncelle";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormAdminBransGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullaniciListesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKullaniciListesi;
        private System.Windows.Forms.ComboBox cBoxBrans;
        private System.Windows.Forms.TextBox tBoxParola;
        private System.Windows.Forms.TextBox tBoxKullaniciAdi;
        private System.Windows.Forms.ComboBox cBoxYetki;
        private System.Windows.Forms.TextBox tBoxSoyad;
        private System.Windows.Forms.TextBox tBoxAd;
        private System.Windows.Forms.TextBox tBoxTc;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}