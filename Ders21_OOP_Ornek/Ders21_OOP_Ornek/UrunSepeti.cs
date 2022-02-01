using System.Collections.Generic;
using static Ders21_OOP_Ornek.Enumlar;

namespace Ders21_OOP_Ornek
{
    public class UrunSepeti
    {
        public int SepetId { get; set; }
        public int MusteriId { get; set; }

        public List<Urun> UrunlerListesi = new List<Urun>();

        public void DogumGunuHediyesiEkle()
        {
            Urun hediye = new Urun()
            {
                UrunAdi = "Gofret",
                UrunId = 300,
                UrunKategorisi = UrunKategorileri.Gıda


            };

            UrunlerListesi.Add(hediye);
        }
    }
}
