# Patikaflix - TV Dizi Listesi Uygulaması

Bu konsol uygulaması, kullanıcıdan TV dizilerine ait bilgileri alır, bir listeye ekler ve bu liste üzerinde bazı LINQ sorguları gerçekleştirir. Uygulama C# dilinde yazılmıştır ve temel OOP (nesne yönelimli programlama) ile LINQ yapıları kullanılmıştır.

---

## 🔧 Özellikler

- Kullanıcıdan dizi bilgilerini alma (dizi adı, yapım yılı, tür, çıkış yılı, yönetmen, platform).
- Girilen her diziyi `TvSeries` sınıfı ile nesneleştirip `tvSeriesList` listesine ekleme.
- Tüm dizileri ekrana yazdırma.
- Komedi türündeki dizileri filtreleyip sadece:
  - Dizi Adı
  - Tür
  - Yönetmen
  bilgileriyle yeni bir liste oluşturma ve sıralı biçimde yazdırma.

---

## 🧩 Kullanılan Sınıflar

### `TvSeries` Class (Patikaflix Namespace)

| Property        | Açıklama                    |
|----------------|-----------------------------|
| TvName         | Dizinin adı                 |
| PublishingYear | Dizinin yapım yılı          |
| Genres         | Dizi türü (Liste şeklinde)  |
| ReleaseYear    | Yayınlanmaya başlama yılı   |
| Directors      | Yönetmen ismi/isimleri      |
| Platform       | Yayınlandığı ilk platform   |

Ayrıca:
- Farklı türler için overload constructor
- `GetTvSeries()` metodu ile ekrana bilgileri düzgün biçimde yazdırma

---

## 📝 Kullanım Adımları

1. Konsol uygulamasını başlatın.
2. Sistem size sırayla:
   - Dizi adı
   - Yapım yılı
   - Tür
   - Yayın yılı
   - Yönetmen
   - Platform
   bilgilerini soracaktır.
3. Her dizi girişinden sonra yeni bir dizi girip girmeyeceğiniz sorulacaktır. `Evet` derseniz giriş devam eder, `Hayır` derseniz liste yazdırılır.
4. Program tüm dizileri listeler.
5. Ardından türü "komedi" olan dizileri, sıralı şekilde (önce isme göre, sonra yönetmene göre) yazdırır.

---

## 📌 LINQ ile Gerçekleştirilen İşlemler

- `Where()` ile türü komedi olan dizilerin filtrelenmesi.
- `Any()` ve `ToLower().Contains("komedi")` ile bir dizinin tür listesinde "komedi" olup olmadığının kontrolü.
- `OrderBy()` ve `ThenBy()` ile isim ve yönetmene göre sıralama.

---

## 👀 Örnek Ekran Çıktısı
![image](https://github.com/user-attachments/assets/c2b4b5db-7b7c-423f-903e-6b7f17f14b6a)

