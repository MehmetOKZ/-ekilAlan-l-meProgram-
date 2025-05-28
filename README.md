# 📐 Şekil Alanı Hesaplama Programı

Bu C# programı, kullanıcıdan dikdörtgen veya daire seçmesini ister ve girilen ölçülere göre ilgili şeklin **alanını hesaplar**.

## 🧮 Özellikler

- Kullanıcıdan şekil seçimi: `d` girilirse **dikdörtgen**, başka bir tuş girilirse **daire** seçilir.
- Gerekli ölçüler kullanıcıdan alınır.
- Alan hesaplanır ve ekrana yazdırılır.

## 📷 Ekran Görüntüleri

### ✅ Şekil Seçim Ekranı
![Şekil Seçim](https://github.com/MehmetOKZ/-ekilAlan-l-meProgram-/blob/master/asset/Screenshot-1.png?raw=true)

---

### 📏 Dikdörtgen Alan Hesaplama
![Dikdörtgen](https://github.com/MehmetOKZ/-ekilAlan-l-meProgram-/blob/master/asset/Screenshot-2.png?raw=true)

---

### 🔵 Daire Alan Hesaplama
![Daire](https://github.com/MehmetOKZ/-ekilAlan-l-meProgram-/blob/master/asset/Screenshot-3.png?raw=true)

---

## 🧑‍💻 Kod Açıklaması

```csharp
if (cevap == "d")

Kullanıcı 'd' girerse, dikdörtgen seçilir.

Yükseklik ve genişlik alınarak alan hesaplanır:

Alan = yükseklik × genişlik
else
Herhangi başka bir giriş yapılırsa daire seçilir.

Yarıçap alınarak alan hesaplanır:

Alan = π × yarıçap²

🛠 Kullanım
1. Projeyi çalıştırın.

2. Şekil seçimi yapın: d veya farklı bir tuş girin.

3. Gerekli ölçüleri girin.

4. Hesaplanan alan sonucu ekranda gözükecektir.

📌 Lisans
Bu proje açık kaynaklıdır ve serbestçe kullanılabilir.

