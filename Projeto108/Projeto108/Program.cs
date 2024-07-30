using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            string[] produtos = new string[N];
            double[] precoCompra = new double[N];
            double[] precoVenda = new double[N];

            for (int i = 0; i < N; i++)
            {
                string[] entradas = Console.ReadLine().Split(' ');
                produtos[i] = entradas[0];
                precoCompra[i] = double.Parse(entradas[1], CultureInfo.InvariantCulture);
                precoVenda[i] = double.Parse(entradas[2], CultureInfo.InvariantCulture);

            }

            int lucroMenor10 = 0;
            int lucroEntre10e20 = 0;
            int lucroMaior20 = 0;
            double totalCompra = 0.0;
            double totalVenda = 0.0;
            double totalLucro = 0.0;

            double[] lucros = new double[N];

            for (int i = 0;i < N; i++)
            {
                lucros[i] = ((precoVenda[i] - precoCompra[i]) / precoCompra[i]) * 100;
            }

            for (int i = 0;i < N ; i++)
            {
                if (lucros[i] < 10)
                {
                    lucroMenor10++;
                }
                else if (lucros[i] >= 10 && lucros[i] <= 20)
                {
                    lucroEntre10e20++;
                }
                else if (lucros[i] > 20)
                {
                    lucroMaior20++;
                }
            }
            
            for (int i = 0; i < N ; i++)
            {
                totalCompra += precoCompra[i];
            }

            for(int i = 0;i < N ; i++)
            {
                totalVenda += precoVenda[i];
            }
            
            for( int i = 0;i < N; i++)
            {
                totalLucro += precoVenda[i] - precoCompra[i];
            }

            Console.WriteLine("Lucro abaixo de 10%:" + lucroMenor10);
            Console.WriteLine("Lucro entre 10% e 20%:" + lucroEntre10e20);
            Console.WriteLine("Lucro acima de 20%:" + lucroMaior20);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Lucro total: " + totalLucro.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}