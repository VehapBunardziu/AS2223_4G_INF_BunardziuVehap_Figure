using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_BunardziuVehap_Figure
{
    internal class Figure
    {
        protected string nome;
        protected double lato;
        public Figure()
        {
            lato = 0;
            nome = "Figura geometrica";
        }
        public virtual double Area() { return 0; }
        public virtual double Perimetro() { return 0; }
    }
}
