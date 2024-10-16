using Projeto141;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[N];

            for (int i = 0; i < N; i++) 
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto { Name = name, Price = price };

            }

            double sum = 0.0;

            for (int i = 0; i < N; i++)
            {
                sum += vet[i].Price;
            }

            double average = sum / N;

            Console.WriteLine("Average price: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}