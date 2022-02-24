using System;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=10, b=0, c = 0;
            try
            {
                c = a / b;
                Console.WriteLine("İstisnadan Sonra...");
            }
            catch(Exception ex)
            {
                Console.WriteLine("İstisnai durum");
            }
            finally //Bir exception oluştuğunda mutlaka yapılmasını istediğimiz bir işlem varsa ,o kodu finally bloğunun içine atıyoruz.
            //Her türlü çalışır.Genellikle veritabanı işlemlerinde kullanırız.Kapatmak için.
            {
                Console.WriteLine("Ne olursa olsun çalış...");
            }
        }
    }
}
