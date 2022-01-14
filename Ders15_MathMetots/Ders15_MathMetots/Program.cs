using System;

namespace Ders15_MathMetots
{
    class Program
    {
        static void Main(string[] args)
        {
            int mutlak7 = Math.Abs(-7);
            Console.WriteLine(mutlak7);

            double cos45 = Math.Cos(45);
            Console.WriteLine(cos45);
            Console.WriteLine(Math.Sin(45));
            Console.WriteLine(Math.Tan(45));
            Console.WriteLine(Math.Max(4, 5));
            Console.WriteLine(Math.Min(1, 10));
            Console.WriteLine(Math.Pow(2, 8));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Log(16,2));
            Console.WriteLine(Math.Exp(4));
            Console.WriteLine(Math.Log10(100));
        }
    }
}
