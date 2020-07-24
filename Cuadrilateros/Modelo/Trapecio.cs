using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelo
{
    class Trapecio
    {
        public double b = 0;
        public double B = 0;
        public double d = 0;
        public double H = 0;

        public double perimetroTra = 0;
        public double areaTra = 0;

        public void PerimetroTrapecio()
        {

            perimetroTra = b + B + d + d;

        }

        public void AreaTrapecio()
        {

            areaTra = (B + b) * H / 2;

        }


    }
}
