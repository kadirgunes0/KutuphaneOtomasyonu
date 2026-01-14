using System;
using System.Collections.Generic;

namespace kitap{
    public class Kitap
    {
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public string Yayinevi { get; set; }
        public int YayinYili { get; set; }
        public string ISBN { get; set; }
        public string Kategori { get; set; }
        public bool alindi { get; set; }
        public string oduncAlanKullaniciAdi { get; set; }
        public int toplamOkunmaSayisi { get; set; } = 0;
        public DateTime AlinisTarihi { get; set; }
    }

    //for fake dataset
    public static class VeriDeposu
    {
        private static List<Kitap> kitaplar = new List<Kitap>
    {
        new Kitap { Ad = "Nutuk", Yazar = "M. Kemal Atatürk", Yayinevi = "Yapı Kredi", YayinYili = 1927, ISBN = "111", Kategori = "Tarih", alindi = false, toplamOkunmaSayisi = 5 },

        new Kitap { Ad = "Suç ve Ceza", Yazar = "Dostoyevski", Yayinevi = "Can Yayınları", YayinYili = 1866, ISBN = "222", Kategori = "Klasik", alindi = true, oduncAlanKullaniciAdi = "mehmet01", AlinisTarihi = DateTime.Now.AddDays(-10), toplamOkunmaSayisi = 8 },

        new Kitap { Ad = "1984", Yazar = "George Orwell", Yayinevi = "Can Yayınları", YayinYili = 1949, ISBN = "333", Kategori = "Distopya", alindi = true, oduncAlanKullaniciAdi = "ayseroot", AlinisTarihi = DateTime.Now.AddDays(-2), toplamOkunmaSayisi = 12 },

        new Kitap { Ad = "Simyacı", Yazar = "Paulo Coelho", Yayinevi = "Can Yayınları", YayinYili = 1988, ISBN = "444", Kategori = "Felsefe", alindi = false, toplamOkunmaSayisi = 3 },

        new Kitap { Ad = "Sefiller", Yazar = "Victor Hugo", Yayinevi = "İş Bankası", YayinYili = 1862, ISBN = "555", Kategori = "Klasik", alindi = false},

        new Kitap{ Ad="Beyaz Zambaklar Ülkesinde", Yazar = "Grigory Petrov", Yayinevi = "Can Yayınları", YayinYili=1925, ISBN="666",Kategori="Sosyoloji", oduncAlanKullaniciAdi = "kadirroot",AlinisTarihi = DateTime.Now.AddDays(-8), toplamOkunmaSayisi = 15 }
        };

        public static List<Kitap> KitaplariGetir() => kitaplar;
    }
}