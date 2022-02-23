using System;
using System.Collections.Generic;

namespace Deleges2
{
    class Program
    {

        delegate void Temsilci();

        static bool TekSayiMi(int sayi)
        {
            return sayi % 2 == 0;
        }
        static void Yaz(List<int> sayilar)
        {
            Console.WriteLine();
            foreach (int s in sayilar)
            {
                Console.Write(s + " ");
            }

        }

        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>() { 2, 4, 6, 7, 9, 1, 50, 3 };


            //Klasik Yöntem
            for (int i = 0; i < sayilar.Count; i++)
            {
                if (sayilar[i] % 2 == 1)
                {
                    Console.Write(sayilar[i] + " ");
                }
            }

            //1.Yöntem
            Predicate<int> p = new Predicate<int>(TekSayiMi);
            //metodlara delege de gidiyor
            Yaz(sayilar.FindAll(p));
            //2.Yöntem
            Yaz(sayilar.FindAll(TekSayiMi)); //TekSayimi Predicate delegesine uygun yapıda olduğu için direk bu şekilde de göndebiliyoruz

            //Anonim Metodlar
            Temsilci t = delegate ()
            {
                Console.WriteLine("Anonim Metod...");
            };

            t();

            //3. Yöntem
            Yaz(sayilar.FindAll(delegate (int s)
            {
                return s % 2 == 1;
            }));



            //4. Yöntem
            Yaz(sayilar.FindAll(s => s % 2 == 1));            
               

        }
    }
}
