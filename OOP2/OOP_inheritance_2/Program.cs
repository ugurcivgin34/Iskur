using System;

namespace OOP_inheritance_2
{
    class Daire
    {
        public double R { get; set; }
        public double DaireAlanHesapla()
        {
            return Math.PI * R * R;
        }
    }

    class Silindir : Daire
    {
        public double H { get; set; }

        public double SilindirHacimHesapla()
        {
            return base.DaireAlanHesapla() * H;
        }
    }

    class Koni : Silindir
    {
        public double KoniHacimHesapla()
        {
            return base.SilindirHacimHesapla() * 0.333;
        }
    }

    class Circle
    {
        protected double r;
        public Circle(double r)
        {
            this.r = r;
        }

        public double DaireAlanHesapla()
        {
            return Math.PI * r * r;
        }

    }
    class Cyclinder : Circle
    {
        protected double h;
        public Cyclinder(double r, double h) : base(r)
        {
            this.h = h;

        }
        public double SilindirHacimHesapla()
        {
            return base.DaireAlanHesapla() * h;
        }
    }

    class Parcel : Cyclinder
    {
        public Parcel(double r, double h) : base(r, h)
        {

        }
        public double KoniHacimHesapla()
        {
            return base.SilindirHacimHesapla() * 0.333;
        }
    }


    class Personel
    {
        public Personel()
        {
            Console.WriteLine("Personel Sınıfı Oluştu...");
        }
    }
    class Mudur : Personel
    {
        public Mudur()
        {
            Console.WriteLine("Müdür Sınıfı Oluştu...");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire() { R = 3 };
            Console.WriteLine(daire.DaireAlanHesapla());

            Silindir silindir = new Silindir() { R = 3, H = 10 };
            Console.WriteLine(silindir.SilindirHacimHesapla());

            Koni koni = new Koni() { R = 3, H = 10 };
            Console.WriteLine(koni.KoniHacimHesapla());

            Console.WriteLine("---------------------------------------");

            Circle circle = new Circle(3);
            Console.WriteLine(circle.DaireAlanHesapla());

            Cyclinder cyclinder = new Cyclinder(3, 10);
            Console.WriteLine(cyclinder.SilindirHacimHesapla());

            Parcel parcel = new Parcel(3, 10);
            Console.WriteLine(parcel.KoniHacimHesapla());


            Console.WriteLine("----------------------");

            Personel personel = new Personel();
            Mudur mudur = new Mudur();


        }
    }
}
