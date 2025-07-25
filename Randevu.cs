// Randevu.cs: Veteriner randevu bilgilerini tanımlar.
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
    internal class Randevu
    // Randevu sınıfı, veteriner randevularını tanımlar ve yalnızca aynı derlemede erişilebilir.
    {
        [Key]
        // RandevuId özelliğinin veritabanında birincil anahtar olduğunu belirtir.
        public int RandevuId { get; set; }
        // RandevuId, randevu için benzersiz kimliği temsil eden tamsayı özelliğidir.
        public DateTime RandevuTarihi { get; set; }
        // RandevuTarihi, randevunun tarihini saklayan DateTime özelliğidir.
        public string Aciklama { get; set; }
        // Aciklama, randevunun detaylarını saklayan string özelliğidir.
        public int EvcilHayvanId { get; set; }
        // EvcilHayvanId, randevunun hangi evcil hayvana ait olduğunu belirten tamsayıdır.
        [ForeignKey("EvcilHayvanId")]
        // EvcilHayvanId’nin EvcilHayvan sınıfıyla yabancı anahtar ilişkisini tanımlar.
        public EvcilHayvan EvcilHayvan { get; set; }
        // EvcilHayvan, randevu ile ilişkili evcil hayvan nesnesini temsil eder.
    }
}