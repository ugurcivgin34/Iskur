using System;

namespace OOP3
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
