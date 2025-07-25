// EvcilHayvan.cs: Evcil hayvan bilgilerini ve ilişkilerini tanımlar.
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
    internal class EvcilHayvan
    // EvcilHayvan sınıfı, evcil hayvan bilgilerini tanımlar ve yalnızca aynı derlemede erişilebilir.
    {
        [Key]
        // EvcilHayvanId özelliğinin veritabanında birincil anahtar olduğunu belirtir.
        public int EvcilHayvanId { get; set; }
        // EvcilHayvanId, evcil hayvan için benzersiz kimliği temsil eden tamsayı özelliğidir.
        [Required]
        // Ad, zorunlu bir özelliktir ve null olamaz.
        public string Ad { get; set; }
        // Ad, evcil hayvanın adını saklayan string özelliğidir.
        [Required]
        // Tur, zorunlu bir özelliktir ve null olamaz.
        public string Tur { get; set; }
        // Tur, evcil hayvanın türünü (ör. Kedi, Köpek) saklayan string özelliğidir.
        public string Cinsi { get; set; }
        // Cinsi, evcil hayvanın cinsini saklayan string özelliğidir.
        public int Yas { get; set; }
        // Yas, evcil hayvanın yaşını saklayan tamsayı özelliğidir.
        public int KullaniciId { get; set; }
        // KullaniciId, evcil hayvanın sahibinin kimliğini belirten tamsayıdır.
        [ForeignKey("KullaniciId")]
        // KullaniciId’nin Kullanicilar sınıfıyla yabancı anahtar ilişkisini tanımlar.
        public byte[] Resim { get; set; }
        // Resim, evcil hayvanın fotoğrafını bayt dizisi olarak saklar.
        public Kullanicilar Kullanici { get; set; }
        // Kullanici, evcil hayvanın sahibi olan kullanıcıyı temsil eder.
        public ICollection<Beslenme> Beslenmeler { get; set; }
        // Beslenmeler, evcil hayvanın beslenme kayıtlarını temsil eden koleksiyondur.
        public ICollection<Randevu> Randevular { get; set; }
        // Randevular, evcil hayvanın veteriner randevularını temsil eden koleksiyondur.
        public ICollection<Asi> Asilar { get; set; }
        // Asilar, evcil hayvanın aşı kayıtlarını temsil eden koleksiyondur.
        public ICollection<SaglikNotu> SaglikNotlari { get; set; }
        // SaglikNotlari, evcil hayvanın sağlık notlarını temsil eden koleksiyondur.
    }
}