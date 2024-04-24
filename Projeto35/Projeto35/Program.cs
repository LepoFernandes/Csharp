using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] coeficientes = Console.ReadLine().Split(' ');

            double a = double.Parse(coeficientes[0], CultureInfo.InvariantCulture);
            double b = double.Parse(coeficientes[1], CultureInfo.InvariantCulture);
            double c = double.Parse(coeficientes[2], CultureInfo.InvariantCulture);

            double delta = (b * b) - 4 * a * c;

            if ( delta < 0 || a == 0)
            {
                Console.WriteLine("Impossivel calcular");
            } else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}