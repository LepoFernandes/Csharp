using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N,N];

            int soma = 0;

            for (int i = 0; i < N; i++)
            {
                string[] dados = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {                    

                    mat[i, j] = int.Parse(dados[j]);
                }
            }

            for (int i = 0; i < N; i++) 
            {
                for(int j = 0;j < N; j++)
                {                   
                    if (mat[i, j] < 0)
                    {
                        soma++;
                    }
                }
            }
            Console.WriteLine("Main Diagonal: ");

            for (int i = 0; i < N; i++) 
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            Console.Write("Negative numbers: ");
            Console.Write(soma);
            
        }
    }
}