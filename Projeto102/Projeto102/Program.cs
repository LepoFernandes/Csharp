using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantia de elementos:");

            int N = int.Parse(Console.ReadLine());
            double soma = 0.0;
            double media = 0.0;

            Console.WriteLine("Digite as entradas:");

            string[] entradas = Console.ReadLine().Split(' ');

            double[] B = new double[N];

            for (int i = 0; i < N; i++)
            {
                B[i] = double.Parse(entradas[i],CultureInfo.InvariantCulture);
            }

            for (int i = 0;i < N; i++)
            {
                soma += B[i];
            }

            media = soma / N;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0;i < N ; i++)
            {
                if (B[i] < media)
                {
                    Console.WriteLine(B[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}