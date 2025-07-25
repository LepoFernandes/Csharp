using Projeto200.Services;
using System;

namespace Curso
{
    /*  JEITO NORMAL SEM MULTICAST
    class Program
    {

        delegate double BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args) 
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            double result = op(a, b);

            Console.WriteLine(result);

        }
    }

    */

    class Program
    {

        delegate void BinaryNumericOperation(double n1, double n2);

        static void Main(string[] args) 
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;

            op += CalculationService.ShowMax;

            op(a, b);
        }
    }
}