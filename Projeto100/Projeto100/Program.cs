using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] entrada;
            entrada = new int[N];
            int count = 0; 

            for (int i = 0; i < N; i++)
            {
                entrada[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0;i < entrada.Length; i++)
            {
                if (entrada[i] % 2 == 0)
                {
                    count++;
                }

            }

            int[] pares = new int[count];
            int index = 0;

            for (int i = 0; i < N; i++)
            {
                if (entrada[i] % 2 == 0)
                {
                    pares[index] = entrada[i];
                    index++;
                }
            }

            Console.WriteLine("Os numeros pares sao:");
            foreach (int elementos in pares)
            {
                Console.WriteLine(elementos);
            }

            Console.WriteLine("A quantidade de pares sao:");
            Console.WriteLine(count);

        }
    }
}