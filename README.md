# Kitap Kayýt Uygulamasý

Bu proje, kitap nesnelerini kaydetmek ve yönetmek için basit bir `Kitap` sýnýfý uygulamasýdýr. `Kitap` sýnýfý, kitaplarýn adý, yazar bilgileri, sayfa sayýsý, yayýnevi ve kayýt tarihi gibi özelliklerini içerir. Uygulama, her bir kitap nesnesi oluþturulduðunda, oluþturulma tarihini kayýt tarihi olarak atar. 

## Proje Özeti

Uygulama iki farklý `constructor` içerir:
- **Parametresiz Constructor**: Parametre almaz ve yalnýzca kayýt tarihini atanýr.
- **Parametreli Constructor**: Kitap adý, yazar adý, sayfa sayýsý ve yayýnevi bilgilerini alýr ve bu deðerleri nesne özelliklerine atar. 

Bu proje örneðinde, Ayþe Kulin'in "Adý Aylin" adlý kitabý kaydedilir ve tüm özellikleriyle konsola yazdýrýlýr.

## Özellikler

`Kitap` sýnýfý aþaðýdaki özellikleri içerir:
- **Ad**: Kitabýn adý.
- **Yazar Adý**: Kitabýn yazarý.
- **Sayfa Sayýsý**: Kitabýn sayfa sayýsý.
- **Yayýnevi**: Kitabýn yayýnevi.
- **Kayýt Tarihi**: Kitap nesnesi oluþturulurken otomatik olarak atanýr.

## Kullaným

Aþaðýdaki adýmlarý izleyerek projeyi çalýþtýrabilirsiniz:

1. Projeyi klonlayýn veya indirin.
2. `.NET` ortamýnda çalýþtýrmak için terminal veya komut satýrýndan `dotnet run` komutunu kullanýn.

Örnek Çýktý:

Kitap 1 Bilgileri: Kitap Adý: Adý Aylin Yazar Adý: Ayþe Kulin Sayfa Sayýsý: 398 Yayýnevi: Remzi Kitabevi Kayýt Tarihi: 03.10.2024

Kitap 2 Bilgileri: Kitap Adý: Adý Aylin Yazar Adý: Ayþe Kulin Sayfa Sayýsý: 398 Yayýnevi: Remzi Kitabevi Kayýt Tarihi: 03.10.2024


## Sýnýf Yapýsý

### `Kitap` Sýnýfý
- **Property'ler**:
  - `Ad`: Kitap adý
  - `YazarAdi`: Yazar adý
  - `SayfaSayisi`: Sayfa sayýsý
  - `Yayinevi`: Yayýnevi
  - `KayitTarihi`: Kayýt tarihi (otomatik atanýr)

- **Metotlar**:
  - `KitapBilgileriniYazdir()`: Kitap bilgilerini konsola yazdýrýr.

### `Constructor` Tanýmlarý
- `Kitap()`: Parametresiz constructor.
- `Kitap(string ad, string yazarAdi, int sayfaSayisi, string yayinevi)`: Kitap adý, yazar adý, sayfa sayýsý ve yayýnevi bilgilerini alan constructor.

## Gereksinimler

Bu proje için `dotnet` 6 SDK gereklidir.

