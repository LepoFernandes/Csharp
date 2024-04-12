using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseR = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area, perimetro, diagonal;

            area =  baseR * altura;
            perimetro =  (2 * baseR) + (2 * altura);
            diagonal =  Math.Sqrt((baseR * baseR) + (altura * altura));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " +  diagonal.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
