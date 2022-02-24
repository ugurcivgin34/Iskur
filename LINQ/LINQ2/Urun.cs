namespace LINQ2
{
    public class Urun
    {
        public int UrunID { get; set; }
        public int KategoriId { get; set; }
        public string UrunAdi { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;
        }

    }
}
