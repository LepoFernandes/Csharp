using System;
using System.Globalization;
namespace curso
{
   class Program
    {
        static void Main(string[] args)
        {

            double entrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double soma = 0.0;
            int numEntradas = 0;
            double media = 0.0;       

            while (entrada >= 0)
            {
                soma = soma + entrada;
                numEntradas++;
                entrada = double.Parse(Console.ReadLine());
            }

            if (numEntradas == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }else
            {
                media = soma / numEntradas;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
           
              
            
        }
    }
}