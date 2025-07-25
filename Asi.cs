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
    internal class Asi
    // Asi sınıfı, evcil hayvan aşı bilgilerini tanımlar ve yalnızca aynı derlemede erişilebilir.
    {
        [Key]
        // AsiId özelliğinin veritabanında birincil anahtar olduğunu belirtir.
        public int AsiId { get; set; }
        // AsiId, aşının benzersiz kimliğini temsil eden tamsayı özelliğidir.

        public string AsiAdi { get; set; }
        // AsiAdi, aşının adını saklayan string özelliğidir.

        public DateTime AsiTarihi { get; set; }
        // AsiTarihi, aşının yapıldığı tarihi saklayan DateTime özelliğidir.

        public int EvcilHayvanId { get; set; }
        // EvcilHayvanId, aşının hangi evcil hayvana ait olduğunu belirten tamsayıdır.

        [ForeignKey("EvcilHayvanId")]
        // EvcilHayvanId’nin EvcilHayvan sınıfıyla yabancı anahtar ilişkisini tanımlar.
        public EvcilHayvan EvcilHayvan { get; set; }
        // EvcilHayvan, aşı ile ilişkili evcil hayvan nesnesini temsil eder.
    }
}