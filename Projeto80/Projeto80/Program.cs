using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i += 2)
            {
                for (int j = 7; j >= 5; j--)
                {
                    Console.WriteLine("I=" + i + " J=" + j);
                }
                if (i + 2 > 9) // Verifica se a próxima iteração de i ultrapassa 7
                {
                    break; // Sai do loop se ultrapassar
                }
            }
        }
    }
}