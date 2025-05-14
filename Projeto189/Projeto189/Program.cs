using System;
using Projeto189.Entitites;
namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<int> printService = new PrintService<int>();

            Console.Write("How many values?");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) 
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            Console.WriteLine();
            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}