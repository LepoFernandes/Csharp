using System;

namespace curso
{
   class Program
    {
        static void Main(string[] args)
        {
            string[] entradas = Console.ReadLine().Split(' ');

            int X = int.Parse(entradas[0]);
            int Y = int.Parse(entradas[1]);

            while (X != Y) { 
            if ( X < Y )
            {
                Console.WriteLine("Crescente");                
                
            }else
                {
                    Console.WriteLine("Decrescente");
                }
                
                entradas = Console.ReadLine().Split(' ');
                X = int.Parse(entradas[0]);
                Y = int.Parse(entradas[1]);
            }
        }
    }
}