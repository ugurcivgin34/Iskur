using System;

namespace Ders15_Metot_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Topla(1,2,3));
            //Console.ReadLine();

            //PuanTopla : (isim,yaş,puanlar)
            //string = isim + ToplamPuan

            //Console.WriteLine(PuanTopla("Ahmet", 44, 70, 80, 90));

            //Rekürsif metodlar, kendini çağıran metotlar
            //Console.WriteLine(Faktoriyel(5));


            //Refereans tipi parametreler
            //ref kullanırken paramaetrenin ilk değerini vermek zorundayız
            int s1 ;
            int s2 = 7;
            //DegerDegistir(ref s1, s2);
          
            //Console.WriteLine("s1: " + s1);
            //Console.WriteLine("s2: " + s2);
            int s3 = DegerDegistir2(out s1);
            Console.WriteLine("s1 " + s1);
            Console.WriteLine("s3 " +s3);
            
        } // Main sonu

        static int DegerDegistir2(out int sayi)
        {
            sayi = 77;
            return 20;
        }


        static void DegerDegistir(ref int s1, int s2)
        {
            s1 = s1 * 10;
            s2 = s2 * 100;
        }

        static int Faktoriyel(int sayi)
        {
            if (sayi <= 1)
                return 1;
            else
                return sayi * Faktoriyel(sayi - 1);


        }

        static string PuanTopla(string isim, int yas, params int[] puanlar)
        {
            int toplamPuan = 0;
            foreach (var puan in puanlar)
            {
                toplamPuan += puan;

            }
            return isim + " " + yas + " " + toplamPuan;
        }
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
    }
}
