using System;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] respostas = Console.ReadLine().Split(' ');

            int A = int.Parse(respostas[0]);

            int ultimoValor = respostas.Length - 1;
            int N = int.Parse(respostas[ultimoValor]);

            int soma = 0;

            for (int i = 0; i < N; i++)
            {
                soma += (A + i);
            }

            Console.WriteLine(soma);

        }
    }
}