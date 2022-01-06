using System;

namespace Ders9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yıldız(*) 50x20 lik bir çerçeve olsun , içinde üst tarafta network akademi yazsın gerekirse while kullanılsın

            //Console.WriteLine("***************************************************");
            //Console.WriteLine("* Network Akademi                                 *");
            //int sayac = 1; 
            //while (sayac <=17)
            //{
            //    Console.WriteLine("*                                                 *");
            //    sayac++;
            //}
            //Console.WriteLine("***************************************************");
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------------------------------------

            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //string s = "* Network Akademi                                 *";
            //Console.WriteLine(s.Substring(2, 15));
            //Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------------------------------------


            //en ve yükseklik klavyeden girilecek .
            //zemin lacivert, yazılar sarı olsun.


            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Console.Clear();
            //Console.WriteLine("En:");
            ////int en = int.Parse(Console.ReadLine());
            //int en = 0;
            //int.TryParse(Console.ReadLine(), out en);

            //Console.WriteLine("Yükseklik:");
            //int yukseklik = int.Parse(Console.ReadLine());

            //string uzun_cizgi = "**************************************************";
            //string network = "* Network Akademi                                ";
            //string bos_satir = "*                                                 ";

            //Console.WriteLine(uzun_cizgi.Substring(0, en));
            //Console.WriteLine(network.Substring(0, en - 1) + "*");

            //const int doluSatirSayisi = 3;
            //int sayac = 1;
            //try
            //{

            //    while (sayac <= yukseklik - doluSatirSayisi) //3 tane satırı zaten kullandığımız için -3 dedik
            //    {
            //        Console.WriteLine(bos_satir.Substring(0, en - 1) + "*");
            //        sayac++;
            //    }
            //    Console.WriteLine(uzun_cizgi.Substring(0, en));
            //    Console.ReadLine();
            //}
            //catch (SystemException e)
            //{
            //    Console.WriteLine("Bir hata oluştu,hata bilgisi:" + e.Message);
            //}

            //finally
            //{
            //    Console.WriteLine("Program sonlandı");
            //}

            //-----------------------------------------------------------------------------------------------

            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //const int doluSatirSayisi = 3;
            //const int ikiYildiz = 2;

            //Console.Clear();

            ////int en = Convert.ToInt32( Console.ReadLine());
            //int en = 0, yukseklik = 0;
            //int minEn = 20;
            //int maxEn = 100;
            //int minYukseklik = 10;
            //int maxYukseklik = 30;
            //do
            //{
            //    Console.Write("En(20 ile 100 arası):");
            //    int.TryParse(Console.ReadLine(), out en);
            //} while (!(en >= minEn && en <= maxEn));
            //Console.Write("Yükseklik:");
            //do
            //{
            //    Console.Write("Yükseklik(10 ile 25 arası):");
            //    int.TryParse(Console.ReadLine(), out yukseklik);
            //} while (!(yukseklik >= minYukseklik && yukseklik <= maxYukseklik));
            ////int yukseklik = Convert.ToInt32(Console.ReadLine());

            //string uzun_cizgi = "*************************************************************************";
            //string network = "** Network Akademi                                                           ";
            //string bos_satir = "**                                                                          ";
            //try
            //{
            //    Console.WriteLine(uzun_cizgi.Substring(0, en));
            //    Console.WriteLine(uzun_cizgi.Substring(0, en));
            //    Console.WriteLine(network.Substring(0, en - 2) + "**");
            //    int sayac = 1;

            //    while (sayac <= yukseklik - doluSatirSayisi)
            //    {
            //        Console.WriteLine(bos_satir.Substring(0, en - ikiYildiz) + "**");
            //        sayac++;
            //    }
            //    Console.WriteLine(uzun_cizgi.Substring(0, en));
            //    Console.WriteLine(uzun_cizgi.Substring(0, en));
            //    Console.ReadLine();
            //}
            //catch (SystemException e)
            //{
            //    Console.WriteLine("Bir hata oluştu, hata bilgisi:" + e.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Program sona erdi.");
            //}

            //-----------------------------------------------------------------------------------------------------------------------



            //Klavyeden girilen sayıları ekrana yazdıran programı
            // koşullar : 5 'in katlarında "BOM" yazsın ,19'un katı girilince programdan çıksın
            //int sayi = 0;

            //while (true)
            //{
            //    Console.Write("Sayı gir leo : ");

            //    int.TryParse(Console.ReadLine(), out sayi);

            //    if (sayi > 0)
            //    {
            //        if (sayi % 5 == 0)
            //        {
            //            Console.WriteLine("BOM");
            //        }

            //        else if (sayi % 19 == 0)
            //        {
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine(sayi.ToString());
            //        }


            //    }

            //}

            ////-----------------------------------------------------------------------------------------------------------------------
            //1-100 arasındaki sayıları yazdıran programı
            //7 ye gekşbce bir şey yazdırmasın , atlasın
            //9 gelince(9 u da yazıp) döngüden çıksın

            //int i = 1;
            //while (i<=10)
            //{
            //    if (i==7)
            //    {
            //        i++;
            //        continue;
            //    }
            //    if(i==10)
            //    {
            //        break;

            //    }
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////----------------------------------------------------------------------------------------------------------------------- 
            //1 den klavyeden sayıya kadar tek mi çift mi olduğunu ekrana yazan progr

            //int i = 1;
            //int sayi = 1;
            //do
            //{
            //    Console.Write("Bİtiş sayısı (1-1000 arası:)");
            //    int.TryParse(Console.ReadLine(), out sayi);
            //} while (!(sayi >= 1 && sayi <= 1000));

            //while (i <= sayi)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i + " sayısı tek bir sayıdır");

            //    }
            //    else
            //    {
            //        Console.WriteLine(i + " sayısı çift bir sayıdır");

            //    }
            //    i++;
            //}

            ////-----------------------------------------------------------------------------------------------------------------------
            ///

            //1 den 10 a kadar olan sayıların toplamını yazdıralım

            //int toplam = 0;

            //for (int i = 0; i < 10; i+=10)
            //{
            //    toplam +=i;
            //}
            //Console.WriteLine("Toplam " + toplam);

            ////-----------------------------------------------------------------------------------------------------------------------

            //ekranda girilen değerleri yazsın, ÇIK yazınca döngüden çıksın

            string ifade ;

            for (; ; )
            {
                Console.WriteLine("Bir yazı yazın ü çıkmak için ÇIK yazın.");
                ifade = Console.ReadLine();
                if (ifade.ToUpper() == "ÇIK")
                {
                    break;
                }
                Console.WriteLine(ifade);
            }


        }

    }
}

