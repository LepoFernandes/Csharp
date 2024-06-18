using System;

namespace Curso
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] entradas = Console.ReadLine().Split(' ');

            int X = int.Parse(entradas[0]);
            int Y = int.Parse(entradas[1]);

            if(X > 1 && X < 20 && X < Y && Y < 100000)
            {
                for(int i = 1; i <= Y ; i++)
                {
                    Console.Write(i);

                    if(i % X == 0)
                    {
                        Console.WriteLine();
                    }else
                    {
                        if(i != Y)
                        {
                            Console.Write(" ");
                        }
                    }
                }
            }

            if (Y % X != 0)
            {
                Console.WriteLine();
            }
        }
    }
}
