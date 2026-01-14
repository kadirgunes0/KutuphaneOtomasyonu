using System;
namespace kitap
{
    public class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public int YayinYili { get; set; }
        public string ISBN { get; set; }
        public string Kategori { get; set; }
    }

    //for fake dataset
    public static class VeriDeposu
    {
        public static List<Kitap> KitaplariGetir()
        {
            return new List<Kitap>
            {
                new Kitap { Ad = "Nutuk", Yazar = "Mustafa Kemal Atatürk", Yayinevi = "Yapı Kredi", YayinYili = 1927, ISBN = "978-975", Kategori = "Tarih" },
                new Kitap { Ad = "Suç ve Ceza", Yazar = "Dostoyevski", Yayinevi = "Can Yayınları", YayinYili = 1866, ISBN = "978-605", Kategori = "Klasik" },
                new Kitap { Ad = "1984", Yazar = "George Orwell", Yayinevi = "Can Yayınları", YayinYili = 1949, ISBN = "978-975-07", Kategori = "Bilim Kurgu" }
            };
        }
    }
}