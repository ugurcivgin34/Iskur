using System;

namespace Ders4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir otoparkın ücret tarifesi şöyledir.
            //0-3 saat : 4 TL
            //3-7 saat : 3 TL
            //7-12 saat : 2 TL
            //BUna göre girilen saate göre otoparka ödenecek ücreti hesaplayıp ekrana yazan pgoramı oluşturunuz 

            //    Console.Write("Kaç saat otoparkta kalmak istiyorsunuz :");
            //    int saat = int.Parse(Console.ReadLine());
            //    int toplam = 0;

            //    if(saat>0 && saat <3)
            //    {
            //        toplam = saat * 4;
            //    }

            //    else if(saat>= 3  && saat <7)
            //    {
            //        toplam = saat * 3;
            //    }

            //    else if(saat>=7 && saat<12)
            //    {
            //        toplam = saat * 2;
            //    } else
            //    {
            //        Console.WriteLine("Saati aştınız");
            //    }

            //    Console.WriteLine("Otoparka girilen saat " + saat + "   göre toplam ücret :"+ toplam +" 'dır") ;

            //}

            //klavyeden girilen bir değerin faktöriyelini bulan pgoramı bulunuz

            //float s;
            //int si, f;
            //bool a = true;
            //for (;a;)
            //{
            //    Console.Write("Lütfen Faktöriyelinin alınmasını istediğiniz sayıyı giriniz: ");
            //    s = Convert.ToSingle(Console.ReadLine());
            //    si = (int)s;
            //    if (si != s || s < 1)
            //    {

            //        Console.WriteLine("Lütfen pozitif tam sayı giriniz:");
            //        a = true;
            //    }
            //    else
            //    {
            //        a = false;
            //        for (f = 1; si > 1; si--)
            //            f *= si; // f=f*si
            //        Console.Write("Faktöriyeli {0}", f);

            //    }

            // başlangıç ve bitiş değeri kullanıcı tarafından verilen sayıları ekranda yazdıran C# for döngüsü örneği

            //Console.Write("İlk sayıyı gir :");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı gir :");
            //int sayi2 = int.Parse(Console.ReadLine());

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //a ' dan z'  kadar olan harfleri ekranda gösteren


            //for (char i = 'a'; i <= 'z'; i++)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            //for (char i = 'z'; i >= 'a'; i--)
            //{
            //    Console.Write(i + " ");
            //}

            //Klavyeden girilecek olan 10 sayıdan en büyük ve en küçük olanı ekrana yazdır

            //int enb = 0, enk = 0;

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine(i + "'ninci sayıyı giriniz : ");
            //    int sayi = int.Parse(Console.ReadLine());

            //    if (i == 1)
            //    {
            //        enb = sayi;
            //        enk = sayi;
            //    }


            //    if (enk > sayi)
            //    {
            //        enk = sayi;

            //    }
            //    if (enb > sayi)
            //    {
            //        enb = sayi;
            //    }


            //}

            //Console.WriteLine("En büyük sayi" + enb);
            //Console.WriteLine("EN küçük sayi" + enk);


            //1' den 100 'e kadar olan sayıların toplamını bulup sonucu ekranda gösteren c#
            //int toplam = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    toplam = toplam + i;
            //}
            //Console.WriteLine(toplam);

            //klavyeden girilen iki sayıyı da dahil ederek , bu iki sayı arasındaki sayıların toplanını bulan c#

            //int sayi1 = int.Parse(Console.ReadLine());
            //int sayi2 = int.Parse(Console.ReadLine());
            //int toplam = 0;
            //if(sayi1>sayi2)
            //{
            //    Console.WriteLine("sayi1 sayi2 den küçük olamaz ");

            //}else
            //{
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {

            //        toplam = toplam + i;
            //    }
            //}

            //Console.WriteLine(toplam);


            //int toplam = 0;
            //Console.Write("Birinci sayiyi giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("İkinci sayiyi giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 < sayi2)
            //{
            //    for (int i = sayi1; i <= sayi2; i++)
            //    {
            //        toplam += i;
            //    }
            //    Console.WriteLine(toplam);
            //}
            //else if (sayi2 < sayi1)
            //{
            //    for (int i = sayi2; i <= sayi1; i++)
            //    {
            //        toplam += i;
            //    }
            //    Console.WriteLine(toplam);
            //}
            //else
            //{
            //    Console.WriteLine("Sayilar birbirine eşittir: " + sayi1);
            //}

            // 0 ile 100 arasındaki tek sayıları yazdıran programı yapınız

            //for (int i = 0; i < 100; i++)
            //{
            //    if(i%2!=0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            string cümle = "ugur civgin";
            string[] liste = cümle.Split(' ');
            string cümle2 = liste[0];
            string cümle3 = liste[1];

            char[] c1 = new char[liste[0].Length];
            char[] c2 = new char[liste[1].Length];


            for (int i = 0; i < cümle2.Length; i++)
            {
                c1[i] = cümle2[i];
                Console.WriteLine(c1[i] + " ");
          
            }
            

            for (int i = 0; i < cümle3.Length; i++)
            {
                c2[i] = cümle3[i];
                Console.Write(c2[i]+ " ");
            }

           
                
            }
           
            

        }
    }



