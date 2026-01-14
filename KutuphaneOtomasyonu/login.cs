using System.Collections.Generic;

namespace kullaniciYonetim
{

    public class ogrenci
    {
        public int ogrenci_no { get; set; }
        public string ogrenci_isim { get; set; }
        public string ogrenci_soyisim { get; set; }
        public string kullanici_adi { get; set; }
        public string ogrenci_parola { get; set; }
        public string ogrenci_mail { get; set; }
        public long ogrenci_tel { get; set; }
        public int ToplamOkunanKitapSayisi { get; set; } = 0;
    }

    public static class ogrenciVeri
    {
        public static List<ogrenci> mevcutOgrenciler = new List<ogrenci>
              {

                new ogrenci { ogrenci_no = 1, ogrenci_isim = "Kadir", ogrenci_soyisim = "kadirdir", kullanici_adi = "kadirroot", ogrenci_parola = "sudormrf", ogrenci_mail = "kadircik@gmail.com", ogrenci_tel = 012345678910,ToplamOkunanKitapSayisi=100 },
                new ogrenci { ogrenci_no = 2, ogrenci_isim = "musa", ogrenci_soyisim = "musaoğlu", kullanici_adi = "musaroot", ogrenci_parola = "musasifre", ogrenci_mail = "musacık@gmail.com", ogrenci_tel = 012345678910 },
                new ogrenci { ogrenci_no = 3, ogrenci_isim = "yuşa", ogrenci_soyisim = "yuşadır", kullanici_adi = "yuşaroot", ogrenci_parola = "yusasifre", ogrenci_mail = "yuşacık@gmail.com", ogrenci_tel = 012345678910 },
                new ogrenci { ogrenci_no = 4, ogrenci_isim = "kerem", ogrenci_soyisim = "keremdir", kullanici_adi = "keremroot", ogrenci_parola = "keremsifre", ogrenci_mail = "keremcik@gmail.com", ogrenci_tel = 012345678910 },
                new ogrenci { ogrenci_no = 5, ogrenci_isim = "anıl", ogrenci_soyisim = "anılcık", kullanici_adi = "anılroot", ogrenci_parola = "anilsire", ogrenci_mail = "anılcık@gmail.com", ogrenci_tel = 012345678910 },
                new ogrenci { ogrenci_no = 101, ogrenci_isim = "Ali", ogrenci_soyisim = "Yılmaz", kullanici_adi = "aliroot", ogrenci_parola = "alisifre", ogrenci_mail = "ali@mail.com", ogrenci_tel = 5551112233, ToplamOkunanKitapSayisi = 15 },
                new ogrenci { ogrenci_no = 102, ogrenci_isim = "Ayşe", ogrenci_soyisim = "Demir", kullanici_adi = "ayseroot", ogrenci_parola = "aysesifre", ogrenci_mail = "ayse@mail.com", ogrenci_tel = 5554445566, ToplamOkunanKitapSayisi = 28 },
                new ogrenci { ogrenci_no = 103, ogrenci_isim = "Can", ogrenci_soyisim = "Kaya", kullanici_adi = "canroot", ogrenci_parola = "cansifre", ogrenci_mail = "can@mail.com", ogrenci_tel = 5557778899, ToplamOkunanKitapSayisi = 10 },
                new ogrenci { ogrenci_no = 104, ogrenci_isim = "Zeynep", ogrenci_soyisim = "Bulut", kullanici_adi = "zeyneproot", ogrenci_parola = "zeynepsifre", ogrenci_mail = "zeynep@mail.com", ogrenci_tel = 5550001122, ToplamOkunanKitapSayisi = 22 },
                new ogrenci { ogrenci_no = 105, ogrenci_isim = "Murat", ogrenci_soyisim = "Yıldız", kullanici_adi = "muratroot", ogrenci_parola = "muratsifre", ogrenci_mail = "murat@mail.com", ogrenci_tel = 5553334455, ToplamOkunanKitapSayisi = 5 }
        };
        public static List<ogrenci> ogrencileriGetir()
        {
            return mevcutOgrenciler;
        }
        public static void ogrenciEkle(ogrenci yeniOgrenci)
        {
            mevcutOgrenciler.Add(yeniOgrenci);
        }
    }
    public class yonetici
    {
        public int yonetici_id { get; set; }
        public string yonetici_kullanici_adi { get; set; }
        public string yonetici_isim { get; set; }
        public string yonetici_soyisim { get; set; }
        public string yonetici_parola { get; set; }
        public string yonetici_mail { get; set; }
        public long yonetici_tel { get; set; }
    };

    public static class yoneticiVeri
    {
        public static List<yonetici> yoneticileriGetir()
        {
            return new List<yonetici>
            {
            new yonetici {yonetici_id=1,yonetici_kullanici_adi="ahmethoca",yonetici_isim="Ahmet",yonetici_soyisim="Demir",yonetici_parola="ahmetsifre",yonetici_mail="ahmetahmet@gmail.com",yonetici_tel=05559990011},
            };
        }
    }
}