using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioEntrada = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double novoSalario = 0;
            double percentual = 0;
            double aumento = 0;

            if (salarioEntrada > 0 && salarioEntrada <= 400)
            {
                aumento = salarioEntrada * 0.15;
                novoSalario = salarioEntrada + aumento;
                percentual = 15;

            }else if (salarioEntrada >= 400.01 &&  salarioEntrada <= 800)
            {
                aumento = salarioEntrada * 0.12;
                novoSalario = salarioEntrada + aumento;
                percentual = 12;
            
            }else if (salarioEntrada >= 800.01 && salarioEntrada <= 1200)
            {
                aumento = salarioEntrada * 0.10;
                novoSalario = salarioEntrada + aumento;
                percentual = 10;

            }else if (salarioEntrada >= 1200.01 && salarioEntrada <= 2000)
            {
                aumento = salarioEntrada * 0.07;
                novoSalario = salarioEntrada + aumento;
                percentual = 7;

            }else
            {
                aumento = salarioEntrada * 0.04;
                novoSalario = salarioEntrada + aumento;
                percentual = 4;
            }
            

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + aumento.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}