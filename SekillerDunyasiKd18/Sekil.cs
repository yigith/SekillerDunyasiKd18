using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekillerDunyasiKd18
{
    public abstract class Sekil : ICizilebilir
    {
        public Sekil() : this("Şekil") 
        {
            
        }

        public Sekil(string tur)
        {
            Tur = tur;
        }

        public string Tur { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Genislik { get; set; }
        public int Yukseklik { get; set; }
        public Color Renk { get; set; } = Color.Black;

        public abstract double Alan();

        public abstract double Cevre();

        public abstract void Ciz(Graphics g);

        public override string ToString()
        {
            return $"{Tur} ({X},{Y}) {Genislik}X{Yukseklik} A:{Alan():0.00} Ç:{Cevre():0.00} R:{Renk}";
        }
    }
}
