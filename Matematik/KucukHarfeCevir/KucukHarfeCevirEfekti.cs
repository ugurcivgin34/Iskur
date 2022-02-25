using SDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KucukHarfeCevir
{
    public class KucukHarfeCevirEfekti : ISDK
    {
        public string EklentiAdi => "Kucuk Harfe Çevir Efekti...";

        public string Islem(string str)
        {
            return str.ToLower();
        }
    }
}
