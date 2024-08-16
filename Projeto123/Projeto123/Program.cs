using Projeto123;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double mediaSalario;

            Console.WriteLine("Dados do primeiro funcionario: ");

            Funcionario a, b;

            a = new Funcionario();
            b = new Funcionario();

            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Dados do segundo funcionario:");

            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();

            Console.Write("Salario: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();


            mediaSalario = (a.Salario + b.Salario) / 2;

            Console.WriteLine("Salario medio: " +  mediaSalario.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}