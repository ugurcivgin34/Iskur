using System;

namespace Interface_Devam_6
{
    //solId = interface segregation  , interfacei parçalama 
    interface IArayuz
    {
        void IslemA();
        void IslemB();
        void IslemC();
        void IslemD();

    }

    interface IArayuzII
    {
        void IslemA();
    }

    interface IArayuzIII:IArayuzII
    {
        void IslemB();
    }

    class A : IArayuz
    {
        public void IslemA()
        {
            throw new NotImplementedException();
        }

        public void IslemB()
        {
            throw new NotImplementedException();
        }

        public void IslemC()
        {
            throw new NotImplementedException();
        }

        public void IslemD()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            
        }
    }
}
