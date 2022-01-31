using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders21_WiNdowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double toplam = 0;
            try
            {
                //, yerine nokta yazılırsa, bunun önüne geçmek için yaptık.
                deger1tbx.Text = deger1tbx.Text.Replace(".", ",");
                deger2tbx.Text = deger2tbx.Text.Replace(".", ",");
                toplam = Double.Parse(deger1tbx.Text) +
               Double.Parse(deger2tbx.Text);

                toplamtbx.Text = toplam.ToString("######.##");
                listBox1.Items.Add(deger1tbx.Text + " + " + deger2tbx.Text + " = " + toplamtbx.Text);
            }
            catch (Exception)
            {
                toplamtbx.Text = "Gerçesiz double";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double carpim = 0;
            try
            {
                deger1tbx.Text = deger1tbx.Text.Replace(".", ",");
                deger2tbx.Text = deger2tbx.Text.Replace(".", ",");
                carpim = Double.Parse(deger1tbx.Text) *
               Double.Parse(deger2tbx.Text);

                carptbx.Text = carpim.ToString("######.##");
                listBox1.Items.Add(deger1tbx.Text + " X " + deger2tbx.Text + " = " + carptbx.Text);
            }
            catch (Exception)
            {

                toplamtbx.Text = "Gerçesiz double";
            }
        }

       
    }
}
