using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas = Console.ReadLine().Split(' ');

            float n1 = float.Parse(notas[0], CultureInfo.InvariantCulture);
            float n2 = float.Parse(notas[1], CultureInfo.InvariantCulture);
            float n3 = float.Parse(notas[2], CultureInfo.InvariantCulture);
            float n4 = float.Parse(notas[3], CultureInfo.InvariantCulture);
            
            float media = ((n1 * 2) + (n2 * 3) + (n3 * 4) + (n4 * 1)) / (2 + 3 + 4 + 1);

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

            float exame = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float mediaFinal = (media + exame) / 2;

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