using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasiKd18
{
    public class Dikdortgen : Sekil
    {
        public Dikdortgen() : base("Dikdörtgen")
        {
        }

        public override double Alan()
        {
            return Genislik * Yukseklik;
        }

        public override double Cevre()
        {
            return 2 * (Genislik + Yukseklik);
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillRectangle(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
