using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int resultado = 0;

            if ( N > 2 && N < 1000 )
            {
                for (int i = 1; i <= 10; i++)
                {
                    resultado = N * i;
                    Console.WriteLine(i + " x " + N + " = " + resultado);
                }
            }
        }
    }
}