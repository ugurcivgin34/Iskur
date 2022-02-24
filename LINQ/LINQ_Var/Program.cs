using System;
using System.Collections.Generic;

namespace LINQ_Var
{
    //HCI(Human Computer Intercetion)

    class Personel
    {
        //auto property arka planda değişkenin tipinde yer açar.Değişkeni oluşturur yani. 
        public int PerID { get; set; }
        public string PerAd { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            //1-var

            var sayi = 12;
            var ad = "Cevder";
            var kontrol = true;
            var pers = new Personel();
            var fiyat = 9.99M;
            var karakter = 'A';

            //sayi = "naber"; //Var da en önemli kriter ilk tipi alana kadar tipi belli değil ama tipi belli oldukta sonra tipi değişmez

            //C# 4.0
            //tip değişebilir.  view back de de çok kullanılıyor.mvc de controllerden dan view e veri göndermek için kullanılır
            dynamic deger = 12;
            deger = "value";


            object degisken1 = 12;
            int sayi1 = (int)degisken1;


            //neye çevirivreceğini biliyor.Gelen tipi dnymacite tutuyor.İhtiyaç olduğunda çeviri de yapabiliyor.
            dynamic degisken2 = 12;
            int sayi2 = degisken2;

            Console.WriteLine(degisken1);


            //2-Auto Property

            //3-Object Inıt
            Personel p = new Personel { PerID = 123, PerAd = "Cevdet" };

            //4-COllection init.
            List<Personel> personeller = new List<Personel>() {
                new Personel { PerID = 111, PerAd = "Okan" },
                new Personel { PerID = 123, PerAd = "Cevdet" },
            };


            //5-Anonim Nesne(Tip)
            var nesne = new { ID = 123, Ad = "Cevdet", Maas = 4567 }; //direk property olarak tanımlattık.



            

        }
    }
}
