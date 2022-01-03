using System;

namespace Ders3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type a = typeof(int);
            //Console.WriteLine(a);
            //------------------------------------------------------------------
            //Console.WriteLine("Lütfen cinsiyetinizi yazınız (e,h):");
            //char cins = Convert.ToChar(Console.ReadLine());
            //if(cins =='a')
            //{
            //    Console.WriteLine("Erkeksiniz");
            //} else if(cins =='h')
            //{
            //    Console.WriteLine("Bayansınız");
            //} else
            //{
            //    Console.WriteLine("Cinsiyetinizi doğru giriniz");
            //}

            //Klavyeden girilen öğrencinin 2 adet not bilgisi girildikten sora , ortalama 50 ve üzerinde ise ekrana geçti değilse kaldı

            //double ilkNot = Convert.ToDouble(Console.ReadLine());
            //double ikinciNot = Convert.ToDouble(Console.ReadLine());

            //double     ortalama = (ilkNot + ikinciNot) / 2;

            //if(ortalama>50)
            //{
            //    Console.WriteLine("Geçti");
            //} else
            //{
            //    Console.WriteLine("Kaldı");
            //}

            //_--------------------------------------------



            //BElirlenen kullanıcı adı ve şifre girildiğinde giriş başarılı yanlış girdiğinde şifre ve kuıllancı adı yanlış 
            //Console.WriteLine("Kullanıcı adını giriniz");
            //String ad = Console.ReadLine();


            //Console.WriteLine("Şifreyi giriniz");
            //String password = Console.ReadLine();

            //if(ad=="okan" && password == "123okan")
            //{
            //    Console.WriteLine("Giriş başarılı");
            //} else
            //{
            //    Console.WriteLine("Kullanıdı adı ve şifre hatalı");
            //}





            //int[] sayiDizisi = new int[10];
            //int toplam = 0;
            //for (int i = 0; i < sayiDizisi.Length; i++)
            //{
            //    Console.Write("Lütfen {0}. sayıyı girin:", i +1);
            //    sayiDizisi[i] = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayiDizisi[i];
            //}
            //double ortalama = toplam / 20;
            //Console.WriteLine("Sayıların ortalaması: " + ortalama);
            //Console.ReadLine();


            //Bir mağazada alınan  ürünün fiyatı 100 TL ve üzerinde ise 5 TL olan kargo ücreti alınmamaktadır.Ürünün fiyatı girildiğinde toplam ödenmesi gereken tutarı gösteren program

            //int ürün;
            //int toplam ;
            //Console.WriteLine("Alacağınız ürün fiyatı ne kadardır : ");
            //ürün = Convert.ToInt32(Console.ReadLine());
            //if (ürün >= 100)
            //{
            //    toplam = ürün;
            //}
            //else
            //{

            //    toplam = ürün + 5;
            //}
            //Console.WriteLine("Toplam sonuç " + toplam);


            //----------------------------------------------------------

            //Console.Write("Klavyeden bir sayı giriniz");
            //int sayi = int.Parse(Console.ReadLine());

            //if(sayi>0)
            //{
            //    Console.WriteLine("Sayı Pozitifdir");
            //} else if (sayi<0)
            //{
            //    Console.WriteLine("Sayı Negatifdir");
            //}  else
            //{
            //    Console.WriteLine("Sayı 0 dır");
            //}

            //Kullanıcıdan girdiği iki sayı ve yapılacak işler türü(toplama,çıkarma,çarpma,bölme) seçildiğinde sonucu hesaplayan programı yapınız 

            //Console.Write("İlk sayıyı giriniz :");
            //double sayi1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz :");
            //double sayi2 = Convert.ToDouble(Console.ReadLine());

            //double toplam, cikarma, carpma, bölme;

            //Console.Write("Yapmak istediğini işlemi belirtiniz (toplama=>1,çıkarma=>2,çarpma=>3,bölme=>4)");
            //int ifade = Convert.ToInt32(Console.ReadLine());

            //if (ifade == 1)
            //{
            //    toplam = sayi1 + sayi2;
            //    Console.Write("Toplam Sonucu : " + toplam);
            //}
            //else if (ifade == 2)
            //{
            //    cikarma = sayi1 - sayi2;
            //    Console.Write("Toplam Sonucu : " + cikarma);
            //}
            //else if (ifade == 4)
            //{
            //    if (sayi2 == 0)
            //    {
            //        Console.WriteLine("Payda 0 olduğu için bu ifade hatalı olur");
            //    }
            //    else
            //    {
            //        bölme = sayi1 / sayi2;
            //        Console.Write("Toplam Sonucu : " + bölme);
            //    }
            //}
            //else
            //{
            //    carpma = sayi1 * sayi2;
            //    Console.Write("Toplam Sonucu : " + carpma);

            //}

            //-------------------------------------------------------------------------------


            //Klavyeden iki ürünün fiyatı girildiğinde toplam fiyatı 200 TL'den fazla ise , 2.üründen %25 indirim yaparak ödenecek tutarı gösteren uygulamayı yapalım

            //Console.Write("İlk ürünün fiyatını giriniz :");
            //double ilkUrun = double.Parse(Console.ReadLine());

            //Console.Write("İkinci ürünün fiyatını giriniz :");
            //double ikinciUrun = double.Parse(Console.ReadLine());
            //double toplam = 0;


            //toplam = ilkUrun + ikinciUrun;

            //if (toplam > 200)
            //{
            //    if (ilkUrun > ikinciUrun)
            //    {
            //        ikinciUrun = ikinciUrun - (ikinciUrun * 0.25);
            //        toplam = ilkUrun + ikinciUrun;
            //        Console.WriteLine("ikinci üründen indirim yapıldı " + toplam + "'dir");
            //    }
            //    else
            //    {
            //        ilkUrun = ilkUrun - (ilkUrun * 0.25);
            //        toplam = ilkUrun + ikinciUrun;
            //        Console.WriteLine("ilk üründen indirim yapıldı " + toplam + " 'dir");
            //    }

            //int gün = (int)DateTime.Now.DayOfWeek;
            //Console.Write("Bugün günlerden: ");
            //switch (gün)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;
            //    default:
            //        break;
            //}

            //-----------------------------------------------------------------------------

            //Kullanıcıya kaçıncı ayda olduğunu sorarak , hangi mevsimde bulunduğunu gösteren program

            //    Console.Write("Kaçıncı ayda olduğunuzu giriniz :");
            //    int ay = Convert.ToInt32(Console.ReadLine());
            //    switch (ay)
            //    {
            //        case 12:
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Kış Mevsimi");
            //            break;
            //        case 3:
            //        case 4:
            //        case 5:
            //            Console.WriteLine("İlkbahar Mevsimi");
            //            break;
            //        case 6:
            //        case 7:
            //        case 8:
            //            Console.WriteLine("Yaz Mevsimi");
            //            break;
            //        case 9:
            //        case 10:
            //        case 11:
            //            Console.WriteLine("Sonbahar Mevsimi");
            //            break;
            //        default:
            //            Console.WriteLine("Ay bilgisini yanlış girdiniz ");
            //            break;
            //    }



            //}

            //Klavyeden giriş yapılan mevsim adına göre o mevsimde yer alan ayları ekrana yazdıran c# console programını yazınız

            //Console.Write("Mevsim adını giriniz :");
            //string mevsim = Console.ReadLine();

            //switch (mevsim)
            //{
            //    case "sonbahar":
            //        Console.WriteLine("Eylül,Ekim,Kasım");
            //        break;

            //    case "kış":
            //        Console.WriteLine("Aralık,Ocak,Şubat");
            //        break;

            //    case "ilkbahar":
            //        Console.WriteLine("Mart,Nisan,Mayıs");
            //        break;

            //    case "yaz":
            //        Console.WriteLine("Haziran,Temmuz,Ağustos");
            //        break;
            //    default:
            //        Console.WriteLine("Farklı bir ifade girdiniz");
            //        break;
            //}

            //---------------------------------------------------------------

            //Klavyeden girilen trafik lambası renjlerine göre ekrana ne yapılacağını yazan programı switch yapısıyla oluşturunuz 
            //Console.WriteLine("Renk belirtiniz");
            //string renk = Console.ReadLine();


            //switch (renk)
            //{
            //    case "kırmızı":
            //        Console.WriteLine("Dur");
            //        break;
            //    case "sarı":
            //        Console.WriteLine("Bekle");
            //        break;
            //    case "yeşil":
            //        Console.WriteLine("Geç");
            //        break;

            //    default:
            //        Console.WriteLine("Farklı renk girdiniz");
            //        break;
            //}

            //------------------------------------------------------------------

            //Kullanıcı tarafından girilen iki sayıyı yapılan işlem seçimine göre uygun işlemlerin yapılmasını sağlayan  c# console uyguması
            //Console.Write("İlk sayıyı giriniz:");
            //int sayi1 = int.Parse(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz:");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int sonuc = 0;

            //Console.WriteLine("Yapmak istediğiniz işlemi belirtiniz ");
            //char ifade = char.Parse(Console.ReadLine());

            //switch (ifade)
            //{
            //    case '+':
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Seçilen işleme göre sonuç " + sonuc + "'dır");
            //        break;

            //    case '-':
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Seçilen işleme göre sonuç " + sonuc + "'dır");
            //        break;
            //    case '*':
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Seçilen işleme göre sonuç " + sonuc + "'dır");
            //        break;
            //    case '/':
            //        if(sayi2==0)
            //        {
            //            Console.WriteLine("İkinci sayı bölme işleminde 0 olamaz");
            //        }else
            //        {
            //            sonuc = sayi1 / sayi2;
            //            Console.WriteLine("Seçilen işleme göre sonuç " + sonuc + "'dır");
            //        }

            //        break;
            //    default:
            //        Console.WriteLine("Farklı bir işlem seçtiniz ");
            //        break;


            //}

            //Klavyeden girilen bir karakterin sesli bir harf mi yoksa sessiz  bir harf mi olduğunu tespit ekrana yazan pgoram
            Console.Write("Bir harf giriniz");
            char ifade = char.Parse(Console.ReadLine());

            switch (ifade)
            {
                case 'a':
                    Console.WriteLine("Sesli harfdir");
                    break;
                case 'e':
                    Console.WriteLine("Sesli harfdir");
                    break;
                case 'ı':
                    Console.WriteLine("Sesli harfdir");
                    break;
                case 'i':
                    Console.WriteLine("Sesli harfdir");
                    break;
                case 'o':
                    Console.WriteLine("Sesli harfdir");
                    break;
                case 'ö':
                    Console.WriteLine("Sesli harfdir");
                    break;
                case 'u':
                    Console.WriteLine("Sesli harfdir");
                    break;
                case 'ü':
                    Console.WriteLine("Sesli harfdir");
                    break;
                default:
                    Console.WriteLine("Sessiz harfdir");
                    break;
            }




        }
    }
}
