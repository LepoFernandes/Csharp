using System;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');

            int a = int.Parse(numeros[0]);
            int b = int.Parse(numeros[1]); 
            int c = int.Parse(numeros[2]);

            if (a < b && a < c)
            {
                Console.WriteLine("Menor = " + a);
            }else if (b < a && b < c)
            {
                Console.WriteLine("Menor = " + b);
            }else
            {
                Console.WriteLine("Menor = " + c);
            }
        }
    }
}