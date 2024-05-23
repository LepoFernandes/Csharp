using System;
using System.Runtime.Serialization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int menor = 0;
            int soma = 0;

            if (X > Y)
            {
                menor = Y;
                Y = X;
                X = menor;
            }

            for (int i = X; i <= Y; i++)
            {
                 if (i % 13 != 0)
                {
                    soma += i;
                }   
            }

            Console.WriteLine(soma);
        }
    }
}