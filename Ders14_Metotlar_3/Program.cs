using System;
using System.Collections.Generic;

namespace Ders14_Metotlar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sayı tahmin oyunu:1' dej 1000 ' e kadar bir sayı tutsun.10 tahmin yaptırsın , küçük ise küçük oldu , büyük ise
            //büyük oldu desin. Tutturursa "tebrikler tutturdunuz" desin.
            //Tahminleriniz 12 76 233 456 878 .... yazsın.
            //List<int> sayilar = new List<int>();
            //Random rastgele = new Random();
            //int sayi = rastgele.Next(1, 1001);
            //Console.WriteLine(sayi);
            //int tahminSayi = 0;
            //bool tutturdu = false;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Sayı giriniz : ");
            //    int.TryParse(Console.ReadLine(), out tahminSayi);

            //    sayilar.Add(tahminSayi);
            //    if(tahminSayi<sayi)
            //    {
            //        Console.WriteLine("Küçük oldu");

            //    }
            //    if (tahminSayi>sayi)
            //    {
            //        Console.WriteLine("Büyük oldu");
            //    }
            //    if(tahminSayi==sayi)
            //    {
            //        Console.WriteLine("Tebrikler kazandınız.");
            //        tutturdu = true;
            //        break;
            //    }
            //}

            //if(!tutturdu)
            //{
            //    Console.WriteLine("Malesef bilemediniz :");
            //    Console.WriteLine("TAhmin ettiğiniz sayılar :");
            //    foreach (var item in sayilar)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}

            //-----------------------------------------------------------------------------------------------------------------------

            // 1-20 arasında rastgele 10'ar sayı üretip iki listeye atan ve daha sonra 
            // iki listede ortak olmayanları başka bir listeye atarak ekrana 
            // yazdıran program:
            // Örnek
            // Liste1 = 1 2 3 4 5 8 12 3 4 9
            // Liste2 = 2 3 11 13 15 8 5 6 7 9
            // Liste3 = 1 4 12 4 11 13 15 6 7
            // 
            //List<int> liste1 = new List<int>();
            //List<int> liste2 = new List<int>();
            //List<int> liste3 = new List<int>();
            //Random rand = new Random();
            //Console.Write("Liste1=");
            //for (int i = 1; i <= 10; i++)
            //{
            //    int sayi = rand.Next(1, 21);
            //    liste1.Add(sayi);
            //    Console.Write(sayi + " ");
            //}
            //Console.WriteLine();
            //Console.Write("Liste2=");
            //for (int i = 1; i <= 10; i++)
            //{
            //    int sayi = rand.Next(1, 21);
            //    liste2.Add(sayi);
            //    Console.Write(sayi + " ");
            //}
            //Console.WriteLine();

            //foreach (var item in liste1)
            //{
            //    if (liste2.Contains(item) == false)
            //        if (liste3.Contains(item) == false)  // Duplike olmasın diye. 
            //            liste3.Add(item);
            //}
            //foreach (var item in liste2)
            //{
            //    if (liste1.Contains(item) == false)
            //        if (liste3.Contains(item) == false) // Duplike olmasın diye. 
            //            liste3.Add(item);
            //}
            //Console.WriteLine("Birleşim Liste3=");
            //foreach (var item in liste3)
            //{
            //    Console.Write(item + " ");
            //}

            //-----------------------------------------------------------------------------------------------------------------------
            //double r = 34.5;
            //double pi = 3.14;
            //double cevre = CevreBul(r, pi);
            //Console.WriteLine(cevre);

            //Console.WriteLine(Topla());
            //Console.WriteLine(Topla(b:7));
            //Console.ReadLine();


            ////-----------------------------------------------------------------------------------------------------------------------
            ///Kendisine gönderilen double dizisini float dizine çeviren MakeItFloat isimli metoduz yazınız 

            ////double[] d = new double[10] { 1.2, 2.3, 3.4, 5, 5, 5, 5, 5, 5, 6 };
            //////float[] f = MakeItFloat(d);
            ////int[] i = MakeItInt(d);

            ////foreach (var item in i)
            ////{
            ////    Console.WriteLine(item + " ");
            ////}


            //Liste içinde liste
            //List<object> listem = new List<object>();
            //List<int> sayilarim1 = new List<int>() { 23, 34, 45, 55 };
            //List<int> sayilarim2 = new List<int>() { 63, 54, 21 };

            //listem.Add(sayilarim1);
            //listem.Add(sayilarim2);

            //foreach (List<int> liste in listem)
            //{
            //    foreach (var item in liste)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine();
            //}

            


        } //Main sonu

        static int[] MakeItInt(double[] doubleArray)
        {
            int[] intArray = new int[doubleArray.Length];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                intArray[i] = (int)doubleArray[i];
            }
            return intArray;
        }
        static float[] MakeItFloat(double[] doubleArray)
        {
            float[] floatArray = new float[doubleArray.Length];
            for (int i = 0; i < doubleArray.Length; i++)
            {
                floatArray[i] = (float)doubleArray[i];
            }
            return floatArray;
        }

        static double CevreBul(double r, double pi = 3.14159275538)
        {
            return r * pi;
        }

        static double Topla(int a = 10, int b = 20)
        {
            return a + b;
        }

    }
}


