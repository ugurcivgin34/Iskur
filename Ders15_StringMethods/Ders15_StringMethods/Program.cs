using System;

namespace Ders15_StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Concat birleştirme yapar.
            //string birlesim = String.Concat("Metwork ", " Akademi ", " 303Sabah ", 2022);
            //Console.WriteLine(birlesim );

            //string[] dizi = { "Korkma", " sönmez", " bu", " safaklarda" };
            //birlesim = String.Concat(dizi);
            //Console.WriteLine(birlesim);

            //int[] intDizi = { 1, 2, 3, 4, 5, 6 };
            //birlesim = String.Concat(intDizi);
            //Console.WriteLine(birlesim);


            ////Compare büyük ,küçük durumuna bakar.ilki ikincisinden büyükse +1 küçük -1 eşitse 0 gelir.
            //string s1 = "Adana";
            //string s2 = "Adıyaman";

            //int comp = String.Compare(s1, s2);
            //Console.WriteLine(comp);
            //if(comp == -1)
            //    Console.WriteLine(s1);
            //else
            //    Console.WriteLine(s2);

            //string st1 = Console.ReadLine();
            //string st2 = Console.ReadLine();

            ////comp = String.Compare(st1.ToUpper(), st2.ToUpper());
            //comp = string.Compare(st1 ,s2, true); //büyük küçük harfi göz artı et demek ordaki true..false dersek küçük harflere öncelik gelir

            //if (comp==-1)
            //    Console.WriteLine("Önce gelen: "+st1);
            //else if(comp==0)
            //    Console.WriteLine("İkisi de sıra olarak eşit ");
            //else
            //    Console.WriteLine("Önce gelen: "+st2);


            string metin = "BEŞİKTAŞ";
            Console.WriteLine(metin.IndexOf("Ş"));
            Console.WriteLine(metin.LastIndexOf("Ş"));
            Console.WriteLine(metin.StartsWith("BEŞ")); //string in başlangıç değeri buna eşit mi.Büyük küçük harfe duyarlı.Bool sonuç gönderir
            Console.WriteLine(metin.EndsWith("TAŞ"));

            metin = "              _____FENERBAHÇE_____      ";
            Console.WriteLine(metin.Trim('_',' ','B','H','A','Ç','E'));

            // sola ve sağa ifade koyulur
            metin = "Merhaba Dünya";
            Console.WriteLine(metin.PadLeft(20,'.'));
            Console.WriteLine(metin.PadRight(20,'.'));


            string youtube = "https://www.youtube.com/watch?x=tbASDAsdasd";
            string[] adres = youtube.Split('.');
            Console.WriteLine(adres[0]);

            string cümle = "Merhaba arkadaşlar bugün hava çok güzel";
            adres = cümle.Split(' ');
            int i = 1;
            foreach (var kelime in adres)
            {
                Console.WriteLine(i + " . kelime "+kelime);
                i++;
            }


            string yeniCumle = string.Join(" ", adres);
            Console.WriteLine(yeniCumle);

            yeniCumle = yeniCumle.ToUpper();
            Console.WriteLine(yeniCumle);

            yeniCumle = yeniCumle.Remove(3, 1); //3 den başlayarak 1 karakter siliyor
            Console.WriteLine(yeniCumle);

            Console.WriteLine(yeniCumle.Insert(6," 123 "));
            Console.WriteLine(yeniCumle.Replace("ARKADAŞLAR","GENÇLER"));

            Console.WriteLine((yeniCumle.Substring(0,8)));

            TersYaz(cümle);
            Console.WriteLine();
            int k = KelimeSay(cümle.Replace(" "," "));
            Console.WriteLine("kelime sayısı :" +k);
          

            
        }

        private static int KelimeSay(string cümle)
        { 

            int sayac = 0;

            string[] dizi = cümle.Split(' ');

            foreach (var item in dizi)
            {
                if(item!="")
                {
                    sayac++;
                }
            }
            return sayac++;
        }

        static void TersYaz(string cümle)
        {
            
            for (int i = cümle.Length-1; i >= 0; i--)
            {
                Console.Write(cümle[i]);
            }
            
        }
    }
}
