using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x != 2 ) { 


                double notas, media;
                double soma = 0.0;
                int count = 0;
            

            
                while (count < 2)
                {
                    notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    if (notas < 0 || notas > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                    else
                    {
                        soma += notas;
                        count++;

                    }
                }

                media = soma / count;
                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                x = int.Parse(Console.ReadLine());

                while (x < 1 || x > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    x = int.Parse(Console.ReadLine());
                }
                


            }
                
        }
    }
}

