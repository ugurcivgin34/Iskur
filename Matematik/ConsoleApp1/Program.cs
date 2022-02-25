using System;
using Matematik;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cebir cebir = new Cebir();
            Console.WriteLine(cebir.KareAl(5));
            Console.WriteLine(cebir.KupAl(5));
        }
    }
}
