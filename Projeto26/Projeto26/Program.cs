using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            double A = double.Parse(valores[0], CultureInfo.InvariantCulture) ;
            double B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = 0.5 * A * C;
            double circulo = 3.14159 * C * C;
            double trapezio = 0.5 * (A + B) * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
