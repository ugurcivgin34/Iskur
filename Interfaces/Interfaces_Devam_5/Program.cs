using System;
using System.Collections;

namespace Interfaces_Devam_5
{
    interface IYuzebilir
    {
        void Yuz();
    }

    interface IYuruyebilir
    {
        void Yuru();
    }

    interface IUcabilir
    {
        void Uc();
    }

    class Penguen : IYuruyebilir, IYuzebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }

    class Pelikan : IYuzebilir, IYuruyebilir, IUcabilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }

    class Hamsi : IYuzebilir
    {
        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }

    class Kedi : IYuruyebilir
    {
        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }

    class Kanarya : IUcabilir, IYuzebilir
    {
        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            liste.Add(new Penguen());
            liste.Add(new Pelikan());
            liste.Add(new Hamsi());
            liste.Add(new Kedi());
            liste.Add(new Kanarya());

            foreach (object obj in liste)
            {
                if (obj is IYuzebilir)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
            Console.WriteLine("------------------------------");
            foreach (object obj in liste)
            {
                if (obj is IUcabilir)
                {
                    Console.WriteLine(obj.ToString());
                }
            }
        }
    }
}
