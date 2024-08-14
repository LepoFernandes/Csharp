using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do primeiro funcionario:");

            Console.Write("Nome: ");
            string nome1 = Console.ReadLine();
            Console.Write("Salario: ");
            double salario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do segundo funcionario:");

            Console.Write("Nome: ");
            string nome2 = Console.ReadLine();
            Console.Write("Salario: ");
            double salario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media;

            media = (salario1 + salario2) / 2;

            Console.WriteLine("Salario medio: " +  media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}