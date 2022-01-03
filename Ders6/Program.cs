using System;

namespace Ders6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("HEllo");
            //Console.Read();

            //byte min = byte.MinValue;

            //Console.WriteLine($"byte max = {min}");





            //int toplam = 0;


            //Console.WriteLine("Sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());


            //for (int i = 1; i < sayi; i++)
            //{
            //   if(sayi%i==0)
            //    {
            //        toplam = toplam + i;
            //    }
            //}

            //if(toplam==sayi)
            //{
            //    Console.WriteLine("Mükemmel sayıdır");
            //} else
            //{
            //    Console.WriteLine("Mükemmel sayı değildir");
            //}

            //klavyeden girilen kişinin adını ,şifresini , yaş

            //Console.Clear();

            //Console.Write("Kullanıcı adını ve soyadını giriniz : ");
            //string adSoyad = Console.ReadLine();

            //Console.Write("Yaşını giriniz : ");
            //int yas = int.Parse(Console.ReadLine());


            //Console.Write("Şifresini giriniz : ");
            //string sifre = Console.ReadLine();

            //Console.WriteLine("Kullanıcının adı : " + adSoyad + "\nyaşı :" + yas + "\nşifresi :" + sifre);

            //Console.Read();


            //object gelenDegisken = 99;
            //Console.WriteLine("Genel değişken : " + gelenDegisken);
            //gelenDegisken = "okan";

            //Console.WriteLine("Genel değişken : " + gelenDegisken);


            //kullanıcı bir sayı girsin ikinin katı yazsın , 3ün katı ise 3 yazsın , 


            //Console.Write("Bir sayı giriniz : ");
            //int sayi = int.Parse(Console.ReadLine());

            //if (sayi % 3 == 0 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("3 e ve 2 e bölünebilir ");
            //}
            //else if (sayi % 4 == 0)
            //{
            //    Console.WriteLine("4' ün katıdır");
            //}
            //else if (sayi % 5 == 0)
            //{
            //    Console.WriteLine("5 ' in katıdır ");
            //}
            //else if (sayi % 3==0)
            //{
            //    Console.WriteLine(" 3 e bölünebilir");
            //}
            //else
            //{
            //    Console.WriteLine("Farklı sayı giriniz");
            //}

            double d = 4.5;
            double kdv = d * 18 / 118;
            Console.WriteLine("d=" + kdv.ToString());

            int kurus = Convert.ToInt32(kdv * 100);
            Console.WriteLine("d=" + kurus.ToString());

            Console.Read();

        }
    }
}
