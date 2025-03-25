using Projeto170.Entities;
using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o numero de contribuintes: ");
            int N = int.Parse(Console.ReadLine());

            List<Contribuinte> list = new List<Contribuinte>();

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}: ");
                Console.Write("Pessoa fisica ou pessoa juridica? (f/j)");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'f')
                {
                    Console.Write("Gastos com saude: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Pfisica pessoafisica = new Pfisica(gastosSaude, nome, rendaAnual);

                    list.Add(pessoafisica);
                }
                else if (ch == 'j')
                {
                    Console.Write("Quantos funcionarios? ");
                    int nFuncionarios = int.Parse(Console.ReadLine());

                    Pjuridica pessoajuridica = new Pjuridica(nFuncionarios, nome, rendaAnual);

                    list.Add(pessoajuridica);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Impostos pagos: ");

            double soma = 0.0;

            foreach (var contribuinte in list)
            {
                Console.WriteLine($"{contribuinte.Nome}: {contribuinte.CalculoImposto():F2}");

                soma =+ contribuinte.CalculoImposto();

            }

            Console.WriteLine($"Total de imposto pago: {soma}");

        }
    }
}