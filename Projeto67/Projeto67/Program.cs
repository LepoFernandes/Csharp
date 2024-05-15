using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,resultado;

            x = int.Parse(Console.ReadLine());

            while (x != 0)
            {

                if (x % 2 == 0)
                {
                    resultado = (x + (x + 2) + (x + 4) + (x + 6) + (x + 8));
                }else
                {
                    resultado = ((x + 1) + (x + 3) + (x + 5) + (x + 7) + (x + 9));
                }

                Console.WriteLine(resultado);

                x = int.Parse(Console.ReadLine());
            }

            
        }
    }
}