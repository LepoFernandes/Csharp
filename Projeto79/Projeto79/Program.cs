using System;
using System.Globalization;
namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int totalCasos = 0;
            int totalCoelhos = 0;
            int totalRatos = 0;
            int totalSapos = 0;
            double percentualC = 0.0;
            double percentualR = 0.0;
            double percentualS = 0.0;

            for (int i = 0; i < N; i++) 
            {
                string[] entradas = Console.ReadLine().Split(' ');

                int Quantia = int.Parse(entradas[0]);
                char Tipo = char.Parse(entradas[1]);

                if (Tipo == 'S')
                {
                    totalSapos += Quantia;

                } else if (Tipo == 'R')
                {
                    totalRatos += Quantia;

                }else if (Tipo == 'C')
                {
                    totalCoelhos += Quantia;
                }

            }

            totalCasos = totalSapos + totalCoelhos + totalRatos;

            percentualC = ((double) totalCoelhos / totalCasos) * 100;
            percentualR = ((double) totalRatos / totalCasos) * 100;
            percentualS = ((double) totalSapos / totalCasos) * 100;

            Console.WriteLine("Total: " +totalCasos + " cobaias");
            Console.WriteLine("Total de coelhos: " + totalCoelhos);
            Console.WriteLine("Total de ratos: " + totalRatos);
            Console.WriteLine("Total de sapos: " + totalSapos);
            Console.WriteLine("Percentual de coelhos: " +  percentualC.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de ratos: " + percentualR.ToString("F2", CultureInfo.InvariantCulture) + " %");
            Console.WriteLine("Percentual de sapos: " + percentualS.ToString("F2", CultureInfo.InvariantCulture) + " %");
        }
    }
}