using System;

namespace Ders12_Metotlar_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //MerhabaDunya("okan");

            //int toplam = Topla(2, 3);
            //int buyuk = BuyukOlaniDondur(22, 99);
            //int buyuk2 = BuyukOlaniDondur(10, 520, 900);
            //int kare = Kare(50);
            ////Console.WriteLine("Büyük olan " + buyuk);
            ////Console.WriteLine("Karesi " + kare);
            //Console.WriteLine("En büyük sayı " + buyuk2);

            //---------------------------------------------------------------------------------------------------------

            //Kendisine gönderilen fiyata %18 KDV ekleyip geri döndüren fiyatı yazınız
            //double fiyat = 100;
            //Console.WriteLine(fiyat +" fiyatına KDV li fiyatı "+  KDVHesapla(fiyat));

            //---------------------------------------------------------------------------------------------------------

            //fiyat ve ürün tiğine göre kdv'li fiyatı döndürsün
            //ürün tipi gıda ise KDV oranı %8,
            //ürün tipi eğitim ise KDVoranı %5,
            //diğerleri %18 kdv ekleyip geri döndüren metodu yazınız

            Console.Write("KDV'siz fiyatı giriniz:");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ürün tipi giriniz:");
            string urunTipi = Console.ReadLine();

            Console.WriteLine("Ürün Tipi=" + urunTipi + " fiyat="
                + fiyat + " KDV'li hali=" +
                                        KDVDahilHesapla(fiyat, urunTipi));
        }

        static double KDVDahilHesapla(double kdvsizFiyat)
        {
            return kdvsizFiyat * 1.18;
        }
        static double KDVDahilHesapla(double kdvsizFiyat, string urunTipi)
        {
            if (urunTipi == "gıda")
                return kdvsizFiyat * 1.08;
            else if (urunTipi == "eğitim")
                return kdvsizFiyat * 1.05;
            else return kdvsizFiyat * 1.18;
        }

        //---------------------------------------------------------------------------------------------------------
        static double KDVHesapla(double fiyat)
        {
            double toplam = fiyat + (0.18 * fiyat);
            return toplam;
        }
        //---------------------------------------------------------------------------------------------------------
        static int Topla(int v1, int v2)
        {
            return v1 + v2;
        }
        //---------------------------------------------------------------------------------------------------------
        static int BuyukOlaniDondur(int s1, int s2)
        {
            if (s1 > s2)
                return s1;
            else
                return s2;
        }
        //---------------------------------------------------------------------------------------------------------
        static int BuyukOlaniDondur(int s1, int s2, int s3)
        {
            int buyuk = s1;
            if (s2 < buyuk)
                buyuk = s1;
            else if (s3 < buyuk)
                buyuk = s3;
            else
                buyuk = s2;
            return buyuk;
        }
        //---------------------------------------------------------------------------------------------------------
        static void MerhabaDunya(string isim)
        {
            Console.WriteLine("Merhaba " + isim);
        }
        //---------------------------------------------------------------------------------------------------------
        static int Kare(int s)
        {
            return s * s;
        }


    }
}
