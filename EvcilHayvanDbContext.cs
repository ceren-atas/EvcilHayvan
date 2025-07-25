using Microsoft.EntityFrameworkCore;
// Entity Framework Core için gerekli sınıfları dahil eder.
using System;
// Temel C# sınıfları ve veri tipleri için System ad alanını dahil eder.
using System.IO;
// Dosya işlemleri için gerekli sınıfları içerir.

namespace EvcilHayvan
// Projeye ait sınıfları gruplandırmak için EvcilHayvan ad alanını tanımlar.
{
    internal class EvcilHayvanDbContext : DbContext
    // EvcilHayvanDbContext sınıfı, veritabanı işlemlerini yönetmek için DbContext sınıfından türetilir.
    {
        // Veritabanı tabloları
        public DbSet<Kullanicilar> Kullanicilar { get; set; }
        // Kullanicilar tablosunu temsil eden DbSet, kullanıcı verilerini yönetir.
        public DbSet<EvcilHayvan> EvcilHayvanlar { get; set; }
        // EvcilHayvanlar tablosunu temsil eden DbSet, evcil hayvan verilerini yönetir.
        public DbSet<Beslenme> Beslenmeler { get; set; }
        // Beslenmeler tablosunu temsil eden DbSet, beslenme kayıtlarını yönetir.
        public DbSet<Randevu> Randevular { get; set; }
        // Randevular tablosunu temsil eden DbSet, veteriner randevularını yönetir.
        public DbSet<Asi> Asilar { get; set; }
        // Asilar tablosunu temsil eden DbSet, aşı kayıtlarını yönetir.
        public DbSet<SaglikNotu> SaglikNotlari { get; set; }
        // SaglikNotlari tablosunu temsil eden DbSet, sağlık notlarını yönetir.
        public DbSet<GeriBildirim> GeriBildirims { get; set; }
        // GeriBildirims tablosunu temsil eden DbSet, kullanıcı geri bildirimlerini yönetir.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // Veritabanı yapılandırmasını özelleştirmek için OnConfiguring metodunu geçersiz kılar.
        {
            base.OnConfiguring(optionsBuilder);
            // Üst sınıfın OnConfiguring metodunu çağırır.
            optionsBuilder.UseSqlite("Data Source=EvcilHayvan.db");
            // SQLite veritabanını kullanmak için bağlantı dizesini yapılandırır.
        }
    }
}