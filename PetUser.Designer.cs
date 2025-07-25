using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvcilHayvan
{
    partial class PetUser
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

        #region Windows Form Designer tarafından oluşturulan kod

        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            grpHayvanProfili = new GroupBox();
            lblSecHayvanCins = new Label();
            listHayvanListe = new ListView();
            pbSecFotoHayvan = new PictureBox();
            lblSecHayvanTur = new Label();
            lblSecHayvanYas = new Label();
            lblSecHayvanİsim = new Label();
            grpHayvanEkle = new GroupBox();
            lblSecilenFoto = new Label();
            pbPetPhoto = new PictureBox();
            lblEklenenFoto = new Label();
            btnResimYukle = new Button();
            label5 = new Label();
            cmbPetCins = new ComboBox();
            label4 = new Label();
            txtPetName = new TextBox();
            lblPetName = new Label();
            cmbPetType = new ComboBox();
            lblPetType = new Label();
            txtPetYas = new TextBox();
            lblPetAge = new Label();
            btnHayvanEkle = new Button();
            grpHatirlatici = new GroupBox();
            listViewReminders = new ListView();
            tabPageCare = new TabPage();
            grpBeslenme = new GroupBox();
            comboBoxPetFeeding = new ComboBox();
            lblHayvan = new Label();
            txtBesSaati = new TextBox();
            lblBesSaat = new Label();
            BtnBeslenmeEkle = new Button();
            listBeslenme = new ListView();
            grpVetRandevu = new GroupBox();
            comboBoxPetVet = new ComboBox();
            lblVetHayvan = new Label();
            dtpVetDate = new DateTimePicker();
            lblVetTarih = new Label();
            txtVetAcikla = new TextBox();
            lblVetAciklama = new Label();
            btnVetEkle = new Button();
            listVet = new ListView();
            grpAsiTarih = new GroupBox();
            cmbAsiHayvan = new ComboBox();
            lblAsiHayvan = new Label();
            txtAsiAdi = new TextBox();
            lblAsiAdi = new Label();
            dtpAsiTarih = new DateTimePicker();
            lblAsiTarih = new Label();
            btnAsiEkle = new Button();
            lstAsi = new ListView();
            grpSaglik = new GroupBox();
            cmbSaglikHayvan = new ComboBox();
            lblNotHayvan = new Label();
            txtSaglikNotu = new TextBox();
            lblSaglikNot = new Label();
            btnNotEkle = new Button();
            listNote = new ListView();
            monthCalendar = new MonthCalendar();
            lblUpcomingEvents = new Label();
            tabPage2 = new TabPage();
            grpHayvanList = new GroupBox();
            HayvanListe = new DataGridView();
            btnHayvanDetay = new Button();
            btnHayvanSil = new Button();
            tabPage4 = new TabPage();
            grpKullanici = new GroupBox();
            lblName = new Label();
            lblEmail = new Label();
            lblGiris = new Label();
            groupBoxTheme = new GroupBox();
            lblTema = new Label();
            cmbTema = new ComboBox();
            groupBoxGuncelle = new GroupBox();
            lblKullaniciAdiGuncelle = new Label();
            txtKullaniciAdi = new TextBox();
            lblMailGuncelle = new Label();
            txtMail = new TextBox();
            lblSifreGuncelle = new Label();
            txtSifre = new TextBox();
            btnBilgileriGuncelle = new Button();
            groupBoxGeriBildirim = new GroupBox();
            cmbPuan = new ComboBox();
            lblPuan = new Label();
            txtGeriBildirim = new TextBox();
            btnGeriBildirimGonder = new Button();
            groupBox1 = new GroupBox();
            hsbSifre = new TextBox();
            label3 = new Label();
            btnHspSil = new Button();
            hsbMail = new TextBox();
            hsbAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnLogout = new Button();
            panelFooter = new Panel();
            lblVersiyon = new Label();
            openFileDialog1 = new OpenFileDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            grpHayvanProfili.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbSecFotoHayvan).BeginInit();
            grpHayvanEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPetPhoto).BeginInit();
            grpHatirlatici.SuspendLayout();
            tabPageCare.SuspendLayout();
            grpBeslenme.SuspendLayout();
            grpVetRandevu.SuspendLayout();
            grpAsiTarih.SuspendLayout();
            grpSaglik.SuspendLayout();
            tabPage2.SuspendLayout();
            grpHayvanList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HayvanListe).BeginInit();
            tabPage4.SuspendLayout();
            grpKullanici.SuspendLayout();
            groupBoxTheme.SuspendLayout();
            groupBoxGuncelle.SuspendLayout();
            groupBoxGeriBildirim.SuspendLayout();
            groupBox1.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPageCare);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1220, 684);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(grpHayvanProfili);
            tabPage1.Controls.Add(grpHayvanEkle);
            tabPage1.Controls.Add(grpHatirlatici);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1212, 651);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "📌 Ana Sayfa";
            // 
            // grpHayvanProfili
            // 
            grpHayvanProfili.BackColor = Color.FromArgb(192, 192, 255);
            grpHayvanProfili.Controls.Add(lblSecHayvanCins);
            grpHayvanProfili.Controls.Add(listHayvanListe);
            grpHayvanProfili.Controls.Add(pbSecFotoHayvan);
            grpHayvanProfili.Controls.Add(lblSecHayvanTur);
            grpHayvanProfili.Controls.Add(lblSecHayvanYas);
            grpHayvanProfili.Controls.Add(lblSecHayvanİsim);
            grpHayvanProfili.Location = new Point(434, 20);
            grpHayvanProfili.Name = "grpHayvanProfili";
            grpHayvanProfili.Size = new Size(756, 413);
            grpHayvanProfili.TabIndex = 0;
            grpHayvanProfili.TabStop = false;
            grpHayvanProfili.Text = "Evcil Hayvan Bilgileri";
            // 
            // lblSecHayvanCins
            // 
            lblSecHayvanCins.AutoSize = true;
            lblSecHayvanCins.Location = new Point(192, 306);
            lblSecHayvanCins.Name = "lblSecHayvanCins";
            lblSecHayvanCins.Size = new Size(43, 20);
            lblSecHayvanCins.TabIndex = 5;
            lblSecHayvanCins.Text = "Cins: ";
            // 
            // listHayvanListe
            // 
            listHayvanListe.BackColor = SystemColors.ButtonFace;
            listHayvanListe.Location = new Point(24, 39);
            listHayvanListe.Name = "listHayvanListe";
            listHayvanListe.Size = new Size(713, 132);
            listHayvanListe.TabIndex = 0;
            listHayvanListe.UseCompatibleStateImageBehavior = false;
            listHayvanListe.View = View.Details;
            listHayvanListe.SelectedIndexChanged += listHayvanListe_SelectedIndexChanged;
            // 
            // pbSecFotoHayvan
            // 
            pbSecFotoHayvan.Location = new Point(24, 192);
            pbSecFotoHayvan.Name = "pbSecFotoHayvan";
            pbSecFotoHayvan.Size = new Size(150, 150);
            pbSecFotoHayvan.SizeMode = PictureBoxSizeMode.StretchImage;
            pbSecFotoHayvan.TabIndex = 1;
            pbSecFotoHayvan.TabStop = false;
            // 
            // lblSecHayvanTur
            // 
            lblSecHayvanTur.AutoSize = true;
            lblSecHayvanTur.Location = new Point(192, 276);
            lblSecHayvanTur.Name = "lblSecHayvanTur";
            lblSecHayvanTur.Size = new Size(37, 20);
            lblSecHayvanTur.TabIndex = 4;
            lblSecHayvanTur.Text = "Tür: ";
            // 
            // lblSecHayvanYas
            // 
            lblSecHayvanYas.AutoSize = true;
            lblSecHayvanYas.Location = new Point(192, 246);
            lblSecHayvanYas.Name = "lblSecHayvanYas";
            lblSecHayvanYas.Size = new Size(37, 20);
            lblSecHayvanYas.TabIndex = 3;
            lblSecHayvanYas.Text = "Yaş: ";
            // 
            // lblSecHayvanİsim
            // 
            lblSecHayvanİsim.AutoSize = true;
            lblSecHayvanİsim.Location = new Point(192, 216);
            lblSecHayvanİsim.Name = "lblSecHayvanİsim";
            lblSecHayvanİsim.Size = new Size(43, 20);
            lblSecHayvanİsim.TabIndex = 2;
            lblSecHayvanİsim.Text = "İsim: ";
            // 
            // grpHayvanEkle
            // 
            grpHayvanEkle.Controls.Add(lblSecilenFoto);
            grpHayvanEkle.Controls.Add(pbPetPhoto);
            grpHayvanEkle.Controls.Add(lblEklenenFoto);
            grpHayvanEkle.Controls.Add(btnResimYukle);
            grpHayvanEkle.Controls.Add(label5);
            grpHayvanEkle.Controls.Add(cmbPetCins);
            grpHayvanEkle.Controls.Add(label4);
            grpHayvanEkle.Controls.Add(txtPetName);
            grpHayvanEkle.Controls.Add(lblPetName);
            grpHayvanEkle.Controls.Add(cmbPetType);
            grpHayvanEkle.Controls.Add(lblPetType);
            grpHayvanEkle.Controls.Add(txtPetYas);
            grpHayvanEkle.Controls.Add(lblPetAge);
            grpHayvanEkle.Controls.Add(btnHayvanEkle);
            grpHayvanEkle.Location = new Point(20, 20);
            grpHayvanEkle.Name = "grpHayvanEkle";
            grpHayvanEkle.Size = new Size(350, 580);
            grpHayvanEkle.TabIndex = 1;
            grpHayvanEkle.TabStop = false;
            grpHayvanEkle.Text = "Evcil Hayvan Ekle";
            // 
            // lblSecilenFoto
            // 
            lblSecilenFoto.AutoSize = true;
            lblSecilenFoto.BackColor = Color.Transparent;
            lblSecilenFoto.Location = new Point(175, 416);
            lblSecilenFoto.Name = "lblSecilenFoto";
            lblSecilenFoto.Size = new Size(117, 20);
            lblSecilenFoto.TabIndex = 12;
            lblSecilenFoto.Text = "Seçilen Fotoğraf";
            // 
            // pbPetPhoto
            // 
            pbPetPhoto.Location = new Point(151, 357);
            pbPetPhoto.Name = "pbPetPhoto";
            pbPetPhoto.Size = new Size(170, 133);
            pbPetPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPetPhoto.TabIndex = 11;
            pbPetPhoto.TabStop = false;
            // 
            // lblEklenenFoto
            // 
            lblEklenenFoto.AutoSize = true;
            lblEklenenFoto.Location = new Point(21, 357);
            lblEklenenFoto.Name = "lblEklenenFoto";
            lblEklenenFoto.Size = new Size(124, 20);
            lblEklenenFoto.TabIndex = 10;
            lblEklenenFoto.Text = "Eklenen Fotoğraf:";
            // 
            // btnResimYukle
            // 
            btnResimYukle.Location = new Point(121, 285);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(200, 29);
            btnResimYukle.TabIndex = 4;
            btnResimYukle.Text = "Resim Yükle";
            btnResimYukle.UseVisualStyleBackColor = true;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 289);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 9;
            label5.Text = "Fotoğraf:";
            // 
            // cmbPetCins
            // 
            cmbPetCins.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPetCins.Location = new Point(121, 167);
            cmbPetCins.Name = "cmbPetCins";
            cmbPetCins.Size = new Size(200, 28);
            cmbPetCins.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 170);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 8;
            label4.Text = "Cins: ";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(121, 52);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(200, 27);
            txtPetName.TabIndex = 0;
            // 
            // lblPetName
            // 
            lblPetName.AutoSize = true;
            lblPetName.Location = new Point(21, 55);
            lblPetName.Name = "lblPetName";
            lblPetName.Size = new Size(35, 20);
            lblPetName.TabIndex = 1;
            lblPetName.Text = "Ad: ";
            // 
            // cmbPetType
            // 
            cmbPetType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPetType.Location = new Point(121, 111);
            cmbPetType.Name = "cmbPetType";
            cmbPetType.Size = new Size(200, 28);
            cmbPetType.TabIndex = 2;
            cmbPetType.SelectedIndexChanged += cmbPetType_SelectedIndexChanged;
            // 
            // lblPetType
            // 
            lblPetType.AutoSize = true;
            lblPetType.Location = new Point(21, 114);
            lblPetType.Name = "lblPetType";
            lblPetType.Size = new Size(37, 20);
            lblPetType.TabIndex = 3;
            lblPetType.Text = "Tür: ";
            // 
            // txtPetYas
            // 
            txtPetYas.Location = new Point(121, 225);
            txtPetYas.Name = "txtPetYas";
            txtPetYas.Size = new Size(200, 27);
            txtPetYas.TabIndex = 4;
            // 
            // lblPetAge
            // 
            lblPetAge.AutoSize = true;
            lblPetAge.Location = new Point(21, 232);
            lblPetAge.Name = "lblPetAge";
            lblPetAge.Size = new Size(37, 20);
            lblPetAge.TabIndex = 5;
            lblPetAge.Text = "Yaş: ";
            // 
            // btnHayvanEkle
            // 
            btnHayvanEkle.BackColor = Color.LightGreen;
            btnHayvanEkle.Location = new Point(121, 508);
            btnHayvanEkle.Name = "btnHayvanEkle";
            btnHayvanEkle.Size = new Size(200, 35);
            btnHayvanEkle.TabIndex = 6;
            btnHayvanEkle.Text = "🐾 Hayvan Ekle";
            btnHayvanEkle.UseVisualStyleBackColor = false;
            btnHayvanEkle.Click += btnHayvanEkle_Click;
            // 
            // grpHatirlatici
            // 
            grpHatirlatici.Controls.Add(listViewReminders);
            grpHatirlatici.Location = new Point(434, 450);
            grpHatirlatici.Name = "grpHatirlatici";
            grpHatirlatici.Size = new Size(756, 150);
            grpHatirlatici.TabIndex = 3;
            grpHatirlatici.TabStop = false;
            grpHatirlatici.Text = "Yaklaşan Hatırlatıcılar";
            // 
            // listViewReminders
            // 
            listViewReminders.Location = new Point(10, 30);
            listViewReminders.Name = "listViewReminders";
            listViewReminders.Size = new Size(736, 110);
            listViewReminders.TabIndex = 0;
            listViewReminders.UseCompatibleStateImageBehavior = false;
            listViewReminders.View = View.Details;
            // 
            // tabPageCare
            // 
            tabPageCare.BackColor = Color.FromArgb(192, 192, 255);
            tabPageCare.Controls.Add(grpBeslenme);
            tabPageCare.Controls.Add(grpVetRandevu);
            tabPageCare.Controls.Add(grpAsiTarih);
            tabPageCare.Controls.Add(grpSaglik);
            tabPageCare.Controls.Add(monthCalendar);
            tabPageCare.Controls.Add(lblUpcomingEvents);
            tabPageCare.Location = new Point(4, 29);
            tabPageCare.Name = "tabPageCare";
            tabPageCare.Padding = new Padding(3);
            tabPageCare.Size = new Size(1212, 651);
            tabPageCare.TabIndex = 1;
            tabPageCare.Text = "\U0001fa7a Bakım Takip";
            // 
            // grpBeslenme
            // 
            grpBeslenme.Controls.Add(comboBoxPetFeeding);
            grpBeslenme.Controls.Add(lblHayvan);
            grpBeslenme.Controls.Add(txtBesSaati);
            grpBeslenme.Controls.Add(lblBesSaat);
            grpBeslenme.Controls.Add(BtnBeslenmeEkle);
            grpBeslenme.Controls.Add(listBeslenme);
            grpBeslenme.Location = new Point(20, 20);
            grpBeslenme.Name = "grpBeslenme";
            grpBeslenme.Size = new Size(570, 300);
            grpBeslenme.TabIndex = 0;
            grpBeslenme.TabStop = false;
            grpBeslenme.Text = "Beslenme Saatleri";
            // 
            // comboBoxPetFeeding
            // 
            comboBoxPetFeeding.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPetFeeding.FormattingEnabled = true;
            comboBoxPetFeeding.Location = new Point(100, 30);
            comboBoxPetFeeding.Name = "comboBoxPetFeeding";
            comboBoxPetFeeding.Size = new Size(225, 28);
            comboBoxPetFeeding.TabIndex = 5;
            // 
            // lblHayvan
            // 
            lblHayvan.AutoSize = true;
            lblHayvan.Location = new Point(20, 33);
            lblHayvan.Name = "lblHayvan";
            lblHayvan.Size = new Size(61, 20);
            lblHayvan.TabIndex = 4;
            lblHayvan.Text = "Hayvan:";
            // 
            // txtBesSaati
            // 
            txtBesSaati.Location = new Point(100, 60);
            txtBesSaati.Name = "txtBesSaati";
            txtBesSaati.PlaceholderText = "Örn: 08:00";
            txtBesSaati.Size = new Size(225, 27);
            txtBesSaati.TabIndex = 0;
            // 
            // lblBesSaat
            // 
            lblBesSaat.AutoSize = true;
            lblBesSaat.Location = new Point(20, 63);
            lblBesSaat.Name = "lblBesSaat";
            lblBesSaat.Size = new Size(45, 20);
            lblBesSaat.TabIndex = 1;
            lblBesSaat.Text = "Saat: ";
            // 
            // BtnBeslenmeEkle
            // 
            BtnBeslenmeEkle.BackColor = Color.LightBlue;
            BtnBeslenmeEkle.Location = new Point(400, 63);
            BtnBeslenmeEkle.Name = "BtnBeslenmeEkle";
            BtnBeslenmeEkle.Size = new Size(150, 30);
            BtnBeslenmeEkle.TabIndex = 2;
            BtnBeslenmeEkle.Text = "➕ Ekle";
            BtnBeslenmeEkle.UseVisualStyleBackColor = false;
            BtnBeslenmeEkle.Click += btnBeslenmeEkle_Click;
            // 
            // listBeslenme
            // 
            listBeslenme.BackColor = SystemColors.ButtonFace;
            listBeslenme.Location = new Point(20, 100);
            listBeslenme.Name = "listBeslenme";
            listBeslenme.Size = new Size(530, 180);
            listBeslenme.TabIndex = 3;
            listBeslenme.UseCompatibleStateImageBehavior = false;
            listBeslenme.View = View.Details;
            // 
            // grpVetRandevu
            // 
            grpVetRandevu.Controls.Add(comboBoxPetVet);
            grpVetRandevu.Controls.Add(lblVetHayvan);
            grpVetRandevu.Controls.Add(dtpVetDate);
            grpVetRandevu.Controls.Add(lblVetTarih);
            grpVetRandevu.Controls.Add(txtVetAcikla);
            grpVetRandevu.Controls.Add(lblVetAciklama);
            grpVetRandevu.Controls.Add(btnVetEkle);
            grpVetRandevu.Controls.Add(listVet);
            grpVetRandevu.Location = new Point(610, 20);
            grpVetRandevu.Name = "grpVetRandevu";
            grpVetRandevu.Size = new Size(570, 300);
            grpVetRandevu.TabIndex = 1;
            grpVetRandevu.TabStop = false;
            grpVetRandevu.Text = "Veteriner Randevuları";
            // 
            // comboBoxPetVet
            // 
            comboBoxPetVet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPetVet.FormattingEnabled = true;
            comboBoxPetVet.Location = new Point(100, 30);
            comboBoxPetVet.Name = "comboBoxPetVet";
            comboBoxPetVet.Size = new Size(208, 28);
            comboBoxPetVet.TabIndex = 7;
            // 
            // lblVetHayvan
            // 
            lblVetHayvan.AutoSize = true;
            lblVetHayvan.Location = new Point(20, 33);
            lblVetHayvan.Name = "lblVetHayvan";
            lblVetHayvan.Size = new Size(61, 20);
            lblVetHayvan.TabIndex = 6;
            lblVetHayvan.Text = "Hayvan:";
            // 
            // dtpVetDate
            // 
            dtpVetDate.Location = new Point(100, 60);
            dtpVetDate.Name = "dtpVetDate";
            dtpVetDate.Size = new Size(208, 27);
            dtpVetDate.TabIndex = 0;
            // 
            // lblVetTarih
            // 
            lblVetTarih.AutoSize = true;
            lblVetTarih.Location = new Point(20, 63);
            lblVetTarih.Name = "lblVetTarih";
            lblVetTarih.Size = new Size(47, 20);
            lblVetTarih.TabIndex = 1;
            lblVetTarih.Text = "Tarih: ";
            // 
            // txtVetAcikla
            // 
            txtVetAcikla.Location = new Point(100, 90);
            txtVetAcikla.Name = "txtVetAcikla";
            txtVetAcikla.PlaceholderText = "Örn: Aşı, Kontrol";
            txtVetAcikla.Size = new Size(208, 27);
            txtVetAcikla.TabIndex = 2;
            // 
            // lblVetAciklama
            // 
            lblVetAciklama.AutoSize = true;
            lblVetAciklama.Location = new Point(20, 93);
            lblVetAciklama.Name = "lblVetAciklama";
            lblVetAciklama.Size = new Size(77, 20);
            lblVetAciklama.TabIndex = 3;
            lblVetAciklama.Text = "Açıklama: ";
            // 
            // btnVetEkle
            // 
            btnVetEkle.BackColor = Color.LightBlue;
            btnVetEkle.Location = new Point(400, 83);
            btnVetEkle.Name = "btnVetEkle";
            btnVetEkle.Size = new Size(150, 30);
            btnVetEkle.TabIndex = 4;
            btnVetEkle.Text = "➕ Ekle";
            btnVetEkle.UseVisualStyleBackColor = false;
            btnVetEkle.Click += btnVetEkle_Click;
            // 
            // listVet
            // 
            listVet.BackColor = SystemColors.ButtonFace;
            listVet.Location = new Point(20, 130);
            listVet.Name = "listVet";
            listVet.Size = new Size(530, 150);
            listVet.TabIndex = 5;
            listVet.UseCompatibleStateImageBehavior = false;
            listVet.View = View.Details;
            // 
            // grpAsiTarih
            // 
            grpAsiTarih.Controls.Add(cmbAsiHayvan);
            grpAsiTarih.Controls.Add(lblAsiHayvan);
            grpAsiTarih.Controls.Add(txtAsiAdi);
            grpAsiTarih.Controls.Add(lblAsiAdi);
            grpAsiTarih.Controls.Add(dtpAsiTarih);
            grpAsiTarih.Controls.Add(lblAsiTarih);
            grpAsiTarih.Controls.Add(btnAsiEkle);
            grpAsiTarih.Controls.Add(lstAsi);
            grpAsiTarih.Location = new Point(20, 330);
            grpAsiTarih.Name = "grpAsiTarih";
            grpAsiTarih.Size = new Size(570, 300);
            grpAsiTarih.TabIndex = 2;
            grpAsiTarih.TabStop = false;
            grpAsiTarih.Text = "Aşı Tarihleri";
            // 
            // cmbAsiHayvan
            // 
            cmbAsiHayvan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAsiHayvan.FormattingEnabled = true;
            cmbAsiHayvan.Location = new Point(100, 30);
            cmbAsiHayvan.Name = "cmbAsiHayvan";
            cmbAsiHayvan.Size = new Size(225, 28);
            cmbAsiHayvan.TabIndex = 6;
            // 
            // lblAsiHayvan
            // 
            lblAsiHayvan.AutoSize = true;
            lblAsiHayvan.Location = new Point(20, 33);
            lblAsiHayvan.Name = "lblAsiHayvan";
            lblAsiHayvan.Size = new Size(61, 20);
            lblAsiHayvan.TabIndex = 5;
            lblAsiHayvan.Text = "Hayvan:";
            // 
            // txtAsiAdi
            // 
            txtAsiAdi.Location = new Point(100, 60);
            txtAsiAdi.Name = "txtAsiAdi";
            txtAsiAdi.PlaceholderText = "Örn: Kuduz Aşısı";
            txtAsiAdi.Size = new Size(225, 27);
            txtAsiAdi.TabIndex = 0;
            // 
            // lblAsiAdi
            // 
            lblAsiAdi.AutoSize = true;
            lblAsiAdi.Location = new Point(20, 63);
            lblAsiAdi.Name = "lblAsiAdi";
            lblAsiAdi.Size = new Size(63, 20);
            lblAsiAdi.TabIndex = 1;
            lblAsiAdi.Text = "Aşı Adı: ";
            // 
            // dtpAsiTarih
            // 
            dtpAsiTarih.Location = new Point(100, 90);
            dtpAsiTarih.Name = "dtpAsiTarih";
            dtpAsiTarih.Size = new Size(225, 27);
            dtpAsiTarih.TabIndex = 2;
            // 
            // lblAsiTarih
            // 
            lblAsiTarih.AutoSize = true;
            lblAsiTarih.Location = new Point(20, 93);
            lblAsiTarih.Name = "lblAsiTarih";
            lblAsiTarih.Size = new Size(47, 20);
            lblAsiTarih.TabIndex = 3;
            lblAsiTarih.Text = "Tarih: ";
            // 
            // btnAsiEkle
            // 
            btnAsiEkle.BackColor = Color.LightBlue;
            btnAsiEkle.Location = new Point(400, 87);
            btnAsiEkle.Name = "btnAsiEkle";
            btnAsiEkle.Size = new Size(150, 30);
            btnAsiEkle.TabIndex = 4;
            btnAsiEkle.Text = "➕ Ekle";
            btnAsiEkle.UseVisualStyleBackColor = false;
            btnAsiEkle.Click += btnAsiEkle_Click;
            // 
            // lstAsi
            // 
            lstAsi.BackColor = SystemColors.ButtonFace;
            lstAsi.Location = new Point(20, 130);
            lstAsi.Name = "lstAsi";
            lstAsi.Size = new Size(530, 150);
            lstAsi.TabIndex = 5;
            lstAsi.UseCompatibleStateImageBehavior = false;
            lstAsi.View = View.Details;
            // 
            // grpSaglik
            // 
            grpSaglik.Controls.Add(cmbSaglikHayvan);
            grpSaglik.Controls.Add(lblNotHayvan);
            grpSaglik.Controls.Add(txtSaglikNotu);
            grpSaglik.Controls.Add(lblSaglikNot);
            grpSaglik.Controls.Add(btnNotEkle);
            grpSaglik.Controls.Add(listNote);
            grpSaglik.Location = new Point(610, 330);
            grpSaglik.Name = "grpSaglik";
            grpSaglik.Size = new Size(570, 300);
            grpSaglik.TabIndex = 3;
            grpSaglik.TabStop = false;
            grpSaglik.Text = "Sağlık Notları";
            // 
            // cmbSaglikHayvan
            // 
            cmbSaglikHayvan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSaglikHayvan.FormattingEnabled = true;
            cmbSaglikHayvan.Location = new Point(100, 30);
            cmbSaglikHayvan.Name = "cmbSaglikHayvan";
            cmbSaglikHayvan.Size = new Size(208, 28);
            cmbSaglikHayvan.TabIndex = 4;
            // 
            // lblNotHayvan
            // 
            lblNotHayvan.AutoSize = true;
            lblNotHayvan.Location = new Point(20, 33);
            lblNotHayvan.Name = "lblNotHayvan";
            lblNotHayvan.Size = new Size(61, 20);
            lblNotHayvan.TabIndex = 3;
            lblNotHayvan.Text = "Hayvan:";
            // 
            // txtSaglikNotu
            // 
            txtSaglikNotu.Location = new Point(100, 60);
            txtSaglikNotu.Multiline = true;
            txtSaglikNotu.Name = "txtSaglikNotu";
            txtSaglikNotu.PlaceholderText = "Örn: Bugün halsizdi";
            txtSaglikNotu.Size = new Size(208, 60);
            txtSaglikNotu.TabIndex = 0;
            // 
            // lblSaglikNot
            // 
            lblSaglikNot.AutoSize = true;
            lblSaglikNot.Location = new Point(20, 63);
            lblSaglikNot.Name = "lblSaglikNot";
            lblSaglikNot.Size = new Size(41, 20);
            lblSaglikNot.TabIndex = 1;
            lblSaglikNot.Text = "Not: ";
            // 
            // btnNotEkle
            // 
            btnNotEkle.BackColor = Color.LightBlue;
            btnNotEkle.Location = new Point(400, 90);
            btnNotEkle.Name = "btnNotEkle";
            btnNotEkle.Size = new Size(150, 30);
            btnNotEkle.TabIndex = 2;
            btnNotEkle.Text = "➕ Ekle";
            btnNotEkle.UseVisualStyleBackColor = false;
            btnNotEkle.Click += btnNotEkle_Click;
            // 
            // listNote
            // 
            listNote.BackColor = SystemColors.ButtonFace;
            listNote.Location = new Point(20, 130);
            listNote.Name = "listNote";
            listNote.Size = new Size(530, 150);
            listNote.TabIndex = 3;
            listNote.UseCompatibleStateImageBehavior = false;
            listNote.View = View.Details;
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(20, 20);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 4;
            // 
            // lblUpcomingEvents
            // 
            lblUpcomingEvents.AutoSize = true;
            lblUpcomingEvents.Location = new Point(20, 190);
            lblUpcomingEvents.Name = "lblUpcomingEvents";
            lblUpcomingEvents.Size = new Size(133, 20);
            lblUpcomingEvents.TabIndex = 5;
            lblUpcomingEvents.Text = "Yaklaşan Etkinlikler";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 192, 255);
            tabPage2.Controls.Add(grpHayvanList);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1212, 651);
            tabPage2.TabIndex = 2;
            tabPage2.Text = "📋 Kayıt Yönetimi";
            // 
            // grpHayvanList
            // 
            grpHayvanList.Controls.Add(HayvanListe);
            grpHayvanList.Controls.Add(btnHayvanDetay);
            grpHayvanList.Controls.Add(btnHayvanSil);
            grpHayvanList.Location = new Point(20, 20);
            grpHayvanList.Name = "grpHayvanList";
            grpHayvanList.Size = new Size(1150, 580);
            grpHayvanList.TabIndex = 0;
            grpHayvanList.TabStop = false;
            grpHayvanList.Text = "Hayvan Listesi";
            // 
            // HayvanListe
            // 
            HayvanListe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HayvanListe.BackgroundColor = Color.White;
            HayvanListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HayvanListe.Location = new Point(18, 35);
            HayvanListe.Name = "HayvanListe";
            HayvanListe.RowHeadersWidth = 51;
            HayvanListe.RowTemplate.Height = 29;
            HayvanListe.Size = new Size(1107, 477);
            HayvanListe.TabIndex = 3;
            // 
            // btnHayvanDetay
            // 
            btnHayvanDetay.BackColor = Color.LightBlue;
            btnHayvanDetay.Location = new Point(20, 526);
            btnHayvanDetay.Name = "btnHayvanDetay";
            btnHayvanDetay.Size = new Size(200, 35);
            btnHayvanDetay.TabIndex = 1;
            btnHayvanDetay.Text = "🔍 Detay";
            btnHayvanDetay.UseVisualStyleBackColor = false;
            btnHayvanDetay.Click += btnHayvanDetay_Click;
            // 
            // btnHayvanSil
            // 
            btnHayvanSil.BackColor = Color.FromArgb(207, 14, 14);
            btnHayvanSil.ForeColor = Color.White;
            btnHayvanSil.Location = new Point(247, 526);
            btnHayvanSil.Name = "btnHayvanSil";
            btnHayvanSil.Size = new Size(200, 35);
            btnHayvanSil.TabIndex = 2;
            btnHayvanSil.Text = "❌ Kayıt Sil";
            btnHayvanSil.UseVisualStyleBackColor = false;
            btnHayvanSil.Click += btnHayvanSil_Click;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(192, 192, 255);
            tabPage4.Controls.Add(grpKullanici);
            tabPage4.Controls.Add(groupBoxTheme);
            tabPage4.Controls.Add(groupBoxGuncelle);
            tabPage4.Controls.Add(groupBoxGeriBildirim);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(btnLogout);
            tabPage4.Controls.Add(panelFooter);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(20);
            tabPage4.Size = new Size(1212, 651);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "👤 Profil";
            // 
            // grpKullanici
            // 
            grpKullanici.Controls.Add(lblName);
            grpKullanici.Controls.Add(lblEmail);
            grpKullanici.Controls.Add(lblGiris);
            grpKullanici.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            grpKullanici.Location = new Point(33, 38);
            grpKullanici.Name = "grpKullanici";
            grpKullanici.Size = new Size(826, 130);
            grpKullanici.TabIndex = 7;
            grpKullanici.TabStop = false;
            grpKullanici.Text = "Kullanıcı Bilgileri";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(20, 40);
            lblName.Name = "lblName";
            lblName.Size = new Size(98, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Ad Soyad: ---";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.Location = new Point(20, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(77, 20);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "E-mail: ---";
            // 
            // lblGiris
            // 
            lblGiris.AutoSize = true;
            lblGiris.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblGiris.Location = new Point(613, 52);
            lblGiris.Name = "lblGiris";
            lblGiris.Size = new Size(104, 20);
            lblGiris.TabIndex = 12;
            lblGiris.Text = "🕒 Giriş Saati ";
            // 
            // groupBoxTheme
            // 
            groupBoxTheme.Controls.Add(lblTema);
            groupBoxTheme.Controls.Add(cmbTema);
            groupBoxTheme.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxTheme.Location = new Point(879, 39);
            groupBoxTheme.Name = "groupBoxTheme";
            groupBoxTheme.Size = new Size(300, 129);
            groupBoxTheme.TabIndex = 8;
            groupBoxTheme.TabStop = false;
            groupBoxTheme.Text = "Tema Ayarları";
            // 
            // lblTema
            // 
            lblTema.AutoSize = true;
            lblTema.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblTema.Location = new Point(10, 56);
            lblTema.Name = "lblTema";
            lblTema.Size = new Size(75, 20);
            lblTema.TabIndex = 0;
            lblTema.Text = "Tema Seç:";
            // 
            // cmbTema
            // 
            cmbTema.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTema.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            cmbTema.Items.AddRange(new object[] { "🔄 Varsayılan Tema", "☀️ Açık Tema", "🌙 Koyu Tema" });
            cmbTema.Location = new Point(91, 51);
            cmbTema.Name = "cmbTema";
            cmbTema.Size = new Size(200, 31);
            cmbTema.TabIndex = 1;
            cmbTema.SelectedIndexChanged += CmbTema_SelectedIndexChanged;
            // 
            // groupBoxGuncelle
            // 
            groupBoxGuncelle.Controls.Add(lblKullaniciAdiGuncelle);
            groupBoxGuncelle.Controls.Add(txtKullaniciAdi);
            groupBoxGuncelle.Controls.Add(lblMailGuncelle);
            groupBoxGuncelle.Controls.Add(txtMail);
            groupBoxGuncelle.Controls.Add(lblSifreGuncelle);
            groupBoxGuncelle.Controls.Add(txtSifre);
            groupBoxGuncelle.Controls.Add(btnBilgileriGuncelle);
            groupBoxGuncelle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBoxGuncelle.Location = new Point(33, 203);
            groupBoxGuncelle.Name = "groupBoxGuncelle";
            groupBoxGuncelle.Size = new Size(400, 310);
            groupBoxGuncelle.TabIndex = 10;
            groupBoxGuncelle.TabStop = false;
            groupBoxGuncelle.Text = "Bilgileri Güncelle";
            // 
            // lblKullaniciAdiGuncelle
            // 
            lblKullaniciAdiGuncelle.AutoSize = true;
            lblKullaniciAdiGuncelle.Location = new Point(25, 40);
            lblKullaniciAdiGuncelle.Name = "lblKullaniciAdiGuncelle";
            lblKullaniciAdiGuncelle.Size = new Size(126, 20);
            lblKullaniciAdiGuncelle.TabIndex = 0;
            lblKullaniciAdiGuncelle.Text = "Yeni Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(170, 37);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(200, 27);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // lblMailGuncelle
            // 
            lblMailGuncelle.AutoSize = true;
            lblMailGuncelle.Location = new Point(25, 101);
            lblMailGuncelle.Name = "lblMailGuncelle";
            lblMailGuncelle.Size = new Size(86, 20);
            lblMailGuncelle.TabIndex = 2;
            lblMailGuncelle.Text = "Yeni E-mail:";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(170, 98);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(200, 27);
            txtMail.TabIndex = 3;
            // 
            // lblSifreGuncelle
            // 
            lblSifreGuncelle.AutoSize = true;
            lblSifreGuncelle.Location = new Point(25, 168);
            lblSifreGuncelle.Name = "lblSifreGuncelle";
            lblSifreGuncelle.Size = new Size(73, 20);
            lblSifreGuncelle.TabIndex = 4;
            lblSifreGuncelle.Text = "Yeni Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(170, 165);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 27);
            txtSifre.TabIndex = 5;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // btnBilgileriGuncelle
            // 
            btnBilgileriGuncelle.BackColor = Color.Chartreuse;
            btnBilgileriGuncelle.Location = new Point(170, 250);
            btnBilgileriGuncelle.Name = "btnBilgileriGuncelle";
            btnBilgileriGuncelle.Size = new Size(200, 35);
            btnBilgileriGuncelle.TabIndex = 8;
            btnBilgileriGuncelle.Text = "✔ Bilgileri Güncelle";
            btnBilgileriGuncelle.UseVisualStyleBackColor = false;
            btnBilgileriGuncelle.Click += BtnBilgileriGuncelle_Click;
            // 
            // groupBoxGeriBildirim
            // 
            groupBoxGeriBildirim.Controls.Add(cmbPuan);
            groupBoxGeriBildirim.Controls.Add(lblPuan);
            groupBoxGeriBildirim.Controls.Add(txtGeriBildirim);
            groupBoxGeriBildirim.Controls.Add(btnGeriBildirimGonder);
            groupBoxGeriBildirim.Location = new Point(482, 203);
            groupBoxGeriBildirim.Name = "groupBoxGeriBildirim";
            groupBoxGeriBildirim.Size = new Size(366, 310);
            groupBoxGeriBildirim.TabIndex = 11;
            groupBoxGeriBildirim.TabStop = false;
            groupBoxGeriBildirim.Text = "Geri Bildirim";
            // 
            // cmbPuan
            // 
            cmbPuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPuan.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            cmbPuan.Location = new Point(226, 26);
            cmbPuan.Name = "cmbPuan";
            cmbPuan.Size = new Size(120, 28);
            cmbPuan.TabIndex = 0;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.Location = new Point(153, 30);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(67, 20);
            lblPuan.TabIndex = 0;
            lblPuan.Text = "Puanınız:";
            // 
            // txtGeriBildirim
            // 
            txtGeriBildirim.Location = new Point(15, 70);
            txtGeriBildirim.Multiline = true;
            txtGeriBildirim.Name = "txtGeriBildirim";
            txtGeriBildirim.PlaceholderText = "Geri bildiriminizi buraya yazın...";
            txtGeriBildirim.Size = new Size(331, 174);
            txtGeriBildirim.TabIndex = 1;
            // 
            // btnGeriBildirimGonder
            // 
            btnGeriBildirimGonder.BackColor = Color.LightSteelBlue;
            btnGeriBildirimGonder.Location = new Point(213, 250);
            btnGeriBildirimGonder.Name = "btnGeriBildirimGonder";
            btnGeriBildirimGonder.Size = new Size(133, 40);
            btnGeriBildirimGonder.TabIndex = 2;
            btnGeriBildirimGonder.Text = "📤 Gönder";
            btnGeriBildirimGonder.UseVisualStyleBackColor = false;
            btnGeriBildirimGonder.Click += btnGeriBildirimGonder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(hsbSifre);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnHspSil);
            groupBox1.Controls.Add(hsbMail);
            groupBox1.Controls.Add(hsbAd);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(893, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 310);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hesap Silme";
            // 
            // hsbSifre
            // 
            hsbSifre.Location = new Point(97, 193);
            hsbSifre.Name = "hsbSifre";
            hsbSifre.Size = new Size(156, 27);
            hsbSifre.TabIndex = 8;
            hsbSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 190);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 7;
            label3.Text = "Şifre:";
            // 
            // btnHspSil
            // 
            btnHspSil.BackColor = Color.FromArgb(207, 14, 14);
            btnHspSil.ForeColor = SystemColors.ButtonHighlight;
            btnHspSil.Location = new Point(133, 245);
            btnHspSil.Name = "btnHspSil";
            btnHspSil.Size = new Size(120, 40);
            btnHspSil.TabIndex = 6;
            btnHspSil.Text = "❌ Hesabı Sil";
            btnHspSil.UseVisualStyleBackColor = false;
            btnHspSil.Click += btnHspSil_Click;
            // 
            // hsbMail
            // 
            hsbMail.Location = new Point(97, 120);
            hsbMail.Name = "hsbMail";
            hsbMail.Size = new Size(156, 27);
            hsbMail.TabIndex = 5;
            // 
            // hsbAd
            // 
            hsbAd.Location = new Point(97, 50);
            hsbAd.Name = "hsbAd";
            hsbAd.Size = new Size(156, 27);
            hsbAd.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 53);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 2;
            label1.Text = "Ad Soyad: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 123);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "E-mail: ";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(228, 154, 107);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(551, 543);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(208, 45);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "🚪 Çıkış Yap";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // panelFooter
            // 
            panelFooter.Controls.Add(lblVersiyon);
            panelFooter.Location = new Point(3, 612);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1209, 31);
            panelFooter.TabIndex = 3;
            // 
            // lblVersiyon
            // 
            lblVersiyon.AutoSize = true;
            lblVersiyon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblVersiyon.Location = new Point(264, 6);
            lblVersiyon.Name = "lblVersiyon";
            lblVersiyon.Size = new Size(631, 20);
            lblVersiyon.TabIndex = 1;
            lblVersiyon.Text = "©2025 Her Hakkı Saklıdır. | Evcil Hayvan Bakım Sistemi | Geliştirici: Ceren ATAŞ | Versiyon: 1.0.0";
            lblVersiyon.Click += lblVersiyon_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // PetUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(1220, 684);
            Controls.Add(tabControl1);
            Name = "PetUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evcil Hayvan Yönetim Sistemi";
            Load += PetUser_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            grpHayvanProfili.ResumeLayout(false);
            grpHayvanProfili.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbSecFotoHayvan).EndInit();
            grpHayvanEkle.ResumeLayout(false);
            grpHayvanEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPetPhoto).EndInit();
            grpHatirlatici.ResumeLayout(false);
            tabPageCare.ResumeLayout(false);
            tabPageCare.PerformLayout();
            grpBeslenme.ResumeLayout(false);
            grpBeslenme.PerformLayout();
            grpVetRandevu.ResumeLayout(false);
            grpVetRandevu.PerformLayout();
            grpAsiTarih.ResumeLayout(false);
            grpAsiTarih.PerformLayout();
            grpSaglik.ResumeLayout(false);
            grpSaglik.PerformLayout();
            tabPage2.ResumeLayout(false);
            grpHayvanList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)HayvanListe).EndInit();
            tabPage4.ResumeLayout(false);
            grpKullanici.ResumeLayout(false);
            grpKullanici.PerformLayout();
            groupBoxTheme.ResumeLayout(false);
            groupBoxTheme.PerformLayout();
            groupBoxGuncelle.ResumeLayout(false);
            groupBoxGuncelle.PerformLayout();
            groupBoxGeriBildirim.ResumeLayout(false);
            groupBoxGeriBildirim.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPageCare;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private GroupBox grpHayvanProfili;
        private ListView listHayvanListe;
        private GroupBox grpHayvanEkle;
        private TextBox txtPetName;
        private Label lblPetName;
        private ComboBox cmbPetType;
        private Label lblPetType;
        private TextBox txtPetYas;
        private Label lblPetAge;
        private Button btnHayvanEkle;
        private ComboBox cmbPetCins;
        private Label label4;
        private GroupBox grpBeslenme;
        private ComboBox comboBoxPetFeeding;
        private Label lblHayvan;
        private TextBox txtBesSaati;
        private Label lblBesSaat;
        private Button BtnBeslenmeEkle;
        private ListView listBeslenme;
        private GroupBox grpVetRandevu;
        private ComboBox comboBoxPetVet;
        private Label lblVetHayvan;
        private DateTimePicker dtpVetDate;
        private Label lblVetTarih;
        private TextBox txtVetAcikla;
        private Label lblVetAciklama;
        private Button btnVetEkle;
        private ListView listVet;
        private GroupBox grpAsiTarih;
        private ComboBox cmbAsiHayvan;
        private Label lblAsiHayvan;
        private TextBox txtAsiAdi;
        private Label lblAsiAdi;
        private DateTimePicker dtpAsiTarih;
        private Label lblAsiTarih;
        private Button btnAsiEkle;
        private ListView lstAsi;
        private GroupBox grpSaglik;
        private ComboBox cmbSaglikHayvan;
        private Label lblNotHayvan;
        private TextBox txtSaglikNotu;
        private Label lblSaglikNot;
        private Button btnNotEkle;
        private ListView listNote;
        private MonthCalendar monthCalendar;
        private Label lblUpcomingEvents;
        private GroupBox grpHayvanList;
        private Button btnHayvanSil;
        private GroupBox grpKullanici;
        private Label lblName;
        private Label lblEmail;
        private Label lblGiris;
        private GroupBox groupBoxTheme;
        private Label lblTema;
        private ComboBox cmbTema;
        private GroupBox groupBoxGuncelle;
        private Label lblKullaniciAdiGuncelle;
        private TextBox txtKullaniciAdi;
        private Label lblMailGuncelle;
        private TextBox txtMail;
        private Label lblSifreGuncelle;
        private TextBox txtSifre;
        private Button btnBilgileriGuncelle;
        private GroupBox groupBoxGeriBildirim;
        private Label lblPuan;
        private ComboBox cmbPuan;
        private TextBox txtGeriBildirim;
        private Button btnGeriBildirimGonder;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox hsbAd;
        private TextBox hsbMail;
        private TextBox hsbSifre;
        private Button btnHspSil;
        private Button btnLogout;
        private Panel panelFooter;
        private Label lblVersiyon;
        private GroupBox grpHatirlatici;
        private ListView listViewReminders;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private Button btnResimYukle;
        private PictureBox pbPetPhoto;
        private Label lblEklenenFoto;
        private Label lblSecHayvanCins;
        private Label lblSecHayvanTur;
        private Label lblSecHayvanYas;
        private Label lblSecHayvanİsim;
        private PictureBox pbSecFotoHayvan;
        private Label lblSecilenFoto;
        private Button btnHayvanDetay;
        private DataGridView HayvanListe;
    }
}