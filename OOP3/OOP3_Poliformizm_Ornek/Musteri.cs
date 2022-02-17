using System;

namespace OOP3_Poliformizm_Ornek
{
    public class Musteri
    {
        public int MusID { get; set; }
        public string MusAdi { get; set; }


        public override string ToString()
        {
            return MusID + " " + MusAdi;
        }
    }
}
