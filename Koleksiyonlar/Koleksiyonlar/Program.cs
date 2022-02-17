using System;
using System.Collections;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList(50); //kapasiteyi bizde belirleyebiliriz.new ArrayList(50); 50 yazarak kapasiteyi 50 yaparız

            for (int i = 0; i < 5; i++)
            {
                liste.Add(12);
            }
            //Console.WriteLine(list.Count);
            //Console.WriteLine(list.Capacity);

            //Console.WriteLine("Adet={0} Kapasite={1}" , liste.Count, liste.Capacity);

            //Console.WriteLine($"Adet={liste.Count} Kapasite={liste.Capacity}");

            
            liste[2] = "11";


            //Stack:LIFO 
            Stack stack = new Stack();
            stack.Push(12);
            stack.Push(32);
            stack.Push(50);
            
            Console.WriteLine(stack.Peek()); //Stack de eleman çıkarmadan en üstte kim var ona bakar
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());




         }
    }
}
