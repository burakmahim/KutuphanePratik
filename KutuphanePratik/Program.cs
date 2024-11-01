using KutuphanePratik;

// Parametre almayan default constructor ile kitap nesnesi oluşturma
Kitap kitap1 = new Kitap();
kitap1.Ad = "Adı Aylin";
kitap1.YazarAdi = "Ayşe Kulin";
kitap1.SayfaSayisi = 398;
kitap1.Yayinevi = "Remzi Kitabevi";

// Parametreli constructor ile kitap nesnesi oluşturma
Kitap kitap2 = new Kitap("Adı Aylin", "Ayşe Kulin", 398, "Remzi Kitabevi");

// Kitap bilgilerini konsola yazdırma
Console.WriteLine("Kitap 1 Bilgileri:");
kitap1.KitapBilgileriniYazdir();

Console.WriteLine("\nKitap 2 Bilgileri:");
kitap2.KitapBilgileriniYazdir();