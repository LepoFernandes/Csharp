using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a largura do terreno:");
            double L = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com o comprimento do terreno:");
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("O terreno possui " + L + "m de largura e " + C + "m de comprimento.");

            Console.WriteLine("Agora digite o valor do metro quadrado:");
            double P = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Metro quadrado vale: " + P.ToString("F2", CultureInfo.InvariantCulture) + " reais.");

            double Area = L * C;
            double Ptotal = Area * P;

            Console.WriteLine("A area total do terreno : " + Area.ToString("F2", CultureInfo.InvariantCulture) + " metros quadrados." );
            Console.WriteLine("O valor total do terreno : " + Ptotal.ToString("F2", CultureInfo.InvariantCulture) + " reais. ");
            
        }
    }
}