using System;
using System.Collections;

namespace OOP2_Static_Ornek
{
    class Asker
    {
        //Statik bölgede tutarız ki sürekli ordan alsın , new lediğimizde normalde 0 lanacak hep .Bu yüzden statik kullandık
        static int sayac = 0;

        public Asker()
        {
            sayac++;
            Console.WriteLine(sayac);
        }

        ~Asker()
        {
            sayac--;
            Console.WriteLine(sayac);
        }
    }
    //T anında ram ' de herhangi bir class ta kaç tane olduğunu nasıl buluruz
    class Program
    {
        static void Main(string[] args)
        {
            Asker a1 = new Asker();
            Asker a2 = new Asker();
            Asker a3 = new Asker();
           
        }
    }
}
