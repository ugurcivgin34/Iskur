using System;

namespace Exceptions3
{
    class BesOlamazHatasi:Exception
    {
        public override string Message => "5 olamaz istisnası...";
    }
    class Program
    {
        static void Main(string[] args)
        {
            throw new BesOlamazHatasi();
        }
    }
}
