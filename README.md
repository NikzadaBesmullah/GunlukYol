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

## Swagger Ekran Görüntüsü
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151327" src="https://github.com/user-attachments/assets/c35a1b5b-6cb3-4b1c-90bb-c6a15920efd9" />

<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 160012" src="https://github.com/user-attachments/assets/2ff400a1-b260-420e-acab-210cbe2d02c0" />

<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 160019" src="https://github.com/user-attachments/assets/1be72d78-c4c4-4cd0-be6e-bdaa32e25ef2" />

<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151348" src="https://github.com/user-attachments/assets/7b7db840-106a-4dba-beb4-0e85b419bd88" />

<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151404" src="https://github.com/user-attachments/assets/6b40e11a-e58b-46a1-b282-7a8f770c2484" />

<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151411" src="https://github.com/user-attachments/assets/223aa298-0c38-4cbe-8d9e-2365522db1af" />

---

Hazırlayan:  
## Besmullah Nikzada

