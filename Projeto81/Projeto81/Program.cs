using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double divisao = 0.0;

            for(int i = 0; i < N; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');

                int X = int.Parse(entradas[0], CultureInfo.InvariantCulture);
                int Y = int.Parse(entradas[1], CultureInfo.InvariantCulture);

                if(Y != 0)
                {
                    divisao =(double) X / Y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }else
                {
                    Console.WriteLine("divisao impossivel");
                }
            }
        }
    }
}