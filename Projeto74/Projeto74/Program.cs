using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double elevado = 0;
            int N = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int i = 1;
            if (N > 5 && N < 2000)
            {
                for (i = 1; i <= N; i++)
                {
                    if (i % 2 == 0)
                    {
                        elevado = Math.Pow(i,2);

                        Console.WriteLine(i + "^2 = " + elevado);
                    }
                }
               
            }
            
        }
    }
}
