using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final_Notu_Hesaplayıcı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ortalama ort = new Ortalama();
            ort.vize = int.Parse(textBox1.Text);
            ort.final = int.Parse(textBox2.Text);

            if (ort.Ortalamahesapla() >= 60)
            {
                MessageBox.Show("Geçtiniz. Ortalamanız: " + ort.Ortalamahesapla());
            }
            else
            {
                MessageBox.Show("Kaldınız. Ortalamanız: " + ort.Ortalamahesapla());
            }
        }
    }
}
