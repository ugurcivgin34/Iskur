using System;
using System.IO;

namespace OOP2_ClassTurleri
{
    abstract class Sekil
    {
        public string Renk { get; set; }

    }
    class Daire : Sekil
    {

    }
    class Silindir : Daire
    {

    }
    sealed class Koni : Silindir
    {

    }
    static class Veritabani
    {
        public static void Kaydet() { }
    }

    class Baglan
    {
        public static void ConnectinonString(string str) { }
    }

    //sealed olduğu için türetme yapamayız
    //class KesikKoni:Koni
    //{

    //}

    class Program
    {
        static void Main(string[] args)
        {
            //Abstract
            //Sekil sekil = new Sekil();

            Veritabani.Kaydet();


            //Statik olan metod statik bellekte tultulduğu için insteans dan böyle erişemeyiz
            Baglan baglan = new Baglan();

            Baglan.ConnectinonString("Okan");

            int[] sayilar = { 45, 120, 35, 30 };

              
            
        }
    }
}
