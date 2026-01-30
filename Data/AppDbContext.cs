using BlazorWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SampleData> SampleDatas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SampleData>().HasData(
                new SampleData { Id = 1, Name = "Konut Projesi A", Category = "İnşaat", Date = DateTime.Now.AddDays(-5), Project = "Alpha", Year = 2024, Branch = "İstanbul", Region = "Marmara", Customer = "Emlak Konut", Priority = "High", AssignedTo = "Ali Yılmaz", PaymentStatus = "Paid", Value = 1250000, Status = "Active", Description = "Merkez şube konut satışı" },
                new SampleData { Id = 2, Name = "Ofis Bloğu B", Category = "Ticari", Date = DateTime.Now.AddDays(-10), Project = "Alpha", Year = 2024, Branch = "Ankara", Region = "İç Anadolu", Customer = "Vestel A.Ş.", Priority = "Medium", AssignedTo = "Fatma Demir", PaymentStatus = "Pending", Value = 850000, Status = "Active", Description = "Ankara şube ofis kiralama" },
                new SampleData { Id = 3, Name = "AVM Projesi C", Category = "Ticari", Date = DateTime.Now.AddMonths(-1), Project = "Beta", Year = 2023, Branch = "İzmir", Region = "Ege", Customer = "Rönesans Holding", Priority = "Low", AssignedTo = "Mehmet Can", PaymentStatus = "Overdue", Value = 5000000, Status = "Inactive", Description = "İzmir AVM projesi tamamlandı" },
                new SampleData { Id = 4, Name = "Villa Etap 1", Category = "Lüks Konut", Date = DateTime.Now.AddMonths(-2), Project = "Gamma", Year = 2024, Branch = "Antalya", Region = "Akdeniz", Customer = "Bireysel Yatırımcı", Priority = "High", AssignedTo = "Ayşe Kaya", PaymentStatus = "Paid", Value = 3200000, Status = "Active", Description = "Antalya lüks villa projesi" },
                new SampleData { Id = 5, Name = "Lojistik Merkezi", Category = "Sanayi", Date = DateTime.Now.AddDays(-15), Project = "Beta", Year = 2024, Branch = "Kocaeli", Region = "Marmara", Customer = "DHL Express", Priority = "Medium", AssignedTo = "Caner Öz", PaymentStatus = "Paid", Value = 4500000, Status = "Active", Description = "Kocaeli lojistik depo depo inşaatı" },
                new SampleData { Id = 6, Name = "Hastane Projesi", Category = "Kamu", Date = DateTime.Now.AddDays(-20), Project = "Delta", Year = 2022, Branch = "Bursa", Region = "Marmara", Customer = "Sağlık Bakanlığı", Priority = "High", AssignedTo = "Deniz Akça", PaymentStatus = "Paid", Value = 12000000, Status = "Active", Description = "Bursa şehir hastanesi ek bina" },
                new SampleData { Id = 7, Name = "Rezidans X", Category = "İnşaat", Date = DateTime.Now.AddDays(-3), Project = "Alpha", Year = 2024, Branch = "İstanbul", Region = "Marmara", Customer = "Ağaoğlu", Priority = "Medium", AssignedTo = "Selin Ak", PaymentStatus = "Paid", Value = 2500000, Status = "Active", Description = "Lüks rezidans satışı" },
                new SampleData { Id = 8, Name = "İş Merkezi Y", Category = "Ticari", Date = DateTime.Now.AddDays(-7), Project = "Beta", Year = 2024, Branch = "Ankara", Region = "İç Anadolu", Customer = "Kuzu Grup", Priority = "High", AssignedTo = "Emre Aydın", PaymentStatus = "Pending", Value = 1800000, Status = "Active", Description = "Modern iş merkezi kiralama" },
                new SampleData { Id = 9, Name = "Depo Z", Category = "Sanayi", Date = DateTime.Now.AddMonths(-1), Project = "Gamma", Year = 2023, Branch = "Kocaeli", Region = "Marmara", Customer = "Trendyol", Priority = "Low", AssignedTo = "Zeynep Koç", PaymentStatus = "Overdue", Value = 3200000, Status = "Active", Description = "Lojistik depo genişletme" },
                new SampleData { Id = 10, Name = "Konut Sitesi D", Category = "İnşaat", Date = DateTime.Now.AddDays(-12), Project = "Delta", Year = 2024, Branch = "Bursa", Region = "Marmara", Customer = "Sur Yapı", Priority = "Medium", AssignedTo = "Hakan Yıldız", PaymentStatus = "Paid", Value = 4100000, Status = "Active", Description = "Yeni etap konut projesi" },
                new SampleData { Id = 11, Name = "Otel Projesi E", Category = "Turizm", Date = DateTime.Now.AddMonths(-3), Project = "Gamma", Year = 2024, Branch = "Antalya", Region = "Akdeniz", Customer = "Hilton", Priority = "High", AssignedTo = "Merve Şahin", PaymentStatus = "Paid", Value = 15000000, Status = "Active", Description = "5 yıldızlı otel inşaatı" },
                new SampleData { Id = 12, Name = "Park Revizyonu", Category = "Kamu", Date = DateTime.Now.AddDays(-4), Project = "Alpha", Year = 2022, Branch = "İstanbul", Region = "Marmara", Customer = "İBB", Priority = "Low", AssignedTo = "Murat Demir", PaymentStatus = "Paid", Value = 500000, Status = "Active", Description = "Şehir parkı yenileme çalışması" }
            );
        }
    }
}
