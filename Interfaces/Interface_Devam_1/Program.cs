using System;
using System.Collections;

namespace Interface_Devam_1
{
    //Fremework u kendi uygulamamıza entegre etmek
    class Depo :IEnumerable
    {
         string[] _urunler = { "Urun1", "Urun2", "Urun3", "Urun4" };

        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Depo depo = new Depo();
            foreach (string s in depo) //IEnumerator interfacenin içinde ki object Current { get;} ile sadece döndürme sağlıyor . 
            {
                Console.WriteLine(s);
            }
        }
    }
}
