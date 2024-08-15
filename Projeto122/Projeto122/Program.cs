using Projeto122;
using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas X, Y;
            X = new Pessoas();
            Y = new Pessoas();
            
            Console.WriteLine("Dados da primeira pessoa:");

            Console.WriteLine("Nome: ");

            X.Nomes = Console.ReadLine();

            Console.WriteLine("Idade: ");

            X.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");

            Console.WriteLine("Nome: ");

            Y.Nomes = Console.ReadLine();

            Console.WriteLine("Idade: ");

            Y.Idade = int.Parse(Console.ReadLine());


            if (X.Idade > Y.Idade)
            {
                Console.WriteLine("Pessoa mais velha : " + X.Nomes);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha : " +  Y.Nomes);
            }

        }
    }
}