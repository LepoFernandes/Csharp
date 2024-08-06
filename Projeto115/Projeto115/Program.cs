using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] A = new int[N, N];


            for (int i = 0; i < N; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(entradas[j]);
                }
            }

            int soma = 0;

            for (int i = 0;i < N; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    if (i < j )
                    {
                        soma += A[i, j];
                    }
                }
            }

            Console.WriteLine("A soma dos elementos: " + soma);
        }
    }
}