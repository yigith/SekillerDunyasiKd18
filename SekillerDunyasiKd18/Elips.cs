using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasiKd18
{
    public class Elips : Sekil
    {
        public double YariCap1 { get { return Genislik / 2d; } }
        public double YariCap2 => Yukseklik / 2d;

        public override double Alan()
        {
            return Math.PI * YariCap1 * YariCap2;
        }

        public override double Cevre()
        {
            double a = YariCap1, b = YariCap2;
            return Math.PI * Math.Sqrt(2 * (a * a + b * b));
        }

        public override void Ciz(Graphics g)
        {
            Brush firca = new SolidBrush(Renk);
            g.FillEllipse(firca, X, Y, Genislik, Yukseklik);
        }
    }
}
