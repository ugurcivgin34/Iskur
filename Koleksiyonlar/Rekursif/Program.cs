using System;

namespace Rekursif
{
    class Program
    {

        static int Faktoriyel(int sayi)
        {
            if (sayi == 1) return 1;

            return Faktoriyel(sayi - 1) * sayi;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Faktoriyel(5));
        }
    }
}
