using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            int X = int.Parse(Console.ReadLine());
            int valor = X;

            if (valor % 2 == 0)
            {
                Console.WriteLine(valor += 1);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
            } else
            {
                Console.WriteLine(valor);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
                Console.WriteLine(valor += 2);
            }

            

        }
    }
}