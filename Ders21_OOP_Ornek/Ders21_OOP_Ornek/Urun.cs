using static Ders21_OOP_Ornek.Enumlar;

namespace Ders21_OOP_Ornek
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public UrunKategorileri UrunKategorisi { get; set; }
    }
}
