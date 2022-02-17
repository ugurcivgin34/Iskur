using System;
using System.Collections;

namespace SortedListtt
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();
            sortedList.Add(34, "İstanbul");
            sortedList.Add(23, "Elazığ");

            Console.WriteLine(sortedList.GetByIndex(0));
           
        }
    }
}
