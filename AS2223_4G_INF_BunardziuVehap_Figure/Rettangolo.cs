using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_BunardziuVehap_Figure
{
    internal class Rettangolo : Figure
    {
        double bbase;
        double altezza;
        public Rettangolo(double bbase, double altezza)
        {
            this.bbase = bbase;
            this.altezza = altezza;
            nome = "Rettangolo";
        }
   
        public override double Perimetro()
        {
            return altezza * 2 + bbase * 2;
        }

        public override double Area()
        {
            return bbase * altezza;
        }

    }
}
