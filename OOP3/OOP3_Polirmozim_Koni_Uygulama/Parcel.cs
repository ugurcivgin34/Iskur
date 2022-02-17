namespace OOP3_Polirmozim_Circle_Uygulama
{
    class Parcel : Cyclinder
    {
        public Parcel(double r, double h) : base(r, h)
        {

        }
        public override double AlanHesapla()
        {
            return base.AlanHesapla() * 0.333;
        }
    }
}
