// PetUser.cs: Kullanıcı ana ekranını ve evcil hayvan yönetimini sağlar.
using Microsoft.EntityFrameworkCore;
// Entity Framework Core için gerekli sınıfları dahil eder.
using System;
// Temel C# sınıfları ve veri tipleri için System ad alanını dahil eder.
using System.Runtime.InteropServices;
// Platformlar arası işlemler için gerekli sınıfları içerir.
using System.Collections.Generic;
// Generic koleksiyonlar için gerekli ad alanıdır.
using System.ComponentModel;
// Bileşen model sınıfları için ad alanıdır.
using System.Data;
// Veri işleme sınıfları için ad alanıdır.
using System.Drawing;
// Görüntü işleme sınıfları için ad alanıdır.
using System.IO;
// Dosya işlemleri için gerekli sınıfları içerir.
using System.Linq;
// LINQ sorguları için gerekli ad alanıdır.
using System.Net.Mail;
// E-posta gönderme sınıfları için ad alanıdır.
using System.Net;
// Ağ işlemleri için gerekli sınıfları içerir.
using System.Text;
// Metin işleme sınıfları için ad alanıdır.
using System.Threading.Tasks;
// Asenkron programlama için sınıfları içerir.
using System.Windows.Forms;
// Windows Forms için gerekli sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    public partial class PetUser : Form
    // PetUser sınıfı, kullanıcı ana ekranını yöneten bir Windows Forms sınıfıdır.
    {
        private byte[] _resimBytes; // Resmi geçici olarak saklar
        private Dictionary<string, string[]> cinsler; // Tür ve cins ilişkisi
        private readonly int _kullaniciId; // Oturum açmış kullanıcı kimliği
        private NotifyIcon notifyIcon; // Bildirim balonları
        private System.Windows.Forms.Timer hatirlaticiTimer; // Hatırlatıcı zamanlayıcısı

        // Form başlatıcısı, kullanıcı kimliğini alır ve bileşenleri hazırlar.
        public PetUser(int kullaniciId)
        {
            InitializeComponent();
            _kullaniciId = kullaniciId;
            InitializeData();
            InitializeHatirlaticiListView();
            InitializeNotifyIconAndTimer();
            LoadAnimals();
            LoadAnimalsToComboBox();
            LoadFeedingTimes();
            LoadVetAppointments();
            LoadAciAppointments();
            LoadNoteAppointments();
        }

        // Tür, cins ve liste görünümlerini başlatır.
        private void InitializeData()
        {
            cinsler = new Dictionary<string, string[]>
            {
                { "Kedi", new[] { "Tekir", "Siyam", "Pers", "British", "Scottish", "Persian", "Siyam", "Van Kedisi", "Ragdoll" } },
                { "Köpek", new[] { "Golden", "Akita", "Border Collie", "Kangal", "Pomeranian", "Chihuahua", "Husky", "Samoyed", "Toy Poodle", "Buldog" } },
                { "Kuş", new[] { "Muhabbet Kuşu", "Cennet Papağanı", "Kanarya", "Finch Kuşu", "Sultan Papağanı", "Jako Papağanı", "Amazon Papağanı" } },
                { "Balık", new[] { "Japon Balığı", "Guppy", "Beta", "Molly", "Platy", "Kılıç Kuyruk", "Neon Tetra", "Danio Rerio" } },
                { "Tavşan", new[] { "Hollanda Lop", "Mini Rex", "AslanBaş", "Hollanda Cüce Tavşanı", "Angora" } },
                { "Kaplumbağa", new[] { "Kırmızı Yanaklı Su Kaplumbağası", "Sarı Yanaklı Su Kaplumbağası", "Musk" } }
            };

            if (cinsler == null || !cinsler.Any())
            {
                MessageBox.Show("Tür ve cins verileri yüklenemedi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cmbPetType.Items.Clear();
            cmbPetType.Items.AddRange(cinsler.Keys.ToArray());

            // Hayvan listesi için sütunlar
            listHayvanListe.Columns.Clear();
            listHayvanListe.Columns.Add("İsim", 100);
            listHayvanListe.Columns.Add("Yaş", 50);
            listHayvanListe.Columns.Add("Tür", 100);
            listHayvanListe.Columns.Add("Cins", 100);
            listHayvanListe.FullRowSelect = true;

            // Beslenme listesi için sütunlar
            listBeslenme.Columns.Clear();
            listBeslenme.Columns.Add("Hayvan Adı", 150);
            listBeslenme.Columns.Add("Beslenme Saati", 100);
            listBeslenme.FullRowSelect = true;
            listBeslenme.View = View.Details;

            // Veteriner randevuları için sütunlar
            listVet.Columns.Clear();
            listVet.Columns.Add("Hayvan Adı", 150);
            listVet.Columns.Add("Randevu Tarihi", 120);
            listVet.Columns.Add("Açıklama", 200);
            listVet.FullRowSelect = true;
            listVet.View = View.Details;

            // Aşı listesi için sütunlar
            lstAsi.Columns.Clear();
            lstAsi.Columns.Add("Hayvan Adı", 150);
            lstAsi.Columns.Add("Aşı Tarihi", 120);
            lstAsi.Columns.Add("Aşı Adı", 200);
            lstAsi.FullRowSelect = true;
            lstAsi.View = View.Details;

            // Not listesi için sütunlar
            listNote.Columns.Clear();
            listNote.Columns.Add("Hayvan Adı", 150);
            listNote.Columns.Add("Not Tarihi", 120);
            listNote.Columns.Add("Not", 200);
            listNote.FullRowSelect = true;
            listNote.View = View.Details;
        }

        // Hatırlatıcı listesi için sütunlar
        private void InitializeHatirlaticiListView()
        {
            listViewReminders.Columns.Clear();
            listViewReminders.Columns.Add("Tür", 100);
            listViewReminders.Columns.Add("Hayvan Adı", 150);
            listViewReminders.Columns.Add("Tarih/Saat", 120);
            listViewReminders.Columns.Add("Açıklama", 200);
            listViewReminders.FullRowSelect = true;
            listViewReminders.View = View.Details;
        }

        // Bildirim simgesi ve zamanlayıcıyı başlatır.
        private void InitializeNotifyIconAndTimer()
        {
            try
            {
                notifyIcon = new NotifyIcon
                {
                    Icon = SystemIcons.Information,
                    Visible = true,
                    Text = "Evcil Hayvan Yönetim Sistemi",
                    BalloonTipIcon = ToolTipIcon.Info,
                    BalloonTipTitle = "Evcil Hayvan Yönetim Sistemi"
                };

                var contextMenu = new ContextMenuStrip();
                var showItem = new ToolStripMenuItem("Göster");
                showItem.Click += (s, e) => this.Show();
                var exitItem = new ToolStripMenuItem("Çıkış");
                exitItem.Click += (s, e) => Application.Exit();
                contextMenu.Items.AddRange(new ToolStripItem[] { showItem, exitItem });
                notifyIcon.ContextMenuStrip = contextMenu;

                this.Resize += (s, e) =>
                {
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        notifyIcon.ShowBalloonTip(2000, "Evcil Hayvan Yönetim Sistemi", "Uygulama sistem tepsisinde çalışıyor.", ToolTipIcon.Info);
                        this.Hide();
                    }
                };

                hatirlaticiTimer = new System.Windows.Forms.Timer { Interval = 30000 };
                hatirlaticiTimer.Tick += HatirlaticiTimer_Tick;
                hatirlaticiTimer.Start();

                notifyIcon.ShowBalloonTip(2000, "Evcil Hayvan Yönetim Sistemi", "Bildirim sistemi aktif!", ToolTipIcon.Info);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bildirim sistemi başlatılırken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Yaklaşan randevu, aşı ve beslenme hatırlatıcılarını yükler.
        // LoadHatirlatici metodunda değişiklik
        private void LoadHatirlatici()
        {
            try
            {
                listViewReminders.Items.Clear();
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var now = DateTime.Now;
                    var endTime = now.AddHours(24);
                    var allReminders = new List<dynamic>();

                    var randevular = ctx.Randevular
                        .Include(r => r.EvcilHayvan)
                        .Where(r => r.EvcilHayvan.KullaniciId == _kullaniciId && r.RandevuTarihi >= now && r.RandevuTarihi <= endTime)
                        .AsNoTracking()
                        .ToList();

                    foreach (var randevu in randevular)
                    {
                        allReminders.Add(new
                        {
                            Type = "🏥 Randevu",
                            Name = randevu.EvcilHayvan.Ad,
                            Time = randevu.RandevuTarihi,
                            Description = randevu.Aciklama ?? "Belirtilmemiş",
                            Id = randevu.RandevuId
                        });
                    }

                    var asilar = ctx.Asilar
                        .Include(a => a.EvcilHayvan)
                        .Where(a => a.EvcilHayvan.KullaniciId == _kullaniciId && a.AsiTarihi >= now && a.AsiTarihi <= endTime)
                        .AsNoTracking()
                        .ToList();

                    foreach (var asi in asilar)
                    {
                        allReminders.Add(new
                        {
                            Type = "💉 Aşı",
                            Name = asi.EvcilHayvan.Ad,
                            Time = asi.AsiTarihi,
                            Description = asi.AsiAdi ?? "Belirtilmemiş",
                            Id = asi.AsiId
                        });
                    }

                    // Beslenmeler için güncellenmiş sorgu
                    var beslenmeler = ctx.Beslenmeler
                        .Include(b => b.EvcilHayvan)
                        .Where(b => b.EvcilHayvan.KullaniciId == _kullaniciId)
                        .AsNoTracking()
                        .ToList() // Veriyi belleğe çek
                        .Where(b => b.BeslenmeSaati.Date >= now.Date && b.BeslenmeSaati.Date <= endTime.Date // Tarih kontrolü
                            && b.BeslenmeSaati.Hour >= now.Hour && b.BeslenmeSaati.Minute >= now.Minute // Saat ve dakika kontrolü
                            && (b.BeslenmeSaati.Hour < endTime.Hour || (b.BeslenmeSaati.Hour == endTime.Hour && b.BeslenmeSaati.Minute <= endTime.Minute)));

                    foreach (var beslenme in beslenmeler)
                    {
                        allReminders.Add(new
                        {
                            Type = "🍽️ Beslenme",
                            Name = beslenme.EvcilHayvan.Ad,
                            Time = DateTime.Today.Add(beslenme.BeslenmeSaati.TimeOfDay),
                            Description = "Beslenme Saati",
                            Id = beslenme.BeslenmeId
                        });
                    }

                    var sortedReminders = allReminders.OrderBy(r => r.Time).ToList();

                    foreach (var reminder in sortedReminders)
                    {
                        var item = new ListViewItem(reminder.Type);
                        item.SubItems.Add(reminder.Name);
                        item.SubItems.Add(reminder.Time.ToString("dd/MM/yyyy HH:mm"));
                        item.SubItems.Add(reminder.Description);
                        item.Tag = new { Type = reminder.Type, Id = reminder.Id, Time = reminder.Time };
                        listViewReminders.Items.Add(item);
                    }

                    if (listViewReminders.Items.Count == 0)
                    {
                        var item = new ListViewItem("Bilgi");
                        item.SubItems.Add("Yaklaşan hatırlatıcı bulunmuyor");
                        item.SubItems.Add("-");
                        item.SubItems.Add("24 saat içinde planlanmış bir etkinlik yok");
                        listViewReminders.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hatırlatıcı yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // HatirlaticiTimer_Tick metodunda değişiklik
        private void HatirlaticiTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                var now = DateTime.Now;
                var threshold = now.AddMinutes(30);

                using (var ctx = new EvcilHayvanDbContext())
                {
                    var randevular = ctx.Randevular
                        .Include(r => r.EvcilHayvan)
                        .Where(r => r.EvcilHayvan.KullaniciId == _kullaniciId && r.RandevuTarihi >= now && r.RandevuTarihi <= threshold)
                        .AsNoTracking()
                        .ToList();

                    foreach (var randevu in randevular)
                    {
                        notifyIcon.BalloonTipTitle = "🏥 Randevu Hatırlatıcısı";
                        notifyIcon.BalloonTipText = $"'{randevu.EvcilHayvan.Ad}' için randevu: {randevu.RandevuTarihi:dd/MM/yyyy HH:mm}\nAçıklama: {randevu.Aciklama}";
                        notifyIcon.ShowBalloonTip(10000);
                        System.Threading.Thread.Sleep(1000);
                    }

                    var asilar = ctx.Asilar
                        .Include(a => a.EvcilHayvan)
                        .Where(a => a.EvcilHayvan.KullaniciId == _kullaniciId && a.AsiTarihi >= now && a.AsiTarihi <= threshold)
                        .AsNoTracking()
                        .ToList();

                    foreach (var asi in asilar)
                    {
                        notifyIcon.BalloonTipTitle = "💉 Aşı Hatırlatıcısı";
                        notifyIcon.BalloonTipText = $"'{asi.EvcilHayvan.Ad}' için aşı: {asi.AsiTarihi:dd/MM/yyyy HH:mm}\nAşı: {asi.AsiAdi}";
                        notifyIcon.ShowBalloonTip(10000);
                        System.Threading.Thread.Sleep(1000);
                    }

                    // Beslenmeler için güncellenmiş sorgu
                    var beslenmeler = ctx.Beslenmeler
                        .Include(b => b.EvcilHayvan)
                        .Where(b => b.EvcilHayvan.KullaniciId == _kullaniciId)
                        .AsNoTracking()
                        .ToList() // Veriyi belleğe çek
                        .Where(b => b.BeslenmeSaati.Date >= now.Date && b.BeslenmeSaati.Date <= threshold.Date // Tarih kontrolü
                            && b.BeslenmeSaati.Hour >= now.Hour && b.BeslenmeSaati.Minute >= now.Minute // Saat ve dakika kontrolü
                            && (b.BeslenmeSaati.Hour < threshold.Hour || (b.BeslenmeSaati.Hour == threshold.Hour && b.BeslenmeSaati.Minute <= threshold.Minute)));

                    foreach (var beslenme in beslenmeler)
                    {
                        notifyIcon.BalloonTipTitle = "🍽️ Beslenme Hatırlatıcısı";
                        notifyIcon.BalloonTipText = $"'{beslenme.EvcilHayvan.Ad}' için beslenme saati: {beslenme.BeslenmeSaati:HH:mm}";
                        notifyIcon.ShowBalloonTip(10000);
                        System.Threading.Thread.Sleep(1000);
                    }
                }

                LoadHatirlatici();
            }
            catch (Exception ex)
            {
                notifyIcon.BalloonTipTitle = "Hata";
                notifyIcon.BalloonTipText = $"Bildirim kontrolünde hata: {ex.Message}";
                notifyIcon.ShowBalloonTip(10000);
            }
        }

        // Form kapanırken kaynakları temizler.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            hatirlaticiTimer?.Stop();
            hatirlaticiTimer?.Dispose();
            notifyIcon?.Dispose();
        }

        // Kullanıcının evcil hayvanlarını yükler.
        private void LoadAnimals()
        {
            try
            {
                listHayvanListe.Items.Clear();
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var hayvanlar = ctx.EvcilHayvanlar
                        .Where(h => h.KullaniciId == _kullaniciId)
                        .Select(h => new { h.EvcilHayvanId, h.Ad, h.Yas, h.Tur, h.Cinsi })
                        .AsNoTracking()
                        .ToList();

                    HayvanListe.AutoGenerateColumns = false;
                    HayvanListe.Columns.Clear();
                    HayvanListe.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "EvcilHayvanId", Name = "EvcilHayvanId", HeaderText = "ID", Visible = false });
                    HayvanListe.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Ad", Name = "Ad", HeaderText = "İsim" });
                    HayvanListe.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Yas", Name = "Yas", HeaderText = "Yaş" });
                    HayvanListe.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Tur", Name = "Tur", HeaderText = "Tür" });
                    HayvanListe.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Cinsi", Name = "Cinsi", HeaderText = "Cins" });

                    HayvanListe.DataSource = hayvanlar;

                    foreach (var hayvan in hayvanlar)
                    {
                        var item = new ListViewItem(hayvan.Ad);
                        item.SubItems.Add(hayvan.Yas.ToString());
                        item.SubItems.Add(hayvan.Tur);
                        item.SubItems.Add(hayvan.Cinsi ?? "Belirtilmemiş");
                        item.Tag = hayvan.EvcilHayvanId;
                        listHayvanListe.Items.Add(item);
                    }
                }
                LoadHatirlatici();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Evcil hayvanlar yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ComboBox'lara evcil hayvanları yükler.
        private void LoadAnimalsToComboBox()
        {
            try
            {
                comboBoxPetFeeding.Items.Clear();
                comboBoxPetVet.Items.Clear();
                cmbAsiHayvan.Items.Clear();
                cmbSaglikHayvan.Items.Clear();

                using (var ctx = new EvcilHayvanDbContext())
                {
                    var hayvanlar = ctx.EvcilHayvanlar
                        .Where(h => h.KullaniciId == _kullaniciId)
                        .Select(h => new { h.EvcilHayvanId, h.Ad })
                        .AsNoTracking()
                        .ToList();

                    LoadComboBoxItems(hayvanlar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hayvan listesi yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ComboBox'lara hayvanları ekler.
        private void LoadComboBoxItems(IEnumerable<dynamic> hayvanlar)
        {
            foreach (var hayvan in hayvanlar)
            {
                var petItem = new { Id = hayvan.EvcilHayvanId, Ad = hayvan.Ad };
                comboBoxPetFeeding.Items.Add(petItem);
                comboBoxPetVet.Items.Add(petItem);
                cmbAsiHayvan.Items.Add(petItem);
                cmbSaglikHayvan.Items.Add(petItem);
            }

            comboBoxPetFeeding.DisplayMember = "Ad";
            comboBoxPetFeeding.ValueMember = "Id";
            comboBoxPetVet.DisplayMember = "Ad";
            comboBoxPetVet.ValueMember = "Id";
            cmbAsiHayvan.DisplayMember = "Ad";
            cmbAsiHayvan.ValueMember = "Id";
            cmbSaglikHayvan.DisplayMember = "Ad";
            cmbSaglikHayvan.ValueMember = "Id";
        }

        // Beslenme saatlerini yükler.
        private void LoadFeedingTimes()
        {
            try
            {
                listBeslenme.Items.Clear();
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var beslenmeler = ctx.Beslenmeler
                        .Include(b => b.EvcilHayvan)
                        .Where(b => b.EvcilHayvan.KullaniciId == _kullaniciId)
                        .AsNoTracking()
                        .ToList();

                    foreach (var beslenme in beslenmeler)
                    {
                        var item = new ListViewItem(beslenme.EvcilHayvan.Ad);
                        item.SubItems.Add(beslenme.BeslenmeSaati.ToString("HH:mm"));
                        listBeslenme.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beslenme saatleri yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Veteriner randevularını yükler.
        private void LoadVetAppointments()
        {
            try
            {
                listVet.Items.Clear();
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var randevular = ctx.Randevular
                        .Include(r => r.EvcilHayvan)
                        .Where(r => r.EvcilHayvan.KullaniciId == _kullaniciId)
                        .AsNoTracking()
                        .ToList();

                    foreach (var randevu in randevular)
                    {
                        var item = new ListViewItem(randevu.EvcilHayvan.Ad);
                        item.SubItems.Add(randevu.RandevuTarihi.ToString("dd/MM/yyyy HH:mm"));
                        item.SubItems.Add(randevu.Aciklama ?? "Belirtilmemiş");
                        listVet.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Randevular yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Aşı kayıtlarını yükler.
        private void LoadAciAppointments()
        {
            try
            {
                lstAsi.Items.Clear();
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var asilar = ctx.Asilar
                        .Include(a => a.EvcilHayvan)
                        .Where(a => a.EvcilHayvan.KullaniciId == _kullaniciId)
                        .AsNoTracking()
                        .ToList();

                    foreach (var asi in asilar)
                    {
                        var item = new ListViewItem(asi.EvcilHayvan.Ad);
                        item.SubItems.Add(asi.AsiTarihi.ToString("dd/MM/yyyy HH:mm"));
                        item.SubItems.Add(asi.AsiAdi ?? "Belirtilmemiş");
                        lstAsi.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aşılar yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sağlık notlarını yükler.
        private void LoadNoteAppointments()
        {
            try
            {
                listNote.Items.Clear();
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var notlar = ctx.SaglikNotlari
                        .Include(n => n.EvcilHayvan)
                        .Where(n => n.EvcilHayvan.KullaniciId == _kullaniciId)
                        .AsNoTracking()
                        .ToList();

                    foreach (var not in notlar)
                    {
                        var item = new ListViewItem(not.EvcilHayvan.Ad);
                        item.SubItems.Add(not.NotTarihi.ToString("dd/MM/yyyy HH:mm"));
                        item.SubItems.Add(not.Not ?? "Belirtilmemiş");
                        listNote.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sağlık notları yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tür seçildiğinde cinsleri günceller.
        private void cmbPetType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPetType.SelectedItem != null)
            {
                string secilenTur = cmbPetType.SelectedItem.ToString();
                if (cinsler.ContainsKey(secilenTur))
                {
                    cmbPetCins.Items.Clear();
                    cmbPetCins.Items.AddRange(cinsler[secilenTur]);
                    cmbPetCins.SelectedIndex = -1;
                }
            }
            else
            {
                cmbPetCins.Items.Clear();
                cmbPetCins.SelectedIndex = -1;
            }
        }

        // Resim yükleme işlemi
        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _resimBytes = File.ReadAllBytes(openFileDialog.FileName);
                        if (_resimBytes.Length > 5 * 1024 * 1024)
                        {
                            Console.WriteLine("Resim Boyutu Çok Fazla.");
                            MessageBox.Show("Resim boyutu 5 MB'dan büyük olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            _resimBytes = null;
                            return;
                        }

                        using (var ms = new MemoryStream(_resimBytes))
                        {
                            pbPetPhoto.Image = Image.FromStream(ms);
                        }
                        lblSecilenFoto.Text = "";
                        MessageBox.Show("Resim başarıyla yüklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Resim yüklenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _resimBytes = null;
                        pbPetPhoto.Image = null;
                    }
                }
            }
        }

        // Evcil hayvan ekleme işlemi
        private void btnHayvanEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPetName.Text))
            {
                MessageBox.Show("Evcil hayvan adı boş olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbPetType.SelectedItem == null)
            {
                MessageBox.Show("Evcil hayvan türü seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtPetYas.Text, out int yas) || yas < 0)
            {
                MessageBox.Show("Geçerli bir yaş giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var pet = new EvcilHayvan
                    {
                        Ad = txtPetName.Text,
                        Tur = cmbPetType.SelectedItem.ToString(),
                        Cinsi = cmbPetCins.SelectedItem?.ToString(),
                        Yas = yas,
                        KullaniciId = _kullaniciId,
                        Resim = _resimBytes
                    };

                    ctx.EvcilHayvanlar.Add(pet);
                    ctx.SaveChanges();
                    MessageBox.Show("Evcil hayvan başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAnimals();
                    LoadAnimalsToComboBox();

                    txtPetName.Clear();
                    cmbPetType.SelectedIndex = -1;
                    txtPetYas.Clear();
                    _resimBytes = null;
                    pbPetPhoto.Image = null;
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Seçili evcil hayvan detaylarını gösterir.
        private void listHayvanListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listHayvanListe.SelectedItems.Count > 0)
            {
                try
                {
                    using (var ctx = new EvcilHayvanDbContext())
                    {
                        var selectedItem = listHayvanListe.SelectedItems[0];
                        int evcilHayvanId = (int)selectedItem.Tag;
                        var hayvan = ctx.EvcilHayvanlar
                            .FirstOrDefault(h => h.EvcilHayvanId == evcilHayvanId && h.KullaniciId == _kullaniciId);

                        if (hayvan != null)
                        {
                            lblSecHayvanİsim.Text = "İsim: " + hayvan.Ad;
                            lblSecHayvanYas.Text = "Yaş: " + hayvan.Yas.ToString();
                            lblSecHayvanTur.Text = "Tür: " + hayvan.Tur;
                            lblSecHayvanCins.Text = "Cins: " + (hayvan.Cinsi ?? "Belirtilmemiş");

                            if (hayvan.Resim != null && hayvan.Resim.Length > 0)
                            {
                                using (var ms = new MemoryStream(hayvan.Resim))
                                {
                                    pbSecFotoHayvan.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                pbSecFotoHayvan.Image = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Beslenme saati ekleme
        private void btnBeslenmeEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxPetFeeding.SelectedItem == null)
            {
                MessageBox.Show("Bir hayvan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBesSaati.Text))
            {
                MessageBox.Show("Beslenme saati giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DateTime.TryParseExact(txtBesSaati.Text, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime beslenmeSaati))
            {
                MessageBox.Show("Geçerli bir saat formatı giriniz (Örn: 08:00)!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var ctx = new EvcilHayvanDbContext())
                {
                    dynamic selectedPet = comboBoxPetFeeding.SelectedItem;
                    int evcilHayvanId = selectedPet.Id;

                    var beslenme = new Beslenme
                    {
                        EvcilHayvanId = evcilHayvanId,
                        BeslenmeSaati = DateTime.Today.Add(beslenmeSaati.TimeOfDay)
                    };

                    ctx.Beslenmeler.Add(beslenme);
                    ctx.SaveChanges();
                    MessageBox.Show("Beslenme saati eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadFeedingTimes();
                    LoadHatirlatici();

                    comboBoxPetFeeding.SelectedIndex = -1;
                    txtBesSaati.Clear();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Veteriner randevusu ekleme
        private void btnVetEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxPetVet.SelectedItem == null)
            {
                MessageBox.Show("Bir hayvan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpVetDate.Value < DateTime.Now)
            {
                MessageBox.Show("Geçerli bir randevu tarihi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtVetAcikla.Text))
            {
                MessageBox.Show("Randevu açıklaması giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var ctx = new EvcilHayvanDbContext())
                {
                    dynamic selectedPet = comboBoxPetVet.SelectedItem;
                    int evcilHayvanId = selectedPet.Id;

                    var randevu = new Randevu
                    {
                        EvcilHayvanId = evcilHayvanId,
                        RandevuTarihi = dtpVetDate.Value,
                        Aciklama = txtVetAcikla.Text
                    };

                    ctx.Randevular.Add(randevu);
                    ctx.SaveChanges();
                    MessageBox.Show("Randevu eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadVetAppointments();
                    LoadHatirlatici();

                    comboBoxPetVet.SelectedIndex = -1;
                    dtpVetDate.Value = DateTime.Now;
                    txtVetAcikla.Clear();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Aşı ekleme
        private void btnAsiEkle_Click(object sender, EventArgs e)
        {
            if (cmbAsiHayvan.SelectedItem == null)
            {
                MessageBox.Show("Bir hayvan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAsiAdi.Text))
            {
                MessageBox.Show("Aşı adı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpAsiTarih.Value < DateTime.Now)
            {
                MessageBox.Show("Geçerli bir aşı tarihi seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var ctx = new EvcilHayvanDbContext())
                {
                    dynamic selectedPet = cmbAsiHayvan.SelectedItem;
                    int evcilHayvanId = selectedPet.Id;

                    var asi = new Asi
                    {
                        EvcilHayvanId = evcilHayvanId,
                        AsiAdi = txtAsiAdi.Text,
                        AsiTarihi = dtpAsiTarih.Value
                    };

                    ctx.Asilar.Add(asi);
                    ctx.SaveChanges();
                    MessageBox.Show("Aşı eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadAciAppointments();
                    LoadHatirlatici();

                    cmbAsiHayvan.SelectedIndex = -1;
                    txtAsiAdi.Clear();
                    dtpAsiTarih.Value = DateTime.Now;
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sağlık notu ekleme
        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            if (cmbSaglikHayvan.SelectedItem == null)
            {
                MessageBox.Show("Bir hayvan seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSaglikNotu.Text))
            {
                MessageBox.Show("Not giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var ctx = new EvcilHayvanDbContext())
                {
                    dynamic selectedPet = cmbSaglikHayvan.SelectedItem;
                    int evcilHayvanId = selectedPet.Id;

                    var saglikNotu = new SaglikNotu
                    {
                        EvcilHayvanId = evcilHayvanId,
                        Not = txtSaglikNotu.Text,
                        NotTarihi = DateTime.Now
                    };

                    ctx.SaglikNotlari.Add(saglikNotu);
                    ctx.SaveChanges();
                    MessageBox.Show("Sağlık notu eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadNoteAppointments();
                    LoadHatirlatici();

                    cmbSaglikHayvan.SelectedIndex = -1;
                    txtSaglikNotu.Clear();
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evcil hayvan detaylarını göster
        private void btnHayvanDetay_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayvanListe.SelectedRows.Count > 0)
                {
                    var selectedRow = HayvanListe.SelectedRows[0];
                    var evcilHayvanId = Convert.ToInt32(selectedRow.Cells["EvcilHayvanId"].Value);

                    var detayForm = new EvcilHayvanDetay(evcilHayvanId, _kullaniciId);
                    detayForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Bir evcil hayvan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Form yüklenirken kullanıcı bilgilerini ve tarih formatlarını ayarlar.
        private void PetUser_Load(object sender, EventArgs e)
        {
            KisiBilgisi();
            lblGiris.Text = $"Giriş Saati: {DateTime.Now.ToShortTimeString()}";
            dtpVetDate.Format = DateTimePickerFormat.Custom;
            dtpVetDate.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpAsiTarih.Format = DateTimePickerFormat.Custom;
            dtpAsiTarih.CustomFormat = "dd.MM.yyyy HH:mm";
        }

        // Kullanıcı bilgilerini yükler.
        private void KisiBilgisi()
        {
            using (var ctx = new EvcilHayvanDbContext())
            {
                var user = ctx.Kullanicilar.Find(_kullaniciId);

                if (user != null)
                {
                    lblName.Text = $"Ad Soyad: {user.KullaniciAdi}";
                    lblEmail.Text = $"E-posta: {user.Eposta}";
                }
                else
                {
                    lblName.Text = "Ad Soyad: Bulunamadı";
                    lblEmail.Text = "E-posta: Bulunamadı";
                }
            }
        }

        // Çıkış işlemi
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                UserLogin loginForm = new UserLogin();
                loginForm.Show();
            }
        }

        // Tema değiştirme işlemi
        private void CmbTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTema.SelectedItem.ToString() == "🌙 Koyu Tema")
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    tab.BackColor = Color.FromArgb(45, 45, 45);
                    tab.ForeColor = Color.White;
                }
            }
            else if (cmbTema.SelectedItem.ToString() == "☀️ Açık Tema")
            {
                this.BackColor = SystemColors.Control;
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    tab.BackColor = SystemColors.Control;
                    tab.ForeColor = Color.Black;
                }
            }
            else
            {
                this.BackColor = Color.FromArgb(192, 192, 255);
                foreach (TabPage tab in tabControl1.TabPages)
                {
                    tab.BackColor = Color.FromArgb(192, 192, 255);
                    tab.ForeColor = Color.Black;
                }
            }
        }

        // Kullanıcı bilgilerini güncelleme
        private void BtnBilgileriGuncelle_Click(object sender, EventArgs e)
        {
            string yeniAd = txtKullaniciAdi.Text;
            string yeniMail = txtMail.Text;
            string yeniSifre = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(yeniAd) || yeniAd.Length > 30)
            {
                MessageBox.Show("Kullanıcı adı boş olamaz ve 30 karakterden uzun olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(yeniMail) || yeniMail.Length > 80)
            {
                MessageBox.Show("E-posta boş olamaz ve 80 karakterden uzun olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(yeniSifre) && yeniSifre.Length > 30)
            {
                MessageBox.Show("Şifre 30 karakterden uzun olamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var kullanici = ctx.Kullanicilar.FirstOrDefault(u => u.KullaniciId == _kullaniciId);

                    if (kullanici != null)
                    {
                        kullanici.KullaniciAdi = yeniAd;
                        kullanici.Eposta = yeniMail;

                        if (!string.IsNullOrEmpty(yeniSifre))
                        {
                            kullanici.Sifre = yeniSifre;
                        }

                        ctx.SaveChanges();
                        MessageBox.Show($"Bilgiler güncellendi!\nAd: {yeniAd}\nE-posta: {yeniMail}\nŞifre: {(string.IsNullOrEmpty(yeniSifre) ? "(değişmedi)" : "••••••")}", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        KisiBilgisi();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilgiler güncellenirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // E-posta gönderme işlemi
        private void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                string smtpEmail = "atasceren16@gmail.com";
                string smtpPassword = "xwci ajfv erqf ebld";

                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(smtpEmail);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential(smtpEmail, smtpPassword);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"E-posta gönderilemedi: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hesap silme işlemi
        private void btnHspSil_Click(object sender, EventArgs e)
        {
            string emailToDelete = hsbMail.Text;
            string password = hsbSifre.Text;

            if (string.IsNullOrWhiteSpace(emailToDelete) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("E-posta ve şifre giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var ctx = new EvcilHayvanDbContext())
                {
                    var userToDelete = ctx.Kullanicilar.FirstOrDefault(u => u.Eposta == emailToDelete && u.Sifre == password);

                    if (userToDelete != null)
                    {
                        DialogResult result = MessageBox.Show("Hesabı silmek istediğinize emin misiniz?", "Hesap Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            ctx.Kullanicilar.Remove(userToDelete);
                            ctx.SaveChanges();

                            MessageBox.Show("Hesap silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string subject = "Hesap Silme Bildirimi";
                            string body = "Merhaba,\n\nHesabınız silindi. Bu işlemi siz gerçekleştirmediyseniz, lütfen iletişime geçin.";
                            SendEmail(userToDelete.Eposta, subject, body);

                            UserLogin lgn = new UserLogin();
                            lgn.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("İşlem iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hesap silinirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Evcil hayvan silme işlemi
        private void btnHayvanSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (HayvanListe.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Silmek için bir evcil hayvan seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var selectedRow = HayvanListe.SelectedRows[0];
                int evcilHayvanId = Convert.ToInt32(selectedRow.Cells["EvcilHayvanId"].Value);
                string hayvanAdi = selectedRow.Cells["Ad"].Value.ToString();

                DialogResult result = MessageBox.Show($"'{hayvanAdi}' adlı evcil hayvanı silmek istediğinize emin misiniz?\nTüm kayıtlar (beslenme, randevu, aşı, sağlık notları) silinecek.", "Evcil Hayvan Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (var ctx = new EvcilHayvanDbContext())
                {
                    var hayvan = ctx.EvcilHayvanlar
                        .FirstOrDefault(h => h.EvcilHayvanId == evcilHayvanId && h.KullaniciId == _kullaniciId);

                    if (hayvan == null)
                    {
                        MessageBox.Show("Seçilen evcil hayvan bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    ctx.Beslenmeler.RemoveRange(ctx.Beslenmeler.Where(b => b.EvcilHayvanId == evcilHayvanId));
                    ctx.Randevular.RemoveRange(ctx.Randevular.Where(r => r.EvcilHayvanId == evcilHayvanId));
                    ctx.Asilar.RemoveRange(ctx.Asilar.Where(a => a.EvcilHayvanId == evcilHayvanId));
                    ctx.SaglikNotlari.RemoveRange(ctx.SaglikNotlari.Where(n => n.EvcilHayvanId == evcilHayvanId));

                    ctx.EvcilHayvanlar.Remove(hayvan);
                    ctx.SaveChanges();

                    var kullanici = ctx.Kullanicilar.FirstOrDefault(k => k.KullaniciId == _kullaniciId);
                    if (kullanici != null)
                    {
                        string subject = "Evcil Hayvan Kaydı Silindi";
                        string body = $"Merhaba {kullanici.KullaniciAdi},\n\n'{hayvanAdi}' adlı evcil hayvan kaydınız silindi.\nSilme Tarihi: {DateTime.Now:dd/MM/yyyy HH:mm}\nBu işlemi siz gerçekleştirmediyseniz, lütfen iletişime geçin.";
                        SendEmail(kullanici.Eposta, subject, body);
                    }

                    LoadAnimals();
                    LoadAnimalsToComboBox();
                    LoadFeedingTimes();
                    LoadVetAppointments();
                    LoadAciAppointments();
                    LoadNoteAppointments();

                    Console.WriteLine($"{hayvanAdi} Silindi.");
                    MessageBox.Show($"'{hayvanAdi}' silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.InnerException?.Message ?? ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Geri bildirim gönderme
        private void btnGeriBildirimGonder_Click(object sender, EventArgs e)
        {
            if (cmbPuan.SelectedItem == null || string.IsNullOrWhiteSpace(txtGeriBildirim.Text))
            {
                MessageBox.Show("Puan ve yorum giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int puan = Convert.ToInt32(cmbPuan.SelectedItem);
                string yorum = txtGeriBildirim.Text;

                using (var db = new EvcilHayvanDbContext())
                {
                    var yeniGeri = new GeriBildirim
                    {
                        KullaniciId = _kullaniciId,
                        Puan = puan,
                        Yorum = yorum,
                        Tarih = DateTime.Now
                    };
                    db.GeriBildirims.Add(yeniGeri);
                    db.SaveChanges();
                }

                MessageBox.Show($"Geri bildirim alındı!\nPuan: {puan}\nYorum: {yorum}", "Teşekkürler", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtGeriBildirim.Clear();
                cmbPuan.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Geri bildirim gönderilirken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblVersiyon_Click(object sender, EventArgs e)
        {

        }
    }
}