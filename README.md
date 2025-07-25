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
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151327" src="https://github.com/user-attachments/assets/c35a1b5b-6cb3-4b1c-90bb-c6a15920efd9" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151411" src="https://github.com/user-attachments/assets/223aa298-0c38-4cbe-8d9e-2365522db1af" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151404" src="https://github.com/user-attachments/assets/6b40e11a-e58b-46a1-b282-7a8f770c2484" />
<img width="1920" height="1020" alt="Ekran görüntüsü 2025-07-25 151348" src="https://github.com/user-attachments/assets/7b7db840-106a-4dba-beb4-0e85b419bd88" />

---

## Notlar

- Veritabanı dosyası (`gorevler.db`) proje ile birlikte gelir.
- Her kullanıcı kendi görev ve hedeflerini görebilir.

---



Hazırlayan:  
Nikzada Besmullah

