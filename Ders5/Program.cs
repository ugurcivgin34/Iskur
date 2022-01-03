using System;

namespace Ders5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen sayının kaç basamaklı olduğunu bulan programı while döngüsü ile yapınızı

            //int sayi = int.Parse(Console.ReadLine());
            //int sayac = 0;


            //while(sayi>0)
            //{
            //    sayi = sayi / 10;
            //    sayac++;
            //}

            //Console.WriteLine(sayac.ToString());

            //---------------------------------------
            //Random rnd = new Random();
            //int sayi = rnd.Next(50); //10 dahil 50 arası rastgele sayı üretir


            //Tanımlanan sayılar dizisi içersindeki sayıları toplayan consol programı

            //int[] dizi = new int[] { 10, 50, 25, 42, 52, 14, 52 };
            //int toplam = 0;

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    toplam = toplam + dizi[i];
            //}

            //Console.WriteLine("Dizi içindeki elamanların toplamı : " + toplam);

            //Dİzi içindeki en büyük ve en küçük elamanı bulunuz

            //    int[] dizi = new int[]  { 10,52,4,12,36,5,10};
            //    int enb = 0, enk = 0;

            //    enb = dizi[0];
            //    enk = dizi[0];

            //    for (int i = 1; i < dizi.Length; i++)
            //    {
            //        if(dizi[i]>enb)
            //        {
            //            enb = dizi[i];
            //        }if(dizi[i]<enk)
            //        {
            //            enk = dizi[i];
            //        }
            //    }

            //    Console.WriteLine("En büyük elaman " + enb);
            //    Console.WriteLine("En küçük eleman " + enk);
            //}

            //Bir dizide aşağıdaki gibi notlar yer almaktadır. 50 ve üzeri not geçer kabül edilmektedir. döngü ullnarak geçen ve kalan öğrenci sayısını bulunuz 

            //int [] dizi = new int [] { 40,60,50,70,30,34,60,20,80,100};
            //int geç=0, kalan=0;

            //foreach (var item in dizi)
            //{
            //    if(item>=50)
            //    {
            //        geç++;
            //    } else
            //    {
            //        kalan++;
            //    }
            //}

            //Console.WriteLine("Geçen öğrenci sayısı " + geç);
            //Console.WriteLine("Kalan öğrenci sayısı " + kalan);

            //-----------------------------------------------------

            //Kullanıcı tarafından girilen gün adının haftanın kaçıncı günü olduğunu bulan programı bulunuz


            //string[] gunler = { "pazartesi", "salı", "carsamba", "persembe", "cuma", "cumartesi", "pazar" };
            //Console.WriteLine("Gün adı giriniz : ");
            //string gun = Console.ReadLine();
            //for (int i = 0; i < gunler.Length; i++)
            //{
            //    if (gun == gunler[i])
            //    {
            //        Console.WriteLine(i + 1 + ". gündür");
            //    }
            //}
            //Console.ReadLine();

            //---------------------------------------------------------------------

            //Sınıf mevcut bilgisinin kullancı tarafından alındığı ve her öğrencinin
            //isminin kullanıcı tarafından tanımlandığı ve en sonunda sınıf listesini yazdıran pgoramı oluşturunuz

            //Console.WriteLine("Sınıf mevcudunu giriniz : ");
            //int mevcut = int.Parse(Console.ReadLine());

            //string[] dizi = new string[mevcut];

            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    Console.WriteLine("Öğrenci ismini giriniz :");
            //    dizi[i] = Console.ReadLine();
            //}

            //foreach (string item in dizi)
            //{
            //    Console.WriteLine("Sınıf listesi : " + item);
            //}

            //20 elamanlı diziye rastgele -100 ile +100 arası sayılar atayan ve daha sonra dizinin elemanlarını , pozitif sayı adetini , negatif sayı adetini 
            //ve işaretsiz sayı adetini ekranda gösteren 
            //Random rnd = new Random();
            //int pozitif = 0, negatif = 0, isaretsiz = 0;
            //int[] dizi = new int[20];


            //for (int i = 0; i < dizi.Length; i++)
            //{
            //    dizi[i] = rnd.Next(-100, 100);
            //}

            //foreach (var item in dizi)
            //{
            //    if(item>0)
            //    {
            //        pozitif++;
            //    }else if (item<0)
            //    {
            //        negatif++;
            //    }else
            //    {
            //        isaretsiz++;
            //    }
            //}

            //Console.WriteLine("Eleman sayısı: " + dizi.Length);
            //Console.WriteLine("Pozitif sayısı: " + pozitif);
            //Console.WriteLine("Negatif sayısı : " + negatif);
            //Console.WriteLine("İşaretsiz sayısı :" + isaretsiz);
            //_--------------------------------------------------------------
            // AŞağıdaki int dizi içindeki tek sayıları foreach döngüsüyle ekrana yazdıran ve teksayıların adetini ekranda gösteren programı yazınız 
            //int[] dizi = new int[] { 10, 15, 20, 33, 22, 11, 9, 8, 48, 47, 12, 25, 12, 21 };
            //int sayac = 0;
            //foreach (var item in dizi)
            //{
            //    if(item%2!=0)
            //    {
            //        sayac++;
            //        Console.WriteLine(item);

            //    }
            //}
            //Console.WriteLine("Tek sayı adeti :" + sayac);


            //Klavyeden girilen bir metnin içindeki sesli ve sessiz harflerin sayısını ekranda görüntüleyen  C# programı

            //Console.WriteLine("Bir cümle giriniz");
            //string cümle = Console.ReadLine();

            //int sesli = 0;
            //int sessiz = 0;

            //cümle = cümle.Trim();

            //for (int i = 0; i < cümle.Length; i++)
            //{
            //    if(cümle[i]=='a' || cümle[i] == 'e' || cümle[i] == 'ı' || cümle[i] == 'i' || cümle[i] == 'o' || cümle[i] == 'ö' || cümle[i] == 'u' || cümle[i] == 'ü')
            //    {
            //        sesli++;
            //    } 
            //    else if(cümle[i]==' ')
            //    {

            //    } else
            //    {
            //        sessiz++;
            //    }
            //}
            //Console.WriteLine("Sesli sayısı " + sesli);
            //Console.WriteLine("Sessiz sayısı " + sessiz);


            //Klavyeden girilen sayıya kadar olan asal sayıları ekrana yazdıran program

            //Console.WriteLine("Lütfen sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());


            //for (int i = 2; i <= sayi; i++)
            //{
            //    int sayac = 0;

            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            sayac = 1;
            //            break;
            //        }
            //    }
            //    if (sayac == 0)
            //    {
            //        Console.WriteLine(i);

            //    }
            //}


            //-------------------------
            //fibonacci işlemini yaptırınız

            int sayi = 15;
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine(b);
            for (int i = 0; i < sayi; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
                Console.WriteLine("Merhaba");
                
            }

            
               


        }
        }
    }






