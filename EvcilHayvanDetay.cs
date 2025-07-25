// EvcilHayvanDetay.cs: Evcil hayvan detaylarını gösteren formu yönetir.
using System;
// Temel C# sınıfları ve veri tipleri için System ad alanını dahil eder.
using System.Runtime.InteropServices;
// Platformlar arası işlemler için gerekli sınıfları içerir.
using Microsoft.EntityFrameworkCore;
// Entity Framework Core için gerekli sınıfları dahil eder.
using System.Drawing;
// Görüntü işleme sınıfları için ad alanıdır.
using System.IO;
// Dosya işlemleri için gerekli sınıfları içerir.
using System.Linq;
// LINQ sorguları için gerekli ad alanıdır.
using System.Windows.Forms;
// Windows Forms için gerekli sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    public partial class EvcilHayvanDetay : Form
    // EvcilHayvanDetay sınıfı, evcil hayvan detaylarını gösteren bir Windows Forms sınıfıdır.
    {
        private readonly int _evcilHayvanId;
        // _evcilHayvanId, formda gösterilen evcil hayvanın kimliğini saklar.
        private readonly int _kullaniciId;
        // _kullaniciId, oturum açmış kullanıcının kimliğini saklar.
        private readonly EvcilHayvanDbContext _context;
        // _context, veritabanı işlemlerini gerçekleştirmek için DbContext nesnesidir.

        public EvcilHayvanDetay(int evcilHayvanId, int kullaniciId)
        // Form başlatıcısı, evcil hayvan ve kullanıcı kimliklerini alarak formu başlatır.
        {
            InitializeComponent();
            // Form bileşenlerini başlatır.
            _evcilHayvanId = evcilHayvanId;
            // Parametredeki evcil hayvan kimliğini sınıf değişkenine atar.
            _kullaniciId = kullaniciId;
            // Parametredeki kullanıcı kimliğini sınıf değişkenine atar.
            _context = new EvcilHayvanDbContext();
            // Veritabanı bağlantısını başlatır.
            this.Load += new System.EventHandler(this.EvcilHayvanDetay_Load);
            // Form yüklenirken EvcilHayvanDetay_Load metodunu çağırır.
        }

        private void EvcilHayvanDetay_Load(object sender, EventArgs e)
        // Form yüklendiğinde çalışır ve verileri yüklemek için ilgili metodları çağırır.
        {
            try
            {
                YukleGenelBilgiler();
                // Evcil hayvanın genel bilgilerini yükler.
                YukleAsilar();
                // Evcil hayvanın aşılarını yükler.
                YukleBeslenmeSaatleri();
                // Evcil hayvanın beslenme saatlerini yükler.
                YukleRandevular();
                // Evcil hayvanın randevularını yükler.
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Form yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private void YukleGenelBilgiler()
        // Evcil hayvanın genel bilgilerini (ad, yaş, tür, cins, sahip, resim) yükler.
        {
            try
            {
                var hayvan = _context.EvcilHayvanlar
                    .Include(h => h.Kullanici)
                    .FirstOrDefault(h => h.EvcilHayvanId == _evcilHayvanId && h.KullaniciId == _kullaniciId);
                // Veritabanından evcil hayvanı ve ilgili kullanıcıyı sorgular.
                if (hayvan != null)
                {
                    lblAd.Text = "Ad: " + hayvan.Ad;
                    // Evcil hayvanın adını etikete yazar.
                    lblYas.Text = "Yaş: " + hayvan.Yas.ToString();
                    // Evcil hayvanın yaşını etikete yazar.
                    lblTur.Text = "Tür: " + hayvan.Tur;
                    // Evcil hayvanın türünü etikete yazar.
                    lblCins.Text = "Cins: " + (hayvan.Cinsi ?? "Belirtilmemiş");
                    // Evcil hayvanın cinsini etikete yazar, yoksa "Belirtilmemiş" gösterir.
                    lblSahip.Text = "Sahip: " + (hayvan.Kullanici?.KullaniciAdi ?? "Bilinmiyor");
                    // Sahibin adını etikete yazar, yoksa "Bilinmiyor" gösterir.
                    if (hayvan.Resim != null && hayvan.Resim.Length > 0)
                    {
                        using (var ms = new MemoryStream(hayvan.Resim))
                        {
                            pbHayvanFoto.Image = Image.FromStream(ms);
                        }
                        // Evcil hayvanın resmini varsa PictureBox’a yükler.
                    }
                    else
                    {
                        pbHayvanFoto.Image = null;
                        // Resim yoksa PictureBox’ı boşaltır.
                    }
                }
                else
                {
                    MessageBox.Show("Evcil hayvan bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Evcil hayvan bulunamazsa hata mesajı gösterir.
                    this.Close();
                    // Formu kapatır.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Genel bilgiler yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private void YukleAsilar()
        // Evcil hayvanın aşılarını listeler (ad, tarih).
        {
            try
            {
                lstAsilar.Columns.Clear();
                // Aşı listesinin sütunlarını temizler.
                lstAsilar.Columns.Add("Aşı Adı", 300);
                // Aşı adı için 300 piksel genişlikte sütun ekler.
                lstAsilar.Columns.Add("Tarih", 150);
                // Tarih için 150 piksel genişlikte sütun ekler.
                lstAsilar.Columns.Add("ID", 0);
                // Gizli ID sütunu ekler.
                var asilar = _context.Asilar
                    .Where(a => a.EvcilHayvanId == _evcilHayvanId)
                    .OrderByDescending(a => a.AsiTarihi)
                    .ToList();
                // Evcil hayvanın aşılarını tarihe göre azalan sırayla sorgular.
                lstAsilar.Items.Clear();
                // Aşı listesini temizler.
                foreach (var asi in asilar)
                {
                    var item = new ListViewItem(asi.AsiAdi);
                    item.SubItems.Add(asi.AsiTarihi.ToString("dd.MM.yyyy HH:mm"));
                    item.SubItems.Add(asi.AsiId.ToString());
                    lstAsilar.Items.Add(item);
                    // Her aşı için listeye satır ekler (ad, tarih, ID).
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Aşılar yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private void YukleBeslenmeSaatleri()
        // Evcil hayvanın beslenme saatlerini listeler.
        {
            try
            {
                lstBeslenme.Columns.Clear();
                // Beslenme listesinin sütunlarını temizler.
                lstBeslenme.Columns.Add("Beslenme Saati", 300);
                // Beslenme saati için 300 piksel genişlikte sütun ekler.
                lstBeslenme.Columns.Add("ID", 0);
                // Gizli ID sütunu ekler.
                var beslenmeler = _context.Beslenmeler
                    .Where(b => b.EvcilHayvanId == _evcilHayvanId)
                    .OrderBy(b => b.BeslenmeSaati)
                    .ToList();
                // Evcil hayvanın beslenme saatlerini saate göre artan sırayla sorgular.
                lstBeslenme.Items.Clear();
                // Beslenme listesini temizler.
                foreach (var beslenme in beslenmeler)
                {
                    var item = new ListViewItem(beslenme.BeslenmeSaati.ToString("HH:mm"));
                    item.SubItems.Add(beslenme.BeslenmeId.ToString());
                    lstBeslenme.Items.Add(item);
                    // Her beslenme için listeye satır ekler (saat, ID).
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beslenme saatleri yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private void YukleRandevular()
        // Evcil hayvanın randevularını listeler (tarih, açıklama).
        {
            try
            {
                lstRandevular.Columns.Clear();
                // Randevu listesinin sütunlarını temizler.
                lstRandevular.Columns.Add("Tarih", 150);
                // Tarih için 150 piksel genişlikte sütun ekler.
                lstRandevular.Columns.Add("Açıklama", 400);
                // Açıklama için 400 piksel genişlikte sütun ekler.
                lstRandevular.Columns.Add("ID", 0);
                // Gizli ID sütunu ekler.
                var randevular = _context.Randevular
                    .Where(r => r.EvcilHayvanId == _evcilHayvanId)
                    .OrderByDescending(r => r.RandevuTarihi)
                    .ToList();
                // Evcil hayvanın randevularını tarihe göre azalan sırayla sorgular.
                lstRandevular.Items.Clear();
                // Randevu listesini temizler.
                foreach (var randevu in randevular)
                {
                    var item = new ListViewItem(randevu.RandevuTarihi.ToString("dd.MM.yyyy HH:mm"));
                    item.SubItems.Add(randevu.Aciklama ?? "Belirtilmemiş");
                    item.SubItems.Add(randevu.RandevuId.ToString());
                    lstRandevular.Items.Add(item);
                    // Her randevu için listeye satır ekler (tarih, açıklama, ID).
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Randevular yüklenirken hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Hata oluşursa kullanıcıya hata mesajını gösterir.
            }
        }

        private void BtnAsiGuncelle_Click(object sender, EventArgs e)
        // Aşı güncelleme butonuna tıklandığında seçili aşıyı düzenlemek için form açar.
        {
            if (lstAsilar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek aşıyı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Hiçbir aşı seçilmediyse uyarı mesajı gösterir.
                return;
            }
            var selectedItem = lstAsilar.SelectedItems[0];
            // Seçilen aşı satırını alır.
            int asiId = Convert.ToInt32(selectedItem.SubItems[2].Text);
            // Seçilen satırdan aşı kimliğini alır.
            using (var form = new Form())
            {
                form.Text = "Aşı Güncelle";
                // Yeni formun başlığını ayarlar.
                form.Size = new Size(400, 200);
                // Formun boyutlarını belirler.
                form.StartPosition = FormStartPosition.CenterParent;
                // Formu ana formun ortasında açar.
                var txtAsiAdi = new TextBox { Location = new Point(120, 20), Size = new Size(200, 20), Text = selectedItem.Text };
                // Aşı adı için metin kutusu oluşturur ve seçili aşı adını yükler.
                var dtpAsiTarihi = new DateTimePicker { Location = new Point(120, 50), Size = new Size(200, 20) };
                // Aşı tarihi için tarih seçici oluşturur.
                dtpAsiTarihi.Value = DateTime.ParseExact(selectedItem.SubItems[1].Text, "dd.MM.yyyy HH:mm", null);
                // Tarih seçiciye seçili aşı tarihini yükler.
                var lblAsiAdi = new Label { Text = "Aşı Adı:", Location = new Point(20, 23) };
                // Aşı adı etiketi oluşturur.
                var lblAsiTarihi = new Label { Text = "Aşı Tarihi:", Location = new Point(20, 53) };
                // Aşı tarihi etiketi oluşturur.
                var btnKaydet = new Button
                {
                    Text = "Kaydet",
                    Location = new Point(120, 90),
                    Size = new Size(100, 30)
                };
                // Kaydet butonu oluşturur.
                btnKaydet.Click += (s, ev) =>
                {
                    try
                    {
                        var asi = _context.Asilar.Find(asiId);
                        // Veritabanından aşıyı bulur.
                        if (asi != null)
                        {
                            asi.AsiAdi = txtAsiAdi.Text;
                            // Aşı adını günceller.
                            asi.AsiTarihi = dtpAsiTarihi.Value;
                            // Aşı tarihini günceller.
                            _context.SaveChanges();
                            // Değişiklikleri veritabanına kaydeder.
                            YukleAsilar();
                            // Aşı listesini yeniler.
                            form.Close();
                            // Formu kapatır.
                            MessageBox.Show("Aşı başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Başarı mesajı gösterir.
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Güncelleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Hata oluşursa kullanıcıya hata mesajını gösterir.
                    }
                };
                form.Controls.AddRange(new Control[] { lblAsiAdi, txtAsiAdi, lblAsiTarihi, dtpAsiTarihi, btnKaydet });
                // Form kontrollerini ekler.
                form.ShowDialog();
                // Formu diyalog olarak gösterir.
            }
        }

        private void BtnBeslenmeGuncelle_Click(object sender, EventArgs e)
        // Beslenme saati güncelleme butonuna tıklandığında seçili beslenme saatini düzenler.
        {
            if (lstBeslenme.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek beslenme saatini seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Hiçbir beslenme seçilmediyse uyarı mesajı gösterir.
                return;
            }
            var selectedItem = lstBeslenme.SelectedItems[0];
            // Seçilen beslenme satırını alır.
            int beslenmeId = Convert.ToInt32(selectedItem.SubItems[1].Text);
            // Seçilen satırdan beslenme kimliğini alır.
            using (var form = new Form())
            {
                form.Text = "Beslenme Saati Güncelle";
                // Yeni formun başlığını ayarlar.
                form.Size = new Size(400, 150);
                // Formun boyutlarını belirler.
                form.StartPosition = FormStartPosition.CenterParent;
                // Formu ana formun ortasında açar.
                var dtpBeslenmeSaati = new DateTimePicker
                {
                    Location = new Point(120, 20),
                    Size = new Size(200, 20),
                    Format = DateTimePickerFormat.Time,
                    ShowUpDown = true
                };
                // Beslenme saati için tarih seçici oluşturur.
                dtpBeslenmeSaati.Value = DateTime.ParseExact(selectedItem.Text, "HH:mm", null);
                // Tarih seçiciye seçili beslenme saatini yükler.
                var lblBeslenmeSaati = new Label { Text = "Beslenme Saati:", Location = new Point(20, 23) };
                // Beslenme saati etiketi oluşturur.
                var btnKaydet = new Button
                {
                    Text = "Kaydet",
                    Location = new Point(120, 60),
                    Size = new Size(100, 30)
                };
                // Kaydet butonu oluşturur.
                btnKaydet.Click += (s, ev) =>
                {
                    try
                    {
                        var beslenme = _context.Beslenmeler.Find(beslenmeId);
                        // Veritabanından beslenmeyi bulur.
                        if (beslenme != null)
                        {
                            beslenme.BeslenmeSaati = DateTime.Today.Add(dtpBeslenmeSaati.Value.TimeOfDay);
                            // Beslenme saatini günceller.
                            _context.SaveChanges();
                            // Değişiklikleri veritabanına kaydeder.
                            YukleBeslenmeSaatleri();
                            // Beslenme listesini yeniler.
                            form.Close();
                            // Formu kapatır.
                            MessageBox.Show("Beslenme saati başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Başarı mesajı gösterir.
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Güncelleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Hata oluşursa kullanıcıya hata mesajını gösterir.
                    }
                };
                form.Controls.AddRange(new Control[] { lblBeslenmeSaati, dtpBeslenmeSaati, btnKaydet });
                // Form kontrollerini ekler.
                form.ShowDialog();
                // Formu diyalog olarak gösterir.
            }
        }

        private void BtnRandevuGuncelle_Click(object sender, EventArgs e)
        // Randevu güncelleme butonuna tıklandığında seçili randevuyu düzenler.
        {
            if (lstRandevular.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek randevuyu seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Hiçbir randevu seçilmediyse uyarı mesajı gösterir.
                return;
            }
            var selectedItem = lstRandevular.SelectedItems[0];
            // Seçilen randevu satırını alır.
            int randevuId = Convert.ToInt32(selectedItem.SubItems[2].Text);
            // Seçilen satırdan randevu kimliğini alır.
            using (var form = new Form())
            {
                form.Text = "Randevu Güncelle";
                // Yeni formun başlığını ayarlar.
                form.Size = new Size(400, 200);
                // Formun boyutlarını belirler.
                form.StartPosition = FormStartPosition.CenterParent;
                // Formu ana formun ortasında açar.
                var dtpRandevuTarihi = new DateTimePicker
                {
                    Location = new Point(120, 20),
                    Size = new Size(200, 20),
                    Format = DateTimePickerFormat.Custom,
                    CustomFormat = "dd.MM.yyyy HH:mm"
                };
                // Randevu tarihi için tarih seçici oluşturur.
                dtpRandevuTarihi.Value = DateTime.ParseExact(selectedItem.Text, "dd.MM.yyyy HH:mm", null);
                // Tarih seçiciye seçili randevu tarihini yükler.
                var txtAciklama = new TextBox
                {
                    Location = new Point(120, 50),
                    Size = new Size(200, 20),
                    Text = selectedItem.SubItems[1].Text
                };
                // Açıklama için metin kutusu oluşturur ve mevcut açıklamayı yükler.
                var lblRandevuTarihi = new Label { Text = "Randevu Tarihi:", Location = new Point(20, 23) };
                // Randevu tarihi etiketi oluşturur.
                var lblAciklama = new Label { Text = "Açıklama:", Location = new Point(20, 53) };
                // Açıklama etiketi oluşturur.
                var btnKaydet = new Button
                {
                    Text = "Kaydet",
                    Location = new Point(120, 90),
                    Size = new Size(100, 30)
                };
                // Kaydet butonu oluşturur.
                btnKaydet.Click += (s, ev) =>
                {
                    try
                    {
                        var randevu = _context.Randevular.Find(randevuId);
                        // Veritabanından randevuyu bulur.
                        if (randevu != null)
                        {
                            randevu.RandevuTarihi = dtpRandevuTarihi.Value;
                            // Randevu tarihini günceller.
                            randevu.Aciklama = txtAciklama.Text;
                            // Randevu açıklamasını günceller.
                            _context.SaveChanges();
                            // Değişiklikleri veritabanına kaydeder.
                            YukleRandevular();
                            // Randevu listesini yeniler.
                            form.Close();
                            // Formu kapatır.
                            MessageBox.Show("Randevu başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Başarı mesajı gösterir.
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Güncelleme sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Hata oluşursa kullanıcıya hata mesajını gösterir.
                    }
                };
                form.Controls.AddRange(new Control[] { lblRandevuTarihi, dtpRandevuTarihi, lblAciklama, txtAciklama, btnKaydet });
                // Form kontrollerini ekler.
                form.ShowDialog();
                // Formu diyalog olarak gösterir.
            }
        }
    }
}