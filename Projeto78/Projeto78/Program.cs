using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int maiorNumero = 0;
            int posicaoMaiorNumero = 0;

            for (int i = 1; i <= 100; i++)
            {
                int N = int.Parse(Console.ReadLine());

                if (N > maiorNumero)
                {
                    maiorNumero = N;
                    posicaoMaiorNumero = i;
                }
            }

            Console.WriteLine(maiorNumero);
            Console.WriteLine(posicaoMaiorNumero);
        }
    }
}