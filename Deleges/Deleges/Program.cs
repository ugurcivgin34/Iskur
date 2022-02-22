using System;

namespace Deleges
{
    class Program
    {
        public delegate void Temsilci();
        public static void Mesaj()
        {
            Console.WriteLine("Mesaj");
        }
        public static void Gunaydin()
        {
            Console.WriteLine("Günaydın");
        }

        public static void Merhaba(string str)
        {
            Console.WriteLine("Merhaba" + str);
        }
        public static string Hi()
        {
            return "Hi!";
        }

        static void Main(string[] args)
        {

            Temsilci t = new Temsilci(Mesaj);
            t += Mesaj; 
            t += Gunaydin;
            //t += Hi; Return type yanlış..
            //t += Merhaba; İmzası farklı
            //t -= Mesaj;

            //t();//Metodları çağırma işlemini burda yapıyoruz

            foreach (Delegate del in t.GetInvocationList())
            {
                //Console.WriteLine(del.Method.Name);
                if (del.Method.Name !="Mesaj")
                {
                    del.DynamicInvoke(); 
                }
            }
            




        }
    }
}
