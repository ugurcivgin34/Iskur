namespace OOP3_Poliformizm_Ornek
{
    public class Personel
    {
        public int PerID { get; set; }
        public string PerAdi { get; set; }


        //Herşeyin atası obje.Objenin ToString metodunu ezerek buraya istediğimiz ifadeyi ekrana yazdırıyoruz.
        public override string ToString()
        {
            return PerID + " " + PerAdi;
        }

      

    }
}
