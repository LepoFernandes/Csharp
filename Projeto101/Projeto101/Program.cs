using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas entradas deseja?");

            int N = int.Parse(Console.ReadLine());

            int[] A = new int[N];
            int[] B = new int[N];
            int[] C = new int[N];
            int index = 0;

            Console.WriteLine("Entre com os numeros:");

            string[] entradas1 = Console.ReadLine().Split(' ');

            string[] entradas2 = Console.ReadLine().Split(' ');

            for(int i = 0;i < entradas1.Length; i++)
            {
                A[i] = int.Parse(entradas1[i]);
            }

            for(int i = 0; i < entradas2.Length; i++)
            {
                B[i] = int.Parse(entradas2[i]);
            }

            for(int i = 0;i < N ; i++)
            {
                C[index] = A[i] + B[i];
                index++;
            }

            Console.WriteLine("Os resultados sao:");

            foreach (int elementos in C)
            {
                Console.WriteLine(elementos);
            }
        }
    }
}

