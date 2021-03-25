
namespace HastaneTakipSon.Formlar.Admin
{
    partial class FormAdminEkleSil
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
            this.tabCAdmin = new System.Windows.Forms.TabControl();
            this.tabPKullaniciKayit = new System.Windows.Forms.TabPage();
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
            this.tabPSil = new System.Windows.Forms.TabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnVazgec = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.tBoxTcSil = new MetroFramework.Controls.MetroTextBox();
            this.tabCAdmin.SuspendLayout();
            this.tabPKullaniciKayit.SuspendLayout();
            this.tabPSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCAdmin
            // 
            this.tabCAdmin.Controls.Add(this.tabPKullaniciKayit);
            this.tabCAdmin.Controls.Add(this.tabPSil);
            this.tabCAdmin.Location = new System.Drawing.Point(8, 63);
            this.tabCAdmin.Name = "tabCAdmin";
            this.tabCAdmin.SelectedIndex = 0;
            this.tabCAdmin.Size = new System.Drawing.Size(667, 378);
            this.tabCAdmin.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCAdmin.TabIndex = 1;
            // 
            // tabPKullaniciKayit
            // 
            this.tabPKullaniciKayit.Controls.Add(this.cBoxBrans);
            this.tabPKullaniciKayit.Controls.Add(this.tBoxParola);
            this.tabPKullaniciKayit.Controls.Add(this.tBoxKullaniciAdi);
            this.tabPKullaniciKayit.Controls.Add(this.cBoxYetki);
            this.tabPKullaniciKayit.Controls.Add(this.tBoxSoyad);
            this.tabPKullaniciKayit.Controls.Add(this.tBoxAd);
            this.tabPKullaniciKayit.Controls.Add(this.tBoxTc);
            this.tabPKullaniciKayit.Controls.Add(this.btnIptal);
            this.tabPKullaniciKayit.Controls.Add(this.btnKaydet);
            this.tabPKullaniciKayit.Controls.Add(this.label7);
            this.tabPKullaniciKayit.Controls.Add(this.label6);
            this.tabPKullaniciKayit.Controls.Add(this.label5);
            this.tabPKullaniciKayit.Controls.Add(this.label4);
            this.tabPKullaniciKayit.Controls.Add(this.label3);
            this.tabPKullaniciKayit.Controls.Add(this.label2);
            this.tabPKullaniciKayit.Controls.Add(this.label1);
            this.tabPKullaniciKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPKullaniciKayit.Location = new System.Drawing.Point(4, 25);
            this.tabPKullaniciKayit.Name = "tabPKullaniciKayit";
            this.tabPKullaniciKayit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPKullaniciKayit.Size = new System.Drawing.Size(659, 349);
            this.tabPKullaniciKayit.TabIndex = 0;
            this.tabPKullaniciKayit.Text = "Kullanıcı Kayıt";
            this.tabPKullaniciKayit.UseVisualStyleBackColor = true;
            // 
            // cBoxBrans
            // 
            this.cBoxBrans.FormattingEnabled = true;
            this.cBoxBrans.Location = new System.Drawing.Point(488, 134);
            this.cBoxBrans.Name = "cBoxBrans";
            this.cBoxBrans.Size = new System.Drawing.Size(121, 26);
            this.cBoxBrans.TabIndex = 15;
            // 
            // tBoxParola
            // 
            this.tBoxParola.Location = new System.Drawing.Point(488, 101);
            this.tBoxParola.Name = "tBoxParola";
            this.tBoxParola.Size = new System.Drawing.Size(121, 24);
            this.tBoxParola.TabIndex = 14;
            // 
            // tBoxKullaniciAdi
            // 
            this.tBoxKullaniciAdi.Location = new System.Drawing.Point(488, 60);
            this.tBoxKullaniciAdi.Name = "tBoxKullaniciAdi";
            this.tBoxKullaniciAdi.Size = new System.Drawing.Size(121, 24);
            this.tBoxKullaniciAdi.TabIndex = 13;
            // 
            // cBoxYetki
            // 
            this.cBoxYetki.FormattingEnabled = true;
            this.cBoxYetki.Items.AddRange(new object[] {
            "Doktor",
            "Hemşire",
            "Sekreter",
            "Eczane"});
            this.cBoxYetki.Location = new System.Drawing.Point(148, 176);
            this.cBoxYetki.Name = "cBoxYetki";
            this.cBoxYetki.Size = new System.Drawing.Size(121, 26);
            this.cBoxYetki.TabIndex = 12;
            // 
            // tBoxSoyad
            // 
            this.tBoxSoyad.Location = new System.Drawing.Point(148, 136);
            this.tBoxSoyad.Name = "tBoxSoyad";
            this.tBoxSoyad.Size = new System.Drawing.Size(121, 24);
            this.tBoxSoyad.TabIndex = 11;
            // 
            // tBoxAd
            // 
            this.tBoxAd.Location = new System.Drawing.Point(148, 100);
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.Size = new System.Drawing.Size(121, 24);
            this.tBoxAd.TabIndex = 10;
            // 
            // tBoxTc
            // 
            this.tBoxTc.Location = new System.Drawing.Point(148, 60);
            this.tBoxTc.Name = "tBoxTc";
            this.tBoxTc.Size = new System.Drawing.Size(121, 24);
            this.tBoxTc.TabIndex = 9;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(446, 238);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(95, 50);
            this.btnIptal.TabIndex = 8;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(314, 238);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 50);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Branş";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Parola";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Yetki";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soayd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kimlik no";
            // 
            // tabPSil
            // 
            this.tabPSil.Controls.Add(this.metroLabel1);
            this.tabPSil.Controls.Add(this.btnVazgec);
            this.tabPSil.Controls.Add(this.btnDelete);
            this.tabPSil.Controls.Add(this.tBoxTcSil);
            this.tabPSil.Location = new System.Drawing.Point(4, 25);
            this.tabPSil.Name = "tabPSil";
            this.tabPSil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPSil.Size = new System.Drawing.Size(659, 349);
            this.tabPSil.TabIndex = 1;
            this.tabPSil.Text = "Kayıt Sil";
            this.tabPSil.UseVisualStyleBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.DarkRed;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroLabel1.Location = new System.Drawing.Point(155, 49);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(321, 20);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Silmek istediğiniz çalışanın kimlik numarasını giriniz";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Location = new System.Drawing.Point(303, 154);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(100, 53);
            this.btnVazgec.TabIndex = 2;
            this.btnVazgec.Text = "Vazgeç";
            this.btnVazgec.UseSelectable = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Lime;
            this.btnDelete.Location = new System.Drawing.Point(186, 154);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 53);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Çalışanı Sil";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tBoxTcSil
            // 
            // 
            // 
            // 
            this.tBoxTcSil.CustomButton.Image = null;
            this.tBoxTcSil.CustomButton.Location = new System.Drawing.Point(189, 2);
            this.tBoxTcSil.CustomButton.Name = "";
            this.tBoxTcSil.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tBoxTcSil.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBoxTcSil.CustomButton.TabIndex = 1;
            this.tBoxTcSil.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBoxTcSil.CustomButton.UseSelectable = true;
            this.tBoxTcSil.CustomButton.Visible = false;
            this.tBoxTcSil.Lines = new string[0];
            this.tBoxTcSil.Location = new System.Drawing.Point(186, 85);
            this.tBoxTcSil.MaxLength = 32767;
            this.tBoxTcSil.Name = "tBoxTcSil";
            this.tBoxTcSil.PasswordChar = '\0';
            this.tBoxTcSil.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxTcSil.SelectedText = "";
            this.tBoxTcSil.SelectionLength = 0;
            this.tBoxTcSil.SelectionStart = 0;
            this.tBoxTcSil.ShortcutsEnabled = true;
            this.tBoxTcSil.Size = new System.Drawing.Size(217, 30);
            this.tBoxTcSil.TabIndex = 0;
            this.tBoxTcSil.UseSelectable = true;
            this.tBoxTcSil.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBoxTcSil.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FormAdminEkleSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 463);
            this.Controls.Add(this.tabCAdmin);
            this.Name = "FormAdminEkleSil";
            this.Text = "Hastane Takip Otomasyonu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.tabCAdmin.ResumeLayout(false);
            this.tabPKullaniciKayit.ResumeLayout(false);
            this.tabPKullaniciKayit.PerformLayout();
            this.tabPSil.ResumeLayout(false);
            this.tabPSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCAdmin;
        private System.Windows.Forms.TabPage tabPKullaniciKayit;
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
        private System.Windows.Forms.TabPage tabPSil;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnVazgec;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroTextBox tBoxTcSil;
    }
}