using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());
            double e = double.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());


            int contagem = 0;

            if (a > 0.0)
            {
                contagem += 1;
            }
            if (b > 0.0)
            {
                contagem += 1;
            }
            if (c > 0.0)
            {
                contagem += 1;
            }
            if (d > 0.0)
            {
                contagem += 1;
            }
            if (e > 0.0) { 
            
                contagem += 1;
            }
            if (f  > 0.0)
            {
                contagem += 1;
            }

            Console.WriteLine(contagem + " valores positivos");
        }
    }
}
