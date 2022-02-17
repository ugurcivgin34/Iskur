using System;

namespace OOP3_Poliformizm_Ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel = new Personel();
            Musteri musteri = new Musteri();

            personel.PerID = 1;
            personel.PerAdi = "Uğur Okan";

            musteri.MusID = 2;
            musteri.MusAdi = "Semanur";

            Console.WriteLine(personel);
            Console.WriteLine(musteri);
            Object obj = new object();
            Console.WriteLine(obj);
        }
    }
}
