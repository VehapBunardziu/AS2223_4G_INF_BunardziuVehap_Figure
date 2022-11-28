﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_BunardziuVehap_Figure
{
    internal class Quadrato : Figure
    {
        double lato;
        public Quadrato(double lato) {
            nome = "quadrato";
            this.lato = lato;
        }

        public override double Perimetro()
        {
            return lato * 4;
        }

        public override double Area()
        {
            return lato * lato;
        }
    }
}
