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

            Kullanici sema = new Kullanici();
            sema.AdSoyad = "Sema nur mutlu";
            sema.Telefon = "05376566565";


            Bisiklet bisan = new Bisiklet();
            bisan.Marka = "Bisan";

            Bisiklet sony = new Bisiklet();
            sony.Marka = "Sony";


            Kiralama kiralama = new Kiralama();
            kiralama.Kullanici = ugur;
            kiralama.Bisiklet = bisan;
            kiralama.Baslat();
            int sayi = 1000;
            Thread.Sleep(sayi);
            kiralama.Bitir();

            Kiralama kiralama2 = new Kiralama();
            kiralama2.Bisiklet = sony;
            kiralama2.Kullanici = sema;
            kiralama2.Baslat();
            Thread.Sleep(1000);
            kiralama2.Bitir();
                

        }
    }
}
