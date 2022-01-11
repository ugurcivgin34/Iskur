using System;

namespace Ders10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen değer "bitir" olmadığı sürece alınan sayıları toplayıp en son ekrana toplamı yazdıran programı yazınız.
            //int toplam = 0;
            //int sayi = 0;
            //string str = "";
            //do
            //{
            //    Console.Write("Sayı giriniz : ");
            //    str = Console.ReadLine();
            //   bool dogruMu= int.TryParse(str, out sayi);
            //    //if (str.Length > 0 && sayi == 0 && str.ToLower() != "bitir" && str != "0")
            //    if (!dogruMu && str.ToLower() != "bitir" && str != "0")
            //        Console.WriteLine($"Geçersiz sayı.");
            //    toplam += sayi;
            //} while (str.ToLower() != "bitir");
            //Console.WriteLine($"While loop ile TOPLAM = {toplam}");


            //int toplam = 0;
            //int sayi = 0;
            //string str= "";
            //for(; ; )
            //{
            //    Console.Write("Sayı giriniz : ");
            //    str = Console.ReadLine();
            //    if (str.ToLower() =="bitir")
            //    {
            //        break;
            //    }
            //    bool dogruMu= int.TryParse(str, out sayi);
            //    if (str.Length > 0 && sayi == 0 && str.ToLower() != "bitir" && str != "0")
            //        Console.WriteLine($"Geçersiz sayı.");
            //    toplam += sayi;
            //}
            //Console.WriteLine($"For llop ile TOPLAM ={toplam}");


            //------------------------------------------------------------------------------------------------
            //Çarpım tablosunu yapınız.
            //1 ler 2 ler diye alt alta yazsın.

            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 1; j <= 10; j++)
            //    {
            //        Console.Write(i + "x" + j + "=" + (i * j) + "\t");

            //    }
            //    Console.WriteLine();
            //}


            //--------------------------------------------------------------------------------------------------
            // 1 lerle 6 ları , 2 lerle 7 leri , ..... diye diye alt alta ve yanyan azsın
            //int i, j;
            //for (i = 1; i <= 5; i++)
            //{
            //    for (j = 1; j <=5 ; j++)
            //    {

            //    }

            //}



            //for(int i =1;i<=10;i++)
            //{

            //    for (int j =1; j <= 5; j++)
            //    {
            //        Console.Write(i + "x" + j + "=" + (i * j) + "\t");

            //    }
            //    Console.WriteLine();

            //}

            //Console.WriteLine("\n\n");
            //for (int i = 1; i <= 10; i++)
            //{

            //    for (int j = 6; j <= 10; j++)
            //    {
            //        Console.Write(i + "x" + j + "=" + (i * j) + "\t");

            //    }
            //    Console.WriteLine();

            //}

            //--------------------------------------------------------------------------------------------------
            //Birden girilen sayıya kadar olan çift sayıları yazan , ve aşağıda toplamını alan program

            Console.Write("kaç yaşındasın  ");
            string str = Console.ReadLine();
            int sayi, toplam = 0;
            int sayac = 0;
            bool dogruMu = int.TryParse(str, out sayi);
            if (!dogruMu)
            {
                Console.WriteLine("Yanlış değer girdiniz.Lütfen sayısal değer giriniz");
            }

            for (int i = 1; i <= sayi; i++)
            {
                if (i % 2 != 0)
                {
                    sayac = 1;
                    Console.WriteLine("Tek sayılar :" + i);
                    toplam += i;
                }

            }
            if (sayac == 1)
                Console.WriteLine("Çift sayıların toplamı " + toplam);

            //---------------------------------------------------------------------------------------------------
            // İki sayı giriniz , hangisi küçük ise o sayıdan başlayarak büyük sayıya kadar sayıları ekrana yazan program

            //int sayi1, sayi2;
            //string str;
            //Console.Write("Sayı 1 giriniz :");
            //str = Console.ReadLine();
            //int.TryParse(str, out sayi1);

            //Console.Write("Sayı 2 giriniz :");
            //str = Console.ReadLine();
            //int.TryParse(str, out sayi2);
            //int kucuk, buyuk;
            //if (sayi1 < sayi2)
            //{
            //    kucuk = sayi1;
            //    buyuk = sayi2;
            //}
            //else
            //{
            //    kucuk = sayi2;
            //    buyuk = sayi2;
            //}
            //for (int sayac = kucuk; sayac <= buyuk; sayac++)
            //{
            //    Console.Write(sayac + " ");
            //}

            //---------------------------------------------------------------------------------------------------

            //// Markette 5 ürünün fiyatı tek tek girilip her biri için %18 KDV'li fiyatını ekrana yazdıran programı bulunuz

            //double sayi = 0;
            //double toplam = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write(i+1 +" . ürünün fiyatını giriniz : ");

            //    sayi = double.Parse(Console.ReadLine());
            //    sayi = (sayi * 1.18);
            //    Console.WriteLine(i+1 +".ürünün kdv li fiyatı "+Math.Round(sayi,3) + " dir");
            //    toplam += sayi;

            //}

            //Console.WriteLine("Toplam : " + Math.Round(toplam, 3));

            //---------------------------------------------------------------------------------------------------

            //string ifade = "";
            //string satirlar = "\n";

            //while (true)
            //{
            //    Console.WriteLine("Birşeyler yazınız: ");
            //    string satir = Console.ReadLine();

            //    if (satir.ToLower() == "çık")
            //    {
            //        Console.WriteLine("Girilen değerler : " + satirlar);
            //        break;
            //    }
            //    else
            //    {
            //        satirlar += satir + "\n";
            //    }
            //}
            //Console.WriteLine(satirlar);


            //    for (; ; )
            //    {
            //        Console.WriteLine("Birşeyler yazınız: ");
            //        string satir = Console.ReadLine();

            //        if (satir.ToLower() == "çık")
            //        {
            //            Console.WriteLine("Girilen değerler : " + satirlar);
            //            break;
            //        }
            //        else
            //        {
            //            satirlar += satir + "\n";
            //        }
            //    }
            //    Console.WriteLine(satirlar);
            //

            //---------------------------------------------------------------------------------------------------

            //1 10 arası sayıların faktöriyellerini ekrana yazdırın , en altta da faktöriyeller toplamını yazdırın

            //int i, j, toplam = 0, aratoplam = 1;
            //string bos = "                               ", formatli;
            //for (i = 1; i <= 10; i++)
            //{
            //    aratoplam = 1;
            //    for (j = 2; j <= i; j++)
            //    {
            //        //Console.WriteLine(j);
            //        aratoplam *= j;
            //    }
            //    toplam += aratoplam;
            //    formatli = aratoplam.ToString();
            //    formatli = bos.Substring(0, 15 - formatli.Length) + aratoplam.ToString();
            //    Console.WriteLine(i + " sayısının faktoriyeli= " + formatli);
            //}
            //Console.WriteLine("Faktoriyeller toplamı=   \t" + toplam);

            //---------------------------------------------------------------------------------------

            //dik üçgen , uzunluk 10

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //string cizgi = "****************";
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(cizgi.Substring(0, i));
            //}



        }
        }
    }

    
    
