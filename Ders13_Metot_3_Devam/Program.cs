using System;
using System.Collections.Generic;

namespace Ders13_Metot_3_Devam
{
    class Program
    {

        static List<long> TCler = new List<long>();
        static List<string> adSoyadlar = new List<string>();
        static List<string> adresler = new List<string>();
        static List<string> telefonlar = new List<string>();

        static void Main(string[] args)
        {

            //Basit bir Personel Bilgi Sistemi:
            // TC(long), adSoyad string, adres string, telefon string için birer tane liste
            // tanımlayınız. PersonelIndexGetir(tc),PersonelEkleGuncelle(başarılı ise true döndür)
            // PersonelAra: (TC veya adSoyad ile arama yapacak) tüm bilgileri tek string olarak döndür.
            //PersonelSil(tc): Remove edecek.
            //
            //Ödev: PersonelEkleGuncelle yi PersonelGuncelle ve PersonelEkle olarak yazınız. 

            int index = PersonelIndexGetir(67309105720);
            Console.WriteLine("index=" + index);
            bool basarili = PersonelEkleGuncelle(tc: 67309105720,
                                 adSoyad: "Veysel Perü",
                                 adres: "SahrayıCedit/Kadıköy...",
                                 telefon: "05327741763");
            basarili = PersonelEkleGuncelle(tc: 1111,
                               adSoyad: "Ezgi",
                               adres: "Bostancı...",
                               telefon: "05321111111");
            basarili = PersonelEkleGuncelle(tc: 22222222222,
                               adSoyad: "Şükrü",
                               adres: "Sarıgazi...",
                               telefon: "05322222222");
            basarili = PersonelEkleGuncelle(tc: 12345678910,
                               adSoyad: "Uğur Okan",
                               adres: "Bağcılar...",
                               telefon: "05323333333");
            basarili = PersonelEkleGuncelle(tc: 44444444444,
                               adSoyad: "Melike",
                               adres: "Beşiktaş...",
                               telefon: "05324444444");
            index = PersonelIndexGetir(67309105720);
            Console.WriteLine("index=" + index);

            basarili = PersonelEkleGuncelle(tc: 67309105720,
                                 telefon: "0555 5555555");
            for (int i = 0; i < TCler.Count; i++)
            {
                Console.WriteLine(TCler[i]);
                Console.WriteLine(adSoyadlar[i]);
                Console.WriteLine(adresler[i]);
                Console.WriteLine(telefonlar[i]);
            }
            Console.WriteLine(PersonelGetir(45685471025));
            Console.ReadLine();
        } // Main sonu 


        
       

        

        static string PersonelGetir(long tc=0, string adSoyad="")
        {
            int personelIndex = -1;
            string personel="";
            if (adSoyad != "") personel = "Ad soyad " + adSoyad + " bulanamadı";
            if (tc != 0) personel = "TC " + tc + " bulanamadı";
            if (tc != 0)
            {
                personelIndex = PersonelIndexGetir(tc);
            }
            else
            {
                //if (adSoyad.Contains(adSoyad))
                    personelIndex = adSoyad.IndexOf(adSoyad);
            }
            if (personelIndex != -1)
            {
                personel = Convert.ToString(TCler[personelIndex] + " " +
                    adSoyadlar[personelIndex] + " " +
                     adresler[personelIndex] + " " +
                      telefonlar[personelIndex]);
            }
            return personel;
        }
        static int PersonelIndexGetir(long tc)
        {
            int personelIndex = -1;
            if (TCler.Contains(tc))
            {
                personelIndex = TCler.IndexOf(tc);
            }
            return personelIndex;
        }

        private static bool PersonelEkleGuncelle(long tc = 0, string adSoyad = "", string adres = "", string telefon = "")
        {
            int personelIndex = -1;
            if (tc < 10000000000 || tc > 99999999999)
            {
                Console.WriteLine("TC formatı yanlış. (" + tc + ")  Entera basınız.");
                Console.ReadLine();
                return false;
            }
            if (tc == 0)
            {
                Console.WriteLine("TC sıfır olamaz. Entera basınız.");
                Console.ReadLine();
                return false;
            }
            else
            {
                personelIndex = PersonelIndexGetir(tc);
                if (personelIndex == -1)       // Personel yok, o zaman ekleyeceğiz.
                {
                    if (adSoyad == "")
                    {
                        Console.WriteLine("Ad Soyad boş olamaz. Entera basınız.");
                        Console.ReadLine();
                        return false;
                    }
                    TCler.Add(tc);
                    adSoyadlar.Add(adSoyad);
                    adresler.Add(adres);
                    telefonlar.Add(telefon);
                }
                else   // TC var, o zaman güncelle!
                {
                    if (adSoyad != "") adSoyadlar[personelIndex] = adSoyad;
                    if (adres != "") adresler[personelIndex] = adres;
                    if (telefon != "") telefonlar[personelIndex] = telefon;
                }
            }
            return true;
        }


    }
}

