// GeriBildirim.cs: Kullanıcı geri bildirimlerini tanımlar.
using System;
// Temel C# sınıfları ve veri tipleri için System ad alanını dahil eder.
using System.Collections.Generic;
// Generic koleksiyonlar için gerekli ad alanıdır.
using System.Linq;
// LINQ sorguları için gerekli ad alanıdır.
using System.Text;
// Metin işleme sınıfları için ad alanıdır.
using System.Threading.Tasks;
// Asenkron programlama için sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    public class GeriBildirim
    // GeriBildirim sınıfı, kullanıcı geri bildirimlerini temsil eder ve genel erişime açıktır.
    {
        public int Id { get; set; }
        // Id, geri bildirim için benzersiz kimliği temsil eden tamsayı özelliğidir.
        public int KullaniciId { get; set; }
        // KullaniciId, geri bildirimi veren kullanıcının kimliğini belirten tamsayıdır.
        public int Puan { get; set; }
        // Puan, geri bildirimin değerlendirme puanını saklar.
        public string Yorum { get; set; }
        // Yorum, geri bildirim metnini saklayan string özelliğidir.
        public DateTime Tarih { get; set; }
        // Tarih, geri bildirimin verildiği tarihi saklayan DateTime özelliğidir.
    }
}