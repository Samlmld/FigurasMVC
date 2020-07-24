using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadrilateros.Modelo
{
    class Cuadrado
    {

        public double longuitud = 0;
        public double perimetro = 0;
        public double area = 0;

        public void perimetroCudrado()
        {

            perimetro = longuitud * 4;

        }

        public void areaCuadrado()
        {
            area = longuitud * longuitud;

        }
    }
}
