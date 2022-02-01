using Ders22_OOP_Kalıtım.Sahibindencom;
using System;
using System.Threading;

namespace Ders22_OOP_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            AltClass nesne = new AltClass();
            nesne.AdSoyad = "Salih Uçan"; //AltClass özelliği
            nesne.KayitTarihi = DateTime.Now; // Ana Class özelliği
            nesne.IlanTarihi = Convert.ToDateTime("2022-01-15");
            nesne.IlanTarihiYaz(); // AnaClass metodu.
            nesne.AdSoyadYaz();  // AltClass metodu
            nesne.BilgiYaz();    // AltClass metodu

            Thread.Sleep(5000);  // 5 saniye bekliyor.
            AltClass2 nesne2 = new AltClass2();
            nesne2.KayitTarihi = DateTime.Now;
            nesne2.Baslik = "Uygun fiyatlı olta takımı";

            nesne2.IlanTarihi = Convert.ToDateTime("2022-01-15");
            nesne2.IlanTarihiYaz();
            nesne2.BaslikYaz();

            AnaClass anaNesne = new AnaClass();
            anaNesne.IlanTarihi = Convert.ToDateTime("2021-01-15");
            anaNesne.KayitTarihi = Convert.ToDateTime("2021-01-15");
            anaNesne.IlanTarihiYaz();

            EnAltClass enAltNesne =
                new EnAltClass(23, DateTime.Now, "Hakan Şükür", "uzun");

            Kullanıcılar shakir = new Kullanıcılar();
            shakir.AdSoyad = "Şakir Demir";
            shakir.Telefon = "053858395630";
            Console.WriteLine(shakir.AdSoyad);
        }
    }
}
