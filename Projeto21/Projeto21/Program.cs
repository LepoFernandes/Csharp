using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int media, tempo, velocidade;

            media = 12;
            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            double distancia = tempo * velocidade;

            double litros = distancia / media;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
