using Projeto134;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Digite o primeiro numero do calculo: ");

            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero do calculo: ");

            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Escolha qual a operacao: +  -  /  * ");

            string operacao = Console.ReadLine();

            Console.WriteLine("Voce escolheu: " + operacao);
            Console.WriteLine();

            switch (operacao) 
            {
                case "+":
                    Console.WriteLine("Resultado = " + Calculadora.Soma(A, B));
                    break;
                case "-": 
                    Console.WriteLine("Resultado = " + Calculadora.Subtracao(A,B));
                    break;
                case "*":
                    Console.WriteLine("Resultado = " + Calculadora.Multiplicacao(A, B));
                    break;
                case "/":
                    Console.WriteLine("Resultado = " + Calculadora.Divisao(A, B));
                    break;
                default:
                    Console.WriteLine("Operacao invalida");
                break;

            }     

                
            
        }
    }
}