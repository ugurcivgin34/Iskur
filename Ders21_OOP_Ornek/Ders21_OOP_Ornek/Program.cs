using System;
using static Ders21_OOP_Ornek.Enumlar;

namespace Ders21_OOP_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Urun u1 = new Urun()
                {
                    UrunAdi = "Ekmek",
                    UrunId = 1000,
                    UrunKategorisi = UrunKategorileri.Gıda
                };
                Urun u2 = new Urun()
                {
                    UrunAdi = "Şarj Aleti",
                    UrunId = 1001,
                    UrunKategorisi = UrunKategorileri.Elektronik
                };

                Urun u3 = new Urun()
                {
                    UrunAdi = "Şampuan",
                    UrunId = 1002,
                    UrunKategorisi = UrunKategorileri.Temizlik
                };
                Urun u4 = new Urun()
                {
                    UrunAdi = "Süt",
                    UrunId = 1003,
                    UrunKategorisi = UrunKategorileri.Gıda
                };
                Musteri m = new Musteri()
                {  // Auto Property:
                    MusteriID = 1,
                    Cinsiyet = Cinsiyetler.Erkek,
                    DogumTarihi = new DateTime(1969, 2, 1),
                    MusteriAdi = "Veysel",
                    MusteriSoyadi = "Perü"
                };
                UrunSepeti musterininSepeti = new UrunSepeti()
                {
                    MusteriId = m.MusteriID,
                    SepetId = 1

                };
                musterininSepeti.UrunlerListesi.Add(u1);
                musterininSepeti.UrunlerListesi.Add(u2);
                musterininSepeti.UrunlerListesi.Add(u3);
                musterininSepeti.UrunlerListesi.Add(u4);

                //Önce sepeti ve sepete eklenecek ürünleri yukarıda aldık , sonra bu sepeti müşteriye atadık.
                m.MüsterininUrunSepeti = musterininSepeti;

                m.MusteriBilgilerYazdir();
                m.MusterininSepetiniYazdir();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}

