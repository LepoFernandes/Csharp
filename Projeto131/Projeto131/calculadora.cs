using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Projeto131
{
    internal class calculadora
    {
         public double Pi = 3.14;

         public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

         public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
}
