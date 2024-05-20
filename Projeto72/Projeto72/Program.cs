using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            
            if (X >= 1 && X <= 1000)
            {
                for (int i = 0; i <= X; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }                              
            }
        }
    }
}