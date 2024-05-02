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

            int contagem = 0;

            if (a % 2 == 0)
            {
                contagem += 1;
            }
            if (b % 2 == 0)
            {
                contagem += 1;
            }
            if (c % 2 == 0)
            {
                contagem += 1;
            }
            if (d % 2 ==0) 
            { 
                contagem += 1; 
            }
            if (e % 2 == 0)
            {
                contagem += 1;
            }

            Console.WriteLine(contagem + " valores pares");
        }
    }
}
