using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Button button = new Button();
                button.Width = 40;
                button.Left += 20 + (i * 60);
                button.Text = i.ToString();
                panel1.Controls.Add(button);
                button.Click += Button_Click;
                button.MouseEnter += Button_MouseEnter;
                button.MouseLeave += Button_MouseLeave;

            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = this.BackColor;
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Green;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandı " + ((Button)sender).Text);
            textBox1.Text = ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Red;
        }
    }
}
