using System;
using System.Collections;

namespace HashTablee
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(34, "İstanbul");
            hashtable.Add(23, "Elazığ");
            hashtable.Add(01, "Adana");

            Console.WriteLine(hashtable[34]);

          

        }
    }
}
