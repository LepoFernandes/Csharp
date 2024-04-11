using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = x / y;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
