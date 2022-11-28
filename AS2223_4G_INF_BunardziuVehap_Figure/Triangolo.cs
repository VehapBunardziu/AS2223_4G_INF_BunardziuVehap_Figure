using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_BunardziuVehap_Figure
{
    internal class Triangolo : Figure
    {
        double bbase;
        double altezza; 

        public Triangolo(double bbase, double altezza)
        {
            nome = "Triangolo";
            this.bbase = bbase;
            this.altezza = altezza;
        }

        public override double Perimetro()
        {
            return bbase * 3;
        }

        public override double Area()
        {
            return (bbase * altezza) / 2;
        }
    }
}