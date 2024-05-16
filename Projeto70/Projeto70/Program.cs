using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int somaImpares = 0;
            int min,max;

            if (X > Y)
            {
                 min = Y;
                 max = X;
            }else
            {
                 min = X;
                 max = Y;
            }

            for (int i = min+1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    somaImpares += i;
                }
            }

            Console.WriteLine(somaImpares);
        }
    }
}