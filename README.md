# GünlükYol - Görev ve Hedef Takip Uygulaması

Bu proje, kullanıcıların günlük görevlerini ve kısa, orta, uzun vadeli hedeflerini kolayca planlayıp takip edebilmeleri için geliştirilmiş modern bir web uygulamasıdır.
Kullanıcılar, kendi hesaplarını oluşturarak sisteme giriş yapabilir, günlük yapılacak işlerini ve kişisel hedeflerini ekleyebilir, düzenleyebilir ve tamamlananları işaretleyebilirler.
Her kullanıcı yalnızca kendi görev ve hedeflerini görebilir ve yönetebilir; böylece kişisel veri güvenliği sağlanır.

---

## Proje Açıklaması
Bu uygulama sayesinde kullanıcılar, sisteme kayıt olarak kendi hesaplarını oluşturabilir ve güvenli bir şekilde giriş yapabilirler. Giriş yaptıktan sonra, günlük görevlerini ve kısa, orta, uzun vadeli hedeflerini kolayca ekleyebilir, düzenleyebilir ve tamamlananları işaretleyebilirler. Her kullanıcı yalnızca kendi görev ve hedeflerini görebilir ve yönetebilir; böylece kişisel verilerin gizliliği korunur.
Uygulamada güvenlik için JWT (JSON Web Token) tabanlı kimlik doğrulama sistemi kullanılmıştır. Bu sayede kullanıcıların oturumları güvenli bir şekilde yönetilir. Ayrıca, geliştiriciler ve test edenler için API uç noktaları Swagger arayüzü ile görsel olarak sunulmakta ve kolayca test edilebilmektedir.
Uygulamanın arka tarafı (backend), güçlü ve güvenli bir altyapı sunan .NET 9 Web API ile geliştirilmiştir.
Veri saklama için SQLite veritabanı kullanılmıştır ve tüm kullanıcı işlemleri JWT tabanlı kimlik doğrulama ile korunmaktadır.
Ön yüz (frontend) ise React ve Material UI ile hazırlanmış olup, kullanıcı dostu ve modern bir arayüz sunar.
Bu proje ile amaçlanan, kişisel zaman ve hedef yönetimini dijital ortamda pratik, güvenli ve erişilebilir hale getirmektir.

---

## Kurulum ve Çalıştırma

### 1. Backend (API) Kurulumu

- .NET 9 SDK yüklü olmalı: [https://dotnet.microsoft.com/en-us/download/dotnet/9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Komut satırında proje klasörüne gir:
  ```
  cd GorevTakipApi
  dotnet restore
  dotnet ef database update
  dotnet run
  ```
- API varsayılan olarak `http://localhost:5290` adresinde çalışır.
- Swagger arayüzü için: `http://localhost:5290/swagger`

### 2. Frontend (React) Kurulumu

- Node.js yüklü olmalı: [https://nodejs.org/](https://nodejs.org/)
- Komut satırında frontend klasörüne gir:
  ```
  cd gorev-takip-frontend
  npm install
  npm start
  ```
- Uygulama `http://localhost:3000` adresinde açılır.

### 3. Giriş Bilgileri

- Kayıt olarak yeni kullanıcı oluşturabilirsin.
- Giriş yaptıktan sonra görev ve hedef ekleyebilirsin.

---

##  Ekran Görüntüleri

<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151404" src="https://github.com/user-attachments/assets/35e7e988-1157-450c-8e2a-80fb6db4cd09" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151348" src="https://github.com/user-attachments/assets/a9019749-54df-4d07-bf37-fb12320168aa" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151327" src="https://github.com/user-attachments/assets/03c37d8b-566e-4671-875a-dfc2d7ed4d71" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 160019" src="https://github.com/user-attachments/assets/c20e2b6a-fff2-44b2-bd96-1a27cf7b7dc5" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 160012" src="https://github.com/user-attachments/assets/d44f94dd-7c7a-4da3-8697-960269387eac" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151411" src="https://github.com/user-attachments/assets/67727bbd-731d-49bd-9699-018871747941" />


Hazırlayan:  
## Besmullah Nikzada

