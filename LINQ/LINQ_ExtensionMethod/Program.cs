using System;
using System.Linq;

namespace LINQ_ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //6-Extension Methods(GEnişletme metodları....

            int sayi = 12;
            Console.WriteLine(sayi.KareAl());

            int number = 123;
            Console.WriteLine(number.KareAl());

            string str = "deneme";

            Console.WriteLine(str.TersCevir());

            //1-Static bir class olmalı..
            //2-Mutlaka static sınıf içerisindeki methodlarda static olmalı.
            //3-Methodun ilk parametresi this ile başlamalı , ilgili yapılara eklenmeli

            string strMesaj = "Merhaba";
            Console.WriteLine(strMesaj.Eko(3));


            //7-Expression Tree
            //LINQ sorguları 2 şekilde yazılır..Asıl olan Expression Tree yöntemidir.2 cisi ise SQL cümlesi gibi

            int sayi5 = 2;
            Console.WriteLine(sayi5.KareAl().KupAl().IkiyeBol());


            //8-Lambda Expression "=>"

            int[] sayilar = { 3, 5, 6, 8, 1, 10 };

            foreach (var item in sayilar.Where(s => s % 2 == 1))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(sayilar.Where(s => s % 2 == 1).Sum());

        }
    }
}
