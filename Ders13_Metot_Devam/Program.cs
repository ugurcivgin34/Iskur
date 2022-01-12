using System;
using System.Collections.Generic;

namespace Ders13_Metot_Devam
{
    class Program
    {

        static void Main(string[] args)
        {
            //Sayi girişini otomatikleştiren metodu yazınız.Kullanıcıdan alınan int tiğindeki sayıyı döndürecek
            //int sayi = sayiGir();

            //-------------------------------------------------------------------------------------

            //PArametre olarak aldığı sayının faktöriyelini alıp döndüren metot

            //Console.WriteLine("faktöriyel sonucu = " + Faktoriyel());
            //Console.WriteLine("faktöriyel sonucu = " + Faktoriyel());
            //Console.WriteLine("faktöriyel sonucu = " + Faktoriyel());
            //Console.WriteLine("faktöriyel sonucu = " + Faktoriyel());

            //-------------------------------------------------------------------------------------------------------------------------------------------

            //Gİrilen sayının asal olup olmadığını bulan program
            //Console.WriteLine("Lütfen sayı giriniz lo : ");
            //int sayi = int.Parse(Console.ReadLine());
            //bool asalMi = IsPrime(sayi);

            //if (asalMi)
            //{
            //    Console.WriteLine(sayi + " Asal sayıdır");
            //} else
            //{
            //    Console.WriteLine(sayi + " Asal sayı değildir");
            //}

            //-------------------------------------------------------------------------------------------------------------------------------------------

            //0-100 aralığında rastele ürettiği 10 sayıyı int tipinde dizi(array) olarak döndüren metodu tanımlarınız.
            //int [] rastgele = Random();

            //int[] rastgele = Random();

            //foreach (var item in rastgele)
            //{
            //    Console.Write(item + " ");
            //}

            //Kendisine gönderilen dizideki tek sayıları yine dizi ile gönderen metodu yazınız
            //int[] sayilar = { 11, 85, 96, 99, 14, 13, 530 };

            //int[] tekSayilar =DiziTek(sayilar);

            //Console.WriteLine("Sıfırları görmek ister misiniz (e,h)");
            //string cevap = Console.ReadLine();
            //bool cevapBool = (cevap.ToUpper() == "e") ? true : false;
            //DiziYaz(DiziTek(sayilar),cevapBool);

            //DiziYaz metodunu yazını , parametre olarak int[] dizi alsın
            //int[] sayilar ={ 2, 15, 36, 100, 40};
            //DiziYaz(sayilar);

            //-------------------------------------------------------------------------------------------------------------------------------------------
            //Buyuk2li(99,88); Aldığı 2 sayıdan büyük olanı döndüren metod.

            //int a , b , c ;
            //a = SayiGir();
            //b = SayiGir();
            //c = SayiGir();
            //int enb=Buyuk2li(a,b);
            //Console.WriteLine("50 ve 60 tan büyük olan :" + Buyuk2li(a,b));
            //enb = Buyuk2li(Buyuk2li(a,b),c);
            //Console.WriteLine(a + "," + b + "," + c + " sayılarından büyük olan sayı " +enb);



            ////-------------------------------------------------------------------------------------------------------------------------------------------
            //Liste tipinde aldığı 10 adet sayının karelerini list tipinde döndüren metodu yazınız (2 tane list olacak)

            //List<int> sayilarim = new List<int>() { 2,3,4,5};
            //List<int> karelerim = KareAl(sayilarim);
            //for (int i = 0; i < sayilarim.Count; i++)
            //{
            //    Console.WriteLine(sayilarim[i] + " sayisinin karesi " + karelerim[i]);
            //}

            ////-------------------------------------------------------------------------------------------------------------------------------------------

            //Kullanıcıdan 10 sayı alıp liste ile döndüren metod
            //Metod ismi SayiGetir

            //foreach (var item in SayiGetir())
            //{
            //    Console.Write(item + " ");
            //}

            ////-------------------------------------------------------------------------------------------------------------------------------------------
            //Parametreler(enKucuk,enBuyuk,sayiAdeti)
            //Metot:Bu parametreleri alıp sayıAdeti kadar enKucuk ile enBuyuk arasında rastgele sayı üretip liste olarak geri dönsün.
            //

            //List<int> sayilar = Rastgele(2, 20, 15);

            //foreach (var item in sayilar)
            //{
            //    Console.Write(item + " ");
            //}
            ////-------------------------------------------------------------------------------------------------------------------------------------------
            ///

            //Listeyi Tek string yapan metod
            //List<string> kelimelerim = new List<string>() { "araba", "hızla", "yanımdan", "geçti" };
            //string cümlem = ListToString(kelimelerim);
            //Console.WriteLine(cümlem);


            ////-------------------------------------------------------------------------------------------------------------------------------------------
            //kisaKenar ve uzunKenar ı klavyeden alsın.CevreAlan metodu ile çevre ve alanı yazsın

            //Console.WriteLine("Kısa kenar:");
            //int kK = int.Parse(Console.ReadLine());

            //Console.WriteLine("Uzun kenar :");
            //int uK = int.Parse(Console.ReadLine());

            //CevreAlani(kK, uK);


            //1.metot : Kulllanıcdan veri girişi alan ve girilen stringi geri dönen Yaz()m etodu. 
            //2.metot cokYaz(int adet) adet kadar input(Yaz) alacak , List halinde geri döndürecek


            //string ifade = Yaz();
            List<string> gelenYazilar = CokYaz(5);


            foreach (var item in gelenYazilar)
            {
                Console.WriteLine(item);
            }

        } //Main sonu

