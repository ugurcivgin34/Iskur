using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders21_WindowsForms_OOP
{
    /*
    Ogrenci sınıfını aşağıdaki özellik ve metotları tanımlayınız
   Properties: TcKimlikNo, OkulNo, Ad, Soyad, SinifOgretmeni
   Methods: SinifOgretmeniDegistir(string ogretmen)
   Methods: BilgiYaz(), ogrencinin tüm bilgilerini ekrana yazılsın.
   Methods: Parametreli yapıcı metot ekleyin.
    */

    /* Access Modifiers; Erişim Belirleyici
     * 1-Private: Özel anlamındadır. Sadece bulunduğu yapı
     * içinden erişilebilir. Başka yerden erişilemez.
     * 2-Internal: Bulunduğu proje içinde her yerden 
     * erişimi sağlar. Farklı projeden reişime izin vermez.
     * 3-Protected: Miras alınan sınıflar içerisinden 
     * erişime izin verir. 
     * 4-Protected Internal: Hem Miras alınan sınıflar 
     * içerisinden hem de bulunduğu proje içinde her yerden 
     * erişime izin verir. 
     * 5-Public: Umumi, kamu malıdır. Her yerden erişime
     * izin verir.
     
     */
    class Ogrenci
    {
        public long TcKimlikNo;
        public string OkulNo;
        public string Ad;
        public string Soyad;
        //public string SinifOgretmeni;
        public Ogretmen SinifOgretmeni;
        public Ogrenci()
        {

        }


        public Ogrenci(long tcKimlikNo, string okulNo,
            string ad, string soyad, Ogretmen sinifOgretmeni)
        {
            TcKimlikNo = tcKimlikNo;
            OkulNo = okulNo;
            Ad = ad;
            Soyad = soyad;
            SinifOgretmeni = sinifOgretmeni;
        }

        public void BilgiYaz(ListBox listBox1)
        {
            MessageBox.Show("TCKN:" + TcKimlikNo.ToString());
            listBox1.Items.Add("TCKN:" + TcKimlikNo.ToString());
            MessageBox.Show("Okul No:" + OkulNo);
            listBox1.Items.Add("Okul No:" + OkulNo);
            MessageBox.Show("Ad:" + Ad);
            listBox1.Items.Add("Ad:" + Ad);
            MessageBox.Show("Soyad:" + Soyad);
            listBox1.Items.Add("Soyad:" + Soyad);
            MessageBox.Show("Sınıf Öğretmeni:" + SinifOgretmeni.Ad + " " + SinifOgretmeni.Soyad);
            listBox1.Items.Add("Sınıf Öğretmeni:" + SinifOgretmeni.Ad + " " + SinifOgretmeni.Soyad);
            //listBox1.Items.Add("Adı Soyadı TCKN:" + Ad + " " 
            //    + Soyad + " " + TcKimlikNo);
        }

        public void SinifOgretmeniDegistir(Ogretmen ogretmen)
        {
            SinifOgretmeni = ogretmen;
        }

    }
}
