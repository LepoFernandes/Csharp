using Projeto127;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            funcionario X = new funcionario();

            Console.WriteLine("Entre com os dados do funcionario: ");

            Console.Write("Nome: ");
            X.Nome = Console.ReadLine();

            Console.Write("Salario Bruto: ");
            X.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            X.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionario: " +  X);

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            X.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + X);
        }
    }
}
