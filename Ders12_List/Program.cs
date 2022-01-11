using System;
using System.Collections.Generic;

namespace Ders12_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ////List dizilerden farkı olarak kapasite sınırlı değildir , otomatik değişir
            //List<int> ilkLİstem = new List<int>();
            //List<int> sayilar = new List<int>() { 1000, 2000, 3000 };
            //List<string> sehirler = new List<string>();

            //sayilar.Add(1998);
            //sayilar.Add(13231);
            //sayilar.Insert(0, 1968);
            //sayilar.InsertRange(2, sayilar);

            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();
            //Console.WriteLine("1231 in indexi " + sayilar.IndexOf(1231));

            //bool sivasCheck = sehirler.Contains("sivas"); // sivas listede var mı
            //sehirler.RemoveAt(1); //1. şehiri çıkar

            //sehirler.Sort();
            //int indexBinary = sehirler.BinarySearch("hakkari"); //indexini bulur
            //Console.WriteLine("indexBinary = " + indexBinary);
            //Console.ReadLine();

            List<string> liste = new List<string>();
            liste.Add("Uğur");
            liste.Add("Okan");
            liste.Add("Sait");
            liste.Add("İlve");
            liste.Add("Hakan");
            liste.Add("Sema");
            liste.Add("Nur");
            //List yapılarında boyut sınırlı değildir

            //Console.WriteLine(liste[0]);
            //Console.WriteLine(liste[1]);

            //int v = liste.Count;
            //Console.WriteLine("Listedeki elaman sayısı :" + v);

            //liste.Remove("Okan");
            //liste.RemoveAt(0);

            //liste.Remove("Selvi");

            //int indis = -1;
            //for (int i = 0; i < liste.Count; i++)
            //{
            //    if (liste[i].ToUpper()=="hakan".ToUpper())
            //    {
            //        indis = i;
            //        break;
            //    }
            //}
            //if (indis!=-1)
            //{
            //    liste.RemoveAt(indis);
            //}
            //foreach (var item in liste)
            //{
            //    Console.WriteLine(item);
            //}

            if (ElemanLİstedeVarMi(liste, "Mehmet"))
                Console.WriteLine("Mehmet var.");
            else
                Console.WriteLine("Listede mehmet yok");
            Console.ReadLine();
        }

        public static bool ElemanLİstedeVarMi(List<string> isimler, string arananIsım)
        {
            foreach (var isim in isimler)
            {
                if (isim == arananIsım)
                {
                    return true;
                }



            }
            return false;
        }
    }
}

