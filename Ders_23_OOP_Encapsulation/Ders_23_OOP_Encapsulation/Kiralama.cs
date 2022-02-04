using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_23_OOP_Encapsulation
{
    public class Kiralama
    {
        public int Id { get; set; }
        public Bisiklet Bisiklet { get; set; }
        public Kullanici Kullanici { get; set; }
        public float Sure { get; set; }
        public float Ucret { get; set; }
        public DateTime BaslamaZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public float SaniyeUcreti { get; set; }
        public Kiralama()
        {
            SaniyeUcreti = 0.25f;
        }

        public void Baslat()
        {
            BaslamaZamani = DateTime.Now;

        }
        public void Bitir()
        {
            BitisZamani = DateTime.Now;
            UcretHesapla();

        }

        public void UcretHesapla()
        {
            TimeSpan zamanFarki = BitisZamani - BaslamaZamani;
            //int farkSaniye = zamanFarki.Seconds;
             int farkSaniye = zamanFarki.Hours * 3600 + zamanFarki.Minutes * 60 + zamanFarki.Seconds;
            Console.WriteLine("Fark:" + farkSaniye);
            Sure = (float)farkSaniye;
            Ucret = Sure * SaniyeUcreti;
            BilgiYaz();
        }

        public void BilgiYaz()
        {
            Console.WriteLine("Sayin " + Kullanici.AdSoyad + "\n"
                + "Başlama Zamanı: " + BaslamaZamani + "\n"
                + "Bitiş Zamanı: " + BitisZamani + "\n"
                + "Toplam Süre: " + Sure + "\n"
                + "Toplam Ödemeniz Gereken Tutar: " + Ucret + "'dir" + "\n"
                + "Marka " + Bisiklet.Marka + "\n"
                +""
                ) ;
        }
    }
}
