using System;
using System.Linq;

namespace Ders11_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] rakamlar = new int[] { 1, 2, 5, 8, 6, 3, 10, 5, 85, 46 };

            //rakamlar[1] = 100;
            //rakamlar.SetValue(130, 0);   //ilk elamana 0 atar
            //Console.WriteLine("rakamlar[1]= " + rakamlar.GetValue(1));

            //Console.WriteLine("rakamlar.GetType =" + rakamlar.GetType());
            //Console.WriteLine("rakamlar.Length =" + rakamlar.Length);

            //for (int i = 0; i < rakamlar.Length; i++)
            //{
            //    Console.WriteLine(rakamlar[i]);
            //}

            //foreach (var item in rakamlar)
            //{
            //    Console.WriteLine(item);
            //}

            //-------------------------------------------------------------------------------------------------------------------------------------------

            ////tip[] diziAdi = new tip[boyut];
            //// int[] sayilar = new int[10];
            //int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //// int rakamlar=new int[10];

            //// int[] sayilar = new int[10]; 
            //// indis numaraları 0'dan başlar, birer birer artarak devam eder.

            //string isim1 = "Ahmet";
            //string isim2 = "Ali";
            //string isim3 = "Ayşe";
            //string isim4 = "Veli";
            //string isim5 = "Eda";

            //string[] isimler = new string[5];
            //isimler[0] = "Ahmet";
            //isimler[1] = "Ali";
            //isimler[2] = "Ayşe";
            //isimler[3] = "Veli";
            //isimler[4] = "Eda";


            //rakamlar.SetValue(130, 0); // ilk elemana 130 ata.
            //rakamlar[1] = 100; // ikinci elemana 100 ata
            //Console.WriteLine("rakamlar.GetValue(1)=" + rakamlar.GetValue(1));
            //Console.WriteLine("rakamlar[1]=" + rakamlar[1]);

            //Console.WriteLine("rakamlar.GetValue(0)=" + rakamlar.GetValue(0));
            //Console.WriteLine("rakamlar[0]=" + rakamlar[0]);

            //Console.WriteLine("rakamlar.GetType()=" + rakamlar.GetType());
            //Console.WriteLine("rakamlar.Length()=" + rakamlar.Length);
            ////rakamlar[10] = 100;  // index out of range hatası.

            //for(int i=0; i< isimler.Length;i++)
            //    Console.WriteLine("isimler[" + i + "]=" + isimler[i] );
            //Console.WriteLine("--------------------------------------------");
            //for (int i = 0; i < isimler.Length; i++)
            //    Console.WriteLine("isimler[" + i + "]=" + isimler.GetValue(i));

            //Console.WriteLine("--------------------------------------------");
            //string[] sehirler = { "Adana", "Adıyaman", "Afyon", "Ağrı", "Amasya" };
            //for (int i = 0; i < sehirler.Length; i++)
            //    Console.WriteLine("sehirler[" + i + "]=" + sehirler[i]);
            //Console.WriteLine("--------------------------------------------");
            //int k = 0;
            ////Foreach for ile benzer işi yapar, indis yerine doğrudan şehir bilgisine
            //// ulaşır. 
            //foreach (var item in sehirler)
            //{
            //    Console.WriteLine("Sehirler[" + k + "]=" + item);
            //    k++;
            //}

            //İki array yaratalım: 
            //string[] mySourceArray = new string[10];
            //mySourceArray[0] = "yuvalarında";
            //mySourceArray[1] = "uyuyan";
            //mySourceArray[2] = "üç";
            //mySourceArray[3] = "uykulu";
            //mySourceArray[4] = "tavuğun";
            //mySourceArray[5] = "5";
            //mySourceArray[6] = "6";
            //mySourceArray[7] = "7";
            //mySourceArray[8] = "8";
            //mySourceArray[9] = "9";

            //string[] myTargetArray = new string[15];
            //myTargetArray[0] = "Çevik";
            //myTargetArray[1] = "kahverengi";
            //myTargetArray[2] = "tilki";
            //myTargetArray[3] = "atladı";
            //myTargetArray[4] = "üstüne";
            //myTargetArray[5] = "tembel";
            //myTargetArray[6] = "köpeğin";

            //foreach (var item in myTargetArray)
            //{
            //    Console.WriteLine(item);
            //}
            //mySourceArray.CopyTo(myTargetArray, 5);
            //Console.WriteLine("--------------------------------------------");

            //for (int i = 0; i < mySourceArray.Length; i++)
            //{
            //    Console.WriteLine(i + " " + mySourceArray[i]);
            //}
            //Console.WriteLine("--------------------------------------------");
            //foreach (var item in myTargetArray)
            //{
            //    Console.WriteLine(item);
            //}


            //-------------------------------------------------------------------------------------------------------------------------------------------
            //Kullanıcdan alınan 10 adet isim bilgisini string bir diziye kaydeip , daha sonra dizi elamanlarını kaydedip daha sonra dizi elamanlarını ekrana yazdıran prog
            //string[] isimler = new string[10];
            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    Console.WriteLine("İSim giriniz : ");
            //    isimler[i] = Console.ReadLine();
            //}

            //Console.WriteLine("-------------------------------------------------");

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] puanlar = { 10, 20, 30, 20, 4, 60, 70, 80, 90, 1 };

            //int indis = Array.IndexOf(puanlar, 350);//indix bilgisini getirir
            //int indis = Array.IndexOf(puanlar, 20,2); //1. indisten başlar aramaya
            //Console.WriteLine(indis);


            //Array.Reverse(puanlar);
            //foreach (var item in puanlar)
            //{
            //    Console.WriteLine(item);
            //}


            //string[] sehirler = new string[] { "istanbul", "ankara", "trabzon" };
            //string[] sehirler2 = new string[] { "Ordu", "Giresun", "Bursa" };

            //sehirler = sehirler2;
            //sehirler[0] = "elazığ";
            //Console.WriteLine(sehirler2[0]);

            //object[] karisikDizi = new object[10];
            //karisikDizi[0] = 10;
            //karisikDizi[1] = "Okan";
            //karisikDizi[2] = 15.46;
            //karisikDizi[3] = 16.12d;

            //foreach (var item in karisikDizi)
            //{
            //    Console.WriteLine(item);
            //}

            //object elaman = "Uğur";
            //int indis = Array.IndexOf(karisikDizi, elaman);
            //Console.WriteLine(indis);


            //int[] ar = new int[10];
            //ar[0] = 123;
            //ar[9] = 123;

            //foreach (var item in ar)
            //{
            //    Console.WriteLine(item);
            //}

            //1 ile 10 arasında rastgele 10 sayı üretip bir diziye atın ,
            //sonra da diziyi ekrana yazdırın
            //Random rastgele = new Random();
            //int[] arraySayilar = new int[100];
            //for (int i = 0; i < arraySayilar.Length; i++)
            //{
            //    arraySayilar[i] = rastgele.Next(1, 11);// 0, 10 verirsek 0,dan 9'a 
            //                                           // kadar çıkar,
            //}
            //int sayac = 0;
            //int cc = 0;
            //foreach (var item in arraySayilar)
            //{
            //    Console.Write(item + " ");
            //    sayac++;
            //    if (sayac % 10 == 0)
            //        Console.WriteLine("");
            //    //if (item == 7)
            //    //    count7++;


            //}
            ////Console.WriteLine("7 sayısının adedi=" + cc);

            ////Console.WriteLine("arraySayilar.Count()=" + arraySayilar.Count());

            //cc = arraySayilar.Count(sayi => sayi == 7);
            //Console.WriteLine("arraySayilar.Count()=" + cc);

            //cc = arraySayilar.Count(x => x == 5);
            //Console.WriteLine("arraySayilar.Count()=" + cc);

            //cc = arraySayilar.Count(x => x % 3 == 0);
            //Console.WriteLine("arraySayilar.Count()=" + cc);

            //Console.ReadLine();


            //Dizideki 10 değerlerinin index numalararını ekrana yazdıran programı
            //int[] puanlar = { 10, 20, 30, 40, 10, 14, 10, 20, 30, 90 };

            //int startIndex = 0;
            //int adet10 = puanlar.Count(sayi => sayi == 10);
            //for (int i = 0; i < adet10; i++)
            //{
            //    startIndex = Array.IndexOf(puanlar, 10, startIndex);
            //    Console.WriteLine("10 değeri " + startIndex + " .indexte var");
            //    startIndex += 1;
            //}


            //for (int i = 0; i < puanlar.Length; i++)
            //{
            //    if(puanlar[i]==10)
            //    {
            //        Console.WriteLine("10 değeri " + i + " .indexde var ");
            //    }

            //}

            //kaç tane çift olduğunu bulan program
            //int[] sayilar = { 1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 4 };
            //int ciftSayi = sayilar.Count(x => x % 2 == 0);
            //Console.WriteLine("Çift sayıların sayısı :" + ciftSayi);

            //int[] dizi1 = { 11, 41, 21, 32, 43, 54, 65, 66, 77, 86 };
            ////int[] dizi2 = new int[10];

            //int[] dizi2 = { 44, 55, 13, 14, 12, 54, 21, 33, 57, 56 };
            //// dizi1.CopyTo(dizi2, 5);
            //Array.Copy(dizi1, dizi2, 3);

            //for (int i = 0; i < dizi1.Length; i++)
            //{
            //    Console.WriteLine(dizi2[i]);
            //}
            //20 elamanlı bir array olsun.İçine random 1 den 20 e kadar sayılar atılsın.Sayının 5 bölününce kaç kalıyorsa o kadar yıldız yazsın.
    

            int[] dizi3 = new int[20];
            Random rnd3 = new Random();
            for (int i = 0; i < 20; i++)
                dizi3[i] = rnd3.Next(1, 21);
            for (int i = 0; i < 20; i++)
            {
                Console.Write(dizi3[i] + "--->");
                for (int j = 0; j < dizi3[i] % 5; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
        }
    }
}
