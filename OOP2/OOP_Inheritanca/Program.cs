using System;

namespace OOP_Inheritanca
{

    class Asker
    {
        public int SicilNo { get; set; }
        public string Vazife { get; set; }

        protected void Islem()
        {

        }

    }
    class Insan
    {

    }
    class Er :Asker
    {
        public Er()
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Asker asker = new Asker();
            Er er = new Er();
            
            
        }
    }
}
