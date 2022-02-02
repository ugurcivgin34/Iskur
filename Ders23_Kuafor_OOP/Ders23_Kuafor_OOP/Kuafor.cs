using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders23_Kuafor_OOP
{
    enum Hizmetler
    {
        Saç_Traşı,
        Sakal_Traşı,
        Saç_Yıkama,
        Cilt_Bakımı
    }
    class Kuafor
    {
        //enum Hizmetler: Saç Traşı, Sakal Traşı, Saç Yıkama, Cilt Bakımı
        //Saç Traşı: 20, Sakal Traşı:15, Saç Yıkama:10, Cilt Bakımı:30
        //
        // Metotlar: SacTrasiYap(), SakalTrasiYap, SacYika(), CiltBakimiYap()

        public float SacTrasiUcreti { get; set; }
        public float SakalTrasiUcreti { get; set; }
        public float SacYikamaUcreti { get; set; }
        public float CiltBakimiUcreti { get; set; }

        public Kuafor()
        {
            SacTrasiUcreti = 20;
            SakalTrasiUcreti = 15;
            SacYikamaUcreti = 10;
            CiltBakimiUcreti = 30;
        }
        private List<Hizmetler> alinanHizmetler = new List<Hizmetler>();
        private float toplamUcret;

        public void SacTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Traşı);
            toplamUcret += SacTrasiUcreti;
        }
        public void SakalTrasiYap()
        {
            alinanHizmetler.Add(Hizmetler.Sakal_Traşı);
            toplamUcret += SakalTrasiUcreti;
        }
        public void SacYikamaYap()
        {
            alinanHizmetler.Add(Hizmetler.Saç_Yıkama);
            toplamUcret += SacYikamaUcreti;
        }
        public void CiltBakimiYap()
        {
            alinanHizmetler.Add(Hizmetler.Cilt_Bakımı);
            toplamUcret += CiltBakimiUcreti;
        }

        public void BilgiYaz()
        {
            Console.WriteLine("Aşağıdaki Hizmetleri aldınız:");
            foreach (var item in alinanHizmetler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Toplam Tutar:" + toplamUcret);
        }

    }
}
