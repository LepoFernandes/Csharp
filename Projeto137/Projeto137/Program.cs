using Projeto137;
using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Bem vindo(a) vamos iniciar seu cadastro.");

            Console.Write("Entre com o numero da sua conta: ");

            int numeroConta = int.Parse(Console.ReadLine());

            Conta x = new Conta (numeroConta);

            Console.WriteLine();

            Console.Write("Agora digite o nome do titular da conta: ");

            x.NomeTitular = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Quer fazer um depósito inicial Sr." + x.NomeTitular + " ? (S/N)");
            
            string resposta = Console.ReadLine();

            Console.WriteLine();

            if (resposta == "S")
            {
                Console.Write("Digite o valor do depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.deposito(valorDeposito);
            }
            else if (resposta == "N") 
            {
                double saldo = 0.0;
                Console.WriteLine("O depósito inicial não é obrigatório, mas é vantajoso considerar a possibilidade de depositar um valor no futuro.");
            } else
            {
                Console.WriteLine("Resposta invalida!");
            }

            Console.WriteLine("Dados da conta: ");

            Console.WriteLine(x.ToString());


            Console.WriteLine("Deseja fazer um depósito ou um saque? (1-Depósito / 2- Saque)");

            resposta = Console.ReadLine();

            if (resposta == "1") 
            {
                Console.Write("Digite o valor do depósito: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.deposito(valorDeposito);

                Console.WriteLine("Dados da conta: ");

                Console.WriteLine(x.ToString());

                Console.WriteLine();


            }
            else if (resposta == "2")
            {
                Console.WriteLine("Digite o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x.saque(valorSaque);

                Console.WriteLine();

                if (valorSaque > x.Saldo) 
                {
                    Console.WriteLine("Atenção: seu saldo ficará negativo, o que poderá acarretar em juros.");
                }


                Console.WriteLine("Dados da conta: ");

                Console.WriteLine(x.ToString());

            }
            else
            {
                Console.WriteLine("Comando invalido!");
            }








        }
    }
}