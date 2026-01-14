using System;
using System.Collections.Generic;

namespace kullaniciYonetim { 

	public static class ogrenci
	{
		public int ogrenci_no {  get; set; }
		public string ogrenci_isim { get; set; }
        public string ogrenci_soyisim { get; set; }
        public string kullanici_adi {  get; set; }
		public string ogrenci_parola { get; set; }
		public string ogrenci_mail { get; set; }
		public int ogrenci_tel {  get; set; }
	}

	public static class ogrenciVeri
	{
		public static List<ogrenci> ogrencileriGetir()
		{
			return new List<ogrenci>
			{
                new ogrenci {ogrenci_no = 10,ogrenci_isim="kadir",ogrenci_soyisim="güneş",kullanici_adi = "BOT_XAVIER",ogrenci_parola="yok",mail="botxavier@gmail.com",tel=05519482610}
                new ogrenci {ogrenci_no = 10,ogrenci_isim="yusuf",ogrenci_soyisim="yüksel",kullanici_adi = "BOT_CECIL",ogrenci_parola="var",mail="botcecil@gmail.com",tel=012345678910}
                new ogrenci {ogrenci_no = 10,ogrenci_isim="ömer",ogrenci_soyisim="yüksel",kullanici_adi = "BOT_MUHLIK",ogrenci_parola="yok",mail="botmuhlik@gmail.com",tel=05367864150}
                new ogrenci {ogrenci_no = 10,ogrenci_isim="kemer(kerem)",ogrenci_soyisim="acar",kullanici_adi = "BOT_PHOENIX",ogrenci_parola="var",mail="botphoenix@gmail.com",tel=05515527134}
                new ogrenci {ogrenci_no = 10,ogrenci_isim="ömer",ogrenci_soyisim="yüksel",kullanici_adi = "BOT_ZIBIL",ogrenci_parola="yok",mail="botzibil@gmail.com",tel=05367864150}
            }
		}
	}
    public static class yonetici
    {
        public int yonetici_id { get; set; }
        public int yonetici_isim { get; set; }
        public string yonetici_soyisim { get; set; }
        public string yonetici_parola { get; set; }
        public string yonetici_mail { get; set; }
        public int yonetici_tel { get; set; }
    }
    public static List<yonetici> yoneticileriGetir()
        {
            new yonetici { }
        }
}