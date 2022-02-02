using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders22_OOP_Kalıtım.Sahibindencom
{
    class Dizustu : Bilgisayar
    {
        private string _EkranBoyutu;
        private float _Agirlik;
        public float Agirlik { get => _Agirlik; set => _Agirlik = value; }
        public string EkranBoyutu { get => _EkranBoyutu; set => _EkranBoyutu = value; }
        new public void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine("Marka:" + base.Marka);
            Console.WriteLine("İşlemci:" + base.Islemci);
            Console.WriteLine("Bellek:" + base.Bellek);
            Console.WriteLine("HDD:" + base.HDD);
            Console.WriteLine("SSD:" + base.SSD);
            string eth = "Yok";
            string wifi = "Yok";
            if (base.EthernetVarMi)
                eth = "Var";
            if (base.WifiVarMi)
                wifi = "Var";
            Console.WriteLine("Ethernet:" + eth);
            Console.WriteLine("Wifi:" + wifi);
            Console.WriteLine("Ekran Boyutu:" + _EkranBoyutu);
            Console.WriteLine("Ağırlık:" + _Agirlik);


        }
    }
}
