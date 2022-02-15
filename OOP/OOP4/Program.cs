using System;

namespace OOP4
{

    class Musteri
    {
        //COnstructor arası veri alışverişleri
        public int MusID { get; set; }
        public string MusAdi { get; set; }
        public string Adres { get; set; }

        public Musteri(string ad , string adres):this(1,ad,adres)
        {
           
        }
        public Musteri(int id , string ad , string adres)
        {
            MusID = id;
            MusAdi = ad;
            Adres = adres;
            
        }
    }

    class Deneme
    {
        const double pi = 3.14; //tanımlanan yerde değişebilir
        readonly double katsayi = 1.5;
        public Deneme()
        {
            //pi = 2.5;
            katsayi = 1.1;
        }

        public void Islem()
        {
          
            katsayi = 5.6;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //6-readonly
            
            //7-const
        }
    }
}
