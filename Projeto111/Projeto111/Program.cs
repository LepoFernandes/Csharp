using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());

            int[,] A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(entradas[j]);
                }
            }

            int[] linhas = new int[M];

            for (int i = 0;i < M; i++)
            {
                int soma = 0;

                for (int j = 0;j < N; j++)
                {
                    soma += A[i,j];
                }

                linhas[i] = soma;
            }

            for (int i = 0;i < M; i++)
            {
                Console.WriteLine(linhas[i]);
            }
        }
    }
}