using System.Collections.Generic;

namespace Ders21_OOP_Ornek
{
    public class UrunSepeti
    {
        public int SepetId { get; set; }
        public int MusteriId { get; set; }
        public List<Urun> UrunlerListesi = new List<Urun>();
    }
}
