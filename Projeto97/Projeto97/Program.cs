using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] entradas;
            double[] entradasINT = new double[N];

            double soma = 0.0;
            double media = 0.0;

            entradas = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)  
            {
                entradasINT[i] = double.Parse(entradas[i], CultureInfo.InvariantCulture);
                soma = soma + entradasINT[i];
            }

            media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
