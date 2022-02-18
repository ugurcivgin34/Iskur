using System;
using System.Collections;

namespace Interfaces
{
    interface IArayuz
    {
        void IslemA();


    }
    class Deneme : IArayuz
    {
        public void IslemA()
        {
            throw new NotImplementedException();
        }

        public void MethodA()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Deneme deneme = new Deneme();
            IArayuz arayuz = new Deneme();
            arayuz.IslemA();
           

        }
    }
}
