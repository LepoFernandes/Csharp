using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X > 0 && Y  > 0)
            {
                if (X > Y)
                {
                    int maior = X;
                    X = Y;
                    Y = maior;
                }

                for (int i = X+1; i < Y; i++)
                {
                    if (i % 5 == 3 || i % 5 == 2)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}