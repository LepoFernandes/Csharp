using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] dados1 = Console.ReadLine().Split(' ');
            string[] dados2 = Console.ReadLine().Split(' ');

            string nome1 = dados1[0];
            int idade1 = int.Parse(dados1[1]);

            string nome2 = dados2[0];
            int idade2 = int.Parse(dados2[1]);

            double media = (double)(idade1 + idade2) / 2;

            Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos. ");
        }
    }
}
