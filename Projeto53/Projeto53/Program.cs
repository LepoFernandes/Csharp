using System;
using System.Globalization;
using System.Net.Http.Headers;

namespace curso
{
      class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float b = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float c = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float d = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float e = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float f = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            float valores = 0;
            int contagem = 0;

            if (a > 0.0)
            {
                contagem += 1;
                valores += a;
            }
            if (b > 0.0)
            {
                contagem += 1;
                valores += b;
            }
            if (c > 0.0)
            {
                contagem += 1;
                valores += c;
            }
            if (d > 0.0)
            {
                contagem += 1;
                valores += d;
            }
            if (e > 0.0)
            {
                contagem += 1;
                valores += e;
            }
            if (f > 0.0)
            {
                contagem += 1;
                valores += f;
            }

            float media = valores / contagem;

            Console.WriteLine(contagem + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}