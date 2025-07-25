// NewPass.cs: Şifre sıfırlama ekranını yönetir.
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
using System.Text.RegularExpressions;
// Düzenli ifadeler için gerekli sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    public partial class NewPass : Form
    // NewPass sınıfı, şifre sıfırlama ekranını yöneten bir Windows Forms sınıfıdır.
    {
        public NewPass()
        // Formun başlatıcısı, bileşenleri hazırlar.
        {
            InitializeComponent();
            // Form bileşenlerini başlatır.
        }

        private void LinkGeriDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        // Geri dön bağlantısına tıklandığında giriş formunu açar ve mevcut formu gizler.
        {
            UserLogin grs = new UserLogin();
            // Yeni bir UserLogin formu oluşturur.
            grs.Show();
            // Giriş formunu gösterir.
            this.Hide();
            // Mevcut formu gizler.
        }

        public static string GenerateRandomPassword(int length = 8)
        // Rastgele şifre oluşturur (8 karakter, harf, rakam, özel karakter içerir).
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%&*";
            // Şifrede kullanılacak karakter setini tanımlar.
            Random random = new Random();
            // Rastgele sayı üreticisi oluşturur.
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            // Belirtilen uzunlukta rastgele şifre döndürür.
        }

        private bool EmailGecerliMi(string email)
        // E-posta adresinin geçerliliğini düzenli ifadeyle kontrol eder.
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            // E-posta formatı için düzenli ifade deseni tanımlar.
            return Regex.IsMatch(email, pattern);
            // E-postanın desene uyup uymadığını kontrol eder.
        }

        private void btnReset_Click(object sender, EventArgs e)
        // Şifre sıfırlama butonuna tıklandığında e-posta kontrolü yapar ve yeni şifre gönderir.
        {
            string email = txtEposta.Text.Trim();
            // E-posta girişini alır ve boşlukları temizler.
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Lütfen e-posta adresinizi girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // E-posta boşsa uyarı mesajı gösterir.
                return;
            }
            if (EmailGecerliMi(email))
            {
                using (var context = new EvcilHayvanDbContext())
                {
                    var user = context.Kullanicilar.FirstOrDefault(u => u.Eposta == email);
                    // Veritabanında e-postaya sahip kullanıcıyı arar.
                    if (user == null)
                    {
                        MessageBox.Show("Bu e-posta adresi kayıtlı değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Kullanıcı bulunamazsa hata mesajı gösterir.
                        return;
                    }
                    string newPassword = NewPass.GenerateRandomPassword();
                    // Yeni rastgele şifre oluşturur.
                    user.Sifre = newPassword;
                    // Kullanıcının şifresini günceller.
                    context.SaveChanges();
                    // Değişiklikleri veritabanına kaydeder.
                    SendEmail(email, newPassword);
                    // Yeni şifreyi e-posta ile gönderir.
                    MessageBox.Show("Yeni şifreniz e-posta adresinize gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Başarı mesajı gösterir.
                }
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Bir E-posta Girin!");
                // Geçersiz e-posta formatı için hata mesajı gösterir.
            }
        }

        // Yeni şifreyi kullanıcıya e-posta ile gönderir.
        private void SendEmail(string toEmail, string newPassword)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(Environment.GetEnvironmentVariable("EMAIL_USER"));
                mail.To.Add(toEmail);
                mail.Subject = "Şifre Sıfırlama";
                mail.Body = $"Merhaba, \nyeni şifreniz: {newPassword}\nLütfen giriş yaptıktan sonra şifrenizi değiştirin.";

                smtpServer.Port = 587;

                string emailUser = Environment.GetEnvironmentVariable("EMAIL_USER");
                string emailPass = Environment.GetEnvironmentVariable("EMAIL_PASS");

                smtpServer.Credentials = new NetworkCredential(emailUser, emailPass);
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("E-posta gönderilemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewPass_Load(object sender, EventArgs e)
        // Form yüklendiğinde çalışır, şu an boş.
        {

        }
    }
}