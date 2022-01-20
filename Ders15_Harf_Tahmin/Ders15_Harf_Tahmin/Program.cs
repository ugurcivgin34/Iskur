using System;
using System.Collections.Generic;

namespace Ders15_Harf_Tahmin
{
    class Program
    {
        static void Main(string[] args)
        {
            //harf tahmin oyunu
            Random rnd = new Random();
            int rastgele = rnd.Next(65, 91);
            string rastgeleString = Char.ConvertFromUtf32(rastgele); //Harfe çevirmek için çevirdik asci den çevirdik yani.ASci kodu karşılığı hangi harf ise onu döndürür
            Console.WriteLine(rastgeleString);

            List<string> tahminler = new List<string>();
            bool tutturdu = false ;

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Tahmin : ");
                string tahmin = Console.ReadLine();
                tahmin = tahmin.ToUpper();
                int c = String.Compare(tahmin, rastgeleString, true);
                if (c == 0)
                {
                    Console.WriteLine("Tabrikler, " + i + " . tahminde bildi niz");
                    tutturdu = true;
                    break;
                }
                else if (c == -1)
                {
                    Console.WriteLine("Küçük oldu");
                    tahminler.Add(tahmin);
                }
                else
                {
                    Console.WriteLine("Büyük oldu");
                    tahminler.Add(tahmin);
                }
            }

            if (!tutturdu)
            {
                Console.WriteLine("Kaybettiniz . Tahmin ettiğiniz harflar : ");
                foreach (var item in tahminler)
                {
                    Console.Write(item + " ");
                }
            }

            Console.ReadLine();

        }
    }
}
