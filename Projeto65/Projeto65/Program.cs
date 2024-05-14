using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int idades = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double soma = 0.0;
            double count = 0.0;
            double media;

            while (idades > 0)
            {
                count++;
                soma += idades;
                idades = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            media = soma / count;
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}