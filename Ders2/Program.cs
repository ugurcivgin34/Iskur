using System;

namespace Ders2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //küçükten büyüğe giderken birşey farketmez
            byte a = 5;
            short b = 10;
            sbyte c = 30;
            int d = a + b + c; // int en büyük olduğu için byte short sybyte toplamının sonucunu rahatca işleyebildik
            string e = "deneme";
            char f = 'k';
            object g = e + f + d; // object string ve char dan büyük olduğu için burdada aynı şekilde birşey farketmiyor
            long h = d;
            float i = h;
            double j = i;
            double k = 12.5f;
            Console.WriteLine(j+k);
            Console.WriteLine(g);
           
            ------------------------------------------------------------------------------

            // asci kod karşılığını yazar,int şeklinde istedik çünkü
            char a = 'h';
            int b = a;
            Console.WriteLine(b);
             
            ------------------------------------------------------------------------------
            byte a = 5, b = 10;
            short d = 2, e = 9;
            int f = a + b;
            int g = d + e;//short g = d + e; hata verir 
            Console.WriteLine(f + g);
            
             ------------------------------------------------------------------------------

            //bilinçli tip dönüşümü
            int a = 255;
            byte b= (byte)a;
            Console.WriteLine(b);
            
             ------------------------------------------------------------------------------

            byte b = (byte)12.5f;
            Console.WriteLine(b);
           
             ------------------------------------------------------------------------------

            //veri kaybını önlemek için checked kullanılıyor,normalde byte 0 -255 olduğu için burda 256 dediğimiz için de sonuç 0 çıkar veri kaybı olur
            //bunun önüne geçmek için de checked kullanarak veri kaybını engellemiş oluruz .Program hata verir yani
            int i = 256;
            byte b;
            checked
            {
                b = (byte)i;
            }
            Console.WriteLine(b);
           
             ------------------------------------------------------------------------------

            int i = 255;
            int a = 300;
            byte b, c;
            checked
            {
                
                unchecked
                {
                    c = (byte)a;
                    b = (byte)i;
                }
            }
            Console.WriteLine(b);
            Console.WriteLine(c);
            
             ------------------------------------------------------------------------------

            int i = 255;
            int a = 300;
            byte b, c;
           

                unchecked
                {
                    c = (byte)a;
                    b = (byte)i;
                }
            
            Console.WriteLine(b);
            Console.WriteLine(c);
             
             ------------------------------------------------------------------------------

            object a = '5';
            char b = (char)a;
            Console.WriteLine(b);

            
             ------------------------------------------------------------------------------

            object a = 'c';
            char b = (char)a;
            int c = (int)b;
            Console.WriteLine(c);
           
             ------------------------------------------------------------------------------

            object a = 5;
            int b = (int)a;
            byte c = (byte)b;
            Console.WriteLine(b);

            ------------------------------------------------------------------------------

            //x.ToString()
            string b = 3.ToString();
            Console.WriteLine(b);
              
             ------------------------------------------------------------------------------

            int a = 6;
            string b = a.ToString();
            Console.WriteLine(b);
         
             ------------------------------------------------------------------------------

            string b = 12.5f.ToString();
            Console.WriteLine(b);

                ------------------------------------------------------------------------------

            string b = 'k'.ToString();
            Console.WriteLine(b);
            
            ------------------------------------------------------------------------------

            string b = 5 + "deneme" + 'k' + 12.5f;
            Console.WriteLine(b);
           
             ------------------------------------------------------------------------------

            int a = 5;
            char b = 'k';
            string r = "deneme";
            float f = 12.5f;
            string c = a + b + r + f; // string içinde muhakkak string ifade olması lazım ki + oparetörü kullanılsın 
            Console.WriteLine();
             

            string s1, s2;
            int sayi1, sayi2;
            int toplam;
            Console.Write("Birinci sayıyı giriniz :");
            s1 = Console.ReadLine();
            Console.Write("İkinci sayıyı giriniz :");
            s2 = Console.ReadLine();

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam :" + toplam);
          

            //Oparatörlerr-----------------
            double i = 3d * 5 / 7;
            Console.WriteLine(i);

            int i = 3 * (5 / 7);
            Console.WriteLine(i);
             

            int i = (int)(3f * (5f / 7f));
            Console.WriteLine(i);
            

            int i = 5 % 2;
            Console.WriteLine(i);


            //büyük olanın tipi her zaman tanımlanır
            float i = 5 / 2f;
            Console.WriteLine(i);
             

            float i = 2 / 5 / 2f;
            Console.WriteLine(i);

           

            //Bir arrtırma bir eksiltme operatörleri---

            int a = 5;
            int i = ++a; // önce a yı arttırıp sonra i ye atar , a++ olsaydı önce a i ye eşitler sonra a yı arttırırdı
            Console.WriteLine(i+" "+a);

             

            int a = 5;
            int i = a++;
            int b = i--;
            int c = 10;
            int d = --c;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}",a,i,b,d);
         

            byte a = 5;
            byte b = a--;
            Console.WriteLine(b);

            
            //Karşılaştırma oparetörleri

            bool a = 4 < 6;
            bool b = 6 > 5;
            bool c = 7 <= 7;
            bool d = 9 >= 12;
            bool e = 10 == 12;
            bool f = 1 != 8;
            Console.Write($"{a}\n{b}\n{c}\n{d}\n{e}\n{f}\n");
              

            object i = 50;
            string s = i as string;
            Console.WriteLine(s);

             

            int i = 50;
            bool b1 = i is int;
            bool b2 = i is double;
            bool b3 = 12 is byte;
            bool b4 = 'c' is string;
            bool b5 = 12f + 7 is int;
            Console.WriteLine($"{b1}\n,{b2}\n,{b3}\n,{b4}\n,{b5}\n");

           

            //---------------------MAntıksal Operatörler---------------

            bool b1 = 35 > 10 && 10 == 50;
            bool b2 = 35 > 10 && 10 != 50;
            bool b3 = 5 is int || 12 * 3 == 200;
            bool b4 = 5 < 4 || 45 / 5 == 9;
            bool b5 = !(5 < 4);
            Console.Write(b1+" "+b2+" "+b3+" "+b4+" "+b5);
            


            //-----------------------Bİtsel Öperatörler--------------------
            byte a = 5 & 3;
            byte b = 5 | 3;
            byte d = 5;
            byte e = (byte)~b;  // değili demek yani 100 ise 011 olur
            Console.WriteLine(b);
            

            byte b = 100;// 0110 0100
            byte c = (byte)(b << 1);
            byte d = 50;//0011 0010
            byte e = (byte)(d >> 2);
            Console.Write(c+" "+e);


             

            byte b = 7, a = 1, c;
            c = a = b;
            Console.Write(a+" "+b+" "+c);

           


            int a, b,c;
            a = 5;
            b = 6;
            a = a + b; // a+=b
            Console.WriteLine(a);
             

            //---------------------------------?:Operatörü----------------------
            Console.WriteLine("YAzılım seviyor musunuz? (e,h) :");
            string durum = Console.ReadLine();
            Console.Write(durum == "e" ? "Teşekkürler!!" : "Sağlık olsun...");

           //--------------------------------------------------------------

            //Bir öğrencinin vize(%40) ve final(%60) notlarını klavyeden alıp genel notunu hesaplayan programı oluşturunuz

            String vize, final;
            double vizePuan = 0, finalPuan = 0, ortalama = 0;

            Console.Write("Vize notunu giriniz :");
            vize = Console.ReadLine();

            Console.Write("Final notunu giriniz ");
            final = Console.ReadLine();

            vizePuan = Convert.ToDouble(vize);
            finalPuan = Convert.ToDouble(final);


            ortalama = (vizePuan * 0.4) + (finalPuan * 0.6);

            Console.WriteLine(ortalama);
            

            //---------------------------------------------------------------------
            //Klavyeden fahrenavt olarak girilen sıcaklık bilgisini santigrat cinsine çevirip aşağıdaki formatta ekrana yazdıran prog.
            // C=(F-32)/1.8

            String fah;
            double f ,c;

            Console.Write("Fahrenavt sıcaklığını giriniz :");
            fah = Console.ReadLine();

            f = Convert.ToDouble(fah);

            c = (f - 32) / 1.8;
            c = Math.Round(c, 2); // virgülden sonra 2 basamağı alır

            Console.WriteLine(f + " Fahrenavt "+ c +" Santigrat derecedir");

            ---------------------------------------------------------------------

            //Klavyeden 3 tane girilen sayının toplamını bulan programı yazınız

            String a, b, c;
            int sayi1, sayi2, sayi3, toplam;

            Console.Write("İlk sayıyı giriniz : ");
            a = Console.ReadLine();

            Console.Write("İkinci sayıyı giriniz : ");
            b = Console.ReadLine();

            Console.Write("Üçüncü sayıyı giriniz : ");
            c = Console.ReadLine();

            sayi1 = Convert.ToInt32(a);
            sayi2 = Convert.ToInt32(b);
            sayi3 = Convert.ToInt32(c);

            toplam = sayi1 + sayi2 + sayi3;

            Console.WriteLine("Üç tane sayının toplamı =" +toplam + "'dır");


            ----------------------------------------------------------------------------
             


            //Taban ve yükseklik bilgisi kullanıcıdan alınan üçgenin alanını hesaplayan programı oluşturunuz
            //ALAN = (Taban * Yükseklik) /2

            double alan = 0;
            Console.Write("Taban bilgisini giriniz : ");
            string a = Console.ReadLine();

            Console.Write("Yükseklik bilgisini giriniz : ");
            string b = Console.ReadLine();

            int taban = Convert.ToInt32(a);
            int yükseklik = Convert.ToInt32(b);

            alan = (taban * yükseklik) / 2;

            Console.WriteLine("Alan => " + alan);

            ----------------------------------------------------------------------------

            */

            //Klavyeden kulllanıcının girdiği değerin çift yada tek olduğunu bulan progamı oluşturunuz

            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine(sayi%2==0 ? "Çift Sayıdır":"Tek sayıdır");
            



        }
    }
}
