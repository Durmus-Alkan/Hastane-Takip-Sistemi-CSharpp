
namespace HastaneTakipSon.Formlar.Eczane
{
    partial class FormEczaneCalisani
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
            this.dgwIlac = new System.Windows.Forms.DataGridView();
            this.tBoxAra = new MetroFramework.Controls.MetroTextBox();
            this.btnAz = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIlacKaydet = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarih = new MetroFramework.Controls.MetroDateTime();
            this.tBoxAdet = new MetroFramework.Controls.MetroTextBox();
            this.tBoxAd = new MetroFramework.Controls.MetroTextBox();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwIlac)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwIlac
            // 
            this.dgwIlac.BackgroundColor = System.Drawing.Color.White;
            this.dgwIlac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwIlac.Location = new System.Drawing.Point(23, 117);
            this.dgwIlac.Name = "dgwIlac";
            this.dgwIlac.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgwIlac.RowHeadersWidth = 51;
            this.dgwIlac.RowTemplate.Height = 24;
            this.dgwIlac.Size = new System.Drawing.Size(474, 223);
            this.dgwIlac.TabIndex = 0;
            // 
            // tBoxAra
            // 
            // 
            // 
            // 
            this.tBoxAra.CustomButton.Image = null;
            this.tBoxAra.CustomButton.Location = new System.Drawing.Point(356, 1);
            this.tBoxAra.CustomButton.Name = "";
            this.tBoxAra.CustomButton.Size = new System.Drawing.Size(43, 43);
            this.tBoxAra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBoxAra.CustomButton.TabIndex = 1;
            this.tBoxAra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBoxAra.CustomButton.UseSelectable = true;
            this.tBoxAra.CustomButton.Visible = false;
            this.tBoxAra.Lines = new string[0];
            this.tBoxAra.Location = new System.Drawing.Point(23, 66);
            this.tBoxAra.MaxLength = 32767;
            this.tBoxAra.Name = "tBoxAra";
            this.tBoxAra.PasswordChar = '\0';
            this.tBoxAra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxAra.SelectedText = "";
            this.tBoxAra.SelectionLength = 0;
            this.tBoxAra.SelectionStart = 0;
            this.tBoxAra.ShortcutsEnabled = true;
            this.tBoxAra.Size = new System.Drawing.Size(400, 45);
            this.tBoxAra.TabIndex = 1;
            this.tBoxAra.UseSelectable = true;
            this.tBoxAra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBoxAra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tBoxAra.TextChanged += new System.EventHandler(this.tBoxAra_TextChanged);
            // 
            // btnAz
            // 
            this.btnAz.Location = new System.Drawing.Point(429, 66);
            this.btnAz.Name = "btnAz";
            this.btnAz.Size = new System.Drawing.Size(68, 45);
            this.btnAz.TabIndex = 2;
            this.btnAz.Text = "Azalanı Göster";
            this.btnAz.UseSelectable = true;
            this.btnAz.Click += new System.EventHandler(this.btnAz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIlacKaydet);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtTarih);
            this.groupBox1.Controls.Add(this.tBoxAdet);
            this.groupBox1.Controls.Add(this.tBoxAd);
            this.groupBox1.Location = new System.Drawing.Point(515, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 274);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İlaç Ekle";
            // 
            // btnIlacKaydet
            // 
            this.btnIlacKaydet.Location = new System.Drawing.Point(74, 221);
            this.btnIlacKaydet.Name = "btnIlacKaydet";
            this.btnIlacKaydet.Size = new System.Drawing.Size(94, 47);
            this.btnIlacKaydet.TabIndex = 6;
            this.btnIlacKaydet.Text = "Kaydet";
            this.btnIlacKaydet.UseSelectable = true;
            this.btnIlacKaydet.Click += new System.EventHandler(this.btnIlacKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Son Kullanma Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlaç Adı";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(29, 179);
            this.dtTarih.MinimumSize = new System.Drawing.Size(0, 30);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(139, 30);
            this.dtTarih.TabIndex = 2;
            // 
            // tBoxAdet
            // 
            // 
            // 
            // 
            this.tBoxAdet.CustomButton.Image = null;
            this.tBoxAdet.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tBoxAdet.CustomButton.Name = "";
            this.tBoxAdet.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tBoxAdet.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBoxAdet.CustomButton.TabIndex = 1;
            this.tBoxAdet.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBoxAdet.CustomButton.UseSelectable = true;
            this.tBoxAdet.CustomButton.Visible = false;
            this.tBoxAdet.Lines = new string[0];
            this.tBoxAdet.Location = new System.Drawing.Point(29, 110);
            this.tBoxAdet.MaxLength = 32767;
            this.tBoxAdet.Name = "tBoxAdet";
            this.tBoxAdet.PasswordChar = '\0';
            this.tBoxAdet.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxAdet.SelectedText = "";
            this.tBoxAdet.SelectionLength = 0;
            this.tBoxAdet.SelectionStart = 0;
            this.tBoxAdet.ShortcutsEnabled = true;
            this.tBoxAdet.Size = new System.Drawing.Size(136, 23);
            this.tBoxAdet.TabIndex = 1;
            this.tBoxAdet.UseSelectable = true;
            this.tBoxAdet.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBoxAdet.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tBoxAd
            // 
            // 
            // 
            // 
            this.tBoxAd.CustomButton.Image = null;
            this.tBoxAd.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.tBoxAd.CustomButton.Name = "";
            this.tBoxAd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tBoxAd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tBoxAd.CustomButton.TabIndex = 1;
            this.tBoxAd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tBoxAd.CustomButton.UseSelectable = true;
            this.tBoxAd.CustomButton.Visible = false;
            this.tBoxAd.Lines = new string[0];
            this.tBoxAd.Location = new System.Drawing.Point(29, 47);
            this.tBoxAd.MaxLength = 32767;
            this.tBoxAd.Name = "tBoxAd";
            this.tBoxAd.PasswordChar = '\0';
            this.tBoxAd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tBoxAd.SelectedText = "";
            this.tBoxAd.SelectionLength = 0;
            this.tBoxAd.SelectionStart = 0;
            this.tBoxAd.ShortcutsEnabled = true;
            this.tBoxAd.Size = new System.Drawing.Size(136, 23);
            this.tBoxAd.TabIndex = 0;
            this.tBoxAd.UseSelectable = true;
            this.tBoxAd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tBoxAd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.LightGray;
            this.btnCikis.Location = new System.Drawing.Point(702, 37);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 13;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FormEczaneCalisani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 377);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAz);
            this.Controls.Add(this.tBoxAra);
            this.Controls.Add(this.dgwIlac);
            this.Name = "FormEczaneCalisani";
            this.Text = "Eczane Çalışanı";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormEczaneCalisani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwIlac)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwIlac;
        private MetroFramework.Controls.MetroTextBox tBoxAra;
        private MetroFramework.Controls.MetroButton btnAz;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroButton btnIlacKaydet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroDateTime dtTarih;
        private MetroFramework.Controls.MetroTextBox tBoxAdet;
        private MetroFramework.Controls.MetroTextBox tBoxAd;
        private System.Windows.Forms.Button btnCikis;
    }
}