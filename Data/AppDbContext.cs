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
        public DbSet<PoolDefinition> PoolDefinitions { get; set; }
        public DbSet<PoolColumn> PoolColumns { get; set; }
        public DbSet<CommercialRecord> CommercialRecords { get; set; }
        public DbSet<ProjectRecord> ProjectRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // --- Existing SampleData Seed ---
            modelBuilder.Entity<SampleData>().HasData(
                new SampleData { Id = 1, Name = "Konut Projesi A", Category = "İnşaat", Date = DateTime.Now.AddDays(-5), Project = "Alpha", Year = 2024, Branch = "İstanbul", Region = "Marmara", Customer = "Emlak Konut", Priority = "High", AssignedTo = "Sueda Akça", PaymentStatus = "Paid", Value = 1250000, Status = "Active", Description = "Merkez şube konut satışı" },
                new SampleData { Id = 2, Name = "Ofis Bloğu B", Category = "Ticari", Date = DateTime.Now.AddDays(-10), Project = "Alpha", Year = 2024, Branch = "Ankara", Region = "İç Anadolu", Customer = "Vestel A.Ş.", Priority = "Medium", AssignedTo = "Fatma Demir", PaymentStatus = "Pending", Value = 850000, Status = "Active", Description = "Ankara şube ofis kiralama" },
                new SampleData { Id = 3, Name = "AVM Projesi C", Category = "Ticari", Date = DateTime.Now.AddMonths(-1), Project = "Beta", Year = 2023, Branch = "İzmir", Region = "Ege", Customer = "Rönesans Holding", Priority = "Low", AssignedTo = "Mehmet Can", PaymentStatus = "Overdue", Value = 5000000, Status = "Inactive", Description = "İzmir AVM projesi tamamlandı" },
                new SampleData { Id = 4, Name = "Villa Etap 1", Category = "Lüks Konut", Date = DateTime.Now.AddMonths(-2), Project = "Gamma", Year = 2024, Branch = "Antalya", Region = "Akdeniz", Customer = "Bireysel Yatırımcı", Priority = "High", AssignedTo = "Ayşe Kaya", PaymentStatus = "Paid", Value = 3200000, Status = "Active", Description = "Antalya lüks villa projesi" },
                new SampleData { Id = 5, Name = "Lojistik Merkezi", Category = "Sanayi", Date = DateTime.Now.AddDays(-15), Project = "Beta", Year = 2024, Branch = "Kocaeli", Region = "Marmara", Customer = "DHL Express", Priority = "Medium", AssignedTo = "Caner Öz", PaymentStatus = "Paid", Value = 4500000, Status = "Active", Description = "Kocaeli lojistik depo depo inşaatı" },
                new SampleData { Id = 6, Name = "Hastane Projesi", Category = "Kamu", Date = DateTime.Now.AddDays(-20), Project = "Delta", Year = 2022, Branch = "Bursa", Region = "Marmara", Customer = "Sağlık Bakanlığı", Priority = "High", AssignedTo = "Deniz Akça", PaymentStatus = "Paid", Value = 12000000, Status = "Active", Description = "Bursa şehir hastanesi ek bina" },
                new SampleData { Id = 7, Name = "Rezidans X", Category = "İnşaat", Date = DateTime.Now.AddDays(-3), Project = "Alpha", Year = 2024, Branch = "İstanbul", Region = "Marmara", Customer = "Ağaoğlu", Priority = "Medium", AssignedTo = "Sueda Akça", PaymentStatus = "Paid", Value = 2500000, Status = "Active", Description = "Lüks rezidans satışı" },
                new SampleData { Id = 8, Name = "İş Merkezi Y", Category = "Ticari", Date = DateTime.Now.AddDays(-7), Project = "Beta", Year = 2024, Branch = "Ankara", Region = "İç Anadolu", Customer = "Kuzu Grup", Priority = "High", AssignedTo = "Emre Aydın", PaymentStatus = "Pending", Value = 1800000, Status = "Active", Description = "Modern iş merkezi kiralama" },
                new SampleData { Id = 9, Name = "Depo Z", Category = "Sanayi", Date = DateTime.Now.AddMonths(-1), Project = "Gamma", Year = 2023, Branch = "Kocaeli", Region = "Marmara", Customer = "Trendyol", Priority = "Low", AssignedTo = "Zeynep Koç", PaymentStatus = "Overdue", Value = 3200000, Status = "Active", Description = "Lojistik depo genişletme" },
                new SampleData { Id = 10, Name = "Konut Sitesi D", Category = "İnşaat", Date = DateTime.Now.AddDays(-12), Project = "Delta", Year = 2024, Branch = "Bursa", Region = "Marmara", Customer = "Sur Yapı", Priority = "Medium", AssignedTo = "Hakan Yıldız", PaymentStatus = "Paid", Value = 4100000, Status = "Active", Description = "Yeni etap konut projesi" },
                new SampleData { Id = 11, Name = "Otel Projesi E", Category = "Turizm", Date = DateTime.Now.AddMonths(-3), Project = "Gamma", Year = 2024, Branch = "Antalya", Region = "Akdeniz", Customer = "Hilton", Priority = "High", AssignedTo = "Merve Şahin", PaymentStatus = "Paid", Value = 15000000, Status = "Active", Description = "5 yıldızlı otel inşaatı" },
                new SampleData { Id = 12, Name = "Park Revizyonu", Category = "Kamu", Date = DateTime.Now.AddDays(-4), Project = "Alpha", Year = 2022, Branch = "İstanbul", Region = "Marmara", Customer = "İBB", Priority = "Low", AssignedTo = "Murat Demir", PaymentStatus = "Paid", Value = 500000, Status = "Active", Description = "Şehir parkı yenileme çalışması" }
            );

            for (int i = 13; i <= 100; i++)
            {
                modelBuilder.Entity<SampleData>().HasData(new SampleData 
                { 
                    Id = i, 
                    Name = $"Örnek Proje {i}", 
                    Category = i % 2 == 0 ? "İnşaat" : "Ticari", 
                    Date = DateTime.Now.AddDays(-i), 
                    Project = (i % 4) switch { 0 => "Alpha", 1 => "Beta", 2 => "Gamma", _ => "Delta" },
                    Year = 2020 + (i % 5),
                    Branch = (i % 3) switch { 0 => "İstanbul", 1 => "Ankara", _ => "İzmir" },
                    Region = "Bölge " + (i % 5),
                    Customer = "Müşteri " + (i % 10),
                    Priority = (i % 3) switch { 0 => "High", 1 => "Medium", _ => "Low" },
                    AssignedTo = "Sueda Akça",
                    PaymentStatus = (i % 3) switch { 0 => "Paid", 1 => "Pending", _ => "Overdue" },
                    Value = 100000 * i,
                    Status = "Active",
                    Description = $"Açıklama metni {i}"
                });
            }

            // --- Pool Definitions ---
            modelBuilder.Entity<PoolDefinition>().HasData(
                new PoolDefinition { Id = 1, Name = "DataPool2", DisplayName = "Ticari Kayıtlar", Description = "Yüksek performanslı ticari işlem veri havuzu", TableName = "CommercialRecords" },
                new PoolDefinition { Id = 2, Name = "DataPool3", DisplayName = "Proje Yönetimi", Description = "Aktif proje takip ve bütçe yönetim havuzu", TableName = "ProjectRecords" },
                new PoolDefinition { Id = 3, Name = "UnifiedData", DisplayName = "Veri Havuzu (Excel)", Description = "Genel veri havuzu", TableName = "SampleDatas" }
            );

            // --- Pool Columns for DataPool2 (Ticari) ---
            modelBuilder.Entity<PoolColumn>().HasData(
                new PoolColumn { Id = 1, PoolDefinitionId = 1, OrderIndex = 1, HeaderText = "ID", PropertyName = "Id", DataType = "Text", Width = "80px", CssClass = "ps-4 text-muted font-monospace", HeaderCssClass = "ps-4" },
                new PoolColumn { Id = 2, PoolDefinitionId = 1, OrderIndex = 2, HeaderText = "REF NO", PropertyName = "RefNo", DataType = "BadgeSecondary", Width = "120px", CssClass = "", HeaderCssClass = "" },
                new PoolColumn { Id = 3, PoolDefinitionId = 1, OrderIndex = 3, HeaderText = "TARİH", PropertyName = "Date", DataType = "Date", Width = "120px", CssClass = "text-muted small", HeaderCssClass = "" },
                new PoolColumn { Id = 4, PoolDefinitionId = 1, OrderIndex = 4, HeaderText = "MÜŞTERİ", PropertyName = "CustomerName", DataType = "Text", Width = "", CssClass = "fw-medium text-dark", HeaderCssClass = "" },
                new PoolColumn { Id = 5, PoolDefinitionId = 1, OrderIndex = 5, HeaderText = "BÖLGE", PropertyName = "Region", DataType = "Text", Width = "", CssClass = "text-muted small", HeaderCssClass = "" },
                new PoolColumn { Id = 6, PoolDefinitionId = 1, OrderIndex = 6, HeaderText = "KATEGORİ", PropertyName = "Category", DataType = "BadgePrimary", Width = "", CssClass = "", HeaderCssClass = "" },
                new PoolColumn { Id = 7, PoolDefinitionId = 1, OrderIndex = 7, HeaderText = "TUTAR", PropertyName = "Amount", DataType = "Currency", Width = "", CssClass = "text-end font-monospace fw-bold text-dark", HeaderCssClass = "text-end" },
                new PoolColumn { Id = 8, PoolDefinitionId = 1, OrderIndex = 8, HeaderText = "DURUM", PropertyName = "Status", DataType = "StatusIndicator", Width = "", CssClass = "text-center", HeaderCssClass = "text-center" },
                new PoolColumn { Id = 9, PoolDefinitionId = 1, OrderIndex = 9, HeaderText = "İŞLEM", PropertyName = "Actions", DataType = "Actions", Width = "100px", CssClass = "text-end pe-4", HeaderCssClass = "text-end pe-4" }
            );

            // --- Pool Columns for DataPool3 (Projeler) ---
            modelBuilder.Entity<PoolColumn>().HasData(
                new PoolColumn { Id = 10, PoolDefinitionId = 2, OrderIndex = 1, HeaderText = "#", PropertyName = "Id", DataType = "Text", Width = "60px", CssClass = "text-center fw-bold text-muted", HeaderCssClass = "text-center" },
                new PoolColumn { Id = 11, PoolDefinitionId = 2, OrderIndex = 2, HeaderText = "PROJE DETAYLARI", PropertyName = "ProjectName", DataType = "ProjectDetails", Width = "250px", CssClass = "", HeaderCssClass = "" },
                new PoolColumn { Id = 12, PoolDefinitionId = 2, OrderIndex = 3, HeaderText = "DURUM", PropertyName = "Status", DataType = "StatusBadge", Width = "120px", CssClass = "text-center", HeaderCssClass = "text-center" },
                new PoolColumn { Id = 13, PoolDefinitionId = 2, OrderIndex = 4, HeaderText = "BÜTÇE", PropertyName = "Budget", DataType = "Currency", Width = "150px", CssClass = "text-end font-monospace fw-bold text-dark", HeaderCssClass = "text-end" },
                new PoolColumn { Id = 14, PoolDefinitionId = 2, OrderIndex = 5, HeaderText = "İLERLEME", PropertyName = "Progress", DataType = "ProgressBar", Width = "200px", CssClass = "", HeaderCssClass = "" },
                new PoolColumn { Id = 15, PoolDefinitionId = 2, OrderIndex = 6, HeaderText = "EKİP", PropertyName = "Team", DataType = "AvatarGroup", Width = "150px", CssClass = "", HeaderCssClass = "" },
                new PoolColumn { Id = 16, PoolDefinitionId = 2, OrderIndex = 7, HeaderText = "TESLİM", PropertyName = "DueDate", DataType = "Date", Width = "120px", CssClass = "text-muted small", HeaderCssClass = "" },
                new PoolColumn { Id = 17, PoolDefinitionId = 2, OrderIndex = 8, HeaderText = "İŞLEM", PropertyName = "Actions", DataType = "ActionsVertical", Width = "100px", CssClass = "text-center", HeaderCssClass = "text-center" }
            );
            
            // --- Pool Columns for UnifiedData (SampleDatas replacement) ---
            // ID;PROJE;YIL;BOLGE;SUBE;MUSTERI;ADI;KATEGORI;ONCELIK;ATANAN;DEGER;ODEME;DURUM;ACIKLAMA
            modelBuilder.Entity<PoolColumn>().HasData(
                new PoolColumn { Id = 18, PoolDefinitionId = 3, OrderIndex = 1, HeaderText = "#", PropertyName = "Id", DataType = "Text", Width = "50px", CssClass = "col-index", HeaderCssClass = "col-index" },
                new PoolColumn { Id = 19, PoolDefinitionId = 3, OrderIndex = 2, HeaderText = "ID", PropertyName = "Id", DataType = "Text", Width = "", CssClass = "d-none d-lg-table-cell", HeaderCssClass = "d-none d-lg-table-cell" },
                new PoolColumn { Id = 20, PoolDefinitionId = 3, OrderIndex = 3, HeaderText = "Proje", PropertyName = "Project", DataType = "BadgeLight", Width = "", CssClass = "d-none d-md-table-cell", HeaderCssClass = "d-none d-md-table-cell" },
                new PoolColumn { Id = 21, PoolDefinitionId = 3, OrderIndex = 4, HeaderText = "Yıl", PropertyName = "Year", DataType = "Text", Width = "", CssClass = "d-none d-xl-table-cell", HeaderCssClass = "d-none d-xl-table-cell" },
                new PoolColumn { Id = 22, PoolDefinitionId = 3, OrderIndex = 5, HeaderText = "Bölge", PropertyName = "Region", DataType = "Text", Width = "", CssClass = "d-none d-lg-table-cell text-muted", HeaderCssClass = "d-none d-lg-table-cell" },
                new PoolColumn { Id = 23, PoolDefinitionId = 3, OrderIndex = 6, HeaderText = "Şube", PropertyName = "Branch", DataType = "Text", Width = "", CssClass = "d-none d-lg-table-cell", HeaderCssClass = "d-none d-lg-table-cell" },
                new PoolColumn { Id = 24, PoolDefinitionId = 3, OrderIndex = 7, HeaderText = "Müşteri", PropertyName = "Customer", DataType = "Text", Width = "", CssClass = "fw-medium", HeaderCssClass = "" },
                new PoolColumn { Id = 25, PoolDefinitionId = 3, OrderIndex = 8, HeaderText = "Adı", PropertyName = "Name", DataType = "Text", Width = "", CssClass = "fw-bold", HeaderCssClass = "" },
                new PoolColumn { Id = 26, PoolDefinitionId = 3, OrderIndex = 9, HeaderText = "Kategori", PropertyName = "Category", DataType = "Text", Width = "", CssClass = "d-none d-sm-table-cell", HeaderCssClass = "d-none d-sm-table-cell" },
                new PoolColumn { Id = 27, PoolDefinitionId = 3, OrderIndex = 10, HeaderText = "Öncelik", PropertyName = "Priority", DataType = "PriorityBadge", Width = "", CssClass = "text-center", HeaderCssClass = "text-center" },
                new PoolColumn { Id = 28, PoolDefinitionId = 3, OrderIndex = 11, HeaderText = "Atanan", PropertyName = "AssignedTo", DataType = "UserAvatar", Width = "", CssClass = "d-none d-xxl-table-cell", HeaderCssClass = "d-none d-xxl-table-cell" },
                new PoolColumn { Id = 29, PoolDefinitionId = 3, OrderIndex = 12, HeaderText = "Değer (TL)", PropertyName = "Value", DataType = "Currency", Width = "", CssClass = "text-end font-monospace fw-bold", HeaderCssClass = "text-end" },
                new PoolColumn { Id = 30, PoolDefinitionId = 3, OrderIndex = 13, HeaderText = "Ödeme", PropertyName = "PaymentStatus", DataType = "PaymentStatus", Width = "", CssClass = "text-center", HeaderCssClass = "text-center" },
                new PoolColumn { Id = 31, PoolDefinitionId = 3, OrderIndex = 14, HeaderText = "Durum", PropertyName = "Status", DataType = "StatusPill", Width = "", CssClass = "text-center", HeaderCssClass = "text-center" },
                new PoolColumn { Id = 32, PoolDefinitionId = 3, OrderIndex = 15, HeaderText = "Açıklama", PropertyName = "Description", DataType = "TextTruncate", Width = "", CssClass = "d-none d-xxl-table-cell", HeaderCssClass = "d-none d-xxl-table-cell" }
            );

            // --- Seed Commercial Records (Data Pool 2) ---
            for (int i = 1; i <= 200; i++)
            {
                modelBuilder.Entity<CommercialRecord>().HasData(new CommercialRecord
                {
                    Id = i,
                    RefNo = $"REF-{100000 + i}",
                    Date = DateTime.Now.AddDays(-i % 1000),
                    CustomerName = $"Müşteri {(i % 500) + 1} A.Ş.",
                    Region = (i % 4) switch { 0 => "Marmara", 1 => "Ege", 2 => "İç Anadolu", _ => "Akdeniz" },
                    Category = (i % 3) switch { 0 => "Kurumsal", 1 => "Bireysel", _ => "Kamu" },
                    Amount = (decimal)((i * 137.5) % 50000) + 1000,
                    Status = (i % 5) == 0 ? "Pasif" : (i % 3) == 0 ? "Bekliyor" : "Aktif"
                });
            }

            // --- Seed Project Records (Data Pool 3) ---
            for (int i = 1; i <= 100; i++)
            {
                modelBuilder.Entity<ProjectRecord>().HasData(new ProjectRecord
                {
                    Id = i,
                    ProjectName = $"Proje Görselleştirme #{1000 + i}",
                    CustomerName = $"Global Müşteri {(i % 50) + 1}",
                    Status = (i % 4) switch { 0 => "Active", 1 => "Pending", 2 => "On Hold", _ => "Completed" },
                    Progress = new Random(i).Next(10, 100),
                    Budget = new Random(i).Next(50000, 500000),
                    DueDate = DateTime.Now.AddDays(new Random(i).Next(5, 120))
                });
            }
        }
    }
}
