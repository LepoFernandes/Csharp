using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados da primeira pessoa:");


            string[] dados1 = Console.ReadLine().Split(' ');

            string nome1 = dados1[0];
            int idade1 = int.Parse(dados1[1]);

            Console.WriteLine("Dados da segunda pessoa:");

            string[] dados2 = Console.ReadLine().Split(' ');

            string nome2 = dados2[0];
            int idade2 = int.Parse(dados2[1]);


            string maisVelha;


            if (idade1 > idade2)
            {
                maisVelha = nome1;
            }else
            {
                maisVelha = nome2;
            }

            Console.WriteLine("A pessoa mais velha: ");
            Console.WriteLine(maisVelha);
        }
    }
}