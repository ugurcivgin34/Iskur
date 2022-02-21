using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_GenelTekrarOrnek
{
    
    abstract class Urun:IEnumerable
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }

      

       

        public IEnumerator GetEnumerator()
        {
            return UrunId + "" + UrunAdi;
        }
    }

 
    class Gıda:Urun
    {
        public DateTime SonKullanmaTarihi { get; set; }

    }
    class SutUrunleri:Gıda,IBozabilir,IKisitliTarih
    {

    }
    class HayvanUrunleri:Gıda, IBozabilir, IKisitliTarih,IKirilabilir
    {

    }

    class Eşya:Urun ,IKirilabilir
    {

    }
    interface IKirilabilir
    {

    }
    interface IBozabilir
    {

    }
    interface IKisitliTarih
    {

    }
}
