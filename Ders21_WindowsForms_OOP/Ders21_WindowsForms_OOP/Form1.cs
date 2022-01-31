using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders21_WindowsForms_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Araba arabaNesnesi = new Araba();
            //arabaNesnesi.ID = 1;
            //arabaNesnesi.Marka = "Mazda";
            //arabaNesnesi.Model = "6";
            //arabaNesnesi.BilgiYaz();

            //Araba araba2 = new Araba(2,"Mercedes","S500");
            //araba2.BilgiYaz();

            Ogretmen ogretmen1 = new Ogretmen();
            ogretmen1.Ad = "Mustafa";
            ogretmen1.Soyad = "Kılıç";


            Ogrenci o = new Ogrenci();
            o.TcKimlikNo = 67309105720;
            o.Ad = "Veysel";
            o.Soyad = "Perü";
            o.SinifOgretmeni = ogretmen1;
            o.OkulNo = "452";

            Ogrenci o2 = new Ogrenci();
            o2.TcKimlikNo = 11111111111;
            o2.Ad = "Aysel";
            o2.Soyad = "Demir";
            o2.SinifOgretmeni = ogretmen1;

            Ogrenci o3 = new Ogrenci();
            o3.TcKimlikNo = 11111111111;
            o3.Ad = "Hakan";
            o3.Soyad = "Demir";
            o3.SinifOgretmeni = ogretmen1;

            ogretmen1.ogrenciler.Add(o);
            ogretmen1.ogrenciler.Add(o2);
            ogretmen1.ogrenciler.Add(o3);

            //o.BilgiYaz(listBox1);
            //o.SinifOgretmeniDegistir(ogretmen1);
            //o.BilgiYaz(listBox1);
            ogretmen1.OgrenciListele();





        }
    }
}
