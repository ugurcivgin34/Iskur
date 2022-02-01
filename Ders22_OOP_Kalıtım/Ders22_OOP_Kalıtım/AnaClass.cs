using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders22_OOP_Kalıtım
{
    class AnaClass
    {
        protected string Test;
        private int _ID;
        public int ID
        {
            get { return _ID; }
        }
        private DateTime _KayitTarihi;
        public DateTime KayitTarihi
        {
            get { return _KayitTarihi; }
            set { _KayitTarihi = value; }
        }
        public void BilgiYaz()
        {
            Console.WriteLine("ID:" + ID);
            Console.WriteLine("Kayıt Tarihi:" + KayitTarihi);
        }
        public AnaClass()
        {
            Test = "TEST";
        }
        public AnaClass(int id, DateTime kayitTarihi)
        {
            _ID = id;
            _KayitTarihi = kayitTarihi;
        }
        private DateTime _IlanTarihi;
        public DateTime IlanTarihi
        {
            get { return _IlanTarihi; }
            set { _IlanTarihi = value; }
        }
        public void IlanTarihiYaz()
        {
            Console.WriteLine("İlan Tarihi:" + _IlanTarihi);
        }
    }
}
