using kitap;
using kullaniciYonetim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KutuphaneOtomasyonu
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }
        string girisYapanKullaniciAdi, girisYapanKullaniciParola;
        private void button1_Click(object sender, EventArgs e)
        {
            List<ogrenci> kullanici_ogrenci = ogrenciVeri.ogrencileriGetir();
            List<yonetici> kullanici_yonetici = yoneticiVeri.yoneticileriGetir();
            string kullanici_girdi_adi = ad_mail.Text;
            string kullanici_girdi_parola = parola.Text;
            if (ogrenciButonGiris.Enabled == false)
            {
                ogrenci bulunan = null;

                for (int i = 0; i < kullanici_ogrenci.Count; i++)
                {
                    if ((kullanici_ogrenci[i].kullanici_adi == kullanici_girdi_adi
                        || kullanici_ogrenci[i].ogrenci_mail == kullanici_girdi_adi)
                        && kullanici_ogrenci[i].ogrenci_parola == kullanici_girdi_parola)
                    {
                        bulunan = kullanici_ogrenci[i];
                        loggined.aktifOgrenci = bulunan;
                        break;
                    }
                }
                if (bulunan != null)
                {
                    MessageBox.Show("Giriş Başarılı!");
                    anaMenu lo = new anaMenu();
                    lo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }
            if (yoneticiButonGiris.Enabled == false)
            {
                yonetici bulunanYonetici = null;

                for (int i = 0; i < kullanici_yonetici.Count; i++)
                {
                    if ((kullanici_yonetici[i].yonetici_kullanici_adi == kullanici_girdi_adi
                        || kullanici_yonetici[i].yonetici_mail == kullanici_girdi_adi)
                        && kullanici_yonetici[i].yonetici_parola == kullanici_girdi_parola)
                    {
                        bulunanYonetici = kullanici_yonetici[i];
                        loggined.aktifYonetici = bulunanYonetici;
                        break;
                    }
                }
                if (bulunanYonetici != null)
                {
                    girisYapanKullaniciAdi = kullanici_girdi_adi;
                    girisYapanKullaniciParola = kullanici_girdi_parola;
                    MessageBox.Show("Hoşgeldin Yönetici");
                    yoneticiMenu yoneticiAnaMenu = new yoneticiMenu();
                    yoneticiAnaMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                }
            }

        }
        string oldKullaniciLabel = "Kullanıcı Adı veya mail:";
        string oldParolaLabel = "Parola:";
        private void button3_Click(object sender, EventArgs e)
        {
            kullanici_label.Text = oldKullaniciLabel;
            parola_label.Text = oldParolaLabel;
            ogrenciButonGiris.Enabled = true;
            yoneticiButonGiris.Enabled = false;
            kullanici_label.Text = "Yönetici " + kullanici_label.Text;
            parola_label.Text = "Yönetici " + parola_label.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yöneticiniz ile görüşünüz");
        }

        private void ogrenciButonGiris_Click(object sender, EventArgs e)
        {
            kullanici_label.Text = oldKullaniciLabel;
            parola_label.Text = oldParolaLabel;
            ogrenciButonGiris.Enabled = false;
            yoneticiButonGiris.Enabled = true;
            kullanici_label.Text = "Öğrenci " + kullanici_label.Text;
            parola_label.Text = "Öğrenci " + parola_label.Text;
        }
    }
}
