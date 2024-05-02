using System;
using System.Globalization;
using System.Transactions;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {

            double entradaSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double faixa1 = 2000.00;
            double faixa2 = 3000.00;
            double faixa3 = 4500.00;
            double impostoFaixa1 = 0.08;
            double impostoFaixa2 = 0.18;
            double impostoFaixa3 = 0.28;
            double impostoTotal = 0;


            if (entradaSalario > 0 && entradaSalario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }else if (entradaSalario > 2000.00 &&  entradaSalario <= 3000.00)
            {
                double valorExcedente = entradaSalario - faixa1;
                double imposto1 = valorExcedente * impostoFaixa1;
                impostoTotal = imposto1;
                Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else if (entradaSalario > 3000.00 && entradaSalario <= 4500.00)
            {
                double valorExcedente1 = faixa2 - faixa1;
                double valorExcedente = entradaSalario - faixa2;
                double imposto1 = valorExcedente1 * impostoFaixa1;
                double imposto2 = valorExcedente * impostoFaixa2;
                impostoTotal = imposto1 + imposto2;
                Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                double valorExcedente2 = faixa3 - faixa2;
                double valorExcedente1 = faixa2 - faixa1;
                double valorExcedente = entradaSalario - faixa3;
                double imposto1 = valorExcedente1 * impostoFaixa1;
                double imposto2 = valorExcedente2 * impostoFaixa2;
                double imposto3 = valorExcedente * impostoFaixa3;
                impostoTotal = imposto1 + imposto2 + imposto3;
                Console.WriteLine("R$ " + impostoTotal.ToString("F2", CultureInfo.InvariantCulture));
            }

            

           
        }
    }
}
