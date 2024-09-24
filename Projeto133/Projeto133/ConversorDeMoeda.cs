using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto133
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;


        public static double ValorEmReais(double cotacao , double quantia)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100;

        }
    }
}
