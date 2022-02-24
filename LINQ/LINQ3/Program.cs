using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exceptiion Handling(İstisnaların yakalanması)
            //1-Grammer hataları
            //2-Mantıksal hatalar
            //istisna: bir uygulama çalışırken çalışmasını durdummasına istisna yani exception deriz

            int a = 10, b = 0, c=0;
            int[] sayilar = { 5,6,7,1};


            try
            {
                int s=sayilar[10];
                c = a / b;
            }
            catch(DivideByZeroException ex0p)
            {
                Console.WriteLine("Dosyaya yaz..Sıfıra bölünme");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("SMS Gönder...İndex out of range");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }

            
            //catch //En geneli en sonda olmalı catchlerde
            //{
            //    Console.WriteLine("İstisnai bir durum oluştu");
               
            //}
          
            Console.WriteLine("Bolmeden sonraki işlemler");
            Console.WriteLine(c);
        }
    }
}
