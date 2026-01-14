using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kitap;


namespace KutuphaneOtomasyonu
{

    public partial class anaMenu : Form
    {
        List<Kitap> kitaplar;
        public anaMenu()
        {
            InitializeComponent();
            kitaplar = VeriDeposu.KitaplariGetir();

            foreach (var kitap in kitaplar)
            {
                // Nesne oluştur kitap ismine göre
                ListViewItem isimKitap = new ListViewItem(kitap.Ad);

                // Diğer sütunlara (SubItems) ile ekleme 
                isimKitap.SubItems.Add(kitap.Yazar);
                isimKitap.SubItems.Add(kitap.Yayinevi);
                isimKitap.SubItems.Add(kitap.YayinYili.ToString());
                isimKitap.SubItems.Add(kitap.ISBN);
                isimKitap.SubItems.Add(kitap.Kategori);

                listViewKitaplar.Items.Add(isimKitap);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ListViewItem seciliKitap;
        //listeye 2 kez çift tıklamanız gerekiyor kitabı seçip saklaması için
        private void ciftClick(object sender, MouseEventArgs e)
        {
            if (listViewKitaplar.SelectedItems.Count == 0)
            {
                return;
            }
            seciliKitap = listViewKitaplar.SelectedItems[0];
        }

        Kitap bulunanKitap = null;
        private void kitapAl_Click(object sender, EventArgs e)
        {
            //secim 
            if (seciliKitap == null) { 
                MessageBox.Show("Lütfen kitap seçin."); 
                return; 
            }

            //kitabı bul (ISBN benzersiz)
            string secilenISBN = seciliKitap.SubItems[4].Text;


            if (bulunanKitap != null)
            {
                if (bulunanKitap.alindi)
                {
                    //kitap alınmışsa uyarısı
                    MessageBox.Show($"Bu kitap şu anda kütüphanede değil.");
                }
                else
                {
                    bulunanKitap.alindi = true;
                    bulunanKitap.oduncAlanKullaniciAdi = loggined.aktifOgrenci.kullanici_adi;

                    // 2 haftalık süreyi başlatmak için now kullanarak bugün tarihi alma
                    bulunanKitap.AlinisTarihi = DateTime.Now;

                    //istatistikleri güncelle
                    bulunanKitap.toplamOkunmaSayisi++;
                    loggined.aktifOgrenci.ToplamOkunanKitapSayisi++;

                    MessageBox.Show($"{bulunanKitap.Ad} başarıyla alındı! \n14 gün içinde iade etmelisiniz.");
                }
            }
        }

        private void kitapTeslim_Click(object sender, EventArgs e)
        {
            //seçim kontrolü
            if (seciliKitap == null)
            {
                MessageBox.Show("Lütfen iade etmek istediğiniz kitabı listeden seçin!");
                return;
            }

            //isbn ile kitabı bul
            string secilenISBN = seciliKitap.SubItems[4].Text;

            for (int i = 0; i < kitaplar.Count; i++)
            {
                if (kitaplar[i].ISBN == secilenISBN)
                {
                    bulunanKitap = kitaplar[i];
                    break;
                }
            }

            if (bulunanKitap != null)
            {
                //kitap zaten kütüphanede mi sorgusu
                if (bulunanKitap.alindi == false)
                {
                    MessageBox.Show("Bu kitap zaten kütüphanede, iade edilemez.");
                    return;
                }

                //kitabı iade etmeye çalışan kişi kitabı alan kişi sorgusu
                if (bulunanKitap.oduncAlanKullaniciAdi != loggined.aktifOgrenci.kullanici_adi)
                {
                    MessageBox.Show("Bu kitabı siz almadınız, dolayısıyla iade edemezsiniz!");
                    return;
                }

                //iade işlem
                bulunanKitap.alindi = false;
                //boşa çıkar
                bulunanKitap.oduncAlanKullaniciAdi = "";

                MessageBox.Show("Kitap başarıyla iade edildi.");
            }
        }
    }
}
