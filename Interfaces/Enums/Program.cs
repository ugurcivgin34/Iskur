using System;

namespace Enums
{
    //-Numeric ile string leri birleştirmek için kullanılır.
    //-Enumlar sadece tam sayı üzerinde çalışır
    //-Bir enum ile çalıştığımızda varsayılan tipi int dir, fakat public enum Gunler : byte {---}
    //    şeklinde yaparsak artık veri tipi byte olmuş olacak

    public enum Gunler
    {
        Pazartesi, Salı = 10, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
    }

    //public enum Gunler:byte
    //{
    //    Pazartesi, Salı = 10, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
    //}

    class Hafta
    {

        public Gunler Gun { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 16; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("Merhaba");
            }

            Console.WriteLine((int)Gunler.Pazartesi);
            Hafta hafta = new Hafta();
            hafta.Gun = Gunler.Pazartesi;
            hafta.Gun = (Gunler)1;


        }
    }
}
