using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva as duas notas para saber o resultado:")

            double notaUm = double.parse(Console.ReadLine());
            double notaDois = double.parse(Console.ReadLine());

            double notaTotal = notaUm + notaDois;

            if (notaTotal > 60.0)
            {
                Console.WriteLine("NOTA FINAL = " + notaTotal.toString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + notaTotal.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO")
            }
        }
    }
}
