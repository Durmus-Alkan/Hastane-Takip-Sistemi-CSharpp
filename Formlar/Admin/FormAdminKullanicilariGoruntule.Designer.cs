
namespace HastaneTakipSon.Formlar.Admin
{
    partial class FormAdminKullanicilariGoruntule
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
            this.dgwKullanicilar = new System.Windows.Forms.DataGridView();
            this.btnAdmin = new MetroFramework.Controls.MetroButton();
            this.btnDoktor = new MetroFramework.Controls.MetroButton();
            this.btnHemsire = new MetroFramework.Controls.MetroButton();
            this.btnSekreter = new MetroFramework.Controls.MetroButton();
            this.btnEczane = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwKullanicilar
            // 
            this.dgwKullanicilar.BackgroundColor = System.Drawing.Color.White;
            this.dgwKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKullanicilar.Location = new System.Drawing.Point(23, 192);
            this.dgwKullanicilar.Name = "dgwKullanicilar";
            this.dgwKullanicilar.RowHeadersWidth = 51;
            this.dgwKullanicilar.RowTemplate.Height = 24;
            this.dgwKullanicilar.Size = new System.Drawing.Size(983, 325);
            this.dgwKullanicilar.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(92, 120);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(134, 56);
            this.btnAdmin.TabIndex = 1;
            this.btnAdmin.Text = "ADMİN GÖRÜNTÜLE";
            this.btnAdmin.UseSelectable = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnDoktor
            // 
            this.btnDoktor.Location = new System.Drawing.Point(255, 120);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(136, 56);
            this.btnDoktor.TabIndex = 2;
            this.btnDoktor.Text = "DOKTOR GÖRÜNTÜLE";
            this.btnDoktor.UseSelectable = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnHemsire
            // 
            this.btnHemsire.Location = new System.Drawing.Point(427, 120);
            this.btnHemsire.Name = "btnHemsire";
            this.btnHemsire.Size = new System.Drawing.Size(138, 56);
            this.btnHemsire.TabIndex = 4;
            this.btnHemsire.Text = "HEMŞİRE GÖRÜNTÜLE";
            this.btnHemsire.UseSelectable = true;
            this.btnHemsire.Click += new System.EventHandler(this.btnHemsire_Click);
            // 
            // btnSekreter
            // 
            this.btnSekreter.Location = new System.Drawing.Point(607, 120);
            this.btnSekreter.Name = "btnSekreter";
            this.btnSekreter.Size = new System.Drawing.Size(146, 56);
            this.btnSekreter.TabIndex = 3;
            this.btnSekreter.Text = "SEKRETER GÖRÜNTÜLE";
            this.btnSekreter.UseSelectable = true;
            this.btnSekreter.Click += new System.EventHandler(this.btnSekreter_Click);
            // 
            // btnEczane
            // 
            this.btnEczane.Location = new System.Drawing.Point(786, 120);
            this.btnEczane.Name = "btnEczane";
            this.btnEczane.Size = new System.Drawing.Size(128, 56);
            this.btnEczane.TabIndex = 5;
            this.btnEczane.Text = "ECZANE ÇALIŞANI";
            this.btnEczane.UseSelectable = true;
            this.btnEczane.Click += new System.EventHandler(this.btnEczane_Click);
            // 
            // FormAdminKullanicilariGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 547);
            this.Controls.Add(this.btnEczane);
            this.Controls.Add(this.btnHemsire);
            this.Controls.Add(this.btnSekreter);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.dgwKullanicilar);
            this.Name = "FormAdminKullanicilariGoruntule";
            this.Text = "Hastane Takip Otomasyonu";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormAdminKullanicilariGoruntule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwKullanicilar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwKullanicilar;
        private MetroFramework.Controls.MetroButton btnAdmin;
        private MetroFramework.Controls.MetroButton btnDoktor;
        private MetroFramework.Controls.MetroButton btnHemsire;
        private MetroFramework.Controls.MetroButton btnSekreter;
        private MetroFramework.Controls.MetroButton btnEczane;
    }
}