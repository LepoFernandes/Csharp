using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] A;

            A = new int[N,N];
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = int.Parse(entradas[j]);
                }
            }

            for (int i = 0;i < N; i++) 
            { 
                for(int j = 0;j < N; j++)
                {
                    if (A[i,j] < 0)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Diagonal Principal:");

            for(int i = 0;i < N ; i++)
            {
                Console.Write(A[i,i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Total de negativos: " + count);


        }
    }
}