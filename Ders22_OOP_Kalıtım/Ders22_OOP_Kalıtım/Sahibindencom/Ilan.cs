using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders22_OOP_Kalıtım.Sahibindencom
{
    enum Kategori
    {
        Masaüstü_Bilgisayar,
        Diziüstü_Bilgisayar,
        Temizlik_Ürünü
    }
    class Ilan
    {
        //Ilan : IlanNo , Baslik , IlanTarihi,
        // Kategori :, Fiyat , Satıcı( Kullanıcı sınıfından)
        //BilgiYaz , IndırımYap(yuzde)
        private long _IlanNo;
        public long IlanNO
        {
            get { return _IlanNo; }
            set
            {
                try
                {
                    _IlanNo = value;
                }
                catch
                {
                    Console.WriteLine("Atama yapılamadı.");

                }
            }
        }
        private string _Baslik;
        private DateTime _IlanTarihi;
        private Kategori _Kategori;
        private double _Fiyat;
        private Kullanıcılar _Satici;

        public string Baslik
        { get => _Baslik; set => _Baslik = value; }

        public DateTime IlanTarihi
        { get => _IlanTarihi; set => _IlanTarihi = value; }

        public Kategori Kategori
        { get => _Kategori; set => _Kategori = value; }

        private double Fiyat
        { get => _Fiyat; set => _Fiyat = value; }

        public Kullanıcılar Satici
        { get => _Satici; set => _Satici = value; }
    }
}
