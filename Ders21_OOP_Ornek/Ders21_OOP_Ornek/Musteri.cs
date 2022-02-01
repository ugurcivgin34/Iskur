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

        public void MusteriBilgilerYazdir()
        {
            Console.WriteLine("Müşteri Id:" + MusteriID + "-" +
                MusteriAdi + " " + MusteriSoyadi);
        }
        public bool MusterininDogumGunumu()
        {
            bool kontrol = false;
            if (DogumTarihi.Day == DateTime.Now.Day && DogumTarihi.Month == DateTime.Now.Month)
            {
                kontrol = true;
            }
            return kontrol;
        }
        public void MusterininSepetiniYazdir()
        {
            if (MusterininDogumGunumu())
            {
                MüsterininUrunSepeti.DogumGunuHediyesiEkle();
                Console.WriteLine("Doğum gününüz kutlu olsun.Gofret hediyeniz sepete eklendi");
            }
            int sayac = 1;
            foreach (var item in MüsterininUrunSepeti.UrunlerListesi)
            {
                Console.WriteLine(sayac + " . ürününüz:" + item.UrunAdi);
                sayac++;
            }
        }





    }
}
