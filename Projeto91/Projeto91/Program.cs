using System;
using System.Runtime.Serialization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            

            for (int i = 0;i < N; i++)
            {

                string[] entradas = Console.ReadLine().Split(' ');

                int X = int.Parse(entradas[0]);
                int Y = int.Parse(entradas[1]);

                int maior,menor;
                int soma = 0;

                if (X > Y)
                {
                    maior = X;
                    menor = Y;

                }else
                {
                    maior = Y;
                    menor = X;
                }

                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}