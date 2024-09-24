using Projeto132;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);


            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}