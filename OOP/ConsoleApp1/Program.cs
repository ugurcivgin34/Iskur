using System;

namespace ConsoleApp1
{
    class Personel
    {
        private int id;

        public int getID()
        {
            return id;
        }

        public void setID(int _id)
        {
            id = _id;
        }

        //Özellik
        string _perAd;
        public string PerAd
        {
            get { return _perAd; }
            set { _perAd = value; }
        }

        //c# 3.0 sonrası
        public decimal Maas { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Class members
            //1-Variable
            //2-Methods
            //3-Property
            Personel p = new Personel();
           
            
        }
    }
}
