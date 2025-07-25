// UserLogin.cs: Kullanıcı giriş ekranını yönetir.
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
using System.Threading.Tasks;
// Asenkron programlama için sınıfları içerir.
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore;
// Windows Forms için gerekli sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    public partial class UserLogin : Form
    // UserLogin sınıfı, kullanıcı giriş ekranını yöneten bir Windows Forms sınıfıdır.
    {
        // Formun başlatıcısı
        public UserLogin()
        // Formun başlatıcısı, bileşenleri hazırlar.
        {
            InitializeComponent();
            // Form bileşenlerini başlatır.
        }

        // Kayıt ol bağlantısına tıklanınca kayıt formunu açar, mevcut formu gizler.
        private void linkLabelKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        // Kayıt ol bağlantısına tıklandığında kayıt formunu açar.
        {
            UserRegister kyt = new UserRegister();
            // Yeni bir UserRegister formu oluşturur.
            kyt.Show();
            // Kayıt formunu gösterir.
            this.Hide();
            // Mevcut giriş formunu gizler.
        }

        // Şifremi unuttum bağlantısına tıklanınca şifre sıfırlama formunu açar, mevcut formu gizler.
        private void linkLabelSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        // Şifremi unuttum bağlantısına tıklandığında şifre sıfırlama formunu açar.
        {
            NewPass rst = new NewPass();
            // Yeni bir NewPass formu oluşturur.
            rst.Show();
            // Şifre sıfırlama formunu gösterir.
            this.Hide();
            // Mevcut giriş formunu gizler.
        }

        // Giriş butonuna tıklanınca kullanıcı adı ve şifreyi kontrol eder, başarılıysa ana ekrana yönlendirir.
        private void btnGiris_Click(object sender, EventArgs e)
        // Giriş butonuna tıklandığında kullanıcı girişini doğrular.
        {
            using (EvcilHayvanDbContext ctx = new EvcilHayvanDbContext())
            // Veritabanı bağlantısını başlatır.
            {
                string username = txtKullaniciAdi.Text;
                // Kullanıcı adı giriş alanındaki metni alır.
                string pass = txtSifre.Text;
                // Şifre giriş alanındaki metni alır.

                // Veritabanında kullanıcıyı kontrol et
                var kullanicilar = ctx.Kullanicilar.FirstOrDefault(k => k.KullaniciAdi == username && k.Sifre == pass);
                // Kullanıcı adı ve şifreyi veritabanında sorgular.

                if (kullanicilar != null)
                // Kullanıcı bulunursa devam eder.
                {
                    MessageBox.Show("Hoşgeldiniz, " + username);
                    // Hoş geldiniz mesajı gösterir.

                    var connection = ctx.Database.GetDbConnection();
                    string dataSource = connection.DataSource;

                    // Bağlantı dosya ismi olabilir, bunu tam yola çevir
                    string fullPath = Path.GetFullPath(dataSource);

                    PetUser lgn = new PetUser(kullanicilar.KullaniciId);
                    // Kullanıcı kimliğiyle yeni bir PetUser formu oluşturur.
                    lgn.Show();
                    // Ana ekran formunu gösterir.
                    this.Hide();
                    // Mevcut giriş formunu gizler.
                }
                else
                {
                    MessageBox.Show("Giriş Yapılamadı!", "Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Kullanıcı bulunamazsa hata mesajı gösterir.
                }
            }
        }

        private void UserLogin_Load(object sender, EventArgs e)
        // Form yüklendiğinde çalışır, şu anda herhangi bir işlem yapmaz.
        {

        }
    }
}