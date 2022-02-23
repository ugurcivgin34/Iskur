namespace Events3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Events-Depo
            //Soru:Kapasitesi 10 olan bir depoya, ürün ekleme ve çıkarma işlemleri yapılacaktır.Deponun içinde ürün kalmadığında veya depo
            //dolduğunda calisacak olayların tanımlanası istenmektedir.Ayrıca depo içerisindeki tüm ürünlerin listesini veren depo sınıfını yazınız ?
            //}

            Depo depo = new Depo(10);
            depo.DepoDolu += Depo_DepoDolu;
            depo.DepoBos += Depo_DepoBos;


            Urun urun = new Urun() { UrunID = 123, UrunAdi = "Kalem", Fiyat = 12 };

            for (int i = 0; i < 13; i++)
            {
                depo.Ekle(urun);
                foreach (Urun u in depo)
                {
                    System.Console.WriteLine(u);
                }
                System.Console.WriteLine();
            }
            for (int i = 0; i < 15; i++)
            {
                depo.Cikar(urun);
                foreach (Urun u in depo)
                {
                    System.Console.WriteLine(u);
                }
                System.Console.WriteLine();
            }
        }

        private static void Depo_DepoBos(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("Depo BOŞ");
        }

        private static void Depo_DepoDolu(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("Depo DOLU");
        }
    }
}