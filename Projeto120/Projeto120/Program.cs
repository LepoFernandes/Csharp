using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triangulo X:");

            string[] entradasX = Console.ReadLine().Split(' ');
            double A = double.Parse(entradasX[0], CultureInfo.InvariantCulture);
            double B = double.Parse(entradasX[1], CultureInfo.InvariantCulture);
            double C = double.Parse(entradasX[2], CultureInfo.InvariantCulture);
            
            double P1;

            P1 = (A + B + C) / 2.0;

            double area1;

            area1 = Math.Sqrt(P1 * (P1 - A) * (P1 - B) * (P1 - C));

            Console.WriteLine("Entre com as medidas do triangulo Y:");

            string[] entradasY = Console.ReadLine().Split(' ');
            double A2 = double.Parse(entradasY[0], CultureInfo.InvariantCulture);
            double B2 = double.Parse(entradasY[1], CultureInfo.InvariantCulture);
            double C2 = double.Parse(entradasY[2], CultureInfo.InvariantCulture);

            double P2;

            P2 = (A2 + B2 + C2) / 2.0;

            double area2;

            area2 = Math.Sqrt(P2 * (P2 - A2) * (P2 - B2) * (P2 - C2));


            Console.WriteLine("Area de X : " + area1.ToString("F4" , CultureInfo.InvariantCulture));
            Console.WriteLine("Area de Y : " + area2.ToString("F4", CultureInfo.InvariantCulture));

            string maiorArea;

            if (area1 > area2)
            {
                maiorArea = "X";
            }
            else
            {
                maiorArea = "Y";
            }

            Console.WriteLine("Maior area : " + maiorArea);

        }
    }
}