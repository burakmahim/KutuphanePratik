# Kitap Kay�t Uygulamas�

Bu proje, kitap nesnelerini kaydetmek ve y�netmek i�in basit bir `Kitap` s�n�f� uygulamas�d�r. `Kitap` s�n�f�, kitaplar�n ad�, yazar bilgileri, sayfa say�s�, yay�nevi ve kay�t tarihi gibi �zelliklerini i�erir. Uygulama, her bir kitap nesnesi olu�turuldu�unda, olu�turulma tarihini kay�t tarihi olarak atar. 

## Proje �zeti

Uygulama iki farkl� `constructor` i�erir:
- **Parametresiz Constructor**: Parametre almaz ve yaln�zca kay�t tarihini atan�r.
- **Parametreli Constructor**: Kitap ad�, yazar ad�, sayfa say�s� ve yay�nevi bilgilerini al�r ve bu de�erleri nesne �zelliklerine atar. 

Bu proje �rne�inde, Ay�e Kulin'in "Ad� Aylin" adl� kitab� kaydedilir ve t�m �zellikleriyle konsola yazd�r�l�r.

## �zellikler

`Kitap` s�n�f� a�a��daki �zellikleri i�erir:
- **Ad**: Kitab�n ad�.
- **Yazar Ad�**: Kitab�n yazar�.
- **Sayfa Say�s�**: Kitab�n sayfa say�s�.
- **Yay�nevi**: Kitab�n yay�nevi.
- **Kay�t Tarihi**: Kitap nesnesi olu�turulurken otomatik olarak atan�r.

## Kullan�m

A�a��daki ad�mlar� izleyerek projeyi �al��t�rabilirsiniz:

1. Projeyi klonlay�n veya indirin.
2. `.NET` ortam�nda �al��t�rmak i�in terminal veya komut sat�r�ndan `dotnet run` komutunu kullan�n.

�rnek ��kt�:

Kitap 1 Bilgileri: Kitap Ad�: Ad� Aylin Yazar Ad�: Ay�e Kulin Sayfa Say�s�: 398 Yay�nevi: Remzi Kitabevi Kay�t Tarihi: 03.10.2024

Kitap 2 Bilgileri: Kitap Ad�: Ad� Aylin Yazar Ad�: Ay�e Kulin Sayfa Say�s�: 398 Yay�nevi: Remzi Kitabevi Kay�t Tarihi: 03.10.2024


## S�n�f Yap�s�

### `Kitap` S�n�f�
- **Property'ler**:
  - `Ad`: Kitap ad�
  - `YazarAdi`: Yazar ad�
  - `SayfaSayisi`: Sayfa say�s�
  - `Yayinevi`: Yay�nevi
  - `KayitTarihi`: Kay�t tarihi (otomatik atan�r)

- **Metotlar**:
  - `KitapBilgileriniYazdir()`: Kitap bilgilerini konsola yazd�r�r.

### `Constructor` Tan�mlar�
- `Kitap()`: Parametresiz constructor.
- `Kitap(string ad, string yazarAdi, int sayfaSayisi, string yayinevi)`: Kitap ad�, yazar ad�, sayfa say�s� ve yay�nevi bilgilerini alan constructor.

## Gereksinimler

Bu proje i�in `dotnet` 6 SDK gereklidir.

