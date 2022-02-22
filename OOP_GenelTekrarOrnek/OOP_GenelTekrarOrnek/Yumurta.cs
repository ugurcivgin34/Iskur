using System;

namespace OOP_GenelTekrarOrnek
{
    class Yumurta : Urun, IKirilabilir, IBozulabilir
    {
        public DateTime SKT { get; set; }
        public bool Kirik { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{SKT} {Kirik}";
        }
    }
}
