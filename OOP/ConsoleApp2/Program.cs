using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Personel
    {
        public Personel()
        {
            Console.WriteLine("Nesne Oluştu...");
        }

        ~Personel() //decustroctor, corbage collector
        {
            Console.WriteLine("Nesne Silindi....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            
        }
    }
}
