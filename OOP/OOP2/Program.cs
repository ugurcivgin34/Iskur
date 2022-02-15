using System;

namespace OOP2
{
    class Program
    {
        static void MetodA(int sayi)
        {
            Console.WriteLine("Metod içi (atamadan önce) " + sayi);
            sayi = 999;
            Console.WriteLine("Metod içi (atamadan sonra) " + sayi);
        }
        public static void Yazdir(int[] sayilar)
        {
            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi + " ");

            }
            Console.WriteLine();
        }
        static void MetodB(int[] sayilar)
        {
            Console.WriteLine("MetodB içi (atamadan önce) ");
            Yazdir(sayilar);
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = -555;
            }
            Console.WriteLine("MetodB içi (atamadan sonra) ");
            Yazdir(sayilar);
        }
        static void Main(string[] args)
        {
            //int number = 1;
            //MetodA(50);
            //Console.WriteLine("Metod çağrıldıktan sonra "+ number);

            //int[] numbers = { 2, 2, 2, 2, 2, 2 };
            //MetodB(numbers);
            //Console.WriteLine("MetodB çağrıldıktan sonra " );
            //Yazdir(numbers);


            //4-ctor (yapıcı , inşaa edici metodlar)
            //5-destructure (yıkıcı metod)

            Personel p = new Personel();
            p.PersonelID = 1;
            p.PerAdi = "Uğur";
            p.Maas = 123;

            Personel p2 = new Personel(12, "Okan", 123);
            //Musteri m = new Musteri { MusID = 23, MusAdi = "Uğur", Cari = 123 }; //.object inisilation
            //Arac arac = new Arac("12sa12");
        }

        class Arac
        {
            public string Plaka { get; set; }

            public Arac(string plaka)
            {
                Plaka = plaka;
            }
        }

        class Musteri
        {

            public int MusID { get; set; }
            public string MusAdi { get; set; }
            public decimal Cari { get; set; }
        }

        class Personel
        {

            public int PersonelID { get; set; }
            public string PerAdi { get; set; }
            public decimal Maas { get; set; }

            public Personel(int id, string ad, decimal maas)
            {
                PersonelID = id;
                PerAdi = ad;
                Maas = maas;
                Console.WriteLine(" asdasd ");
            }
            public Personel()
            {
                Console.WriteLine("Yapıcı metod çalıştı");
            }

        }
    }
}
