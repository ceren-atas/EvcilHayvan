// SaglikNotu.cs: Evcil hayvan sağlık notlarını tanımlar.
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
    internal class SaglikNotu
    // SaglikNotu sınıfı, evcil hayvan sağlık notlarını tanımlar ve yalnızca aynı derlemede erişilebilir.
    {
        [Key]
        // NotId özelliğinin veritabanında birincil anahtar olduğunu belirtir.
        public int NotId { get; set; }
        // NotId, sağlık notu için benzersiz kimliği temsil eden tamsayı özelliğidir.
        public string Not { get; set; }
        // Not, sağlık notunun içeriğini saklayan string özelliğidir.
        public DateTime NotTarihi { get; set; }
        // NotTarihi, sağlık notunun oluşturulma tarihini saklayan DateTime özelliğidir.
        public int EvcilHayvanId { get; set; }
        // EvcilHayvanId, sağlık notunun hangi evcil hayvana ait olduğunu belirten tamsayıdır.
        [ForeignKey("EvcilHayvanId")]
        // EvcilHayvanId’nin EvcilHayvan sınıfıyla yabancı anahtar ilişkisini tanımlar.
        public EvcilHayvan EvcilHayvan { get; set; }
        // EvcilHayvan, sağlık notu ile ilişkili evcil hayvan nesnesini temsil eder.
    }
}