using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());


            int[,] mat = new int[N,N];

            for (int i = 0; i < N; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(entradas[j]);
                }
            }

            int[] linhas = new int[N];

            for (int i = 0;i < N; i++)
            {
                int soma = 0;
                for (int j = 0;j < N; j++)
                {
                    soma += mat[i, j];
                }

                linhas[i] = soma;
            }

            foreach (int elementos in linhas)
            {
                Console.WriteLine(elementos);
            }
        }
    }
}