using Projeto129;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            aluno Exemplo = new aluno();

            Console.Write("Digite o nome do aluno(a) : ");
            Exemplo.nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno(a) : ");
            Exemplo.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Exemplo.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Exemplo.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Exemplo.notaTotal();

            double notaTotal = Exemplo.notaTotal();

            if (notaTotal >= 60.0) 
            {
                Console.WriteLine("NOTA FINAL: " + notaTotal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");

            }
            else
            {
                
                double restanteNota = Exemplo.RestanteNota();

                Console.WriteLine("NOTA FINAL: " + notaTotal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + restanteNota.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
            

        }
    }
}