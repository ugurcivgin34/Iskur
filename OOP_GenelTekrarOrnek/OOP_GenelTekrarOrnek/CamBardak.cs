using System;

namespace OOP_GenelTekrarOrnek
{
    class CamBardak : Urun, IKirilabilir
    {
        public bool Kirik { get; set; }

        public override string ToString()
        {
            return base.ToString() + $" {Kirik} ";
        }
    }
}
