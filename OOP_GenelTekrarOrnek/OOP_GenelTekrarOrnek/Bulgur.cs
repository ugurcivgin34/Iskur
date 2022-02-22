using System;

namespace OOP_GenelTekrarOrnek
{
    class Bulgur : Urun, ITETT
    {
        public DateTime TETT { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" {TETT} ";
        }
    }
}
