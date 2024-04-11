using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] p1 = Console.ReadLine().Split(' ');
           string [] p2 = Console.ReadLine().Split(' ');

           int cod1 = int.Parse(p1[0]);
           int num1 = int.Parse(p1[1]);
           double value1 = double.Parse(p1[2], CultureInfo.InvariantCulture);

           int cod2 = int.Parse(p2[0]);
           int num2 = int.Parse(p2[1]);
           double value2 = double.Parse(p2[2], CultureInfo.InvariantCulture);

           double valueTotal = (value1 * num1) + (value2 * num2);

           Console.WriteLine("VALOR A PAGAR: R$ " + valueTotal.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}