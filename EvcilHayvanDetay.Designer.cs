namespace EvcilHayvan
{
    partial class EvcilHayvanDetay
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan kaynakları temizler.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynaklar serbest bırakılacaksa true; aksi halde false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer tarafından oluşturulan kod

        /// <summary>
        /// Tasarımcı desteği için gerekli yöntem - bu yöntemin içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlDetay = new TabControl();
            tabGenelBilgiler = new TabPage();
            grpHayvanBilgileri = new GroupBox();
            lblSahip = new Label();
            lblCins = new Label();
            lblTur = new Label();
            lblYas = new Label();
            lblAd = new Label();
            pbHayvanFoto = new PictureBox();
            lblBaslik = new Label();
            tabAsilar = new TabPage();
            grpAsilar = new GroupBox();
            lstAsilar = new ListView();
            btnAsiGuncelle = new Button();
            tabBeslenme = new TabPage();
            grpBeslenme = new GroupBox();
            lstBeslenme = new ListView();
            btnBeslenmeGuncelle = new Button();
            tabRandevular = new TabPage();
            grpRandevular = new GroupBox();
            lstRandevular = new ListView();
            btnRandevuGuncelle = new Button();
            tabControlDetay.SuspendLayout();
            tabGenelBilgiler.SuspendLayout();
            grpHayvanBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbHayvanFoto).BeginInit();
            tabAsilar.SuspendLayout();
            grpAsilar.SuspendLayout();
            tabBeslenme.SuspendLayout();
            grpBeslenme.SuspendLayout();
            tabRandevular.SuspendLayout();
            grpRandevular.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlDetay
            // 
            tabControlDetay.Controls.Add(tabGenelBilgiler);
            tabControlDetay.Controls.Add(tabAsilar);
            tabControlDetay.Controls.Add(tabBeslenme);
            tabControlDetay.Controls.Add(tabRandevular);
            tabControlDetay.Dock = DockStyle.Fill;
            tabControlDetay.Location = new Point(0, 0);
            tabControlDetay.Name = "tabControlDetay";
            tabControlDetay.SelectedIndex = 0;
            tabControlDetay.Size = new Size(804, 628);
            tabControlDetay.TabIndex = 0;
            // 
            // tabGenelBilgiler
            // 
            tabGenelBilgiler.BackColor = Color.FromArgb(192, 192, 255);
            tabGenelBilgiler.Controls.Add(grpHayvanBilgileri);
            tabGenelBilgiler.Controls.Add(lblBaslik);
            tabGenelBilgiler.Location = new Point(4, 29);
            tabGenelBilgiler.Name = "tabGenelBilgiler";
            tabGenelBilgiler.Padding = new Padding(3);
            tabGenelBilgiler.Size = new Size(796, 595);
            tabGenelBilgiler.TabIndex = 0;
            tabGenelBilgiler.Text = "📋 Genel Bilgiler";
            // 
            // grpHayvanBilgileri
            // 
            grpHayvanBilgileri.BackColor = Color.FromArgb(192, 192, 255);
            grpHayvanBilgileri.Controls.Add(lblSahip);
            grpHayvanBilgileri.Controls.Add(lblCins);
            grpHayvanBilgileri.Controls.Add(lblTur);
            grpHayvanBilgileri.Controls.Add(lblYas);
            grpHayvanBilgileri.Controls.Add(lblAd);
            grpHayvanBilgileri.Controls.Add(pbHayvanFoto);
            grpHayvanBilgileri.Location = new Point(20, 60);
            grpHayvanBilgileri.Name = "grpHayvanBilgileri";
            grpHayvanBilgileri.Size = new Size(750, 480);
            grpHayvanBilgileri.TabIndex = 0;
            grpHayvanBilgileri.TabStop = false;
            grpHayvanBilgileri.Text = "Evcil Hayvan Bilgileri";
            // 
            // lblSahip
            // 
            lblSahip.AutoSize = true;
            lblSahip.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblSahip.Location = new Point(211, 225);
            lblSahip.Name = "lblSahip";
            lblSahip.Size = new Size(61, 23);
            lblSahip.TabIndex = 5;
            lblSahip.Text = "Sahip: ";
            // 
            // lblCins
            // 
            lblCins.AutoSize = true;
            lblCins.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblCins.Location = new Point(211, 185);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(51, 23);
            lblCins.TabIndex = 4;
            lblCins.Text = "Cins: ";
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblTur.Location = new Point(211, 145);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(44, 23);
            lblTur.TabIndex = 3;
            lblTur.Text = "Tür: ";
            // 
            // lblYas
            // 
            lblYas.AutoSize = true;
            lblYas.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblYas.Location = new Point(211, 105);
            lblYas.Name = "lblYas";
            lblYas.Size = new Size(43, 23);
            lblYas.TabIndex = 2;
            lblYas.Text = "Yaş: ";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblAd.Location = new Point(211, 65);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(40, 23);
            lblAd.TabIndex = 1;
            lblAd.Text = "Ad: ";
            // 
            // pbHayvanFoto
            // 
            pbHayvanFoto.Location = new Point(22, 53);
            pbHayvanFoto.Name = "pbHayvanFoto";
            pbHayvanFoto.Size = new Size(173, 195);
            pbHayvanFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHayvanFoto.TabIndex = 0;
            pbHayvanFoto.TabStop = false;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblBaslik.Location = new Point(20, 20);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(226, 28);
            lblBaslik.TabIndex = 1;
            lblBaslik.Text = "Evcil Hayvan Detayları";
            // 
            // tabAsilar
            // 
            tabAsilar.BackColor = Color.FromArgb(192, 192, 255);
            tabAsilar.Controls.Add(grpAsilar);
            tabAsilar.Location = new Point(4, 29);
            tabAsilar.Name = "tabAsilar";
            tabAsilar.Padding = new Padding(3);
            tabAsilar.Size = new Size(796, 595);
            tabAsilar.TabIndex = 1;
            tabAsilar.Text = "💉 Aşılar";
            // 
            // grpAsilar
            // 
            grpAsilar.Controls.Add(lstAsilar);
            grpAsilar.Controls.Add(btnAsiGuncelle);
            grpAsilar.Location = new Point(20, 20);
            grpAsilar.Name = "grpAsilar";
            grpAsilar.Size = new Size(751, 561);
            grpAsilar.TabIndex = 0;
            grpAsilar.TabStop = false;
            grpAsilar.Text = "Aşı Kayıtları";
            // 
            // lstAsilar
            // 
            lstAsilar.BackColor = SystemColors.ButtonFace;
            lstAsilar.Location = new Point(20, 30);
            lstAsilar.Name = "lstAsilar";
            lstAsilar.Size = new Size(710, 460);
            lstAsilar.TabIndex = 0;
            lstAsilar.UseCompatibleStateImageBehavior = false;
            lstAsilar.View = View.Details;
            // 
            // btnAsiGuncelle
            // 
            btnAsiGuncelle.Location = new Point(20, 507);
            btnAsiGuncelle.Name = "btnAsiGuncelle";
            btnAsiGuncelle.Size = new Size(133, 44);
            btnAsiGuncelle.TabIndex = 10;
            btnAsiGuncelle.Text = "Aşıyı Güncelle";
            btnAsiGuncelle.UseVisualStyleBackColor = true;
            btnAsiGuncelle.Click += BtnAsiGuncelle_Click;
            // 
            // tabBeslenme
            // 
            tabBeslenme.BackColor = Color.FromArgb(192, 192, 255);
            tabBeslenme.Controls.Add(grpBeslenme);
            tabBeslenme.Location = new Point(4, 29);
            tabBeslenme.Name = "tabBeslenme";
            tabBeslenme.Padding = new Padding(3);
            tabBeslenme.Size = new Size(796, 595);
            tabBeslenme.TabIndex = 2;
            tabBeslenme.Text = "🍽️ Beslenme Saatleri";
            // 
            // grpBeslenme
            // 
            grpBeslenme.Controls.Add(lstBeslenme);
            grpBeslenme.Controls.Add(btnBeslenmeGuncelle);
            grpBeslenme.Location = new Point(20, 20);
            grpBeslenme.Name = "grpBeslenme";
            grpBeslenme.Size = new Size(760, 563);
            grpBeslenme.TabIndex = 0;
            grpBeslenme.TabStop = false;
            grpBeslenme.Text = "Beslenme Kayıtları";
            // 
            // lstBeslenme
            // 
            lstBeslenme.BackColor = SystemColors.ButtonFace;
            lstBeslenme.Location = new Point(20, 30);
            lstBeslenme.Name = "lstBeslenme";
            lstBeslenme.Size = new Size(710, 460);
            lstBeslenme.TabIndex = 0;
            lstBeslenme.UseCompatibleStateImageBehavior = false;
            lstBeslenme.View = View.Details;
            // 
            // btnBeslenmeGuncelle
            // 
            btnBeslenmeGuncelle.Location = new Point(20, 510);
            btnBeslenmeGuncelle.Name = "btnBeslenmeGuncelle";
            btnBeslenmeGuncelle.Size = new Size(212, 47);
            btnBeslenmeGuncelle.TabIndex = 11;
            btnBeslenmeGuncelle.Text = "Beslenme Saatini Güncelle";
            btnBeslenmeGuncelle.UseVisualStyleBackColor = true;
            btnBeslenmeGuncelle.Click += BtnBeslenmeGuncelle_Click;
            // 
            // tabRandevular
            // 
            tabRandevular.BackColor = Color.FromArgb(192, 192, 255);
            tabRandevular.Controls.Add(grpRandevular);
            tabRandevular.Location = new Point(4, 29);
            tabRandevular.Name = "tabRandevular";
            tabRandevular.Padding = new Padding(3);
            tabRandevular.Size = new Size(796, 595);
            tabRandevular.TabIndex = 3;
            tabRandevular.Text = "\U0001fa7a Veteriner Randevuları";
            // 
            // grpRandevular
            // 
            grpRandevular.Controls.Add(lstRandevular);
            grpRandevular.Controls.Add(btnRandevuGuncelle);
            grpRandevular.Location = new Point(20, 20);
            grpRandevular.Name = "grpRandevular";
            grpRandevular.Size = new Size(769, 562);
            grpRandevular.TabIndex = 0;
            grpRandevular.TabStop = false;
            grpRandevular.Text = "Randevu Kayıtları";
            // 
            // lstRandevular
            // 
            lstRandevular.BackColor = SystemColors.ButtonFace;
            lstRandevular.Location = new Point(20, 30);
            lstRandevular.Name = "lstRandevular";
            lstRandevular.Size = new Size(710, 460);
            lstRandevular.TabIndex = 0;
            lstRandevular.UseCompatibleStateImageBehavior = false;
            lstRandevular.View = View.Details;
            // 
            // btnRandevuGuncelle
            // 
            btnRandevuGuncelle.Location = new Point(20, 507);
            btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            btnRandevuGuncelle.Size = new Size(150, 49);
            btnRandevuGuncelle.TabIndex = 12;
            btnRandevuGuncelle.Text = "Randevuyu Güncelle";
            btnRandevuGuncelle.UseVisualStyleBackColor = true;
            btnRandevuGuncelle.Click += BtnRandevuGuncelle_Click;
            // 
            // EvcilHayvanDetay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(804, 628);
            Controls.Add(tabControlDetay);
            Name = "EvcilHayvanDetay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evcil Hayvan Detayları";
            Load += EvcilHayvanDetay_Load;
            tabControlDetay.ResumeLayout(false);
            tabGenelBilgiler.ResumeLayout(false);
            tabGenelBilgiler.PerformLayout();
            grpHayvanBilgileri.ResumeLayout(false);
            grpHayvanBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbHayvanFoto).EndInit();
            tabAsilar.ResumeLayout(false);
            grpAsilar.ResumeLayout(false);
            tabBeslenme.ResumeLayout(false);
            grpBeslenme.ResumeLayout(false);
            tabRandevular.ResumeLayout(false);
            grpRandevular.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlDetay;
        private TabPage tabGenelBilgiler;
        private GroupBox grpHayvanBilgileri;
        private Label lblSahip;
        private Label lblCins;
        private Label lblTur;
        private Label lblYas;
        private Label lblAd;
        private PictureBox pbHayvanFoto;
        private TabPage tabAsilar;
        private GroupBox grpAsilar;
        private ListView lstAsilar;
        private TabPage tabBeslenme;
        private GroupBox grpBeslenme;
        private ListView lstBeslenme;
        private TabPage tabRandevular;
        private GroupBox grpRandevular;
        private ListView lstRandevular;
        private Label lblBaslik;
        private Button btnAsiGuncelle;
        private Button btnBeslenmeGuncelle;
        private Button btnRandevuGuncelle;
    }
}