        private static List<string> CokYaz(int v)
        {
            List<string> yazilar = new List<string>();
            for (int i = 0; i < v; i++)
            {
                yazilar.Add(Yaz());
            }
            return yazilar;
        }

        static string Yaz()
        {

            Console.Write("Yaz :");
            return (Console.ReadLine());
        }

        static void CevreAlani(int kK, int uK)
        {
            double cevre = (2 * kK + 2 * uK);
            double alan = (kK * uK);

            Console.WriteLine("Dikdörtgenin çevresi : " + cevre + "\nDikdörtgenin alanı :" + alan);
        }

        static string ListToString(List<string> kelimelerim)
        {
            string cümle = "";
            for (int i = 0; i < kelimelerim.Count; i++)
            {
                cümle += kelimelerim[i] + " ";
            }
            return cümle;
        }

        static List<int> Rastgele(int enKucuk, int enBuyuk, int sayiAdeti)
        {
            Random rastgele = new Random();
            List<int> sayilar = new List<int>();
            for (int i = 0; i < sayiAdeti; i++)
            {
                sayilar.Add(rastgele.Next(enKucuk, enBuyuk + 1));
            }
            return sayilar;

        }

        static List<int> SayiGetir()
        {
            List<int> sayilar = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + " . sayıyı giriniz: ");
                sayilar.Add(int.Parse(Console.ReadLine()));
            }
            return sayilar;
        }

        static List<int> KareAl(List<int> sayilar)
        {
            List<int> kareler = new List<int>();

            for (int i = 0; i < sayilar.Count; i++)
            {
                kareler.Add(sayilar[i] * sayilar[i]);
            }

            return kareler;
        }

        static int buyuk3lu(int a, int b, int c)
        {
            return Buyuk2li(Buyuk2li(a, b), c);
        }
        static int Buyuk2li(int s1, int s2)
        {
            if (s1 > s2)
                return s1;
            else
                return s2;
        }

        static int[] DiziTek(int[] dizi)
        {
            int[] tekDizi = new int[dizi.Length];
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] % 2 != 0)
                {
                    tekDizi[i] = dizi[i];
                }
            }
            return tekDizi;
        }

        static void DiziYaz(int[] dizi, bool sifirlariYaz)
        {
            foreach (int eleman in dizi)
            {
                if (sifirlariYaz == true)
                {
                    Console.WriteLine(eleman + " ");
                }
                else
                {
                    if (eleman != 0)
                    {
                        Console.WriteLine(eleman + " ");
                    }
                }
            }
        }
        static void DiziYaz(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }
        static int[] Random()
        {
            int[] dizi = new int[10];
            Random rastgele = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {

                dizi[i] = rastgele.Next(0, 101);
            }

            return dizi;
        }

        static bool IsPrime(int sayi)
        {
            //bool asalMi = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    return false;

                }
            }
            return true;
        }

        static int Faktoriyel()
        {
            Console.WriteLine("Sayı giriniz");
            int sayi = int.Parse(Console.ReadLine());
            int carpim = 1;
            for (int i = 2; i <= sayi; i++)
            {
                carpim *= i;
            }
            return carpim;
        }

        // static dönüştipi metotadi(tip parametre , tip parametre,....)
        static int SayiGir()
        {
            Console.WriteLine("Sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            return sayi;
        }
    }
}
