using System;

namespace OOP4
{

    class Musteri
    {
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
