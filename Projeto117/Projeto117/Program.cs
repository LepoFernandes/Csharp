using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double[,] A = new double[N,N];

            for (int i = 0; i < N; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i,j] = double.Parse(entradas[j], CultureInfo.InvariantCulture);
                }
            }

            double soma = 0.0;

            for (int i = 0;i < N;i++)
            {
                for (int j = 0;j < N;j++)
                {
                    if (A[i,j] > 0)
                    {
                        soma += A[i,j];
                    }
                }
            }


            Console.WriteLine("SOMA DOS POSITIVOS: " +  soma.ToString("F1", CultureInfo.InvariantCulture));

            int indexL = int.Parse(Console.ReadLine());
            int indexC = int.Parse(Console.ReadLine());

            Console.Write("LINHA ESCOLHIDA: ");
            for (int j=0; j < N; j++)
            {
                Console.Write(A[indexL, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            Console.Write("COLUNA ESCOLHIDA: ");

            for (int i = 0;i < N; i++)
            {
                Console.Write(A[i, indexC].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }

            Console.WriteLine();
            Console.Write("DIAGONAL PRINCIPAL: ");

            for (int i = 0; i < N; i++)
            {
                Console.Write(A[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            double[,] alterada = new double[N, N];

            for (int i = 0;i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (A[i,j] > 0)
                    {
                        alterada[i,j] = A[i,j];
                    }else
                    {
                        alterada[i,j] = Math.Pow(A[i,j], 2);
                    }
                }
            }

            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0;i < N ; i++)
            {
                for(int j = 0;j < N; j++)
                {
                    Console.Write(alterada[i,j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}