using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double bonus = (15 * vendas) / 100;

            double total = bonus + salario;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
