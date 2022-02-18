using System;
using System.Collections;

namespace Interfaces_Devam_2
{
    class Urun : IComparable
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object obj)
        {
            Urun urun = (Urun)obj;
            return -1*UrunID.CompareTo(urun.UrunID); //Küçükten büyüğe sıraladıktan sonra tersini istiyorsak -1 ile çarparız
        }

        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList() { 45, 33, 56, 4, 22, 17 };

            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------------");

            ArrayList list1 = new ArrayList() {"Zonguldak","Ankara","Niğde","Adana" };
            list1.Sort();
            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            ArrayList list3 = new ArrayList() { 
                new Urun{UrunID=24,UrunAdi="Kalem",Fiyat=20 },
                new Urun{UrunID=12,UrunAdi="Defter",Fiyat=25},
                new Urun{UrunID=45,UrunAdi="Silgi",Fiyat=10}
            };

        

            
           
            foreach (Urun item in list3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
