
namespace HastaneTakipSon.Formlar.Doktor
{
    partial class FormDoktorAnaSayfa
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
            this.dgwHastaSiradan = new System.Windows.Forms.DataGridView();
            this.btnHastaCagir = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rtBoxsikayet = new System.Windows.Forms.RichTextBox();
            this.rtBoxTeshis = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.rbtnEvet = new MetroFramework.Controls.MetroRadioButton();
            this.rbtnHayir = new MetroFramework.Controls.MetroRadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cBoxTetkit = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cBoxRecete = new System.Windows.Forms.ComboBox();
            this.lBoxRecete = new System.Windows.Forms.ListBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.btnKaydet = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.hastaYas = new MetroFramework.Controls.MetroLabel();
            this.hastaSoyad = new MetroFramework.Controls.MetroLabel();
            this.hastaAd = new MetroFramework.Controls.MetroLabel();
            this.hastaSira = new MetroFramework.Controls.MetroLabel();
            this.btnCikis = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaSiradan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwHastaSiradan
            // 
            this.dgwHastaSiradan.BackgroundColor = System.Drawing.Color.White;
            this.dgwHastaSiradan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwHastaSiradan.Location = new System.Drawing.Point(24, 90);
            this.dgwHastaSiradan.Name = "dgwHastaSiradan";
            this.dgwHastaSiradan.RowHeadersWidth = 51;
            this.dgwHastaSiradan.RowTemplate.Height = 24;
            this.dgwHastaSiradan.Size = new System.Drawing.Size(694, 78);
            this.dgwHastaSiradan.TabIndex = 0;
            // 
            // btnHastaCagir
            // 
            this.btnHastaCagir.Location = new System.Drawing.Point(724, 152);
            this.btnHastaCagir.Name = "btnHastaCagir";
            this.btnHastaCagir.Size = new System.Drawing.Size(105, 52);
            this.btnHastaCagir.TabIndex = 1;
            this.btnHastaCagir.Text = "Hasta Çağır";
            this.btnHastaCagir.UseSelectable = true;
            this.btnHastaCagir.Click += new System.EventHandler(this.btnHastaCagir_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(57, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ŞİKAYET";
            // 
            // rtBoxsikayet
            // 
            this.rtBoxsikayet.Location = new System.Drawing.Point(6, 43);
            this.rtBoxsikayet.Name = "rtBoxsikayet";
            this.rtBoxsikayet.Size = new System.Drawing.Size(186, 197);
            this.rtBoxsikayet.TabIndex = 3;
            this.rtBoxsikayet.Text = "";
            // 
            // rtBoxTeshis
            // 
            this.rtBoxTeshis.Location = new System.Drawing.Point(215, 43);
            this.rtBoxTeshis.Name = "rtBoxTeshis";
            this.rtBoxTeshis.Size = new System.Drawing.Size(186, 197);
            this.rtBoxTeshis.TabIndex = 4;
            this.rtBoxTeshis.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(281, 20);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Teşhis";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(6, 18);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(163, 25);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Yataklı Hasta (E / H)";
            // 
            // rbtnEvet
            // 
            this.rbtnEvet.AutoSize = true;
            this.rbtnEvet.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbtnEvet.Location = new System.Drawing.Point(198, 15);
            this.rbtnEvet.Name = "rbtnEvet";
            this.rbtnEvet.Size = new System.Drawing.Size(38, 25);
            this.rbtnEvet.TabIndex = 9;
            this.rbtnEvet.Text = "E";
            this.rbtnEvet.UseSelectable = true;
            // 
            // rbtnHayir
            // 
            this.rbtnHayir.AutoSize = true;
            this.rbtnHayir.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rbtnHayir.Location = new System.Drawing.Point(253, 15);
            this.rbtnHayir.Name = "rbtnHayir";
            this.rbtnHayir.Size = new System.Drawing.Size(41, 25);
            this.rbtnHayir.TabIndex = 10;
            this.rbtnHayir.Text = "H";
            this.rbtnHayir.UseSelectable = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.rbtnHayir);
            this.groupBox1.Controls.Add(this.rbtnEvet);
            this.groupBox1.Location = new System.Drawing.Point(456, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.rtBoxsikayet);
            this.groupBox2.Controls.Add(this.rtBoxTeshis);
            this.groupBox2.Location = new System.Drawing.Point(28, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 258);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBoxTetkit);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Location = new System.Drawing.Point(462, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 53);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // cBoxTetkit
            // 
            this.cBoxTetkit.FormattingEnabled = true;
            this.cBoxTetkit.ItemHeight = 24;
            this.cBoxTetkit.Items.AddRange(new object[] {
            "Kan",
            "Gaita",
            "İdrar"});
            this.cBoxTetkit.Location = new System.Drawing.Point(136, 13);
            this.cBoxTetkit.Name = "cBoxTetkit";
            this.cBoxTetkit.Size = new System.Drawing.Size(121, 30);
            this.cBoxTetkit.TabIndex = 8;
            this.cBoxTetkit.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(6, 18);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Tetkik İstemi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.metroButton1);
            this.groupBox4.Controls.Add(this.cBoxRecete);
            this.groupBox4.Controls.Add(this.lBoxRecete);
            this.groupBox4.Controls.Add(this.metroLabel3);
            this.groupBox4.Location = new System.Drawing.Point(462, 409);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 140);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(265, 14);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(32, 23);
            this.metroButton1.TabIndex = 17;
            this.metroButton1.Text = "E";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cBoxRecete
            // 
            this.cBoxRecete.FormattingEnabled = true;
            this.cBoxRecete.Items.AddRange(new object[] {
            "Parol",
            "Majezik",
            "Afinitor",
            "Arzerra",
            "Azarga",
            "Certican",
            "Ciloxan",
            "Aspirin",
            "Koraspirin",
            "Diovan",
            "Exelon",
            "Exjade",
            "Foradil"});
            this.cBoxRecete.Location = new System.Drawing.Point(136, 14);
            this.cBoxRecete.Name = "cBoxRecete";
            this.cBoxRecete.Size = new System.Drawing.Size(121, 24);
            this.cBoxRecete.TabIndex = 16;
            // 
            // lBoxRecete
            // 
            this.lBoxRecete.FormattingEnabled = true;
            this.lBoxRecete.ItemHeight = 16;
            this.lBoxRecete.Location = new System.Drawing.Point(6, 50);
            this.lBoxRecete.Name = "lBoxRecete";
            this.lBoxRecete.Size = new System.Drawing.Size(283, 84);
            this.lBoxRecete.TabIndex = 15;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(6, 14);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Reçete";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(338, 570);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(105, 52);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseSelectable = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(456, 570);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(105, 52);
            this.metroButton2.TabIndex = 15;
            this.metroButton2.Text = "İptal";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.hastaYas);
            this.groupBox5.Controls.Add(this.hastaSoyad);
            this.groupBox5.Controls.Add(this.hastaAd);
            this.groupBox5.Controls.Add(this.hastaSira);
            this.groupBox5.Location = new System.Drawing.Point(20, 174);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(698, 96);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sıradaki Hasta";
            // 
            // hastaYas
            // 
            this.hastaYas.AutoSize = true;
            this.hastaYas.Location = new System.Drawing.Point(462, 38);
            this.hastaYas.Name = "hastaYas";
            this.hastaYas.Size = new System.Drawing.Size(79, 20);
            this.hastaYas.TabIndex = 3;
            this.hastaYas.Text = "HASTA YAŞI";
            // 
            // hastaSoyad
            // 
            this.hastaSoyad.AutoSize = true;
            this.hastaSoyad.Location = new System.Drawing.Point(304, 38);
            this.hastaSoyad.Name = "hastaSoyad";
            this.hastaSoyad.Size = new System.Drawing.Size(100, 20);
            this.hastaSoyad.TabIndex = 2;
            this.hastaSoyad.Text = "HASTA SOYADI";
            // 
            // hastaAd
            // 
            this.hastaAd.AutoSize = true;
            this.hastaAd.Location = new System.Drawing.Point(155, 38);
            this.hastaAd.Name = "hastaAd";
            this.hastaAd.Size = new System.Drawing.Size(76, 20);
            this.hastaAd.TabIndex = 1;
            this.hastaAd.Text = "HASTA ADI";
            // 
            // hastaSira
            // 
            this.hastaSira.AutoSize = true;
            this.hastaSira.Location = new System.Drawing.Point(25, 38);
            this.hastaSira.Name = "hastaSira";
            this.hastaSira.Size = new System.Drawing.Size(36, 20);
            this.hastaSira.TabIndex = 0;
            this.hastaSira.Text = "SIRA";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.LightGray;
            this.btnCikis.Location = new System.Drawing.Point(754, 47);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FormDoktorAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 658);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHastaCagir);
            this.Controls.Add(this.dgwHastaSiradan);
            this.Name = "FormDoktorAnaSayfa";
            this.Text = "Doktor Ana Sayfa";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FormDoktorAnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwHastaSiradan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwHastaSiradan;
        private MetroFramework.Controls.MetroButton btnHastaCagir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.RichTextBox rtBoxsikayet;
        private System.Windows.Forms.RichTextBox rtBoxTeshis;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroRadioButton rbtnEvet;
        private MetroFramework.Controls.MetroRadioButton rbtnHayir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroComboBox cBoxTetkit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cBoxRecete;
        private System.Windows.Forms.ListBox lBoxRecete;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnKaydet;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.GroupBox groupBox5;
        private MetroFramework.Controls.MetroLabel hastaYas;
        private MetroFramework.Controls.MetroLabel hastaSoyad;
        private MetroFramework.Controls.MetroLabel hastaAd;
        private MetroFramework.Controls.MetroLabel hastaSira;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Button btnCikis;
    }
}