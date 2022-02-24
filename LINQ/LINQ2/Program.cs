using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ2
{

    class Program
    {
        static void Yaz<T>(List<T> liste)
        {
            foreach (T t in liste)
            {
                Console.WriteLine(t);
            }
        }
        static void Main(string[] args)
        {
            //LINQ sorguları...
            //1-SQL gibi...
            //var sonuc = from u in UrunData.Urunler
            //            select u;

            //Yaz(sonuc.ToList());

            //int ID = 123;
            //var sonuc = from u in UrunData.Urunler
            //            where u.UrunID == ID
            //            select u;
            //ID = 126;
            //Yaz(sonuc.ToList());

            ////LINQ sorguları deffered model ile çalışır...
            //int ID = 123;
            //var sonuc = (from u in UrunData.Urunler
            //            where u.UrunID == ID
            //            select u).ToList();
            //ID = 126;
            //Yaz(sonuc);


            //2.Expression Tree şeklinde
            //var sonuc = UrunData.Urunler.Where(u => u.UrunID == 126).ToList();
            //Yaz(sonuc);


            //linq sorgusu geçikmeli çalışır.Deffered
            //Yaz(sonuc.ToList());//İmmute mode yani linq sorgusu Tolist metodununu gördüğü zaman çalışır.Yani tolist metodunu kullanana kadar
            //ıd değeri en son 128 di .Ekranda 128 yazar.


            //var sonuc = UrunData.Kategoriler.Select(u => u).ToList();


            //var sonuc = from u in UrunData.Urunler select new { ID = u.UrunID, Ad = u.UrunAdi };//buradaki new 5. yöntem olan anonim nesne
            //Yaz(sonuc.ToList());

            //// var ve new olmasının sebebine bakacak olursak 
            //// urun ve kategori sınıflarım mevcut oradan urun ve kategori gelecek ama kullanıcı a ve b tablosundan al derse ürün tipim ney bilemem
            //// o zaman aracıya ihtiyacım olacak ona da var işlem sağlar
            //// hangi aracının geleceğine ise new olanak sağlayacak 

            //
            //var sonuc = from u in UrunData.Urunler
            // select new { ID = u.UrunID, Ad = u.UrunAdi };


            //var sonuc = UrunData.Urunler.Select(u => new { u.UrunID, u.UrunAdi });
            //Yaz(sonuc.ToList());

            //join
            //sql sorgusuna benzer şekilde yazmak
            //var sonuc = from u in UrunData.Urunler
            //            join k in UrunData.Kategoriler
            //            on u.KategoriId equals k.KategoriID
            //            select new { u.UrunID, u.UrunAdi, k.KategoriAdi };


            //espression tree yöntemi
            var sonuc = UrunData.Urunler.Join(UrunData.Kategoriler, u => u.KategoriId, k => k.KategoriID, (u, k) => new { u.UrunID, u.UrunAdi, k.KategoriAdi });

            Yaz(sonuc.ToList());


           

        }
    }
}
