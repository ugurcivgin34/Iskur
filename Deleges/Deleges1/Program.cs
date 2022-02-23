using System;

namespace Deleges1
{
    class Program
    {
        delegate int Temsilci();

        static public int MetodA()
        {
            return 4;
        }

        static public int MetodB()
        {
            return 5;
        }

        static public int MetodC()
        {
            return 6;
        }
        static void Main(string[] args)
        {
            Temsilci t = new Temsilci(MetodA);
            t += new Temsilci(MetodB);
            t += MetodB;
            
            Console.WriteLine(t());
        }
        //Eventler de bir delegedir.
    }
}
