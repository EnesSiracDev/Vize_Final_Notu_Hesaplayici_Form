using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vize_Final_Notu_Hesaplayıcı
{
    internal class Ortalama
    {
        int _vize;
        int _final;

        public int vize
        {
            get { return _vize; }
            set
            {
                if (value > 100)
                {
                    _vize = 100;
                }
                else if (value <= 100 && value >= 0)
                {
                    _vize = value;
                }
                else
                {
                    MessageBox.Show("Geçersiz bir vize notu girdiniz.");
                }
            }
        }

        public int final
        {
            get { return _final; }
            set
            {
                if (value > 100)
                {
                    _final = 100;
                }
                else if (value <= 100 && value >= 0)
                {
                    _final = value;
                }
                else
                {
                    MessageBox.Show("Geçersiz bir final notu girdiniz.");
                }
            }
        }

        public double Ortalamahesapla()
        {
            return _vize * 0.4 + _final * 0.6;
        }
    }
}
