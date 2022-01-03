using System;

namespace ilkprogram1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Entera basın!");
            //Console.ReadLine(); //program daha bitmeden yani hala devam ediyorken kullanılır
            //Console.WriteLine("Entera bastınız!");
            //Console.ReadKey();  //>programın tamamını yazıp bitirdikten sonra kullanılır yani programı okuturuz

            //-----------------------------------------------------------
            //int a = 5;
            //int b = 10;
            //int c = 20;
            //Console.WriteLine(a + " " + b + " " + c);

            //--------------------------------------------

            //var a = 5;
            //var b = "Uğur Okan Çivgin";
            //Console.WriteLine(b.GetType());

            //----------------------

            //float bSayiMax = float.MaxValue;
            //float bSayiMin = float.MinValue;

            //Console.WriteLine($"float tipinin alabileceği en büyük değer:{bSayiMax}");
            //Console.WriteLine($"float   tipinin alabileceği en büyük değer:{bSayiMin}");


            //-----------------------------------
            //char a = 'a';
            //string b = "deneme";
            //string c = a + b + "sınıfı" + 'm';
            //Console.WriteLine(c);

            //------------------------------

            //bool b1 = true;
            //bool b2 = false;
            //bool b3 = 5 > 4;
            //Console.WriteLine(b3);


            //-----------------------------


            //object a = null;
            //object b = 'k';
            //object c = "metin";
            //object d = 12.9f;

            //Console.WriteLine(a.GetType());

            //byte a = 5;
            //byte b = 8;
            //Console.WriteLine(8 + 5);

            //string a;
            //a = Console.ReadLine();
            //Console.WriteLine(a + " metnini yazdınız");


            //int a, b;
            //a = 20;
            //b = a;
            //Console.WriteLine(b);

            //Sabit tanımlama
            //---------------------------
            //const int a = 5;
            //const string b = "deneme";
            //const char c = 's';

            //string ad = "deneme\"deneme"; //aradaki tırnak işaretini belirtmek için \koyduk
            //Console.WriteLine(ad);

            //string a = "asda";
            //string b = "gaga";
            //string c = "kadasd";

            //Console.WriteLine("satır\n yeni satır\n Yeni satır");

            //Console.WriteLine(5.GetType());
            //Console.WriteLine(14.4.GetType());
            //Console.WriteLine("deneme".GetType());



            //klavyeden girilen ad soyad bilgilerini ekrana yazan program

            //String ad, soyad;
            //Console.WriteLine("Adınızı Giriniz");
            //ad = Console.ReadLine();

            //Console.WriteLine("Soyadınızı Gİriniz");
            //soyad = Console.ReadLine();

            //Console.WriteLine("Klavyeden girilen kişinin adı ve soyadı" + ad + " " + soyad + " dır");



            //klavyeden girilen ad soyad e posta ve parola bilgisini yazdıran programı çıktısı
            //String adSoyad, eposta, parola;

            //Console.Write("Adınızı ve soyadınızı giriniz :");
            //adSoyad = Console.ReadLine();
            //Console.Write("E postanızı giriniz : ");
            //eposta = Console.ReadLine();

            //Console.Write("Parolanızı giriniz : ");
            //parola = Console.ReadLine();

            //Console.WriteLine(adSoyad + "\n" + eposta + "\n" + parola);
            //Console.WriteLine($"Ad Soyad :" {adSoyad)\nEposta: { eposta}\nParola: { parola};



            //var a = "Uğur OKan Çivgin";
            //var b = 'a';
            //var c = 1.5;

            //Console.WriteLine(typeof(float));




            //bool c = 5 < 3;
            //Console.WriteLine(c);

            //----------------------------------------------

            // bir a değişkeni olsun karakter olsun char olsun yani. b nin türü string olsun .c değeri de a ile b yi birleştirsin


            //String a = "uğuru";
            //char b = 'm';
            //String c = a + b;
            //Console.WriteLine(c);

            //int sayi;
            //int sayi2;
            //sayi = Convert.ToInt32(Console.ReadLine());
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(sayi + sayi2);

            //-----------------------------------------------------------------

            // string olarak verilen iki değeri toplayıp c e ata .Sonra c yi yaz 

            //String a = "2";
            //String b = "4";
            //int sayi1, sayi2, c;



            //sayi1 = Convert.ToInt32(a);
            //sayi2 = Convert.ToInt32(b);
            //c = sayi1 + sayi2;

            //Console.WriteLine(c);

            //-----------------------------------------------------------

            //Deneme "örnek" deneme    bu ifadeyi ekran çıktısı olarak alalım

            //Console.WriteLine("Deneme \"örnek\" deneme");

            //--------------------------------------------------------------

            //klavyeden 3 ifade gir  , bu 3 ifadeyi her seferinde sorsun ilk ifadeyi gir vs vs , en son 3 nü birleştir boşluk bırakarak yaz

            //String a, b, c;

            //Console.Write("İlk ifadeyi giriniz :");
            //a = Console.ReadLine();

            //Console.Write("İkinci ifadeyi giriniz :");
            //b = Console.ReadLine();

            //Console.Write("Üçüncü ifadeyi giriniz :");
            //c = Console.ReadLine();

            //Console.WriteLine(a + " " + b + " " + c);

            //string yol = @"Wİndows\Program Files";
            //Console.WriteLine(yol);

            //-------------------------------------------------------------

            //4 tane değişken türü tanımla , değişken tiplerini tanımla
            int a = 2;
            char c = 'm';
            bool b = true;
            string s = "okan çivgin";

            Console.WriteLine("a nın veri tipi : " + a.GetType() +"\n" + "c nin veri tipi : " + c.GetType() 
                +"\n"+ "b nin veri tipi : " + b.GetType()+"\n"+ "s nin veri tipi : " + s.GetType());

            Console.WriteLine($" a' nin veri tipi : {a.GetType()}");
           



        }
    }
}
