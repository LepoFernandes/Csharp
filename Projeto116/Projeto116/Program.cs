using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] LinCol = Console.ReadLine().Split(' ');

            int M = int.Parse(LinCol[0]);
            int N = int.Parse(LinCol[1]);


            int[,] A = new int[M, N];
            int[,] B = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] entradasA = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(entradasA[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                string[] entradasB = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    B[i, j] = int.Parse(entradasB[j]);
                }
            }

            int[,] C = new int[M, N];

            for(int i = 0;i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(C[i, j] + " ");
                }
            }
        }
    }
}