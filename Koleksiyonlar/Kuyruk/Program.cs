using System;
using System.Collections;

namespace Kuyruk
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(12);
            queue.Enqueue(22);
            queue.Enqueue(32);

            Console.WriteLine(queue.Peek());
            queue.Dequeue();

            Console.WriteLine(queue.Peek());

        }
    }
}