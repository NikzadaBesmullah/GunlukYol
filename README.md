# GünlükYol - Görev ve Hedef Takip Uygulaması

Bu proje, kullanıcıların günlük görevlerini ve kısa/orta/uzun vadeli hedeflerini yönetebileceği bir web uygulamasıdır.  
Backend .NET 9 Web API, frontend ise React ile geliştirilmiştir.

---

## Proje Açıklaması
Kullanıcılar kayıt olabilir, giriş yapabilir, görev ve hedef ekleyip düzenleyebilir. Her kullanıcı sadece kendi görev ve hedeflerini görebilir. JWT ile güvenli giriş/çıkış sağlanır. Swagger arayüzü ile API uç noktaları kolayca test edilebilir.

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

Swagger arayüzüne tarayıcıdan `http://localhost:5290/swagger` adresinden ulaşabilirsin.  
Ekran görüntüsü almak için:  
- Windows: `Windows + Shift + S` tuşlarına bas, ekranın istediğin bölümünü seç.  
- Görüntüyü README'ye veya teslim dosyasına ekle.

---

## Notlar

- Veritabanı dosyası (`gorevler.db`) proje ile birlikte gelir.
- Her kullanıcı kendi görev ve hedeflerini görebilir.

---

Hazırlayan:  
Nikzada Besmullah
