using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); 
            double mediaTotal = 0.0;
            int count = 0;

            do
            {
                string[] value = Console.ReadLine().Split(' ');
                double valueA = double.Parse(value[0], CultureInfo.InvariantCulture);
                double valueB = double.Parse(value[1], CultureInfo.InvariantCulture);
                double valueC = double.Parse(value[2], CultureInfo.InvariantCulture);

                mediaTotal = ((valueA * 2) + (valueB * 3) + (valueC * 5)) / (2 + 3 + 5);

                count++;

                Console.WriteLine(mediaTotal.ToString("F1", CultureInfo.InvariantCulture));

            } while (count < N);                  
        }
    }
}
