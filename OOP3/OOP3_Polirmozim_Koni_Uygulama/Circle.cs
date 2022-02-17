using System;

namespace OOP3_Polirmozim_Circle_Uygulama
{
    class Circle
    {
        protected double r;
        public Circle(double r)
        {
            this.r = r;
        }

        public virtual double AlanHesapla()
        {
            return Math.PI * r * r;
        }

    }
}
