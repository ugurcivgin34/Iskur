using System;
using System.Threading;

namespace Interfaces_Devam_4
{
    public interface IBoyanabilir
    {

    }

    class Boyahane
    {
        public void Boya(IBoyanabilir arac, ConsoleColor yeniRenk)
        {
            Arac a = (Arac)arac;
            a.Renk = yeniRenk;

            Console.ForegroundColor = a.Renk;
            Console.WriteLine(a.GetType().Name + " boyandı....");
        }
    }

    abstract class Arac
    {
        public ConsoleColor Renk { get; set; }

        public Arac()
        {
            Random rnd = new Random();
            Thread.Sleep(100);
            Renk = (ConsoleColor)rnd.Next(1, 15);
        }
    }

    class Ferrari : Arac, IBoyanabilir
    {
        public Ferrari()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Ferrari");
        }
    }

    class Mustang : Arac, IBoyanabilir
    {
        public Mustang()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("Mustang");
        }
    }
    class BMX : Arac
    {
        public BMX()
        {
            Console.ForegroundColor = Renk;
            Console.WriteLine("BMX");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ferrari f = new Ferrari();
            Mustang m = new Mustang();
            BMX bmx = new BMX();

            Boyahane boyahane = new Boyahane();
            boyahane.Boya(f, ConsoleColor.Red);
            boyahane.Boya(m, ConsoleColor.Cyan);


            
            //boyahane.Boya(bmx);
        }
    }
}
