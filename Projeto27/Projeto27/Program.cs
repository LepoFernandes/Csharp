using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int A = int.Parse(valores[0]);
            int B = int.Parse(valores[1]);
            int C = int.Parse(valores[2]);

            int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
            int Maior = (MaiorAB + C + Math.Abs(MaiorAB - C)) / 2;

            Console.WriteLine(Maior + " eh o maior");
        }
    }
}