using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelo
{
    class Rectangulo
    {


        public double A = 0;
        public double B = 0;
        public double perimetroRectangulo = 0;
        public double areaRectangulo = 0;


        public void PerimetroRectangulo()
        {

            perimetroRectangulo = A * 2 + B * 2;

        }

        public void AreaRectangulo()
        {

            areaRectangulo = A * B;

        }
    }
}
