using System;
using System.Globalization;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double[] entradas;
            entradas = new double[N];

            for (int i = 0; i < N; i++)
            {
                entradas[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double maior = entradas[0];
            int posicao = 0;

            for (int i = 1; i < entradas.Length; i++) 
            {
                if (entradas[i] > maior)
                {
                    maior = entradas[i];
                    posicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicao);

        }
    }
}