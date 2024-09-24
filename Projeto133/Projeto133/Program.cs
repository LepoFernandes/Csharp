using Projeto133;
using System;
using System.Globalization;
using System.Security.AccessControl;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotacao do dolar atual: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.Write("Quantos dolares voce vai comprar: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ValorEmReais(cotacao, quantia);


            Console.WriteLine("Valor a ser pago em reais: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}