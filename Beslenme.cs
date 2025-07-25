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
    internal class Beslenme
    // Beslenme sınıfı, evcil hayvan beslenme bilgilerini tanımlar ve yalnızca aynı derlemede erişilebilir.
    {
        [Key]
        // BeslenmeId özelliğinin veritabanında birincil anahtar olduğunu belirtir.
        public int BeslenmeId { get; set; }
        // BeslenmeId, beslenme kaydının benzersiz kimliğini temsil eden tamsayı özelliğidir.

        public DateTime BeslenmeSaati { get; set; }
        // BeslenmeSaati, beslenmenin yapıldığı zamanı saklayan DateTime özelliğidir.

        public int EvcilHayvanId { get; set; }
        // EvcilHayvanId, beslenmenin hangi evcil hayvana ait olduğunu belirten tamsayıdır.

        [ForeignKey("EvcilHayvanId")]
        // EvcilHayvanId’nin EvcilHayvan sınıfıyla yabancı anahtar ilişkisini tanımlar.
        public EvcilHayvan EvcilHayvan { get; set; }
        // EvcilHayvan, beslenme ile ilişkili evcil hayvan nesnesini temsil eder.
    }
}