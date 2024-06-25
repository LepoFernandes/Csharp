using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] vetor;
            vetor = new int[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++)
            {
                vetor[i] = int.Parse(s[i]);
               
            }

            for (int i = 0;i < N; i++)
            {
                if (vetor[i] < 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }

           
        }
    }
}