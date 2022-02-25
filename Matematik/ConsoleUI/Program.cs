using Matematik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Cebir cebir = new Cebir();
            Console.WriteLine(cebir.KareAl(5));
            Console.WriteLine(cebir.KupAl(2));
        }
    }
}
