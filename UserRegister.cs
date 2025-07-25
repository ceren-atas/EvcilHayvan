// UserRegister.cs: Kullanıcı kayıt ekranını yönetir.
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
using System.Linq;
// LINQ sorguları için gerekli ad alanıdır.
using System.Text;
// Metin işleme sınıfları için ad alanıdır.
using System.Text.RegularExpressions;
// Düzenli ifadeler (regex) için gerekli ad alanıdır.
using System.Threading.Tasks;
// Asenkron programlama için sınıfları içerir.
using System.Windows.Forms;
// Windows Forms için gerekli sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    public partial class UserRegister : Form
    // UserRegister sınıfı, kullanıcı kayıt ekranını yöneten bir Windows Forms sınıfıdır.
    {
        // Formun başlatıcısı
        public UserRegister()
        // Formun başlatıcısı, bileşenleri hazırlar.
        {
            InitializeComponent();
            // Form bileşenlerini başlatır.
        }

        // Giriş bağlantısına tıklanınca giriş formunu açar, mevcut formu gizler.
        private void LinkGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        // Giriş bağlantısına tıklandığında giriş formunu açar.
        {
            UserLogin grs = new UserLogin();
            // Yeni bir UserLogin formu oluşturur.
            grs.Show();
            // Giriş formunu gösterir.
            this.Hide();
            // Mevcut kayıt formunu gizler.
        }

        // E-posta adresinin geçerliliğini regex ile kontrol eder.
        private bool EmailGecerliMi(string email)
        // E-posta adresinin geçerliliğini düzenli ifadeyle kontrol eder.
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // E-posta için düzenli ifade şablonunu tanımlar.
            return Regex.IsMatch(email, pattern);
            // E-postanın şablona uyup uymadığını kontrol eder ve sonucu döndürür.
        }

        // Kayıt ol butonuna tıklanınca kullanıcıyı veritabanına kaydeder.
        private void btnKayitOl_Click(object sender, EventArgs e)
        // Kayıt ol butonuna tıklandığında kullanıcıyı veritabanına kaydeder.
        {
            string mail = txtMail.Text;
            // E-posta giriş alanındaki metni alır.
            Kullanicilar kullanici = new Kullanicilar { KullaniciAdi = txtKad.Text, Eposta = txtMail.Text, Sifre = txtPass.Text };
            // Yeni bir Kullanicilar nesnesi oluşturur ve giriş alanlarından verileri atar.

            if (EmailGecerliMi(mail))
            // E-posta geçerliyse devam eder.
            {
                using (EvcilHayvanDbContext ctx = new EvcilHayvanDbContext())
                // Veritabanı bağlantısını başlatır.
                {
                    ctx.Kullanicilar.Add(kullanici);
                    // Yeni kullanıcıyı veritabanına ekler.
                    int sonuc = ctx.SaveChanges();
                    // Değişiklikleri veritabanına kaydeder ve etkilenen satır sayısını alır.
                    MessageBox.Show(sonuc > 0 ? "Kullanıcı Başarıyla kaydedildi" : "Kullanıcı kaydedilemedi!", "Kayıt Bilgilendirme");
                    // Kayıt başarılıysa başarı mesajı, değilse hata mesajı gösterir.
                }
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir E-posta Girin!");
                // Geçersiz e-posta için hata mesajı gösterir.
            }
        }

        private void UserRegister_Load(object sender, EventArgs e)
        // Form yüklendiğinde çalışır, şu anda herhangi bir işlem yapmaz.
        {

        }
    }
}