using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SDK;

namespace WndTextShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, ISDK> efektler = new Dictionary<string, ISDK>();
        private void btnUygula_Click(object sender, EventArgs e)
        {
            ISDK effekt = efektler[lstEfektler.SelectedItem.ToString()];
            lblSonuc.Text = effekt.Islem(txtMesaj.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string dosya in Directory.GetFiles(@"C:\Users\303UGUR_SABAH\source\repos\ilkprogram1\Matematik\WndTextShop\bin\Debug\Plugin"))
            {
                //MessageBox.Show(dosya);
                Assembly asm = Assembly.LoadFrom(dosya); //LoadFrom ile ram e yükledik
                foreach (Type type in asm.GetTypes())//Dinamik olarak class lara ulaştık.Classların isimlerini yazdı
                {
                    //MessageBox.Show(type.Name);

                    object obj = Activator.CreateInstance(type);
                    ISDK efekt = (ISDK)obj;  
                    efektler.Add(efekt.EklentiAdi, efekt);//Key value şeklinde yani arama yapabiliriz diye directionar i kullandık
                    lstEfektler.Items.Add(efekt.EklentiAdi);


                }
            }
        }
    }
}
