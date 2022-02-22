using System;

namespace OOP_GenelTekrarOrnek
{
    class Sut : Urun, IBozulabilir
    {
        public DateTime SKT { get ; set ; }
        public string Tipi { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{SKT} {Tipi}";
        }
    }
}
