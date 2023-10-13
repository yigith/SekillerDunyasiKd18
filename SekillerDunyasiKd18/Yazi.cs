using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasiKd18
{
    public class Yazi : ICizilebilir
    {
        public Yazi()
        {
        }

        public Yazi(int x, int y, string metin, Color renk)
        {
            X = x;
            Y = y;
            Metin = metin;
            YaziRengi = renk;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public Color YaziRengi { get; set; } = Color.Black;

        public string Metin { get; set; } = string.Empty;

        public string FontAilesi { get; set; } = "Comic Sans MS";

        public int Boyut { get; set; } = 16;

        public void Ciz(Graphics g)
        {
            Font font = new Font(FontAilesi, Boyut);
            Brush firca = new SolidBrush(YaziRengi);
            g.DrawString(Metin, font, firca, X, Y);
        }

        public override string ToString()
        {
            return $"{Metin} ({FontAilesi}, {Boyut}) X:{X} Y:{Y} Renk: {YaziRengi}";
        }
    }
}
