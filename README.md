# MultiShop Mikroservis Projesi

Bu proje, mikroservis mimarisini kullanarak geliştirdiğim modern bir e-ticaret uygulamasıdır. Mikroservis mimarisi ile tasarlanan bu projede, kullanıcıların kayıt olup oturum açmaları, ürünleri inceleyip sepetlerine eklemeleri ve sahte bir ödeme sistemi üzerinden alışverişlerini tamamlamaları sağlanmıştır. 

Proje, kullanıcı kimlik doğrulama, ürün yönetimi, sepet yönetimi ve ödeme işlemleri gibi temel e-ticaret işlevlerini içermekte olup, ölçeklenebilir ve yönetilebilir bir yapı sunmaktadır. Bu sayede, büyük e-ticaret projelerinin gereksinimlerini karşılayacak sağlam bir altyapı oluşturulmuştur.

## 📋 İçindekiler

- [Mikroservis Nedir?](#mikroservis-nedir)
- [Kullanılan Veritabanları](#kullanılan-veritabanları)
- [Kullanılan Backend Teknolojileri](#kullanılan-backend-teknolojileri)
- [Kullanılan Tasarım Desenleri](#kullanılan-tasarım-desenleri)
- [Kullanılan Cloud Servisler](#kullanılan-cloud-servisler)
- [Port Numaraları](#port-numaraları)
- [Proje Görselleri](#proje-görselleri)
- [Kurulum ve Çalıştırma](#-kurulum-ve-çalıştırma)
- [İletişim](#-i̇letişim)

## Mikroservis Nedir?

Mikroservis mimarisi, büyük ve karmaşık uygulamaları daha küçük, bağımsız olarak yönetilebilen ve dağıtılabilen hizmetlere (servislere) bölmeyi amaçlayan bir yazılım geliştirme yaklaşımıdır. Her mikroservis, belirli bir işlevselliği yerine getirir ve birbiri ile iletişim halindedir.

## Kullanılan Veritabanları

- **MS SQL Server** (Local)
- **MS SQL Server** (Docker)
- **PostgreSQL**
- **Redis**
- **MongoDB**
- **SQLite**

## Kullanılan Backend Teknolojileri

- **Docker** - Konteynerizasyon
- **ASP.NET Core Identity** - Kimlik doğrulama
- **JWT (JSON Web Token)** - Token tabanlı yetkilendirme
- **RabbitMQ** - Mesaj kuyruğu sistemi
- **DBeaver** - Veritabanı yönetim aracı
- **Google Cloud Storage** - Bulut depolama
- **Ocelot** - API Gateway
- **SignalR** - Gerçek zamanlı iletişim
- **SMTP Mail** - E-posta gönderimi
- **Ajax** - Asenkron web istekleri
- **Dapper** - Micro ORM

## Kullanılan Tasarım Desenleri

- **Mediator Design Pattern** - Nesneler arası gevşek bağlantı
- **CQRS Design Pattern** - Komut ve sorgu ayrımı
- **Onion Architecture** - Katmanlı mimari yapısı
- **Repository Design Pattern** - Veri erişim katmanı soyutlaması

## Kullanılan Cloud Servisler

- **Google Cloud Storage** - Dosya ve medya depolama

## Port Numaraları

Mikroservislerin çalıştığı port numaraları için [PortNumber.txt](PortNumber.txt) dosyasına bakabilirsiniz.

### Ana Servisler

- **API Gateway (Ocelot)**: 5000
- **Identity Server**: 5001
- **Catalog Service**: 7269/7270
- **Basket Service**: 7110
- **Order Service**: 7096
- **Payment Service**: 7100
- **Discount Service**: 7071
- **Cargo Service**: 7158
- **Comment Service**: 7123
- **Images Service**: 7066
- **Messages Service**: 7079

## Proje Görselleri

Aşağıda MultiShop e-ticaret uygulamasının çeşitli ekran görüntüleri yer almaktadır:

![Ana Sayfa](https://github.com/abdks/MultiShop/assets/62968246/790cacf4-f84a-41c2-9155-979c22eaf66d)
*Ana sayfa görünümü*

![Ürün Listesi](https://github.com/abdks/MultiShop/assets/62968246/6e5f7e82-2969-4e5f-8c43-ee215329361c)
*Ürün katalog sayfası*

![Ürün Detayı](https://github.com/abdks/MultiShop/assets/62968246/a9ba3361-62d1-4992-8187-4ecc605a2f40)
*Ürün detay sayfası*

![Sepet](https://github.com/abdks/MultiShop/assets/62968246/caa0d347-811a-424a-afb4-af0f35544c09)
*Alışveriş sepeti*

![Ödeme](https://github.com/abdks/MultiShop/assets/62968246/b43f3825-511b-4372-9ab5-7e2725c9d93a)
*Ödeme sayfası*

![Admin Panel](https://github.com/abdks/MultiShop/assets/62968246/2c47f297-6174-4ed2-bcd4-a7bd73596e11)
*Yönetici paneli*

![Kullanıcı Profili](https://github.com/abdks/MultiShop/assets/62968246/96f74f96-2d99-4b0c-a8b8-1ff63fe123d5)
*Kullanıcı profil sayfası*

![İstatistikler](https://github.com/abdks/MultiShop/assets/62968246/fb356cc3-4d0b-4647-95ca-bdb593307239)
*Dashboard istatistikleri*

![Mesajlaşma](https://github.com/abdks/MultiShop/assets/62968246/4d1342ea-73b6-4d1a-8609-575d108c2111)
*Mesajlaşma sistemi*

---

## 🚀 Kurulum ve Çalıştırma

1. Projeyi klonlayın
2. Docker Desktop'ı başlatın
3. Her mikroservisin port numaralarını [PortNumber.txt](PortNumber.txt) dosyasından kontrol edin
4. Gerekli veritabanlarını ayağa kaldırın
5. Mikroservisleri sırasıyla başlatın

## 📞 İletişim

Proje hakkında sorularınız için GitHub Issues bölümünü kullanabilirsiniz.