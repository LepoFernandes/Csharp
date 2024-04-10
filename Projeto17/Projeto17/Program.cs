using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFuncionario, nHoras;
            double vHora, vSalario;

            nFuncionario = int.Parse(Console.ReadLine());
            nHoras = int.Parse(Console.ReadLine());
            vHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            vSalario = nHoras * vHora;

            Console.WriteLine("NUMBER = " + nFuncionario);
            Console.WriteLine("SALARY = U$ " + vSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
