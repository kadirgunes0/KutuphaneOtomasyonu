using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KutuphaneOtomasyonu;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class yoneticiMenu : Form
    {
        public void KitapGrafiginiGuncelle()
        {
            // chart2 isminin doğru olduğundan emin ol (tasarım ekranından bakabilirsin)
            chart2.Series.Clear(); //önce serileri temizle
            var seri = chart2.Series.Add("KitapOkunma");
            seri.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut; // Simit grafik

            //sadece en az 1 kez okunmuş kitapları grafiğe ekle
            var okunanKitaplar = kitap.VeriDeposu.KitaplariGetir().Where(k => k.toplamOkunmaSayisi > 0).ToList();

            foreach (var k in okunanKitaplar)
            {
                seri.Points.AddXY(k.Ad, k.toplamOkunmaSayisi);
            }
        }
        public void GrafigiGuncelle()
        {
            //önce tüm serileri temizle (Hata almanı engeller)
            chart1.Series.Clear();

            //yeni bir seri oluştur
            var seri = chart1.Series.Add("Okuma");

            //grafik türünü set et
            seri.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

            foreach (var ogr in kullaniciYonetim.ogrenciVeri.mevcutOgrenciler)
            {
                // X: İsim, Y: Sayı
                seri.Points.AddXY(ogr.ogrenci_isim, ogr.ToplamOkunanKitapSayisi);
            }
        }
        public void OgrenciEmanetListele()
        {
            lvOgrenciler.Items.Clear();
            lvOgrenciler.FullRowSelect = true;

            //önce tüö öğrencileri çağırıyoruz
            foreach (var ogr in kullaniciYonetim.ogrenciVeri.mevcutOgrenciler)
            {
                //ad soyad satırı için
                ListViewItem satir = new ListViewItem(ogr.ogrenci_isim + " " + ogr.ogrenci_soyisim);

                //öğrencilerde kitap kontrolü
                var elindekiKitap = kitap.VeriDeposu.KitaplariGetir()
                                    .FirstOrDefault(k => k.alindi == true && k.oduncAlanKullaniciAdi == ogr.kullanici_adi);

                if (elindekiKitap != null)
                {
                    //kitap alınmışsa
                    satir.SubItems.Add(elindekiKitap.Ad); // 2. Kolon: Kitap Adı

                    //süre ve ceza Hesaplama
                    DateTime teslimTarihi = elindekiKitap.AlinisTarihi.AddDays(14);
                    TimeSpan kalanZaman = teslimTarihi - DateTime.Now;

                    if (DateTime.Now > teslimTarihi)
                    {
                        satir.SubItems.Add("GECİKTİ! (Ceza)"); //column: Süre
                        satir.BackColor = Color.Red;
                        satir.ForeColor = Color.White;
                    }
                    else
                    {
                        satir.SubItems.Add($"{kalanZaman.Days} gün kaldı");
                    }
                }
                else
                {
                    satir.SubItems.Add("-"); //2.Column: Kitap yok
                    satir.SubItems.Add("Kitap Yok"); // 3.Column: Süre bilgisi yok
                    satir.ForeColor = Color.Black; // normal renk
                }

                //silme işlemi için Tag'e öğrenci numarasını ekle
                satir.Tag = ogr.ogrenci_no;
                lvOgrenciler.Items.Add(satir);
            }
        }
        public yoneticiMenu()
        {
            InitializeComponent();
            // ... silme onayından sonraki D - Arayüzü Güncelle kısmı ...
            OgrenciEmanetListele(); // ListView'ı yeniler
            GrafigiGuncelle();      // Öğrenci bazlı pasta grafiğini yeniler
            KitapGrafiginiGuncelle(); // Kitap bazlı simit grafiğini yeniler (BUNU EKLE)
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            //ListView dan bir seçim yapılmış mı kontrol et
            if (lvOgrenciler.SelectedItems.Count > 0)
            {
                ListViewItem seciliSatir = lvOgrenciler.SelectedItems[0];

                //tag özelliğine sakladığımız öğrenci numarasını çekiyoruz
                int silinecekNo = (int)seciliSatir.Tag;
                string adSoyad = seciliSatir.Text;

                //kullanıcıdan onay al
                DialogResult onay = MessageBox.Show($"{adSoyad} isimli öğrenci silinecektir. Emin misiniz?",
                    "Kritik Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (onay == DialogResult.Yes)
                {
                    //öğrenciyi bul
                    var silinecekOgrenci = kullaniciYonetim.ogrenciVeri.mevcutOgrenciler
                                           .FirstOrDefault(x => x.ogrenci_no == silinecekNo);

                    if (silinecekOgrenci != null)
                    {
                        //öğrencinin elindeki kitapları kütüphaneye iade et
                        //verideposu'ndaki tüm kitapları ara
                        foreach (var k in kitap.VeriDeposu.KitaplariGetir())
                        {
                            if (k.oduncAlanKullaniciAdi == silinecekOgrenci.kullanici_adi)
                            {
                                k.alindi = false;
                                k.oduncAlanKullaniciAdi = "";
                            }
                        }

                        //ana listeden öğrenciyi tamamen sil
                        kullaniciYonetim.ogrenciVeri.mevcutOgrenciler.Remove(silinecekOgrenci);

                        //arayüzü Güncelle
                        OgrenciEmanetListele();
                        GrafigiGuncelle();

                        MessageBox.Show("Öğrenci sistemden silindi ve kitapları iade alındı.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen listeden silmek istediğiniz bir öğrenciyi seçin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            createAccount ekleForm = new createAccount();
            ekleForm.ShowDialog(); //formu açar

            //form kapandıktan sonra listeyi yenilemek için:
            OgrenciEmanetListele();
            GrafigiGuncelle();
        }
    }
}
