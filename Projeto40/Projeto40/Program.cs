using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');

            double n1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            double n4 = double.Parse(notas[3], CultureInfo.InvariantCulture);
            
            double media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);

            if (media > 7.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno aprovado.");
            }else if( media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno reprovado.");
            }else
            {
                Console.WriteLine("Media: " + media.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Aluno em exame.");
            }

            double exame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double mediaFinal = (media + exame) / 2;

            Console.WriteLine("Nota do exame: " + exame.ToString("F1", CultureInfo.InvariantCulture));

            if (mediaFinal >= 5.0)
            {
                Console.WriteLine("Aluno aprovado");
            }else
            {
                Console.WriteLine("Aluno reprovado");
            }

            Console.WriteLine("Media final:" + mediaFinal.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}