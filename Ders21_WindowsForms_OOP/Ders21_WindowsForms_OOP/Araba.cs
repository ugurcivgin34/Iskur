using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders21_WindowsForms_OOP
{
    class Araba
    {
        public int ID;
        public string Marka;
        public string Model;

        public Araba()
        {
            MessageBox.Show("Yapıcı metot çalıştı");
        }

        public Araba(int ID,string marka , string model)
        {
            MessageBox.Show("3 parametreli yapıcı metot çalıştı");
            this.ID = ID;
            Marka = marka;
            Model = model;
        }

        public void BilgiYaz()
        {
            MessageBox.Show("Marka:" + this.Marka);
            MessageBox.Show("Marka:" + this.Model);
       
        }
    }
}
