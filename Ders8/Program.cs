using System;

namespace Ders8
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int say = 0;
            //sayalim:
            //    Console.WriteLine("Sıradaki sayı" + say);
            //    say++;
            //    if (say <= 1000)
            //    goto sayalim;

            //Goto ile faktöriyel hesaplama yapma
            //---------------------------------------------------------------
            //faktöriyel hesapla
            //    int fak = 1;

            //    Console.Write("Faktöriyel hesaplanacak sayıyı gir ");
            //    int sayi =int.Parse( Console.ReadLine());

            //hesapla:
            //    fak = sayi * fak;
            //    sayi--;

            //    if (sayi > 1)
            //        goto hesapla;

            //    Console.WriteLine(fak);

            //---------------------------------------------------------------------
            //Klavyeden taban ve üs bilgisi alın , taban üs bilgisine göre kuvvetini hesaplayınız

            //    //Console.Write("Taban sayıgısını giriniz ");
            //    int taban = int.Parse(Console.ReadLine());

            //    Console.Write("Kuvveti giriniz :");
            //    int üst = int.Parse(Console.ReadLine());

            //    int sonuc = 1;

            //hesapla:

            //        sonuc = taban * sonuc;
            //        üst--;
            //    if (üst >= 1)
            //        goto hesapla;

            //            Console.WriteLine(sonuc);

            //------------------------------------------------------------------------------------------------------------------------------------------
            //Klavyeden girilen sayi 0-100 arasında değil ise tekrar isteyen program yazalım
            //Yukarıdaki şekilde 3 sayı alıp aritmetik ortalamasını alan programı yazınız



            //    double toplam = 0;
            //    int sayac = 1;

            //sayiIste:
            //    Console.WriteLine(sayac + ".Sayı: ");
            //    int s = Convert.ToInt32(Console.ReadLine());
            //    if (s >= 0 && s <= 100)
            //    {
            //        toplam += s;
            //        sayac++;

            //    } else
            //    {
            //        goto sayiIste;
            //    }
            //    if (sayac <= 3)
            //        goto sayiIste;
            //    Console.WriteLine("3 sayının ortalaması:" +Math.Round(toplam/3),2);

            //------------------------------------------------------------------------------------------------------------------------------------------

            //islem:
            //Console.Write("İlk sayıyı giriniz : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz : ");
            //int b = int.Parse(Console.ReadLine());

            //int sonuc = 0;

            //Console.WriteLine("Yapmak istediğiniz işlemi belirtiniz :(topla,cikar,bölme,carpma,çıkış) ");
            //string ifade = Console.ReadLine();

            //switch (ifade)
            //{
            //    case "topla":
            //        sonuc = a + b;
            //        Console.WriteLine("Toplam :" + sonuc);
            //        break;
            //    case "cikar":
            //        sonuc = a - b;
            //        Console.WriteLine("Çıkarma :" + sonuc);
            //        break;
            //    case "bölme":
            //        if (b == 0)
            //        {
            //            Console.WriteLine("İkinci sayı 0 olamaz");
            //        }
            //        else
            //        {
            //            sonuc = a / b;
            //            Console.WriteLine("Bölme :" + sonuc);
            //        }
            //        break;
            //    case "carpma":
            //        sonuc = a * b;
            //        Console.WriteLine("Çarpma :" + sonuc);
            //        break;
            //    case "cikis":
            //        Console.WriteLine("Çıkış yapıldı");
            //        break;

            //    default:
            //        Console.WriteLine("Farklı işlem girdiniz.Lütfen tekrar giriniz");
            //        goto islem;

            //}

            //------------------------------------------------------------------------------------------------------------------------------------------
            //int prim = 3500;
            //int sayac = 0;
            //while(prim <7200)
            //{
            //    sayac = (7200 - prim) / 360;
            //    Console.WriteLine("Emekliliğe daha "+sayac+"var,çalışmaya devam");
            //    prim += 360;
            //    sayac++;
            //}
            //Console.WriteLine(sayac+" yılda emekli oldunuz lo");

            //1 den 10 a kadar while döngüsü ile  sayıları yazdıran kod

            //int sayi = 1;
            //while (sayi<=10)
            //{

            //    Console.WriteLine(sayi);
            //    sayi++;
            //}

            //------------------------------------------------------------------------------------------------------------------------------------------
            //Klavyeden alınan değer ÇIK olmadığı sürece alınan yazıları ekrana yazdıran prog.While kullan


            //string ifade = "";

            //while (ifade.ToLower() != "çık")
            //{
            //    Console.WriteLine(ifade);
            //    Console.Write("Bir ifade giriniz : ");
            //    ifade = Console.ReadLine();
            //}
            //Console.WriteLine("Program sonlandı");




            //------------------------------------------------------------------------------------------------------------------------------------------
            //Klavyeden girilen değer "bitir" olmadığı sürece alınan sayıları toplayıp en son ekrana toplamı yazdıran programı yapınız


            //Console.Write("Bir ifade giriniz ");
            //string ifade = Console.ReadLine();
            //int toplam = 0;
            //int sayi = 0;
            //if (ifade.ToLower() != "bitir")
            //{
            //    toplam = int.Parse(ifade);

            //}


            //while (ifade.ToLower() != "bitir")
            //{
            //    Console.Write("Bir ifade giriniz : ");
            //    ifade = Console.ReadLine();
            //    if (ifade.ToLower() == "bitir")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        sayi = int.Parse(ifade);
            //        toplam = toplam + sayi;
            //    }


            //}
            //Console.WriteLine("Toplam sonucu "+toplam);


            //int toplam = 0;
            //int sayi;
            //int tempImt = 0;
            //Console.Write("Sayı giriniz:");
            //string str = Console.ReadLine();
            //while (str.ToLower() != "bitir")
            //{
            //    if (int.TryParse(str, out sayi))
            //    {
            //        //tempImt = int.Parse(str);
            //        toplam += sayi;
            //    }

            //    Console.WriteLine("SAyı giriniz");
            //    str = Console.ReadLine();
            //}
            //Console.WriteLine("Toplam=" + toplam);


            int toplam = 0;
            int sayi;

            Console.WriteLine("Sayı giriniz:");
            string str = Console.ReadLine();
            try
            {
                while (str.ToLower() != "bitir")
                {
                    if (int.TryParse(str, out sayi))
                    {
                        //tempImt = int.Parse(str);
                        toplam += sayi;
                    }

                    Console.WriteLine("SAyı giriniz");
                    str = Console.ReadLine();
                }

            }
            catch (SystemException)
            {
                Console.WriteLine("Sayı formatı hatalı,işlem yapılmalı");
                Console.WriteLine("İşlemler geri alındı");
            }

            finally
            {
                if (toplam > 0)
                {
                    Console.WriteLine("Toplam=" + toplam);
                }
                Console.WriteLine("Program sona erdi");
            }



        }
    }
}
