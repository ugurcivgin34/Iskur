using System;
using System.Threading;

namespace Ders_23_OOP_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici ugur = new Kullanici();
            ugur.AdSoyad = "Uğur Okan Çivgin";
            ugur.Telefon = "05385839563";


            Bisiklet bisan = new Bisiklet();
            bisan.Marka = "Bisan";


            Kiralama kiralama = new Kiralama();
            kiralama.Kullanici = ugur;
            kiralama.Bisiklet = bisan;
            kiralama.Baslat();
            int sayi = 10000;
            Thread.Sleep(sayi);
            kiralama.Bitir();
            

        }
    }
}
