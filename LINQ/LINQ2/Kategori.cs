namespace LINQ2
{
    class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }

        public override string ToString()
        {
            return KategoriID + " " + KategoriAdi;
        }
    }
}
