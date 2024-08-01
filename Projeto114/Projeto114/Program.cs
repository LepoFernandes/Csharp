using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N,N];

            for (int i = 0;i < N; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(entradas[j]);
                }
            }

            int[] maiores = new int[N];

            

            for (int i = 0; i < N; i++)
            {
                int maior = 0;

                for (int j = 0;j < N; j++)
                {
                    if (mat[i,j] > maior)
                    {
                        maior = mat[i,j];
                    }
                }
                maiores[i] = maior;
            }

            foreach (int elementos in maiores)
            {
                Console.WriteLine(elementos);
            }
        }
    }
}