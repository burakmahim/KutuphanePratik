using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphanePratik
{
    public class Kitap
    {
        // Property tanımlamaları
        public string Ad { get; set; }
        public string YazarAdi { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; private set; }

        // Default constructor
        public Kitap()
        {
            KayitTarihi = DateTime.Now; // Nesne oluşturulduğunda Kayıt Tarihi otomatik atanır
        }

        // Parametreli constructor
        public Kitap(string ad, string yazarAdi, int sayfaSayisi, string yayinevi)
        {
            Ad = ad;
            YazarAdi = yazarAdi;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
            KayitTarihi = DateTime.Now; // Nesne oluşturulduğunda Kayıt Tarihi otomatik atanır
        }

        // Kitap bilgilerini yazdıran metot
        public void KitapBilgileriniYazdir()
        {
            Console.WriteLine($"Kitap Adı: {Ad}");
            Console.WriteLine($"Yazar Adı: {YazarAdi}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {Yayinevi}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
        }
    }
}
