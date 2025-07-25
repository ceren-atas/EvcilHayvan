// Kullanicilar.cs: Kullanıcı bilgilerini ve evcil hayvan ilişkisini tanımlar.
using System;
// Temel C# sınıfları ve veri tipleri için System ad alanını dahil eder.
using System.Collections.Generic;
// Generic koleksiyonlar için gerekli ad alanıdır.
using System.ComponentModel.DataAnnotations;
// Veri doğrulama ve modelleme için kullanılan sınıfları içerir.
using System.ComponentModel.DataAnnotations.Schema;
// Veritabanı şeması ile ilgili öznitelikleri içerir.
using System.Linq;
// LINQ sorguları için gerekli ad alanıdır.
using System.Text;
// Metin işleme sınıfları için ad alanıdır.
using System.Threading.Tasks;
// Asenkron programlama için sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    internal class Kullanicilar
    // Kullanicilar sınıfı, kullanıcı bilgilerini tanımlar ve yalnızca aynı derlemede erişilebilir.
    {
        [Key]
        // KullaniciId özelliğinin veritabanında birincil anahtar olduğunu belirtir.
        public int KullaniciId { get; set; }
        // KullaniciId, kullanıcı için benzersiz kimliği temsil eden tamsayı özelliğidir.
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        [Required]
        // KullaniciAdi, veritabanında varchar türünde, en fazla 30 karakter ve zorunlu bir özelliktir.
        public string KullaniciAdi { get; set; }
        // KullaniciAdi, kullanıcının adını saklayan string özelliğidir.
        [Column(TypeName = "varchar")]
        [MaxLength(80)]
        [Required]
        // Eposta, veritabanında varchar türünde, en fazla 80 karakter ve zorunlu bir özelliktir.
        public string Eposta { get; set; }
        // Eposta, kullanıcının e-posta adresini saklayan string özelliğidir.
        [Column(TypeName = "varchar")]
        [MaxLength(30)]
        [Required]
        // Sifre, veritabanında varchar türünde, en fazla 30 karakter ve zorunlu bir özelliktir.
        public string Sifre { get; set; }
        // Sifre, kullanıcının şifresini saklayan string özelliğidir.
        public ICollection<EvcilHayvan> EvcilHayvanlar { get; set; }
        // EvcilHayvanlar, kullanıcının sahip olduğu evcil hayvanları temsil eden koleksiyondur.
    }
}