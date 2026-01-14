using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kullaniciYonetim;
namespace KutuphaneOtomasyonu
{
    public partial class createAccount : Form
    {
        public createAccount()
        {
            InitializeComponent();
        }

        private void hesapOlustur_Click(object sender, EventArgs e)
        {
            ogrenci yeniOgrenci = new ogrenci()
            {
                ogrenci_no = int.Parse(yeniOgrenciNo.Text),
                ogrenci_isim = yeniOgrenciİsim.Text,
                ogrenci_soyisim = yeniOgrenciSoyisim.Text,
                kullanici_adi = yeniOgrenciUsername.Text,
                ogrenci_parola = yeniOgrenciParola.Text,
                ogrenci_mail = yeniOgrenciMail.Text,
                ogrenci_tel = long.Parse(yeniOgrenciTel.Text)
            };

            ogrenciVeri.mevcutOgrenciler.Add(yeniOgrenci);
            MessageBox.Show("Öğrenci başarıyla eklendi!");
        }
    }
}
