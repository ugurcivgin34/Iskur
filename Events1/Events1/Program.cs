using System;

namespace Events1
{
    //1-Temsilciye ihtiyaç var
    //2-O temsilci tipinden event(olay) tanımlanır...
    //3-Olayı tetikleyecek mekanizma kurulur.
    //4-Class oluşturulur
    //5-Olaya bir metod bağlanır
    //6-Çalıştır

    delegate void Temsilci();
    class Button
    {
        public event Temsilci Tikla; //return type Temsilci türünde
        public void Calistir()
        {
            if (Tikla !=null)
            {
                Tikla();
            }
        }
        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Events
            Button btn = new Button();
            btn.Tikla += Btn_Tikla;
            btn.Calistir();
           
        }

        private static void Btn_Tikla()
        {
            Console.WriteLine("Butona tıklandı...");
        }
    }
}
