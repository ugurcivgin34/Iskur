using System;

namespace Ders23_Kuafor_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici fikri = new Kullanici();
            fikri.AdSoyad = "Fikri Çalışkan";

            fikri.kuafor.SacTrasiYap();
            fikri.kuafor.SacYikamaYap();

            fikri.kuafor.BilgiYaz();
        }
    }
}
