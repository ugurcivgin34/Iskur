using Ders22_OOP_Kalıtım.Sahibindencom;
using System;
using System.Threading;

namespace Ders22_OOP_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            //AltClass nesne = new AltClass();
            //nesne.AdSoyad = "Salih Uçan"; //AltClass özelliği
            //nesne.KayitTarihi = DateTime.Now; // Ana Class özelliği
            //nesne.IlanTarihi = Convert.ToDateTime("2022-01-15");
            //nesne.IlanTarihiYaz(); // AnaClass metodu.
            //nesne.AdSoyadYaz();  // AltClass metodu
            //nesne.BilgiYaz();    // AltClass metodu

            ////Thread.Sleep(5000);  // 5 saniye bekliyor.
            //AltClass2 nesne2 = new AltClass2();
            //nesne2.KayitTarihi = DateTime.Now;
            //nesne2.Baslik = "Uygun fiyatlı olta takımı";

            //nesne2.IlanTarihi = Convert.ToDateTime("2022-01-15");
            //nesne2.IlanTarihiYaz();
            //nesne2.BaslikYaz();

            //AnaClass anaNesne = new AnaClass();
            //anaNesne.IlanTarihi = Convert.ToDateTime("2021-01-15");
            //anaNesne.KayitTarihi = Convert.ToDateTime("2021-01-15");
            //anaNesne.IlanTarihiYaz();

            //EnAltClass enAltNesne =
            //    new EnAltClass(23, DateTime.Now, "Hakan Şükür", "uzun");

            Kullanici Shakir = new Kullanici();
            Shakir.AdSoyad = "Şakir Demir";
            Shakir.Telefon = "05324445566";
            Console.WriteLine(Shakir.AdSoyad);

            // Test Amaçlı
            Ilan ilan = new Ilan();
            ilan.IlanNo = 123123;
            ilan.Fiyat = 100;
            ilan.Baslik = "Şok İndirimler";
            ilan.IlanTarihi = DateTime.Now;
            ilan.Satici = Shakir;
            ilan.BilgiYaz();

            Dizustu dzb = new Dizustu();
            dzb.Kategori = Kategori.Dizüstü_Bilgisayar;
            dzb.IlanNo = 1;
            dzb.IlanTarihi = DateTime.Now;
            dzb.Baslik = "Sağlam Dizüstü Bilgisayar";
            dzb.Agirlik = 2.3f;
            dzb.Islemci = "AMD Ryzen 7";
            dzb.Fiyat = 10000.0d;
            dzb.Marka = "Lenovo";
            dzb.Bellek = "32GB";
            dzb.HDD = 0;
            dzb.SSD = 1024;
            dzb.EthernetVarMi = true;
            dzb.WifiVarMi = true;
            dzb.EkranBoyutu = "14";
            dzb.Satici = Shakir;

            dzb.BilgiYaz();
            

            Masaustu mst = new Masaustu();
            mst.Satici = Shakir;
            mst.IlanNo = 2;
            mst.IlanTarihi = Convert.ToDateTime("2022-01-19");
            mst.Baslik = "Sağlam Masaüstü Bilgisayar";
            mst.Islemci = "AMD Ryzen 6";
            mst.Fiyat = 9000.0D;
            mst.Marka = "Acer";
            mst.Bellek = "32GS";
            mst.HDD = 0;
            mst.SSD = 1024;
            mst.EthernetVarMi = true;
            mst.WifiVarMi = true;
            mst.KasaTipi = KasaTipi.Dikey;

            mst.BilgiYaz();





        }
    }
}
