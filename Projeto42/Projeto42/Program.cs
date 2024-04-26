using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nr = Console.ReadLine().Split(' ');

            double A = double.Parse(nr[0], CultureInfo.InvariantCulture);
            double B = double.Parse(nr[1], CultureInfo.InvariantCulture);
            double C = double.Parse(nr[2], CultureInfo.InvariantCulture);

            if (A + B > C && A + C > B && B + C > A)
            {
                double perimetro = A + B + C;

                Console.WriteLine("Perimetro = " +  perimetro.ToString("F1", CultureInfo.InvariantCulture));
            } else
            {
                double area = ((A + B) * C) / 2.0;

                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}