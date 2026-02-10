# Okyanus - Blazor Web Application

Bu proje, modern bir web arayüzüne sahip, **.NET 8** ve **Blazor Server** teknolojileri kullanılarak geliştirilmiş kapsamlı bir dashboard uygulamasıdır. İçerisinde veri havuzu, analiz raporları, dinamik kullanıcı yönetimi ve gelişmiş grafikler bulunmaktadır.

## 🚀 Özellikler

- **Modern Arayüz:** responsive ve şık tasarım, özel animasyonlar.
- **Veri Havuzu:** Milyonlarca satır veriyi sanallaştırma (Virtualization) ile performanslı gösterme.
- **Raporlama Merkezi:** ApexCharts entegrasyonu ile interaktif grafikler (Alan, Halka, Bar).
- **Dinamik Sekme Yönetimi:** Sekmeler arası gezinti ve kalıcı "Ana Sayfa" mantığı.
- **Kullanıcı Yönetimi:** Dinamik kullanıcı değiştirme ve profil yönetimi.

## 🛠 Gereksinimler

Projeyi çalıştırmadan önce bilgisayarınızda aşağıdakilerin kurulu olduğundan emin olun:

- [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (veya Docker üzerinde çalışan bir instance)
- Bir kod editörü (Önerilen: VS Code veya Visual Studio 2022)

### 🎨 Tasarım ve Arayüz Gereksinimleri

Projenin modern arayüzünün (fontlar, ikonlar, grafikler) eksiksiz çalışması için **aktif bir internet bağlantısı** gereklidir (CDN bağımlılıkları).

- **Google Fonts:** Proje, modern ve okunabilir `Inter` ve `Outfit` font ailelerini kullanır.
- **ApexCharts JS:** Gelişmiş grafik kütüphanesi.
- **Bootstrap Icons:** Kullanıcı arayüzünde kullanılan tüm ikon seti.
- **Bootstrap Bundle JS:** Menü ve interaktif bileşenler.

Ayrıca, projenin **CSS Isolation** özelliğinin doğru çalışması ve stil dosyalarının üretilmesi için projeyi ilk kez çalıştırırken mutlaka bir kez `dotnet build` komutu çalıştırılmalıdır (veya `dotnet run` öncesi bu işlem otomatik yapılır).

## 📦 Kurulum Adımları

1. **Projeyi Klonlayın:**
   Terminali açın ve projeyi bilgisayarınıza indirin (veya ZIP olarak indirip çıkarın).
   ```bash
   git clone https://github.com/kullaniciadi/BlazorWebApp.git
   cd BlazorWebApp
   ```

2. **Veritabanı Bağlantısını Ayarlayın:**
   `appsettings.json` dosyasını açın ve `DefaultConnection` alanına kendi SQL Server bağlantı cümlenizi yazın.
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=BlazorAppDb;Trusted_Connection=True;TrustServerCertificate=True;"
   }
   ```
   *Not: Eğer Mac kullanıyorsanız ve Docker ile SQL Server çalıştırıyorsanız, bağlantı cümlenizi ona göre düzenleyin (örn: `Server=localhost,1433;User Id=sa;Password=...`).*

3. **Veritabanını Oluşturun:**
   Terminalde proje dizinindeyken aşağıdaki komutu çalıştırarak veritabanını ve tabloları oluşturun:
   ```bash
   dotnet ef database update
   ```

## ▶️ Çalıştırma

Uygulamayı geliştirme modunda çalıştırmak için:

```bash
dotnet watch run
```

Bu komut uygulamayı başlatacak ve tarayıcınızda otomatik olarak açacaktır (genellikle `http://localhost:5xxx` adresinde). `watch` parametresi sayesinde kodda yaptığınız değişiklikler anında sayfaya yansır (Hot Reload).

## 📂 Proje Yapısı

- **Components/Pages:** Sayfa tasarımları (Home, DataGrid, Reports vb.).
- **Components/Layout:** Ana katman (MainLayout) ve menü (NavMenu).
- **Services:** İş mantığı servisleri (UserService, TabService).
- **wwwroot:** Statik dosyalar (CSS, JS, Resimler).

## 🤝 Katkıda Bulunma

1. Bu depoyu forklayın.
2. Yeni bir özellik dalı (feature branch) oluşturun.
3. Değişikliklerinizi commit yapın.
4. Dalınızı pushlayın ve bir Pull Request oluşturun.

---
*Geliştirici Notu: Proje Blazor Server olduğu için sürekli bir WebSocket bağlantısına ihtiyaç duyar. Tarayıcı bağlantısı koptuğunda sayfa yenilenmelidir.*
