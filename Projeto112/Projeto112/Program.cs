using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] linhasEcolunas = Console.ReadLine().Split(' ');

            int M = int.Parse(linhasEcolunas[0]);
            int N = int.Parse(linhasEcolunas[1]);

            int[,] mat = new int[M, N];


            for (int i = 0; i < M; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(entradas[j]);
                }
            }

            int count = 0;

            for (int i = 0;i < M; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            int[] negativos = new int[count];
            int index = 0;

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        negativos[index] = mat[i,j];
                        index++;
                    }
                }
            }

            foreach (int elementos in negativos)
            {
                Console.WriteLine(elementos);
            }

        }
    }
}