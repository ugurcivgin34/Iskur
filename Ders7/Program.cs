using System;

namespace Ders7
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a, b, c, d, sonuc1, sonuc2, sonuc3;
            //a = 5;
            //b = 10;
            //c = 20;
            //d = 30;
            //sonuc1 = a * b / c  + d;
            //Console.WriteLine("Sonuç = "+ sonuc1.ToString());

            //as is
            //object obj = "Okan";
            //string yazi = obj as string;


            //uint a5 = 65;
            //uint b5 = ~a5;
            //Console.WriteLine(Convert.ToString(b5, toBase: 16));//to base kaçlık tabanda yazmak istiyorsak o şekilde yazdırır

            //Bitsel sağa kaydırma >> (2 e bölme)
            //byte bs = 6;
            //byte bs2 = (byte)(bs >> 1);
            //Console.WriteLine("bs2=" + bs2);


            //--------------------------------------------
            //Bilinçsiz Tür Dönüşümü

            //Küçük tür , Büyük türe otomatik olarak dönüştürülür

            //byte byteSayi = 58;
            //int intSayi = byteSayi;
            //int il = 6000;
            //byte bb = il;//hata verir

            //float fSayi = 29.5f;
            //double dSayi = fSayi;

            //double dSayi2 = fSayi;
            //float fSayi2 = dSayi2; //hata verir


            //Kısıtlı Tür Dönüşümü (Casting)

            //Değişkenimizin türünü daha küçük bir tipe çevirirken veri kaybı oluyorsa program hata veriyor.
            //Bu şekilde checked bloğu içerisinde cast işlemi yapılıyorsa, veri kaybı olduğu durumda yukarıdaki gibi çalışma zamanı hatası verecektir.

            //int tipinde bir değişken, kendisinden daha küçük byte tipinden bir değişkene cast edilmektedir.
            //Haliyle veri kaybı oluşmakta ve bu durumu unchecked sayesinde göz ardı ederek işlemimize devam edilmektedir.
            //unchecked
            //{
            //    int sayiSayi6 = 30;
            //    byte byteSayi6 = (byte)sayiSayi6;
            //    Console.WriteLine("byteSayi6=" + byteSayi6);
            //}


            //convert Sınıfı ile tür dönüşümü
            //double ddd = 678.4550;
            //string str = Convert.ToString(ddd);
            //Console.WriteLine("str = " + str);


            //string postaKodu = "34734";
            //int postaKoduInt = Convert.ToInt32(postaKodu);
            //Console.WriteLine("postaKoduInt=" + postaKoduInt);


            //Klavyeden fahrenheit olarak girilen sıcaklık bilgisini santigrat cinsine çevirip
            //aşağıdaki formatta ekrana yazdıran programı
            //32 FAhrenheit => 0 Santigrad derecedir
            //c=(F-32)/1.8

            //Console.Write("Fahrenheit sıcaklık bilgisini giriniz : ");
            //double f = Convert.ToDouble(Console.ReadLine());

            //double c = (f - 32) / 1.8;
            //c = Math.Round(c,2); // virgülden sonra 2 basamak yazmak istiyorsak bu şekilde belirtiriz

            //Console.WriteLine(f.ToString() + " Fahrenheit =>" + c.ToString()  + " Santigrad derecedir");

            //Ekrandan alınan 2 sayının toplamının karesini ekrana yazan program

            //Console.Write("İlk sayıyı giriniz : ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz : ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //int sonuc = sayi1 + sayi2;
            //sonuc = sonuc * sonuc;

            //Console.WriteLine(sayi1  + " ve " + sayi2 + " sayılarının toplamının karesi = " + sonuc  + "'dir" );

            //char y = '6';
            //object kutu = y;

            //object p = 'p';
            //Console.WriteLine(p);


            //--------------------------------------------------------------------------------------

            //Klavyeden bir sayı giriniz. 5 den büyükse sayının kendisini yaz , değilse sayının karesini ekrana yazdıran program

            //Console.Write("Bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //if(sayi>5)
            //{
            //    Console.WriteLine("Sayının kendisi " + sayi);
            //} else
            //{
            //    //sayi = sayi * sayi;
            //    Console.WriteLine("Sayının karasi : " + Math.Pow(sayi,2));
            //}



            //--------------------------------------------------------------------------------------
            //Klavyeden girilen 2 sayıdan büyük olanı ekrana yazan program

            //Console.Write("Bir sayı giriniz : ");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayı giriniz : ");
            //int sayi2 = int.Parse(Console.ReadLine());

            //if (sayi1 > sayi2)
            //{
            //    Console.WriteLine("Büyük olan sayı " + sayi1);
            //}
            //else if (sayi1==sayi2)
            //{
            //    Console.WriteLine("İki sayı eşittir ");
            //}
            //else
            //{
            //    Console.WriteLine("Büyük olan sayı " + sayi2);
            //}


            //--------------------------------------------------------------------------------------
            //Klavyeden girilen 3 adet sayıdan, 100'den küçük olanlarının toplamını yazan programı yazınız

            //Console.Write("1. sayıyı giriniz : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.Write("3. sayıyı giriniz : ");
            //int c = int.Parse(Console.ReadLine());

            //int toplam = 0;

            //if (a<100)
            //{
            //    toplam += a;
            //}
            //if (b<100)
            //{
            //    toplam += b;
            //}
            //if (c<100)
            //{
            //    toplam += c;
            //}

            //Console.WriteLine("Yüzden küçük olanların toplamı: " + toplam.ToString());


            //--------------------------------------------------------------------------------------
            //Notu harfe çeviren program:
            //0-49:F
            //50-64:D
            //65-74:C
            //75-84:B
            //85-100:A

            //Console.Write("Notu giriniz : ");
            //int not = int.Parse(Console.ReadLine());


            //if (not >= 0 && not <= 49)
            //{
            //    Console.WriteLine("F");
            //}
            //else if (not >= 50 && not <= 64)
            //{
            //    Console.WriteLine("D");
            //}
            //else if (not >= 65 && not <= 74)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (not >= 75 && not <= 84)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (not >= 85 && not <= 100)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen 0 ile 100 arasında bir not giriniz ");
            //}

            //--------------------------------------------------------------------------------------

            //Klavyeden 2 sayı alınız. Kalvyeden işlem bilgisini alınır : (topla,çıkar,çarp,bool)


            //Console.WriteLine("İlk sayıyı giriniz : ");
            //int a = int.Parse(Console.ReadLine());

            //Console.WriteLine("İkinci sayıyı giriniz : ");
            //int b = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapmak istediğiniz işlemi belirtiniz ");
            //char ifade = char.Parse(Console.ReadLine());

            //int sonuc = 0;


            //switch (ifade)
            //{
            //    case '+':
            //        sonuc = a + b;
            //        Console.WriteLine("Toplam :" + sonuc);
            //        break;
            //    case '-':
            //        sonuc = a - b;
            //        Console.WriteLine("Çıkarma :" + sonuc);
            //        break;
            //    case '/':
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
            //    case '*':
            //        sonuc = a * b;
            //        Console.WriteLine("Çarpma :" + sonuc);
            //        break;

            //    default:
            //        Console.WriteLine("Farklı işlem girdiniz.Lütfen tekrar giriniz");

            //        break;
            //}

            //--------------------------------------------------------------------------------------

            //Klavyeden girilen sayı çift ise ekrana yazdır ,
            //tek ise 3 ün katı mı değil mi kontrol edilsin.
            //3ün katı ise kaç katı olduğu ekrana yazdırılsın
            //3 ün katı değilse , mod 3 ten artan sayı yazılsın

            //Console.Write("Bir sayı giriniz :");
            //int sayi = int.Parse(Console.ReadLine());

           

            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine("Girilen sayı çift sayıdır");
            //}
            //else
            //{
            //    if (sayi % 3 == 0)
            //    {


            //        Console.WriteLine("3 ün " + (sayi / 3) + " katıdır.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Mod sonucu " + (sayi % 3));
            //    }

            //}

            //Klavyeden girilen 5 sayıdan kaçının pozitif , kaçının negatif olduğunu sayan 
            //Ayrıca  negatiflerle pozitiflerin ayrı ayrı toplamlarını alan program
            //1.Adım: NEgatifler toplamı : -30  Pozitifler toplamı : 150


            Console.WriteLine("5 tane sayı giriniz :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int pozitif = 0, negatif = 0;
            int toplamPozitif = 0;
            int toplamNegatif = 0;

            if(a>0)
            {
                pozitif++;
                toplamPozitif += a;
            } else
            {
                negatif--;
                toplamNegatif += a;
            }
            if (b > 0)
            {
                pozitif++;
                toplamPozitif += b;
            }
            else
            {

                negatif--;
                toplamNegatif += b;
            }
            if (c > 0)
            {
                pozitif++;
                toplamPozitif += c;
            }
            else
            {

                negatif--;
                toplamNegatif += c;
            }
            if (d > 0)
            {
                pozitif++;
                toplamPozitif += d;
            }
            else
            {

                negatif--;
                toplamNegatif += d;
            }
            if (e > 0)
            {
                pozitif++;
                toplamPozitif += e;
            }
            else
            {
                negatif--;
                toplamNegatif += e;
            }

            Console.WriteLine("Pozitifler toplamı : " + toplamPozitif + " Negatifler Toplamı: "+ toplamNegatif );
            Console.WriteLine("Pozitif sayısı :" + pozitif + " Negatif sayısı: " + negatif);



            }

    }

}


