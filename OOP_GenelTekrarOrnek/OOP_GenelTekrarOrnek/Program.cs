using System;

namespace OOP_GenelTekrarOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru:Bir market ürün olarak Bardak,Süt,Yoğurt,KağıtHavlu ,Yumurta gibi ürünleri satmaktadır.Bu ürünlerden bazıları
            //kırılabilen,bazıları bozulabilen veya belirli bir sürede satılması gereken ürünlerdir.
            //1-Marketteki tüm ürünleri listeleyen...
            //2-Urun ekleyebildiğimiz..
            //3-Çeşitli durumlara göre rapor alabildiğimiz(Süresi geçmiş ürünler , kırık ürünler vb gibi...)
            //Yukarıdaki durumları göz önüne alarak gerekli sistemi OOP kullanarak modelleyiniz ve yazınız.

            Market<Urun> market = new Market<Urun>();

            market.UrunEkle(new Bulgur { UrunID=23,UrunAdi="Pilavlık Bulgur",Fiyat=10,TETT=DateTime.Parse("25/02/2022")});
            market.UrunEkle(new CamBardak { UrunID = 44, UrunAdi = "6'LI Su Bardağı", Fiyat = 35, Kirik = true });
            market.UrunEkle(new CamBardak { UrunID = 48, UrunAdi = "6'LI Çay Bardağı", Fiyat = 25, Kirik = false });
            market.UrunEkle(new KagitHavlu { UrunID = 11, UrunAdi = "Kağıt Havlu", Fiyat = 37 });
            market.UrunEkle(new Sut { UrunID = 55, UrunAdi = "1'lt süt", Tipi = "Keçi", Fiyat = 15, SKT = DateTime.Parse("18/02/2022") });
            market.UrunEkle(new Yumurta { UrunID = 25, UrunAdi = "15'li Yumurta", Kirik = true, SKT = DateTime.Parse("19/02/2022"),Fiyat=25 });
            market.UrunEkle(new Yumurta { UrunID = 33, UrunAdi = "30'li Yumurta", Kirik = false, SKT = DateTime.Parse("28/02/2022"),Fiyat=33 });


            //Ürün Listele 
            Console.WriteLine("Tüm ürünler");
            foreach (var item in market.TumUrunler())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Kırık Ürünler");
            foreach (var item in market.KirikUrunler())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Bozuk Ürünler");
            foreach (var item in market.BozukUrunler())
            {
                Console.WriteLine(item);
            }


        }
    }
}
