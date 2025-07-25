namespace EvcilHayvan
{
    partial class UserLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogin));
            panel1 = new Panel();
            linkLabelSifremiUnuttum = new LinkLabel();
            labelBaslik = new Label();
            linkLabelKayitOl = new LinkLabel();
            labelKayitOl = new Label();
            btnGiris = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            pictureBoxLogo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(linkLabelSifremiUnuttum);
            panel1.Controls.Add(labelBaslik);
            panel1.Controls.Add(linkLabelKayitOl);
            panel1.Controls.Add(labelKayitOl);
            panel1.Controls.Add(btnGiris);
            panel1.Controls.Add(txtSifre);
            panel1.Controls.Add(txtKullaniciAdi);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Location = new Point(26, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 474);
            panel1.TabIndex = 0;
            // 
            // linkLabelSifremiUnuttum
            // 
            linkLabelSifremiUnuttum.AutoSize = true;
            linkLabelSifremiUnuttum.Font = new Font("Cambria", 9.5F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelSifremiUnuttum.Location = new Point(401, 309);
            linkLabelSifremiUnuttum.Name = "linkLabelSifremiUnuttum";
            linkLabelSifremiUnuttum.Size = new Size(122, 19);
            linkLabelSifremiUnuttum.TabIndex = 14;
            linkLabelSifremiUnuttum.TabStop = true;
            linkLabelSifremiUnuttum.Text = "Şifremi Unuttum";
            linkLabelSifremiUnuttum.LinkClicked += linkLabelSifremiUnuttum_LinkClicked;
            // 
            // labelBaslik
            // 
            labelBaslik.AutoSize = true;
            labelBaslik.BackColor = Color.Transparent;
            labelBaslik.Font = new Font("Cambria", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelBaslik.Location = new Point(304, 137);
            labelBaslik.Name = "labelBaslik";
            labelBaslik.Size = new Size(137, 36);
            labelBaslik.TabIndex = 13;
            labelBaslik.Text = "Üye Girişi";
            // 
            // linkLabelKayitOl
            // 
            linkLabelKayitOl.AutoSize = true;
            linkLabelKayitOl.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelKayitOl.Location = new Point(401, 421);
            linkLabelKayitOl.Name = "linkLabelKayitOl";
            linkLabelKayitOl.Size = new Size(58, 17);
            linkLabelKayitOl.TabIndex = 12;
            linkLabelKayitOl.TabStop = true;
            linkLabelKayitOl.Text = "Kayıt Ol";
            linkLabelKayitOl.LinkClicked += linkLabelKayitOl_LinkClicked;
            // 
            // labelKayitOl
            // 
            labelKayitOl.AutoSize = true;
            labelKayitOl.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelKayitOl.Location = new Point(282, 421);
            labelKayitOl.Name = "labelKayitOl";
            labelKayitOl.Size = new Size(114, 17);
            labelKayitOl.TabIndex = 11;
            labelKayitOl.Text = "Hesabın Yok Mu?";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.FromArgb(243, 200, 120);
            btnGiris.FlatStyle = FlatStyle.Popup;
            btnGiris.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(225, 363);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(300, 46);
            btnGiris.TabIndex = 10;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = Color.LightGray;
            txtSifre.BorderStyle = BorderStyle.FixedSingle;
            txtSifre.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.Location = new Point(225, 260);
            txtSifre.Multiline = true;
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(300, 39);
            txtSifre.TabIndex = 9;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BackColor = Color.LightGray;
            txtKullaniciAdi.BorderStyle = BorderStyle.FixedSingle;
            txtKullaniciAdi.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKullaniciAdi.Location = new Point(225, 200);
            txtKullaniciAdi.Multiline = true;
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtKullaniciAdi.Size = new Size(300, 38);
            txtKullaniciAdi.TabIndex = 8;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(305, 24);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(135, 118);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // UserLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(842, 526);
            Controls.Add(panel1);
            Name = "UserLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Üye Girisi";
            Load += UserLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private LinkLabel linkLabelSifremiUnuttum;
        private Label labelBaslik;
        private LinkLabel linkLabelKayitOl;
        private Label labelKayitOl;
        private Button btnGiris;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private PictureBox pictureBoxLogo;
    }
}