using System;

namespace OOP3_Polirmozim_Circle_Uygulama
{

    class Program
    {
        static void Main(string[] args)
        {

            Circle circle = new Circle(3);
            Console.WriteLine(circle.AlanHesapla());

            Cyclinder cyclinder = new Cyclinder(3, 10);
            Console.WriteLine(cyclinder.AlanHesapla());

            Parcel parcel = new Parcel(3, 10);
            Console.WriteLine(parcel.AlanHesapla());


            Console.WriteLine("----------------------");


        }
    }
}
