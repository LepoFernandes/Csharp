using System;

 namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());

            int[,] A;

            A = new int[M , N];

            for (int i = 0; i < M; i++)
            {
                string[] linha0 = Console.ReadLine().Split(' ');
                
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(linha0[j]);
                }
               
            }

            for (int i = 0;i < M; i++)
            {
                for (int j = 0;j < N; j++)
                {
                    Console.Write(A[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}