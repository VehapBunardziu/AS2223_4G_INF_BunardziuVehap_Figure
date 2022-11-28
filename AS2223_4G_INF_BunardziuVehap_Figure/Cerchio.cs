using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_BunardziuVehap_Figure
{
    internal class Cerchio : Figure
    {
        double raggio;

        public Cerchio(double raggio)
        {
            this.raggio = raggio;
            nome = "Cerchio";
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * raggio;
        }

        public override double Area()
        {
            return Math.PI * raggio * raggio;
        }

        public string NomeFigura
        {
            get { return nome; }
        }
    }
}
