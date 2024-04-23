using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva as duas notas para saber o resultado:");

            double notaUm = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double notaDois = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaTotal =  notaUm + notaDois;

            if (notaTotal > 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + notaTotal.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + notaTotal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
            }
        }
    }
}