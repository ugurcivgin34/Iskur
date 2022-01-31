using System;
using static Ders21_OOP_Ornek.Enumlar;

namespace Ders21_OOP_Ornek
{
    class Musteri
    {
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyetler Cinsiyet { get; set; }
        public UrunSepeti MüsterininUrunSepeti { get; set; }

        public void MusteriBilgilerYazdir ()
        {
            Console.WriteLine("Müşteri Id:" + MusteriID + "-" +
                MusteriAdi + " " + MusteriSoyadi);
        }

        public void MusterininSepetiniYazdir()
        {
            int sayac = 1;
            foreach (var item in MüsterininUrunSepeti.UrunlerListesi)
            {
                Console.WriteLine(sayac + " . ürününüz:" + item.UrunAdi);
                sayac++;
            }
        }




    }
}
