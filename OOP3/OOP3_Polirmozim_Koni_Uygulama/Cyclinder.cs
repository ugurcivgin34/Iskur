namespace OOP3_Polirmozim_Circle_Uygulama
{
    class Cyclinder : Circle
    {
        protected double h;
        public Cyclinder(double r, double h) : base(r)
        {
            this.h = h;

        }
        public override double AlanHesapla()
        {
            return base.AlanHesapla() * h;
        }
    }
}
