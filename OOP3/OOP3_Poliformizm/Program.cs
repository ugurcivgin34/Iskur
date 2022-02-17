using System;

namespace OOP3_Poliformizm
{

    //Girilen 10 luk tabanda sayının 2 lik tabana çeviren program => (72)10 = (?)2
    //100 kişilik bir sınıfta öğrenciler 1-10 arası not alıyor.Rastgele not alacaklar.Notların frekansını bulun. 
    class Araba
    {
        public virtual void Sur()
        {
            Console.WriteLine("Araba sür...");
        }
    }
    class Ferrari : Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Ferrari sür..");
        }
    }

    class Mercedes : Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Mercedes sür..");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Araba araba = new Araba();
            //Ferrari ferrari = new Ferrari();
            //Mercedes mercedes = new Mercedes();
            Araba araba = new Araba();
            Araba ferrari = new Ferrari();
            Araba mercedes = new Mercedes();

            araba.Sur();
            ferrari.Sur();
            mercedes.Sur();

            //Object obj = new Ferrari();
            //((Ferrari)obj).Sur();
        }
    }
}
