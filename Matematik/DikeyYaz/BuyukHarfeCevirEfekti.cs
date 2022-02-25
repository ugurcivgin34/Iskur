using SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukHarfeCevir
{
    public class BuyukHarfeCevirEfekti : ISDK
    {
        public string EklentiAdi => "Buyuk Harfe Çevir Efekti...";

        public string Islem(string str)
        {
           return str.ToUpper();
        }
    }
}
