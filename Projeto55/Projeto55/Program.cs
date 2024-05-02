using System;

namespace curso
{
   class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

            int contagemImpar = 0;
            int contagemPares = 0;
            int contagemPos = 0;
            int contagemNeg = 0;

            if (a % 2 == 0)
            {
                contagemPares += 1;
            }else
            {
                contagemImpar += 1;
            }
            if (b % 2 == 0)
            {
                contagemPares += 1;
            }
            else
            {
                contagemImpar += 1;
            }
            if (c % 2 == 0)
            {
                contagemPares += 1;
            }
            else
            {
                contagemImpar += 1;
            }
            if (d % 2 == 0)
            {
                contagemPares += 1;
            }
            else
            {
                contagemImpar += 1;
            }
            if (e % 2 == 0)
            {
                contagemPares += 1;
            }
            else
            {
                contagemImpar += 1;
            }


            if (a >  0)
            {
                contagemPos += 1;
            }
            else if( a < 0 )
            {
                contagemNeg += 1;
            }
            if (b > 0)
            {
                contagemPos += 1;
            }
            else if (b < 0)
            {
                contagemNeg += 1;
            }
            if (c > 0)
            {
                contagemPos += 1;
            }
            else if (c < 0)
            {
                contagemNeg += 1;
            }
            if (d > 0)
            {
                contagemPos += 1;
            }
            else if (d < 0)
            {
                contagemNeg += 1;
            }
            if (e > 0)
            {
                contagemPos += 1;
            }
            else if (e < 0)
            {
                contagemNeg += 1;
            }

            Console.WriteLine(contagemPares + " valor(es) par(es)");
            Console.WriteLine(contagemImpar + " valor(es) impar(es)");
            Console.WriteLine(contagemPos + " valor(es) positivo(s)");
            Console.WriteLine(contagemNeg + " valor(es) negativo(s)");
        }
    }
}